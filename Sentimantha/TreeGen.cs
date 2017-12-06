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
                    tree.AddNode(new TK_Item(targetId));
                else if(textanalyzer.IsStopWord(word))
                    tree.AddNode(new TK_Item(stopwordId));
                else if(word.Equals("NOT"))
                    tree.AddNode(new TK_Item("NOT"));
                else if(word.EndsWith("!"))
                    tree.AddNode(new TK_Item(exclamationId));
                else{
                    tree.AddNode(new TK_Item(normalWordId));
                    //TODO Tell Ope to create an indexer for the children of the tree kernel in order to 
                    var item = tree.Children[tree.Children.Count-1];
                    if(textanalyzer.PercentCaps(word)  > 0.8) 
                        item.AddNode(new TK_Item(capsId));
                    item.AddNode(new TK_Item(word));
                    item.AddNode(new TK_Item("POS"));
                }
            return tree;
        }
    }
}
