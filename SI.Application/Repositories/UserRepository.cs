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
    public class UserRepository : BaseRepository, IUserRepository
    {
        public User Get(int id)
        {
            if (!File.Exists(DbFile)) return null;

            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                User result = cnn.Query<User>(
                    @"SELECT *
                    FROM Users
                    WHERE ID = @id", new { id }).FirstOrDefault();
                return result;
            }
        }

        public User Get(string name)
        {
            if (!File.Exists(DbFile)) return null;

            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                User result = cnn.Query<User>(
                    @"SELECT *
                    FROM Users
                    WHERE Name = @name", new { name }).FirstOrDefault();
                return result;
            }
        }
        public void Delete(int id)
        {
            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                cnn.Execute(@"delete from Users where ID=@ID", new { ID = id });
            }
        }
        public void Add(User data)
        {


            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                data.ID = cnn.Query<int>(
                    @"INSERT INTO Users 
                    (  Name ) VALUES 
                    ( @Name );
                    select last_insert_rowid()", data).First();
            }
        }

        public void Update(User data)
        {


            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                cnn.Execute(@"update Users set Name = @Name where ID=@ID", data);
            }
        }

        public IList<User> List(Expression<Func<User, bool>> query = null)
        {
            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                var result = cnn.Query<User>(
                    @"SELECT *
                    FROM Users").AsQueryable();
                if (query == null)
                {
                    return result.ToList();
                }
                return result.Where(query).ToList();
            }
        }
    }
}
