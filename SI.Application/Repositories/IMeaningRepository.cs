using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SI.App.Models;

namespace SI.App.Repositories
{
    public interface IMeaningRepository
    {
        Meaning Get(int id);
        Meaning Get(string name);
        Meaning Get(Expression<Func<Meaning, bool>> query = null);
        void Add(Meaning data);
        void Update(Meaning data);
        IList<Meaning> List(Expression<Func<Meaning, bool>> query = null);
        void Delete(int id);
    }
}
