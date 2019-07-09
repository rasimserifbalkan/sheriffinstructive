using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SI.App.Models;

namespace SI.App
{
    public class SessionData
    {
        public static User loginUser { get; set; }
        public static int loginUserId { get; set; }
    }
}
