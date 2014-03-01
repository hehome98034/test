using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllImportantProjects
{
    class PhoneNumber
    {
        public int num;
        public PhoneNumber(int val)
        {
            num = val;
        }
        public void printWords(char[] word)
        {
            if (word == null) return;
            if (word.Length == 0) return;
            int level = 0;
            int len = word.Length;
            char[] partial = new char[len];
            printUtil(word, level, partial, len);
        }

        private void printUtil(char[] word, int level, char[] part, int length)
        {
            if (level == length)
            {
                for (int i = 0; i < level; i++)
                    Console.Write("{0}", part[i]);
                Console.WriteLine();
                return;
            }
            for (int i = 0; i < 3; i++)
            {
                part[level] = getLetter(word[level], i);
                printUtil(word, level + 1, part, length);
            }
        }

        private char getLetter(char digit, int ordinal)
        {
            char zero='0';
            char A = 'A';
            int digitValue = (int)digit - (int)zero;
            char result = (char)(3*digitValue + ordinal + (int)A);
            return result;
        }
    }
}
