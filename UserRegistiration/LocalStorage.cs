using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserRegistiration
{
    static class  LocalStorage
    {
        public static List<User> Users { get; set; } = new List<User>();

        public static Form MainForm { get; set; }

        public static int Count { get; set; } = 1;


    }
}
