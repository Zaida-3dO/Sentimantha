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
        public static TreeKernel Generate(List<string> expandedText, string pathToStopWords ,string targetId, string stopwordId, 
            string exclamationId, string capsId, string normalWordId) {
            //TODO Remember to tell Ope to add targetId and the rest to the constructor for the tree kernel
            var tree = new TreeKernel("Root");
            var textanalyzer = new TextAnalyzer.TextAnalyzer(pathToStopWords);
            foreach(var word in expandedText)
                if(word.StartsWith("@"))
                    tree.AddNode(new TreeKernel(targetId));
                else if(textanalyzer.IsStopWord(word))
                    tree.AddNode(new TreeKernel(stopwordId));
                else if(word.Equals("NOT"))
                    tree.AddNode(new TreeKernel("NOT"));
                else if(word.EndsWith("!"))
                    tree.AddNode(new TreeKernel(exclamationId));
                else{
                    tree.AddNode(new TreeKernel(normalWordId));
                    //TODO Tell Ope to create an indexer for the children of the tree kernel in order to 
                    //TODO Explain the problem better
                    var item = tree.Children[(tree.Children.Length-1)];
                    if(textanalyzer.IsCaps(word)) 
                        item.AddNode(new TreeKernel(capsId));
                    item.AddNode(new TreeKernel(word));
                    item.AddNode(new TreeKernel("POS"));
                }
            return tree;
        }
    }
}
