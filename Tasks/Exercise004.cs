using System;
using System.Linq;

// Move the first letter of each word to the end of it, then add "ay" to the end of the word. 
// Leave punctuation marks untouched.

namespace TechReturners.Tasks
{
    public class Exercise004
    {
        public static string PigIt(string str)
        {
            var words = str.Split(new [] { ' ' });
            for (var i = 0; i < words.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(words[i]))
                {
                    //Ignore any double spaces
                    continue;
                }
                int posFirstLetter = -1;
                int posLastLetter = 0;
                for (var j =0; j< words[i].Length; j++)
                {
                    if (!Char.IsPunctuation(words[i][j]))
                    {
                        if (posFirstLetter == -1)
                        {
                            posFirstLetter = j;
                        }
                        posLastLetter = j;
                    }
                }
                var firstLetter = "";
                if (posFirstLetter != -1)
                {
                    firstLetter = words[i][posFirstLetter].ToString();
                    words[i] = words[i].Remove(posFirstLetter, 1);
                }
                var toAppend = firstLetter + "ay";
                words[i] = words[i].Insert(posLastLetter, toAppend);
            }
            var pigWords = string.Join(" ", words);
            return pigWords;
        }
    }
}

