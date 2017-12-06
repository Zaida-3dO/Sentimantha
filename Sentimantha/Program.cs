using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentimantha {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            List<string>a = Maxxer.Expand("there's a bug,isn't theeere? How's everyone there. 'Twas hot yesterday 'twasn't cold");
            foreach (var item in a)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
        
    }
}
