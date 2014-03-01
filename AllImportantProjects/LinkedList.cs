using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllImportantProjects
{
    class LinkedNode 
    {
        public int value;
        public LinkedNode next;
        public LinkedNode(int n)
        {
            value = n;
            next = null;
        }
    }
    class LinkedList
    {
        public LinkedNode createList(int n)
        {
            if (n==0) return null;
            LinkedNode head = new LinkedNode(9);
            LinkedNode pre=head;
             LinkedNode cur = null;
            for (int i=1; i<n; i++)
            {
               cur = new LinkedNode(9);
                pre.next=cur;
                pre=cur;
            }
            pre.next = null;
            return head;
        }

        public int countLength(LinkedNode head)
        {
            if (head==null) return 0;
            else return 1+countLength(head.next);
        }

        public LinkedNode addListNoExtra(LinkedNode A, LinkedNode B)
        {
           int A_length = countLength(A);
            int B_length = countLength(B);
            LinkedNode longer = A;
            LinkedNode shorter = B;
            int flag = 0;
            if (A_length < B_length)
            {
                longer = B;
                shorter = A;
            }
            LinkedNode ResultLinkedNode = longer;
            LinkedNode last=null;
            while (shorter!=null)
            {
                int temp =(longer.value + shorter.value + flag) % 10;
                flag = (longer.value + shorter.value) / 10;
                longer.value=temp;
                longer=longer.next;
                shorter=shorter.next;                    
            }
            while (flag==1)
            {
                if ( longer!=null)
                {                    
                    int temp=(longer.value + 1) % 10;
                    flag = (longer.value + 1) / 10;
                    longer.value=temp;
                    last = longer;
                    longer = longer.next;
                }
                else
                {
                    last.next=new LinkedNode(1);
                    break;
                }
            }
            return ResultLinkedNode;
        }        
    }
}
