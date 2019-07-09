using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SI.App.Models;

namespace SI.App.Repositories
{
    public interface ISetRepository
    {
        Set Get(int id);
        Set Get(string name);
        void Add(Set data);
        void Update(Set data);
        IList<Set> List(Expression<Func<Set, bool>> query = null);
        void Delete(int id);

        SetExportModel ExportSet(int id);
 

    }
}
