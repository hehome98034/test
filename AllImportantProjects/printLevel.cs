using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllImportantProjects
{
    class printLevel
    {
        public static int maxHeight(Node root)
        {
            if (null == root) return 0;
            int lHeight = maxHeight(root.left);
            int rHeight = maxHeight(root.right);
            if (lHeight > rHeight)
                return lHeight + 1;
            else
                return rHeight + 1;
        }

        public static void printLevelMethod(Node p, int level)
        {
            if (p == null) return;
            if (level == 1)
            {
                Console.Write("{0}", p.value);

            }
            else
            {
                printLevelMethod(p.left, level - 1);
                printLevelMethod(p.right, level - 1);
            }
        }

        public static void printLevelOrder(Node root)
        {
            int height = maxHeight(root);
            for (int level = 1; level <= height; level++)
            {
                printLevelMethod(root, level);
                Console.WriteLine();
            }
        }
    }
}


