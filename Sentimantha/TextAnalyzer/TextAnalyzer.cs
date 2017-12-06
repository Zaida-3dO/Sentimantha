using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentimantha.TextAnalyzer {
    public class TextAnalyzer {
        HashSet<string> stopwords;
        public TextAnalyzer(string PathToStopWords) {
            string[] punctuations = { " ", ",", "@", "#", "$", "%", "^", "&", "*", "+", "=", "`", "~", "<", ">", "/", "\\", "|", ":", "(", ")", "?", "!", ";", "-", "–", "_", "[", "]", "\"", ".", "…", "\t", "\n", "\r" };
            stopwords = new HashSet<string>();
            string stopwordsFull =  File.ReadAllText(PathToStopWords);
            foreach (string word in stopwordsFull.Split(punctuations, StringSplitOptions.RemoveEmptyEntries).ToList()) {
                stopwords.Add(word.ToLower());
            }
           
        }
        public bool IsStopWord(string word) {
            return (stopwords.Contains(word.ToLower()));
        }
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
