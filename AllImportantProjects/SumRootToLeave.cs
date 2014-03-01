using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace AllImportantProjects
{
    class SumRootToLeave
    {
        public SumRootToLeave()
        {

        }
        public int calculateSum()
        {
            InOrder id = new InOrder();
            Node root = id.createTree(2);
            Queue myQueue = new Queue();
            myQueue.Enqueue(root);
            int sum = 0;
            while (myQueue.Count > 0)
            {
                Node top = (Node)myQueue.Dequeue();
                if ((top.left == null) && (top.right == null))
                {
                    sum += top.value;
                }
                if (top.left != null)
                {
                    top.left.value = top.value * 10 + top.left.value;
                    myQueue.Enqueue(top.left);
                }
                 if (top.right != null)
                 {
                     top.right.value = top.value * 10 + top.right.value;
                     myQueue.Enqueue(top.right);
                 }
            }
            return sum;
        }
        
        public void printAllpath(Node root, int sum)
        {
            if (root == null) return;
            ArrayList al = new ArrayList();
            ArrayList working = new ArrayList();
            printSumUtil(al, root, sum, working);
        }

        public void printTreeByLevel(Node root)
        {
            if (root==null) return;
            Queue cur = new Queue();
            Queue next = new Queue();            
            cur.Enqueue(root);
            while ((cur.Count > 0) || (next.Count > 0))
            {
                if (cur.Count > 0)
                {
                    Node temp = (Node)cur.Dequeue();
                    Console.Write("{0}->", temp.value);
                    if (temp.right != null)
                        next.Enqueue(temp.right);
                    if (temp.left != null)
                        next.Enqueue(temp.left);
                }
                else
                {
                    Console.WriteLine();
                    Queue tq = next;
                    next = cur;
                    cur = tq;
                }
            }
        }
        private void printSumUtil(ArrayList al, Node root, int sum, ArrayList working)
        {
            if (root == null)
                return;
            if (root.value == sum)
            {
                working.Add(root.value);
                ArrayList temp = (ArrayList)working.Clone();
                al.Add(temp);
                return;
            }
            working.Add(root.value);
            if (root.left != null)
            {
                printSumUtil(al, root.left, sum - root.value, working);
            }
            if (root.right != null)
            {
                printSumUtil(al, root.right, sum - root.value, working);
            }
            working.RemoveAt(working.Count - 1);
        }
        
    }
}
