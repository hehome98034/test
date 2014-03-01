using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace AllImportantProjects
{
    class DiceProblem
    {
        public DiceProblem()
        {

        }
        public void printDice(int num)
        {
            int level = 0;
            int[] value = new int[num];
            printDiceWork(value, level, num);
        }

        private void printDiceWork(int[] value, int level, int num)
        {
            if (level == num)
            {
                for (int i = 0; i < num; i++)
                {
                    Console.Write("{0}", value[i]);
                }
                Console.WriteLine();
                return;
            }
            for (int i = 0; i < 6; i++)
            {
                value[level] = i+1;
                printDiceWork(value, level + 1, num);
            }
        }
    }
}
