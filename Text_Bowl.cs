using System;
using System.Collections.Generic;
using System.Text;

namespace Palin_Ident
{
    class Text_Bowl
    {   
        // stringvariables as resources light
        public static string welcomeMsg = "\n\t\t...........................................\n\t\tWelcome to the great Palindrome-Identifier!";
        public static string briefMsg = " With the help of this program you may identify if a word is an palindrome or not.";
        public static string aboutPalinMsg = "\tA palindrome is a word, number, phrase, or other sequence of characters which reads the same backward as forward,such as madam or racecar.";
        public static string inputReqMsg = "°>>> Please type in the questionable word, number or phrase now and confirm with the \"enter-key\": ";
        public static string reversedQueryMsg = "\tThe query reads backwards as: ";
        public static string forwardHashMsg = "\tThe hash for the query forward reads: ";
        public static string backwardHashMsg = "\tThe hash for the query backward reads: ";
        public static string returnMsg = "\tFor another query please just press any key!";
        public static string palinTrueMsg = "\t  °>>> The query  > {0} <  is indeed a palindrome! <<<°\n\t\t\t_______________________________________\n\t\t\t_______________________________________";
        public static string palinFalseMsg = "\t  °>>> Unfortunately the query  > {0} <  is no palindrome! <<<°\n\t\t\t________________________________________________\n\t\t\t________________________________________________\n\t\t\tMisspelt or want to try another term - you're welcome to have another try!";
        public static string closedLineLongDesign = "\t\t\t_________________________________________________________________________________________________________________________";
        public static string closedLineMediumDesign = "________________________________________________";
        public static string dashedLineLongDesign = "-------------------------------------------------------------------------------------------------------------------------------------------------";
        public static string dashedLineMediumDesign = "------------------------------------";
        public static string dotLineMediumPlusDesign = "...........................................";
        public static string dotLineMediumDesign = "....................................";
        public static string logoDesign = "         ____    __                            __    ___         _____ \n" +
                                          "        /  _ \\  /_ \\  |    |    /|   /      | |  \\  |   |   /|  |  | |    \n" +
                                          " <      |____| |____| |    |   / |  /   __  | |   | |___   / |  /  |        >\n" +
                                          "  °>>>> |      |    | |    |  /  | /   <MW> | | | | |     /  | /   |   <<<<°\n" +
                                          " <      |      |    | |___ | /   |/         | |__/  |___|/   |/    |        >";
        public static string inputLengthOver250Msg = "My poor code wasn't able to handle your surplus inquiry due to too many characters. \nPlease feel free to try it again with a shorter query.";
        public static string inputLengthZero = "Your are supposed to type something in before you start a request. \nPlease feel free to try it again with feeding some input before.";



        // changes background- and fontcolor of the concole
        public static void colorSettingDesign()
        {
            // TODO: exception handling
            //         - falls der Nutzer nicht die Rechte für die Changes hat
            //         - falls auf dem System die Farbe nicht verfügbar ist

            if (Console.BackgroundColor == ConsoleColor.Black)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Green;
            }
        }

      
    }


}
