using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentimantha {
    public static class Maxxer {
        
        
       
        /// <summary>
        /// requires: any sentence of type string;
        /// returns: returns the list of non clitic words
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static List<string> Expand(string word) {
            List<string> brokenWords = new List<string>();
            
            List<string> sentenceList = new List<string>();
            char[] delimiter =  {'\t','\n',' ' };
            sentenceList = word.Split(delimiter).ToList();
            foreach (var item in sentenceList)
            {
                BreakMe(item,brokenWords);
            }
            return brokenWords;
        }

        /// <summary>
        /// requires:a word to be broken down, and a list to hold words;
        /// returns:none;A void type
        /// </summary>
        /// <param name="word"></param>
        /// <param name="brokenWords"></param>
        public static void BreakMe(string word, List<string> brokenWords) {
            //the apostrophe sign is used as the delimier "'"
            string fword = "";
            string sword = "";

            //checks for the presence of an apostrophe
            if (word.Contains("'"))
            {
                //checks if the apostrophe is at the front of the word
                if (!word.ElementAt(0).Equals('\''))
                {
                    //if no, it checks for the different possible ending letters;
                    switch (word.Last())
                    {
                        case ('a'):
                            int i = word.Length - 1;
                            if (word.ElementAt(i).Equals('n') && word.ElementAt(i - 1).Equals('n') && word.ElementAt(0).Equals('g'))
                            {
                                brokenWords.Add("going");
                            }
                            else if (word.ElementAt(i).Equals('n') && word.ElementAt(i - 1).Equals('n') && word.ElementAt(0).Equals('g'))
                            {
                                brokenWords.Add("got");
                            }
                            brokenWords.Add("to");
                            break;
                        case ('d'):
                            fword = word.Split('\'')[0];
                            sword = "ha" + word.Split('\'')[1];
                            brokenWords.Add(fword);
                            brokenWords.Add(sword);
                            break;

                        case ('e'):
                            fword = word.Split('\'')[0];
                            switch (word.Split('\'')[1])
                            {
                                case ("ve"):
                                    sword = "have";
                                    break;
                                case ("re"):
                                    sword = "are";
                                    break;
                            }
                            brokenWords.Add(fword);
                            brokenWords.Add(sword);
                            break;

                        case ('l'):
                            if (word.Split('\'')[0].Equals("y"))
                            {
                                fword = word.Split('\'')[0] + "ou";
                            }
                            else
                            {
                                fword = word.Split('\'')[0];
                            }
                            sword = "wi" + word.Split('\'')[1];
                            brokenWords.Add(fword);
                            brokenWords.Add(sword);
                            break;

                        case ('s'):
                            fword = word.Split('\'')[0];
                            sword = "i" + word.Split('\'')[1];
                            brokenWords.Add(fword);
                            brokenWords.Add(sword);
                            break;

                        case ('t'):
                            string fakeText = word.Split('\'')[0];
                            fword = fakeText.Remove(fakeText.Length - 1, 1);
                            sword = "no" + word.Split('\'')[1];
                            brokenWords.Add(fword);
                            brokenWords.Add(sword);
                            break;
                        //checks for nouns
                        default:
                            fword = word.Split('\'')[0];
                            sword = "i" + word.Split('\'')[1];
                            brokenWords.Add(fword);
                            brokenWords.Add(sword);
                            break;

                    }


                }
                //if yes, checks for words like 'Twas = it was
                else
                {
                    brokenWords.Add("I" + word.ElementAt(1).ToString().ToLower());
                    BreakMe(word.Remove(0, 2),brokenWords);
                }
            }
            //if there's no apostrophe present anymore
            else
            {
                    brokenWords.Add(word);
                }
            
        }
    }
}
