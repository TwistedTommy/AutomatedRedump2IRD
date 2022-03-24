using System;
using System.Data;
using System.Data.SQLite;
using System.Threading.Tasks;

namespace AutomatedRedump2IRD
{
    class Database
    {
        public string ConnectionString { get; set; }

        public DataTable SelectIRDInfo()
        {
            DataTable dt = new DataTable();

            using (SQLiteConnection con = new SQLiteConnection(ConnectionString))
            {
                con.Open();

                SQLiteCommand command = new SQLiteCommand();
                command.Connection = con;
                command.CommandText = @"SELECT GameDKey, GamePIC, GameDID, TrackFilename, TrackMD5, TrackSHA1 FROM `ps3_ird_info`";

                SQLiteDataAdapter da = new SQLiteDataAdapter(command);
                da.Fill(dt);

                con.Close();
            }

            return dt;
        }
    }
}
