using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyuboDriveFinal
{
    class session
    {
        static string username;
        public static string getUserData
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }
    }
}
