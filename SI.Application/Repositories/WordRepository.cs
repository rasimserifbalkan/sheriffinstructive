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
    public class WordRepository : BaseRepository, IWordRepository
    {
        public void Add(Word data)
        {

            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                data.ID = cnn.Query<int>(
                    @"INSERT INTO Words 
                    ( WordText,SetId ) VALUES 
                    ( @WordText,@SetId );
                    select last_insert_rowid()", data).First();
            }
        }

        public Word Get(int id)
        {
            if (!File.Exists(DbFile)) return null;

            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                Word result = cnn.Query<Word>(
                    @"SELECT *
                    FROM Words
                    WHERE ID = @id", new { id }).FirstOrDefault();
                return result;
            }
        }
        public void Delete(int id)
        {
            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                cnn.Execute(@"delete from Words where ID=@ID", new { ID = id });
            }
        }
        public Word Get(string wordText)
        {
            if (!File.Exists(DbFile)) return null;

            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                Word result = cnn.Query<Word>(
                    @"SELECT *
                    FROM Words
                    WHERE WordText = @WordText", new { WordText = wordText }).FirstOrDefault();
                return result;
            }
        }

        public IList<Word> List(Expression<Func<Word, bool>> query = null)
        {
            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                var result = cnn.Query<Word>(
                    @"SELECT *
                    FROM Words").AsQueryable();
                if (query == null)
                {
                    return result.ToList();
                }
                return result.Where(query).ToList();
            }
        }

        public void Update(Word data)
        {
            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                cnn.Execute(@"update Words set WordText = @WordText where ID=@ID", data);
            }
        }
        //Kullanıcının ezberlemediği kelimeleri getirir
        public IList<Word> List(int SetId, int UserId)
        {
            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
              return  cnn.Query<Word>(@"select w.* from Sets as s
join Words as w
on s.ID = w.SetId
where s.ID = @SetsId  and w.ID not in(select WordId from Memorization where SetsId = @SetsId and UserId = @UserId)", new { SetsId = SetId, UserId = UserId }).ToList();
            }
        }

        public IList<Word> ListMemorizationWord(int SetId, int UserId)
        {
            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                return cnn.Query<Word>(
                    @"SELECT *
                    FROM Words where ID in(select WordId from Memorization where SetsId = @SetsId and UserId = @UserId)", new { SetsId = SetId, UserId = UserId }).ToList();
              
            }
        }
    }
}
