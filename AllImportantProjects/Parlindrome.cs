using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllImportantProjects
{
    class Parlindrome
    {
        public bool IsParlinDrome(string value)
        {
            if (null == value) return true;
            if (value.Length < 2) return true;
            char[] val = value.ToArray<char>();
            int i = 0;
            bool isP = true;
            while (i < val.Length - 1 - i)
            {
                if (val[i]!=val[val.Length-1-i])
                {
                    isP = false;
                    break;
                }
                i++;
            }
            return isP;
        }
    }
}
