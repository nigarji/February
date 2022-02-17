using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string text = ("Happy Days All Together");
            UpDown(text);



        }




        static void UpDown(string text)

        {

            for (int i = 0; i < text.Length; i++)
            {

                bool result = char.IsUpper(text[i]);
                char c = text[i];


                if (result)
                {
                    Console.Write(char.ToLower(c));

                }
                else

                {
                    Console.Write(char.ToUpper(c));

                }


            }

        }
    }
}
