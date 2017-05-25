using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyricaDesign
{
    class Auth_Checker
    {
        public static bool contains_num(string tocheck)
        {
            for (int i = 0; i != tocheck.Count(); ++i)
            {
                if ((int)tocheck[i] >= 48 && (int)tocheck[i] <= 57) return true;
            }
            return false;
        }

        public static bool is_passcorrect(string tocheck)
        {
            if (Auth_Checker.contains_num(tocheck) && tocheck.Count() >= 6) return true;
            return false;
        }

        public static bool is_logincorrect(string tocheck)
        {
            if (tocheck.Count() >= 4) return true;
            return false;
        }
    }
}
