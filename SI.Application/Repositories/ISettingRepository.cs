using SI.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SI.App.Repositories
{
    public interface ISettingRepository
    {
        Setting Get(int id);
        Setting Get(string name);
        void Add(Setting data);
        void Update(Setting data);
        IList<Setting> List(Expression<Func<Setting, bool>> query = null);
        void Delete(int id);
    }
}
