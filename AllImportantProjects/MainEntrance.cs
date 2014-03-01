using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;


namespace AllImportantProjects
{
    class MainEntrance
    {
        static void Main(string[] args)
        {
            
           
            InOrder mine = new InOrder();
            Node root_temp  = mine.createTree(10);
            printLevel.printLevelOrder(root_temp);
            /*
           mine.inOrder(root);
           mine.PostOrder(root);
           mine.preOrder(root);
            
           Console.WriteLine();
           DiceProblem dp = new DiceProblem();
           dp.printDice(3);

           StringPermutation pp = new StringPermutation("abc");
           pp.printPermutation("aab");
            

           ScheduleQueue[] my = new ScheduleQueue[100];
           for (int i = 0; i < 100; i++)
           {
               my[i] = new ScheduleQueue();
               my[i].start = i*100;
               my[i].end = my[i].start + i * 3;
           }
            
           MergeSchedule mq = new MergeSchedule();
           ArrayList result = new ArrayList();
           mq.doMerge(my, result);
            
           Parlindrome myP = new Parlindrome();
           while (true)
           {
               Console.WriteLine("please enter a word");
               string val = Console.ReadLine();
               bool isP = myP.IsParlinDrome(val);
               Console.WriteLine("It is a parlindine: {0}", isP);
           }
            
           PhoneNumber pN = new PhoneNumber(12);
           pN.printWords(pN.num.ToString().ToArray<char>());
            
           */
            InOrder io = new InOrder();
            Node root = io.createTree(10);

            io.ReverseInOrder(root);

            int i = 0;
            io.getnThNode(root, ref i, 4);
            i = 0;
            io.getnThNode(root, ref i, 3);
            i = 0;
            io.getnThNode(root, ref i, 2);
            i = 0;
            io.getnThNode(root, ref i, 1);

            /*
            LinkSibling ls = new LinkSibling();
            ls.LinkThem_DFS(root);
             
            if (true)
            {
                Console.WriteLine("please enter a value");
                int val = Convert.ToInt32(Console.ReadLine());
                MathCalculation mc = new MathCalculation(val, 20);
                mc.buildSequence();
                int Rvalue = mc.reverse();
                int curMax = mc.getLargestSum();

                int len = mc.sequence.Length;
                for (int i = 0; i < len; i++)
                    Console.Write("{0},", mc.sequence[i]);
                Console.WriteLine("No the max sequcne");
                Console.WriteLine("the biggest sequence is {0}", curMax);

                Console.Read();
                
            }
            

            bitOperation bo = new bitOperation();
            Byte value = 5;
            Byte X = bo.Reverse(value);
            Byte Y = bo.ReverseNoBit(value);
            Console.WriteLine("the values are {0}, {1}", X, Y);
           

            LinkedList util = new LinkedList();
            LinkedNode A = util.createList(4);
            LinkedNode B = util.createList(6);
            LinkedNode result = util.addListNoExtra(A, B);

          

            zigZag zz = new zigZag();
            zz.printZigZag("PAYPALISHIRING", 3);
            zz.Reverse();
              

            SumRootToLeave srt = new SumRootToLeave();
            int val = srt.calculateSum();
            Console.WriteLine("the total value is {0}", val);
        

            InOrder io = new InOrder();
            Node root = io.createTree(10);
            ArrayList al = io.serializeIt(root);
            Node newRoot = io.Deserial(al
           

            InOrder io = new InOrder();
            SumRootToLeave srt = new SumRootToLeave();
            Node root = io.createBigTree(200);
            srt.printTreeByLevel(root);
            
            srt.printAllpath(root, 13);
             */
        }
    }
}
