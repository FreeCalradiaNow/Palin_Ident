using System;
using System.Linq;

namespace Palin_Ident
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\n\t" + Textpatch.welcomeMsg + 
                              "\n\n" + Textpatch.briefMsg + 
                              "\n" + Textpatch.aboutPalinMsg + 
                              "\n\n\n" + Textpatch.inputReqMsg);

            string inputQuery0 = Console.ReadLine().ToLower();

            char[] inputQuery2 = inputQuery0.ToCharArray();
            Array.Reverse(inputQuery2);
            string reversedQuery = new string(inputQuery2);

            int reversedHash = reversedQuery.GetHashCode();
            int originalHash = inputQuery0.GetHashCode();

            if (reversedHash == originalHash)
            {
                Console.WriteLine(Textpatch.palinTrueMsg);
            }
            else
            {
                Console.WriteLine(Textpatch.palinFalseMsg);
            }


            Console.WriteLine(Textpatch.returnMsg);
            Console.ReadKey();
            Console.Clear();
            Main();


            // Menu for Clear
            //          Another try
            // display hash
            // display restrictions

            // restrictions/ exeptin handling
        }
    }
}
