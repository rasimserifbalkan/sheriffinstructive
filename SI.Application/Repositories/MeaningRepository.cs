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
    public class MeaningRepository : BaseRepository, IMeaningRepository
    {
        public void Add(Meaning data)
        {
            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                data.ID = cnn.Query<int>(
                    @"INSERT INTO Meanings 
                    ( MeaningWord ,WordId) VALUES 
                    ( @MeaningWord,@WordId );
                    select last_insert_rowid()", data).First();
            }
        }

        public void Delete(int id)
        {
            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                cnn.Execute(@"delete from Meanings where ID=@ID", new { ID = id });
            }
        }

        public Meaning Get(int id)
        {
            if (!File.Exists(DbFile)) return null;

            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                Meaning result = cnn.Query<Meaning>(
                    @"SELECT *
                    FROM Meanings
                    WHERE ID = @id", new { id }).FirstOrDefault();
                return result;
            }
        }

        public Meaning Get(string meaningWord)
        {
            if (!File.Exists(DbFile)) return null;

            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                Meaning result = cnn.Query<Meaning>(
                    @"SELECT *
                    FROM Meanings
                    WHERE MeaningWord = @MeaningWord", new { MeaningWord = meaningWord }).FirstOrDefault();
                return result;
            }
        }

        public Meaning Get(Expression<Func<Meaning, bool>> query)
        {
            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                var result = cnn.Query<Meaning>(
                    @"SELECT *
                    FROM Meanings").AsQueryable();
              
                return result.Where(query).FirstOrDefault();
            }
        }

        public IList<Meaning> List(Expression<Func<Meaning, bool>> query = null)
        {
            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                var result = cnn.Query<Meaning>(
                    @"SELECT *
                    FROM Meanings").AsQueryable();
                if (query == null)
                {
                    return result.ToList();
                }
                return result.Where(query).ToList();
            }
        }

        public void Update(Meaning data)
        {
            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                cnn.Execute(@"update Meanings set MeaningWord = @MeaningWord where ID=@ID", data);
            }
        }
    }
}
