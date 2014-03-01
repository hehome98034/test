using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace AllImportantProjects
{
    class Node
    {
        public Node left;
        public Node right;
        public Node next;
        public int value;
        public string Name;

        public Node(int val)
        {
            left = null;
            right = null;
            value = val;
            next = null;
        }      
    }
    class InOrder
    {
        /// <summary>
        /// this created based on BFS
        /// a full balanced tree, 
        /// starting node[1]
        /// </summary>
        /// <param name="total"></param>
        /// <returns></returns>
        public Node createTree(int total)
        {
            Node[] all = new Node[total + 15];
            for (int i = 0; i < total + 15; i++)
                all[i] = new Node(i);
            all[1].left = all[2];
            all[2].left = all[4];
            all[3].left = all[6];            
            all[6].left = all[7];

            all[1].right = all[3];

            all[2].right = all[5];
            
            return all[1];
        }

        public Node createBigTree(int total)
        {
            Node[] all = new Node[total];
            for (int i = 0; i < total; i++)
            {
                all[i] = new Node(i % 5);
                all[i].Name = "node-" + Convert.ToString(i);
                
            }
            for (int i = 0; i < total / 2 - 5; i++)
            {
                all[i].value = i % 5;
                all[i].left = all[i * 2 + 1];
                all[i].right = all[i * 2 + 2];
            }
            return all[0];
        }

        public ArrayList serializeIt(Node root)
        {
            ArrayList al = new ArrayList();
            serialUti(root, al);
            for (int i = 0; i < al.Count; i++)
            
                Console.Write("{0}", al[i]);
            
            return al;
        }

        public Node Deserial(ArrayList al)
        {
            int i = 0;
            Node r = null;
            DeserialUtil(ref r, al, ref i);
            return r;
        }

        private void DeserialUtil(ref Node cur, ArrayList al, ref int index)
        {
            if (index > al.Count - 1) return;
            object top = al[index++];
            string temp = (string)top;
            int value = 0;
            if (temp != "#")
            {
                value= Convert.ToInt32(temp);
                cur = new Node(value);
                ///cur.left and cur.right are both null
                ///in the initialization
                DeserialUtil(ref cur.left, al, ref index);
                DeserialUtil(ref cur.right, al, ref index);
            }

        }

        
        private void serialUti(Node root, ArrayList res)
        {
            if (root == null)
            {
                res.Add("#");
                return;
            }
            res.Add(Convert.ToString(root.value));
            serialUti(root.left, res);
            serialUti(root.right, res);
        }

        public void ReverseInOrder(Node root)
        {
            if (root == null) return;
            ReverseInOrder(root.right);
            Console.WriteLine("{0}->", root.value);
            ReverseInOrder(root.left);

        }

        public Node CommonAncestor(Node root, Node X, Node Y)
        {                        
            if (null == root) return null;
            if (root == X) return X;
            if (root == Y) return Y;
            Node left = CommonAncestor(root.left, X, Y);
            Node right = CommonAncestor(root.right, X, Y);
            if ((left != null) && (right != null))
                return root;
            else if ((left == null) && (right == null))
                return null;
            else return (null==left) ? right : left;
            

        }

        public void getnThNode(Node root,ref int i, int N)
        {
            if (root == null) return;
            getnThNode(root.right, ref i, N);
            i++;
            
            if (i == N)
            {
                Console.WriteLine("the value of {0}th is {1}", N, root.value);
                return;
            }            
            getnThNode(root.left, ref i, N);            
        }
        /// <summary>
        /// this is inorder traversal
        /// </summary>
        /// <param name="root"></param>
        public void inOrder(Node root)
        {
            Stack inStack = new Stack();
            Node r = root;
            while (true)
            {
                if (r != null)
                {
                    inStack.Push(r);
                    r = r.left;
                }
                else if (inStack.Count > 0)
                {
                    r = (Node)inStack.Pop();
                    Console.WriteLine("{0}->", r.value);
                    r = r.right;
                }
                else
                {
                    break;
                }
            }
            return;
        }

        /// <summary>
        /// this is post order traversal
        /// </summary>
        /// <param name="root"></param>

        public void PostOrder(Node root)
        {
            Stack myPost = new Stack();
            if (null == root) return;
            Node r = root;
            myPost.Push(root);
            Node pre = null;
            while (myPost.Count>0)
            {
                Node cur = (Node)myPost.Peek();
                /// going down
                if ((pre == null) || (pre.left == cur) || (pre.right == cur))
                {
                    if (cur.left != null)
                        myPost.Push(cur.left);
                    else if (cur.right != null)
                        myPost.Push(cur.right);
                    else
                    {
                        cur = (Node)myPost.Pop();
                        Console.Write("{0}, ", cur.value);
                    }
                    pre = cur;
                }
                /// going up from left child
                if (cur.left == pre)
                {
                    if (cur.right != null)
                    {
                        myPost.Push(cur.right);
                    }
                    else
                    {
                        cur = (Node)myPost.Pop();

                        Console.Write("{0}, ", cur.value);
                    }
                }
                /// going up from right child
                if (cur.right == pre)
                {
                    cur = (Node)myPost.Pop();
                    Console.Write("{0}, ", cur.value);
                }
                
                pre = cur;
            }
        }
        public void preOrder(Node root)
        {
            if (null == root) return;
            Stack pre = new Stack();
            pre.Push(root);
            while (pre.Count > 0)
            {
                Node cur = (Node)pre.Pop();
                Console.Write("{0}", cur.value);
                if (cur.right != null)
                    pre.Push(cur.right);
                if (cur.left != null)
                    pre.Push(cur.left);
            }

        }
    }
}
