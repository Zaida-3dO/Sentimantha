using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentimantha.Tree {
    public class TreeKernel {
        public TK_Item Name;
        public bool HasChildren { get { return (children.Count > 0); } }
        List<TreeKernel> children;
        public TreeKernel(string Name) {
            this.Name = new TK_Item(Name);
            children = new List<TreeKernel>();
        }
        public void AddNode(TreeKernel child) {
            children.Add(child);

        }
        public void AddNode(TreeKernel child,int position) {
            children.Insert(position, child);
        }
        public void RemoveNode(TreeKernel child) {
            children.Remove(child);
        }
        public void RemoveNodeAt(int index) {
            children.RemoveAt(index);
        }
        public TreeKernel[] Children { get; }

        //TODO constructor
    }
}
