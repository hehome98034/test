using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllImportantProjects
{
    class BuildBTree
    {
        public BuildBTree()
        {

        }
        /// <summary>
        /// assuming that input has been verified
        /// </summary>
        /// <param name="pre"></param>
        /// <param name="inorder"></param>
        /// <returns></returns>
        /// 
        /*
        public Node constructTree(int[] pre, int[] inorder)
        {
            int pre_s = 0;
            int pre_e = pre.Length - 1;
            int in_s = 0;
            int in_e = inorder.Length - 1;
            /*
            return GetTree(pre, pre_s, pre_e, inorder, in_s, in_e);
            
        }
        */

        public int getInorderPosition(int[] inorder, int val)
        {
            int i = 0;
            while ((i<inorder.Length) && (inorder[i]!=val)) i++;
            return i;
        }
        /*
        private Node GetTree(int[] pre, int s1, int e1, int[] inorder, int s2, int e2)
        {
            if ((e1 < s1) || (e2 < s2) || (s1 > pre.Length - 1) || (s2 > inorder.Length - 1))
                return null;
            int root_Value = pre[s1];
            int dividing = getInorderPosition(inorder, root_Value);
            Node root = new Node(root_Value);

            root.left = GetTree(pre, s1+1, , inorder, s2, dividing-1);
                

        }
         */
    }
}
