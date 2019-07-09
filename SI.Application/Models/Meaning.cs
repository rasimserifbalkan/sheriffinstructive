using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI.App.Models
{
    public class Meaning
    {
        public int ID { get; set; }
        public string MeaningWord { get; set; }
        public int WordId { get; set; }
    }
}
