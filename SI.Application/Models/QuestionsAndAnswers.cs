using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI.App.Models
{
    public class QuestionsAndAnswers
    {
        public string Question { get; set; }
        public string AndAnswer { get; set; }
        public List<string> AndAnswers { get; set; } = new List<string>();
    }
}
