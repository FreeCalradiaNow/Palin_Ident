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
        public static string inputReqMsg = "Please type in the questionable word, number or phrase now and confirm with the \"enter-key\": ";
        public static string reversedQueryMsg = "\tThe query reads backwards as: ";
        public static string forwardHashMsg = "\tThe hash for the query forward reads: ";
        public static string backwardHashMsg = "\tThe hash for the query backward reads: ";
        public static string returnMsg = "\tFor another query please just press any key!";
        public static string palinTrueMsg = "\tThe query is indeed a palindrome!";
        public static string palinFalseMsg = "\tUnfortunately the query is no palindrome!\n\tMisspelt or want to try another term - you're welcome to have another try!";
        public static string closedLineLongDesign = "_________________________________________________________________________________________________________________________________________________";
        public static string closedLineMediumDesign = "____________________________________";
        public static string dashedLineLongDesign = "-------------------------------------------------------------------------------------------------------------------------------------------------";
        public static string dashedLineMediumDesign = "------------------------------------";
        public static string dotLineMediumPlusDesign = "...........................................";
        public static string dotLineMediumDesign = "....................................";
        public static string logoDesign = "        ____    __                            __    ___         _____\n" +
                                          "       /  _ \\  /_ \\  |    |    /|   /      | |  \\  |   |   /|  |  | |   \n" +
                                          " <     |____| |____| |    |   / |  /   __  | |   | |___   / |  /  |       >\n" +
                                          "  >>>> |      |    | |    |  /  | /   <MW> | | | | |     /  | /   |   <<<<\n" +
                                          " <     |      |    | |___ | /   |/         | |__/  |___|/   |/    |       >";



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

        public static void removeWhites()
        {

        }
    }


}
