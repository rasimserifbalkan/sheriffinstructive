using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI.App.Repositories
{
    public class BaseRepository
    {
        public static string DbFile
        {
            get { return Environment.CurrentDirectory + "\\db.s3db"; }
        }

        public static SQLiteConnection SimpleDbConnection()
        {
            return new SQLiteConnection("Data Source=" + DbFile);
        }
    }
}
