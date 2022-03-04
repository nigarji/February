using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders02._28
{
    static class Extension
    {

        public static void IsCapitalized ( this string word) 
        {
            word = word.ToLower (); 
            string[] newWord = word.Split(' ');
            StringBuilder sb = new StringBuilder();

            foreach (var item in newWord)
            {
                sb.Append(char.ToUpper(item[0]));

                for (int i = 1; i < item.Length; i++)
                {
                    sb.Append(item[i].ToString());
                }
               
            }
            Console.WriteLine(sb.ToString());
        }

        public static bool CustomContain(this string word, string searchWord)
        {
            foreach (var item in word) //bulik minic
            {
                if (searchWord == word.IndexOfAny(item))
                {
                    return true;
                }
                return false;
            }

            return true;
        }
    }
}
