using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using SI.App.Models;

namespace SI.App.Repositories
{
    public class SettingRepository : BaseRepository, ISettingRepository
    {
        public Setting Get(int id)
        {
            if (!File.Exists(DbFile)) return null;

            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                Setting result = cnn.Query<Setting>(
                    @"SELECT *
                    FROM Settings
                    WHERE ID = @id", new { id }).FirstOrDefault();
                return result;
            }
        }

        public Setting Get(string name)
        {
            if (!File.Exists(DbFile)) return null;

            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                Setting result = cnn.Query<Setting>(
                    @"SELECT *
                    FROM Settings
                    WHERE SettingsName = @name", new { name }).FirstOrDefault();
                return result;
            }
        }
        public void Delete(int id)
        {
            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                cnn.Execute(@"delete from Settings where ID=@ID", new { ID = id });
            }
        }
        public void Add(Setting data)
        {


            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                data.ID = cnn.Query<int>(
                    @"INSERT INTO Settings 
                    (  SettingsName,SettingValue ) VALUES 
                    ( @SettingsName,@SettingValue );
                    select last_insert_rowid()", data).First();
            }
        }

        public void Update(Setting data)
        {


            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                cnn.Execute(@"update Settings set SettingsName =@SettingsName,SettingValue = @SettingValue where ID=@ID", data);
            }
        }

        public IList<Setting> List(Expression<Func<Setting, bool>> query = null)
        {
            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                var result = cnn.Query<Setting>(
                    @"SELECT *
                    FROM Settings").AsQueryable();
                if (query == null)
                {
                    return result.ToList();
                }
                return result.Where(query).ToList();
            }
        }
    }
}
