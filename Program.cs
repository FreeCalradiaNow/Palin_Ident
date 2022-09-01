using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace Palin_Ident
{
    public class Program
    {
        static void Main()
        {
            Text_Bowl.colorSettingDesign();

            Console.WriteLine("\n\t\t" + Text_Bowl.dotLineMediumPlusDesign +
                              Text_Bowl.logoDesign + 
                              Text_Bowl.welcomeMsg + 
                              "\n\t\t" + Text_Bowl.dotLineMediumPlusDesign +
                              "\n\n\n\n" + Text_Bowl.briefMsg +
                              "\n" + Text_Bowl.dotLineMediumDesign +
                              "\n\n\n" + Text_Bowl.aboutPalinMsg +
                              "\n" + Text_Bowl.dashedLineMediumDesign +
                              "\n\n\n" + Text_Bowl.inputReqMsg);

            string inputQuery0 = Console.ReadLine().ToLower();

            // TODO: exception handling
            //         - falls der Input ohne eingegebene Zeihen kommt
            //         - falls der Input x Zeichen überschreitet
            // TODO: Oder MaxLength der eingabe direct begrenzenen mit Msg über cw
            // TODO: Whitespaces nach der Eingabe automatisch erasen?

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
                Console.WriteLine("\n\n\n\n" + 
                                  Text_Bowl.palinFalseMsg +
                                  "\n" + Text_Bowl.dashedLineMediumDesign);
            }


            Console.WriteLine("\n\n\n\t\t" + Text_Bowl.closedLineMediumDesign +
                               "\n\t\t" + Text_Bowl.returnMsg +
                               "\n\n\n\n\n" + Text_Bowl.closedLineLongDesign);
            Console.ReadKey();
            Console.Clear();
            Main();


            // TODO: Menu for -Clear
            //                -Another try
            //                -display hash
            //  maybe via case block
        }
    }
}
