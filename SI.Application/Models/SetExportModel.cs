using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI.App.Models
{
   public class SetExportModel
    {
        public string Name { get; set; }
        public List<Word> Words { get; set; }
        public List<Meaning> Meanings { get; set; }
    }
}
