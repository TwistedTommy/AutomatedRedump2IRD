using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AutomatedRedump2IRD.IsoTools {
    /// <summary>
    /// 
    /// </summary>
    public class RedumpFileStream : FileStream {
        private const long size_3k3y_ = 16 + 16 + 16 + 115;
        private const long start_3k3y_ = 0xF70;
        private const long end_3k3y_ = start_3k3y_ + size_3k3y_;
        private byte[] sec_3k3y_;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="mode"></param>
        /// <param name="access"></param>
        /// <param name="sec_3k3y"></param>
        public RedumpFileStream(string path, FileMode mode, FileAccess access, byte[] sec_3k3y) : base(path, mode, access) {
            System.Diagnostics.Debug.Assert(sec_3k3y.Length == size_3k3y_, "Unexpected sec3k3y size.");
            sec_3k3y_ = sec_3k3y;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="offset"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public override int Read(byte[] array, int offset, int count) {
            int ret = base.Read(array, offset, count);

            // Check if the read has data inside our 3k3y sector, if so copy the memory over.
            if (base.Position >= start_3k3y_ && base.Position - ret <= end_3k3y_) {
                long start_position_of_read = base.Position - ret;
                long offset_of_3k3y_sector = start_position_of_read <= start_3k3y_ ? 0 : start_position_of_read - start_3k3y_;
                long offset_of_3k3y_in_array = offset + (start_position_of_read >= start_3k3y_ ? 0 : start_3k3y_ - start_position_of_read);
                Array.Copy(sec_3k3y_, offset_of_3k3y_sector, array, offset_of_3k3y_in_array, Math.Min(array.Length - offset_of_3k3y_in_array, size_3k3y_ - offset_of_3k3y_sector));
                
                // TODO: array.Length - offset_of_3k3y_in_array is over-estimate, we can copy less...
                // Could be some off-by-1 errors above for edge cases?
            }
            return ret;
        }
    }
}
