using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTree
{
    public class TreeNode
    {
        public TreeNode(int info)
        {
            Info = info;
        }
        public int Info { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }
    }
}
