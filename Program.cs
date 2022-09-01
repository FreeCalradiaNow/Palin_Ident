using System;
using System.Linq;

namespace Palin_Ident
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine(Text_Bowl.logoDesign + // Logo broken af
                              "\n\t" + Text_Bowl.welcomeMsg + 
                              "\n" + Text_Bowl.dotLineLongDesign +
                              "\n\n\n\n" + Text_Bowl.briefMsg +
                              "\n" + Text_Bowl.dotLineMediumDesign +
                              "\n\n\n" + Text_Bowl.aboutPalinMsg +
                              "\n" + Text_Bowl.dashedLineMediumDesign +
                              "\n\n\n" + Text_Bowl.inputReqMsg);

            string inputQuery0 = Console.ReadLine().ToLower();

            // Wenn Input Empty catch exeption
            // Wenn Input über x Zeichen catch exeption

            char[] inputQuery2 = inputQuery0.ToCharArray();
            Array.Reverse(inputQuery2);
            string reversedQuery = new string(inputQuery2);

            int reversedHash = reversedQuery.GetHashCode();
            int originalHash = inputQuery0.GetHashCode();

            if (reversedHash == originalHash)
            {
                Console.WriteLine("\n\n\n\n" + Text_Bowl.dashedLineLongDesign + 
                                  "\n\t\t" + Text_Bowl.palinTrueMsg);
            }
            else
            {
                Console.WriteLine(Text_Bowl.palinFalseMsg);
            }


            Console.WriteLine("\n\n\n\t\t" + Text_Bowl.closedLineMediumDesign +
                               "\n\t\t" + Text_Bowl.returnMsg +
                               "\n\n\n\n\n" + Text_Bowl.closedLineLongDesign);
            Console.ReadKey();
            Console.Clear();
            Main();


            // Menu for -Clear
            //          -Another try
            //          -display hash
            // maybe via case block
        }
    }
}
