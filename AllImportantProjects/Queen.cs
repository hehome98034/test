
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;


namespace Queen
{
    class Program
    {
        static void Main2(string[] args)
        {
            int N = 8;
            while (N < 15)
            {
                ArrayList result = new ArrayList();
                int[] cols = new int[N];
                PrintQueen(result, 0, cols, N);
                Console.WriteLine("the total is {0}", result.Count);
                N++;
            }
            Console.ReadLine();
        }

        static void PrintQueen(ArrayList result, int row, int[] Columns, int Dimension)
        {
            if (row == Dimension)
            {
                int[] one = new int[Dimension];
                for (int i = 0; i < Dimension; i++)
                    one[i] = Columns[i];
                result.Add(one);
            }
            else
            {
                ///this is for Row Number "row" and Column Number "i"
                for (int i = 0; i < Dimension; i++)
                {
                    if (fits(Columns, row, i)==true)
                    {
                        Columns[row]=i;
                        PrintQueen(result, row+1, Columns, Dimension);
                    }
                }
            }              
        }

        static bool fits(int[] Columns, int row, int position)
        {
            bool value = true;
            for (int i = 0; i < row; i++)
            {
                /// this is to compare two position, row i, column Columns[i] against row, position
                if (Columns[i] == position)
                    value = false;
                if (Math.Abs(position - Columns[i]) == Math.Abs(row - i))
                    value = false;
                if (value == false)
                    break;
            }
            return value;
        }
        
    }
}
