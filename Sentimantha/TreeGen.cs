using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sentimantha.Tree;
using Sentimantha.TextAnalyzer;
namespace Sentimantha {
    public static class TreeGen {        
        /// <summary>
        /// Generates a tree kernel from the specified expanded text.
        /// </summary>
        /// <param name="expandedText">The expanded text.</param>
        /// <returns>A tree kernel based on the expanded text</returns>
        public static TreeKernel Generate(List<string> expandedText) {
            var tree = new TreeKernel();
            foreach(var word in expandedText){
                if(word.StartsWith("@")){

                }                                             
                    
            }
        }
    }
}
