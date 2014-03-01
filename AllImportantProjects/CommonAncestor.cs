using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllImportantProjects
{
    class CommonAncestor
    {
        public Node[] tree;
        public InOrder myTree;
        public CommonAncestor(int sizeNode)
        {
            tree = new Node[sizeNode];
            myTree = new InOrder();
        }

    }
}
