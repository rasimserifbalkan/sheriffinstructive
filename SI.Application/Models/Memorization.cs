using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI.App.Models
{
    public class Memorization
    {
        public int ID { get; set; }
        public int SetsId { get; set; }
        public int WordId { get; set; }
        public int UserId { get; set; }
        public DateTime MemorizationDate { get; set; }
    }
}
