using DiscUtils.Udf;
using IsoTools.Common.Properties;
using IsoTools.Iso9660;
using AutomatedRedump2IRD.IsoTools;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IsoTools
{
    /// <summary>
    /// 
    /// </summary>
    public class IrdCreateRedumpFile : IrdCreateFile {
        private readonly byte[] header_3k3y = Encoding.ASCII.GetBytes("Encrypted 3K ISO");
        private readonly byte[] sector_3k3y = new byte[16 + 16 + 16 + 115];

        /// <summary>
        /// 
        /// </summary>
        /// <param name="decrypted"></param>
        /// <param name="createIrdFile"></param>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <param name="pic"></param>
        public IrdCreateRedumpFile(bool decrypted, bool createIrdFile, byte[] d1, byte[] d2, byte[] pic) : base(decrypted, createIrdFile) {
            System.Diagnostics.Debug.Assert(header_3k3y.Length == 16, "Unexpected header_3k3y size.");
            System.Diagnostics.Debug.Assert(d1.Length == 16, "Unexpected d1 size.");
            System.Diagnostics.Debug.Assert(d2.Length == 16, "Unexpected d2 size.");
            System.Diagnostics.Debug.Assert(pic.Length == 115, "Unexpected pic size.");

            // Write the generic 3k3y header inforatmion.
            Array.Copy(header_3k3y, sector_3k3y, header_3k3y.Length);

            // Write the dynamic 3k3y information.
            Array.Copy(d1, 0, sector_3k3y, 16, d1.Length);
            Array.Copy(d2, 0, sector_3k3y, 32, d2.Length);
            Array.Copy(pic, 0, sector_3k3y, 48, pic.Length);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected override async Task<bool> CheckIfValid() {
            // Get the ps3 header from the iso.
            byte[] ps3_header = null;
            using (Stream iso_stream = this.Open()) {
                long ps3_header_size = 0;
                PS3CDReader ps3_cd_reader = new PS3CDReader(iso_stream);
                ICollection<DirectoryMemberInformation> members = ps3_cd_reader.Members;
                List<DirectoryMemberInformation> list = (
                    from d in members
                    where d.IsFile
                    select d).Distinct<DirectoryMemberInformation>().ToList<DirectoryMemberInformation>();
                ps3_header_size = list.First<DirectoryMemberInformation>().StartSector * 2048;

                // Note: The full ps3_header_size isn't needed, the IRD's "Header" seems to always be smaller than 0>StartSector, but can't find why (from code seems to write all, so why IrdViewer is missing some)...
                if (ps3_header_size == 0)
                    return false;
                ps3_header = new byte[ps3_header_size];
                iso_stream.Seek(0, SeekOrigin.Begin);
                if (iso_stream.Read(ps3_header, 0, (int)ps3_header_size) != ps3_header_size)
                    return false;
            }

            // Modify the header with the d1/d2/key information at the 3k3y location (0xF70), and write it to the temporary Redump2IRD.exe.header file.
            string tmp_header_info_file = new Uri(System.Reflection.Assembly.GetEntryAssembly().GetName().CodeBase + ".ps3-header-only.iso").LocalPath;
            if (File.Exists(tmp_header_info_file))
                File.Delete(tmp_header_info_file);
            Array.Copy(sector_3k3y, 0, ps3_header, 0xF70, sector_3k3y.Length);
            File.WriteAllBytes(tmp_header_info_file, ps3_header);

            // Analayze the "header" file above so we can get correct information.
            IsoCryptoClass isoCryptoClass = new IsoCryptoClass();
            if (await isoCryptoClass.AnalyseISO(tmp_header_info_file) && isoCryptoClass.IsEncrypted) {
                FileInfo fileInfo = new FileInfo(base.Path);
                base.Regions = isoCryptoClass.Regions;
                base.EndOfDataSector = (long)base.Regions.Last<Region>().End;
                base.TotalSectors = (long)((uint)(fileInfo.Length / (long)2048));

                File.Delete(tmp_header_info_file);
                this.IsValid = true;
                return true;
            }

            File.Delete(tmp_header_info_file);
            this.IsValid = false;
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected override Stream Open() {
            return new RedumpFileStream(base.Path, FileMode.Open, FileAccess.Read, sector_3k3y);
        }
    }
}