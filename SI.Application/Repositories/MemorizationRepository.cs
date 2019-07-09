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
    public class MemorizationRepository : BaseRepository, IMemorizationRepository
    {
        public void Add(Memorization data)
        {
            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                data.ID = cnn.Query<int>(
                    @"INSERT INTO Memorization 
                    ( SetsId ,WordId,UserId,MemorizationDate) VALUES 
                    ( @SetsId ,@WordId,@UserId,@MemorizationDate );
                    select last_insert_rowid()", data).First();
            }
        }

        public void Delete(int id)
        {
            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                cnn.Execute(@"delete from Memorization where ID=@ID", new { ID = id });
            }
        }

        public Memorization Get(int id)
        {
            if (!File.Exists(DbFile)) return null;

            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                Memorization result = cnn.Query<Memorization>(
                    @"SELECT *
                    FROM Memorization
                    WHERE ID = @id", new { id }).FirstOrDefault();
                return result;
            }
        }

        public Memorization GetBySetsId(int SetsId)
        {
            if (!File.Exists(DbFile)) return null;

            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                Memorization result = cnn.Query<Memorization>(
                    @"SELECT *
                    FROM Memorization
                    WHERE SetId = @SetsId", new { SetsId = SetsId }).FirstOrDefault();
                return result;
            }
        }

        public Memorization Get(Expression<Func<Memorization, bool>> query)
        {
            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                var result = cnn.Query<Memorization>(
                    @"SELECT *
                    FROM Memorization").AsQueryable();

                return result.Where(query).FirstOrDefault();
            }
        }

        public IList<Memorization> List(Expression<Func<Memorization, bool>> query = null)
        {
            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                var result = cnn.Query<Memorization>(
                    @"SELECT *
                    FROM Memorization").AsQueryable();
                if (query == null)
                {
                    return result.ToList();
                }
                return result.Where(query).ToList();
            }
        }

        public void Update(Memorization data)
        {
           
        }
    }
}
