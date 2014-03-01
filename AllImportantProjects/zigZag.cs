

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllImportantProjects
{
    class zigZag
    {
        public zigZag()
        {
        }
        private int Rint(int val)
        {
            int flag = 0;
            if (val < 0)
            {
                val = val * (-1);
                flag = -1;
            }
            int sum = 0;
            while (val > 0)
            {
                int digit = val % 10;
                sum = sum * 10 + digit;
                val = val / 10;
            }
            if (flag == -1)
                sum = sum * (-1);
            return sum;
        }
        public void Reverse()
        {
            while (true)
            {
                Console.WriteLine("Please enter a value");
                int val = Convert.ToInt32(Console.ReadLine());
                val = Rint(val);
                Console.WriteLine("The result is {0}", val);
            }
        }
        public void printZigZag(string inVal, int Rows)
        {
            int len=inVal.Length;
            char[] charVal = inVal.ToArray<char>();
            int ordinal=0;
            int ColumnPairs = len/(Rows + 1) + 1; //calculate # of pairs of columns based on zig/zag
            char[,] Zig = new char[ColumnPairs * 2, Rows];
            for (int i=0; i<ColumnPairs*2; i++)
            {
                for (int j=0; j<Rows; j++)
                {
                    Zig[i, j] = ' ';
                }
            }

            for (int i = 0; i < ColumnPairs; i++)
            {
                for (int j = 0; j < Rows; j++)
                {
                    if (ordinal < len)
                    {
                        Zig[i * 2, j] = charVal[ordinal++];
                    }
                }
                if (ordinal < len)
                {
                    Zig[i * 2 + 1, 1] = charVal[ordinal++];
                }
            }
           
            for (int j = 0; j < Rows; j++)
            {
                for (int i = 0; i < ColumnPairs * 2; i++)
                {
                    char temp = Zig[i, j];
                    if (temp!=' ')
                        Console.Write("{0} ", Zig[i, j]);
                }
                
            }

        }
    }
}
