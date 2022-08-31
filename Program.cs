using System;
using System.Linq;

namespace Palin_Ident
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\tplaceholder_welcome\n\n\tplaceholder_inputRequest");

            string inputWord = Console.ReadLine();

            char[] inputChar = inputWord.ToCharArray();

            int inputCount = inputChar.Length;

            bool evenCount = (inputCount % 2 == 0);

            Char[] firstHalf = (inputChar.Length / 2);

            if (evenCount == true)
            {
               
            }
            else
            {
                //Console.WriteLine("ungerade");
            }

           

            Console.WriteLine(inputChar);
          




        }
    }
}
