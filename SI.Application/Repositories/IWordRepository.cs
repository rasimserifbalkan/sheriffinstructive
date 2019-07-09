using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SI.App.Models;

namespace SI.App.Repositories
{
    public interface IWordRepository
    {
        Word Get(int id);
        Word Get(string wordText);
        void Add(Word data);
        void Update(Word data);
        IList<Word> List(Expression<Func<Word, bool>> query = null);
        void Delete(int id);
        IList<Word> List(int SetId, int UserId);

        IList<Word> ListMemorizationWord(int SetId, int UserId);
    }
}
