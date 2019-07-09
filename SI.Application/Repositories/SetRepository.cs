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
    public class SetRepository : BaseRepository, ISetRepository
    {
        public Set Get(int id)
        {
            if (!File.Exists(DbFile)) return null;

            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                Set result = cnn.Query<Set>(
                    @"SELECT *
                    FROM Sets
                    WHERE ID = @id", new { id }).FirstOrDefault();
                return result;
            }
        }

        public Set Get(string name)
        {
            if (!File.Exists(DbFile)) return null;

            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                Set result = cnn.Query<Set>(
                    @"SELECT *
                    FROM Sets
                    WHERE Name = @name", new { name }).FirstOrDefault();
                return result;
            }
        }
        public void Delete(int id)
        {
            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                cnn.Execute(@"delete from Sets where ID=@ID", new { ID = id });
            }
        }
        public void Add(Set data)
        {
            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                data.ID = cnn.Query<int>(
                    @"INSERT INTO Sets 
                    ( Name ) VALUES 
                    ( @Name );
                    select last_insert_rowid()", data).First();
            }
        }

        public void Update(Set data)
        {
            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                cnn.Execute(@"update Sets set Name = @Name where ID=@ID", data);
            }
        }

        public IList<Set> List(Expression<Func<Set, bool>> query = null)
        {
            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                var result = cnn.Query<Set>(
                    @"SELECT *
                    FROM Sets").AsQueryable();
                if (query == null)
                {
                    return result.ToList();
                }
                return result.Where(query).ToList();
            }
        }

        public SetExportModel ExportSet(int id)
        {
            SetExportModel exportModel = new SetExportModel();
            IWordRepository wordRepository = new WordRepository();
            IMeaningRepository meaningRepository = new MeaningRepository();
            exportModel.Name = Get(id).Name;
            exportModel.Words = wordRepository.List(x => x.SetId == id).ToList();
            exportModel.Meanings = meaningRepository.List(x => exportModel.Words.Any(t => t.ID == x.WordId)).ToList();

            return exportModel;
        }
    }
}
