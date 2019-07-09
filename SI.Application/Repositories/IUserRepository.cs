using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SI.App.Models;

namespace SI.App.Repositories
{
    public interface IUserRepository
    {
        User Get(int id);
        User Get(string name);
        void Add(User data);
        void Update(User data);
        IList<User> List(Expression<Func<User,bool>> query = null);
        void Delete(int id);
    }
}
