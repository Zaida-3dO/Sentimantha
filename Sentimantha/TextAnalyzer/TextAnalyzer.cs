using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentimantha.TextAnalyzer {

    public class TextAnalyzer {
        HashSet<string> stopwords;
        /// <summary>
        /// Initializes a new instance of the <see cref="TextAnalyzer"/> class.
        /// </summary>
        /// <param name="PathToStopWords">The path to stop words.</param>
        public TextAnalyzer(string PathToStopWords) {
            string[] punctuations = { " ", ",", "@", "#", "$", "%", "^", "&", "*", "+", "=", "`", "~", "<", ">", "/", "\\", "|", ":", "(", ")", "?", "!", ";", "-", "–", "_", "[", "]", "\"", ".", "…", "\t", "\n", "\r" };
            stopwords = new HashSet<string>();
            string stopwordsFull =  File.ReadAllText(PathToStopWords);
            foreach (string word in stopwordsFull.Split(punctuations, StringSplitOptions.RemoveEmptyEntries).ToList()) {
                stopwords.Add(word.ToLower());
            }
           
        }
        /// <summary>
        /// Determines whether the specified word is a stop word .
        /// </summary>
        /// <param name="word">The word.</param>
        /// <returns>
        ///   <c>true</c> if  the specified word is a stop word otherwise, <c>false</c>.
        /// </returns>
        public bool IsStopWord(string word) {
            return (stopwords.Contains(word.ToLower()));
        }
        /// <summary>
        /// Determines whether the specified word is in Caps.
        /// </summary>
        /// <param name="word">The word.</param>
        /// <returns>
        ///   <c>true</c> if the specified word has more than half in caps; otherwise, <c>false</c>.
        /// </returns>
        public bool IsCaps(string word) {
            int uppers = 0;
            foreach (char letter in word) {
                if (char.IsUpper(letter))
                    uppers++;
            }
            return (uppers >= (word.Length / 2));
        }
    }
}
