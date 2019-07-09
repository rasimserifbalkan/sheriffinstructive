using SI.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SI.App.Repositories
{
    public interface IMemorizationRepository
    {
        Memorization Get(int id);
        Memorization GetBySetsId(int setsId);
        Memorization Get(Expression<Func<Memorization, bool>> query = null);
        void Add(Memorization data);
        void Update(Memorization data);
        IList<Memorization> List(Expression<Func<Memorization, bool>> query = null);

        void Delete(int id);
    }
}
