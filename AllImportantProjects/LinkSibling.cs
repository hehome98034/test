using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace AllImportantProjects
{
    class LinkSibling
    {
        private ArrayList result;

        public LinkSibling()
        {
            result = new ArrayList();
        }

        public void LinkThem_DFS(Node root)
        {
            Link_DFS_Util(root, 0);
            
        }

        private void Link_DFS_Util(Node root, int level)
        {
            if (root == null) return;
            ArrayList cur = null;
            if (result.Count <= level)
            {
                cur = new ArrayList();
                result.Add(cur);
            }
                
            ArrayList levelth = (ArrayList)result[level];
            levelth.Add(root);

            Link_DFS_Util(root.left, level + 1);
            Link_DFS_Util(root.right, level + 1);
        }

        public Node LinkThem_BFS(Node root)
        {
            return null;
            
        }
    }
}
