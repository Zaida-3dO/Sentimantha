using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentimantha.Tree {
    public class TK_Item {
        string name;
        /// <summary>
        /// Initializes a new instance of the <see cref="TK_Item"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public TK_Item(string name) {
            this.name = name;
        }
        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance, the name of the Item.
        /// </returns>
        public override string ToString() {
            return name;
        }
    }
}
