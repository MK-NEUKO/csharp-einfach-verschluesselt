using System;
using System.Text.RegularExpressions;

namespace csharp_einfach_verschluesselt
{
    class Program
    {
        static void Main(string[] args)
        {
            // Text vom User erfragen.
            string userInput = GetUserInput();

            // Alle Buchstaben zu Großbuchstaben ändern, alle Umlaute normalisieren.
            string userInputNormalized = NormalizeUserInput(userInput);

            // Text Verschlüsseln
            string outputOfRotate13 = Rotate13(userInputNormalized);

            // verschlüsselten Text ausgeben
            Console.WriteLine(outputOfRotate13);

            Console.ReadKey();
        }

        private static string GetUserInput()
        {
            Console.WriteLine("Wilkommen im Programm ROT13.");
            Console.WriteLine("Das Programm verschlüsselt die folgende Eingabe.");
            return Console.ReadLine();
        }

        private static string NormalizeUserInput(string userInput)
        {
            userInput = userInput.ToUpper();
            userInput = userInput.Replace("Ä", "AE");
            userInput = userInput.Replace("Ö", "OE");
            userInput = userInput.Replace("Ü", "UE");
            userInput = userInput.Replace("ß", "SS");

            return userInput;
        }

        private static string Rotate13(string userInputNormalized)
        {
            string outputString = "";

            foreach (var currentChar in userInputNormalized)
            {              
                if (CheckForLettersOnly(currentChar))
                {
                    outputString += RotateChar(currentChar);
                }
                else
                    outputString += currentChar;
            }
            return outputString;
        }

        private static bool CheckForLettersOnly(char currentChar)
        {
            Regex onlyLetters = new Regex("[a-zA-Z]");
            return onlyLetters.IsMatch(currentChar.ToString());
        }

        private static char RotateChar(char currentChar)
        {
            Console.WriteLine("Rotate");
            return currentChar;
        }        
    }
}
