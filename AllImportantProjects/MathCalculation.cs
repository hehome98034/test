using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace AllImportantProjects
{
    class MathCalculation
    {
        private int value;
        public int[] sequence;

        public MathCalculation(int X, int n)
        {
            value = X;
            sequence = new int[n];
        }

        public void buildSequence()
        {
            for (int i=0; i<sequence.Length; i++)
            {
                sequence[i] =  i;
                if (i%3==0)
                    sequence[i]=sequence[i] * (-4);
            }
        }
        public int reverse()
        {
            int result = 0;
            while (value > 0)
            {
                int digit = value % 10;
                result = result * 10 + digit;
                value = value / 10;
            }
            return result;
        }

        public int getLargestSum()
        {
            int len=sequence.Length;
            int i=0;
            int curMax = int.MinValue;
            int running = 0;
            while (i < len)
            {
               if (sequence[i]  >= 0)
               {
                   if (sequence[i] > curMax)
                       curMax=sequence[i];
                   running = running + sequence[i];
               }

               else if (sequence[i] < 0)
               {
                   if (sequence[i] > curMax)
                       curMax = sequence[i];

                   if ((running>curMax) && (running!=0))
                   {
                       curMax = running;
                   }
                   if (running + sequence[i] > 0)
                       running = running + sequence[i];
                   else
                       running = 0;
               }
               i++;
            }
            return curMax; 
        }
    }
}
