using System;
using System.Text.RegularExpressions;

namespace csharp_einfach_verschluesselt
{
    class Program
    {
            // Testdaten
            // Hallo                                       UNYYB
            // Es ist gerade 7:21 Uhr am Dienstag Morgen   RF VFG TRENQR 7:21 HUE NZ QVRAFGNT ZBETRA
            // Übung macht besser ;-)	                   HROHAT ZNPUG ORFFRE ;-)


        static void Main(string[] args)
        {
            string userInput = GetUserInput();           
            string userInputNormalized = NormalizeUserInput(userInput);
            string outputOfRotate13 = Rotate13(userInputNormalized);
            OutputOfTheEncryptedText(outputOfRotate13);

            Console.ReadKey();
        }

        private static string GetUserInput()
        {
            Console.WriteLine("Wilkommen im Programm ROT13.");
            Console.WriteLine("Das Programm verschlüsselt die folgende Eingabe.");
            Console.WriteLine();
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
            int rotationWidth = 13;
            char[] letterCircle = new char[52]
            {
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
                'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',

                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
                'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
            };

            int indexForEncryptedLetters = Array.IndexOf(letterCircle, currentChar) + rotationWidth;
            return letterCircle[indexForEncryptedLetters];
        }

        private static void OutputOfTheEncryptedText(string outputOfRotate13)
        {
            Console.WriteLine();
            Console.WriteLine("Der Verschlüsselte Text ist wie folgt:");
            Console.WriteLine();
            Console.WriteLine(outputOfRotate13);
        }
    }
}
