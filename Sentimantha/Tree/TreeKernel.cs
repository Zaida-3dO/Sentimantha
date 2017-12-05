using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentimantha.Tree {
    public class TreeKernel {
        public TK_Item name;
        public bool HasChildren { get; }
        List<TreeKernel> children;
        public TreeKernel(string Name) { }
        public void AddNode(TreeKernel child) { }
        public void AddNode(TreeKernel child,int position) { }
        public void RemoveNode(TreeKernel child) { }
        public void RemoveNodeAt(int index) { }
        public List<TreeKernel> Children { get; }

        //TODO constructor
    }
}
