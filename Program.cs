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
                              "\n" + Text_Bowl.logoDesign + 
                              Text_Bowl.welcomeMsg + 
                              "\n\t\t" + Text_Bowl.dotLineMediumPlusDesign +
                              "\n\n\n\n" + Text_Bowl.briefMsg +
                              "\n" + Text_Bowl.dotLineMediumDesign +
                              "\n\n\n" + Text_Bowl.aboutPalinMsg +
                              "\n" + Text_Bowl.dashedLineMediumDesign +
                              "\n\n\n" + Text_Bowl.inputReqMsg);

        Inputrequest:
            string inputQuery0 = Console.ReadLine();
            string inputQuery1 = new string(inputQuery0.ToLower().Replace(" ", String.Empty));
            
            int inputLength = inputQuery1.Length;
            
            // controls the input (instead of switch case or exception handling)
            if(inputLength > 249)
            {
                Console.WriteLine(Text_Bowl.inputLengthOver250Msg);
                goto Inputrequest;
            }
            else if (inputLength <= 0)
            {
                Console.WriteLine(Text_Bowl.inputLengthZero);
                goto Inputrequest;
            }
            else
            {
                goto Inquiry;
            }

            Inquiry:
            char[] inputQuery2 = inputQuery1.ToCharArray();
            Array.Reverse(inputQuery2);
            string reversedQuery = new string(inputQuery2);

            int reversedHash = reversedQuery.GetHashCode();
            int originalHash = inputQuery1.GetHashCode();


            if (reversedHash == originalHash)
            {
                Console.WriteLine("\n\n\n\n" + Text_Bowl.dashedLineLongDesign + 
                                  "\n\t\t" + string.Format(Text_Bowl.palinTrueMsg, inputQuery0));
            }
            else
            {
                Console.WriteLine("\n\n\n\n" + Text_Bowl.dashedLineLongDesign +
                                  "\n\t\t" + string.Format(Text_Bowl.palinFalseMsg, inputQuery0)); 
            }



            Console.WriteLine("\n\n\n\t\t\t" + Text_Bowl.closedLineMediumDesign +
                               "\n\t\t" + Text_Bowl.returnMsg +
                               "\n" + Text_Bowl.closedLineLongDesign);
            Console.ReadKey();
            Console.Clear();
            Main();
            //Environment.Exit(0);

            // TODO: create fix Menu for -Clear
            //                           -Another try
            //                           -display hash
            //  maybe via case block
            //  watchout: Clear(); not only wipes the screen but also the content of the variables
        }
    }
}
