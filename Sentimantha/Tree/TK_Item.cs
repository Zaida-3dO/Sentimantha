using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentimantha.Tree {
    public class TK_Item {
        string name;
        public TK_Item(string name) {
            this.name = name;
        }
        public override string ToString() {
            return name;
        }
        //TODO Constructor
    }
}
