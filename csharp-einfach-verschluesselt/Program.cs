using System;

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
            Console.WriteLine("Text vom User holen!");
            return "userInput";
        }

        private static string NormalizeUserInput(string userInput)
        {
            Console.WriteLine("Text normalisieren!");
            return "Normalisierter Text";
        }

        private static string Rotate13(string userInputNormalized)
        {
            Console.WriteLine("Text verschlüsseln!");
            return "verschlüsselter Text";
        }             
    }
}
