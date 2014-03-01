using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace AllImportantProjects
{
    class StringPermutation
    {
        public string word;
        public StringPermutation(string value)
        {
            word=value;
        }

        public void printCombination(string val)
        {
            if (null == val) return;
            char[] myWord = val.ToArray<char>();
            int len = myWord.Length;
            ArrayList result = new ArrayList();
            ///int start = 0;
            ///printCombinationUtil(myWord, start, len);
            ///start = 1;
        }

        private void printCombinationUtil()
        {
           

        }

        public void printPermutation(string val)
        {
            if (null == val) return;
            char[] myWord = val.ToArray<char>();
            
            int len = myWord.Length;
            char[] result = new char[len];
            bool[] used = new bool[len];
            for (int i = 0; i < len; i++) 
                used[i] = false;
            int level = 0;
            worker(myWord, level, used,  result);

        }

        private void worker(char[] word, int level, bool[] used, char[]result)
        {
            if (level == word.Length)
            {
                for (int i = 0; i < word.Length; i++)
                    Console.Write(result[i]);
                Console.WriteLine();
                return;
            }
            for (int i = 0; i < word.Length; i++)
            {
                if (used[i] == true) continue;
                result[level] = word[i];
                used[i] = true;
                worker(word, level+1, used, result);
                used[i] = false;
            }
        }
    }
}
