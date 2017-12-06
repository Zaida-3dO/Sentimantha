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
            stopwords = new HashSet<string>();
            string stopwordsFull =  File.ReadAllText(PathToStopWords);
            //foreach (string word in query.Split(punctuations, StringSplitOptions.RemoveEmptyEntries).ToList()) {
            //    results.Add(CorrectWord(word));
            //}
            // public static string[] punctuations = { " ",",","@","#","$","%","^","&","*","+","=","`","~","<",">","/","\\","|",":","(",")","?","!",";","-", "–","_","[","]","\"",".","…","\t","\n","\r" };

        }
        public bool IsStopWord(string word) {
            return (stopwords.Contains(word.ToLower()));
        }
        public bool IsCaps(string word) { return false; }
    }
}
