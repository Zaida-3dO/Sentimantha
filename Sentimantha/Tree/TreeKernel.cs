using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentimantha.Tree {
    public class TreeKernel {
        /// <summary>
        /// The name of the Item
        /// </summary>
        public TK_Item Name;
        /// <summary>
        /// Gets a value indicating whether this instance has children.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has children; otherwise, <c>false</c>.
        /// </value>
        public bool HasChildren { get { return (children.Count > 0); } }
        List<TreeKernel> children;
        /// <summary>
        /// Initializes a new instance of the <see cref="TreeKernel"/> class.
        /// </summary>
        /// <param name="Name">The name.</param>
        public TreeKernel(string Name) {
            this.Name = new TK_Item(Name);
            children = new List<TreeKernel>();
        }
        /// <summary>
        /// Adds the specified node.
        /// Nodes should not be added more than once
        /// </summary>
        /// <param name="child">The child to be added.</param>
        public void AddNode(TreeKernel child) {
            children.Add(child);

        }
        /// <summary>
        /// Adds the node to the specified index.
        /// </summary>
        /// <param name="child">The child node to be added.</param>
        /// <param name="position">The position to insert the node.</param>
        public void AddNode(TreeKernel child,int position) {
            children.Insert(position, child);
        }
        /// <summary>
        /// Removes the first occurence of the node.
        /// </summary>
        /// <param name="child">The child.</param>
        public void RemoveNode(TreeKernel child) {
            children.Remove(child);
        }
        /// <summary>
        /// Removes the node at the specified index.
        /// </summary>
        /// <param name="index">The index to remove a node from.</param>
        public void RemoveNodeAt(int index) {
            children.RemoveAt(index);
        }
        /// <summary>
        /// Gets the children of this tree.
        /// </summary>
        /// <value>
        /// The children as an array.
        /// </value>
        public TreeKernel[] Children { get; }
    }
}
