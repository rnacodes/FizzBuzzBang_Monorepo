using FBB.Engine.Extensions;
using static FBB.Engine.Extensions.Extensions;

namespace FBB.Engine.Classes
{
    public static class ConsoleDialogOptions
    {
        public static void Translate()
        {
            string userInputToTranslate;

            Console.WriteLine("Enter a number between 1 and 1000 to translate into our special FizzBuzzBang language!");

            userInputToTranslate = Console.ReadLine() ?? string.Empty;

            while (!userInputToTranslate.IsInputValidNumber())
            {
                Console.WriteLine("Please enter a valid number.");
                userInputToTranslate = Console.ReadLine() ?? string.Empty;
            }

            var numberInFBB = userInputToTranslate.TranslateNumber();

            Console.WriteLine(userInputToTranslate + " translated is: " + numberInFBB);
        }

        public static void Print()
        {
            Console.WriteLine("Now printing requested numbers:");

            for (int counter = 1; counter <= 100; counter++)
            {
                string translatedInputToPrint = counter.ToString().TranslateNumber();

                Console.WriteLine(translatedInputToPrint);

                translatedInputToPrint = "";
            }

        }

        public static void Add()
        {
            Console.WriteLine("Coming soon!");
            //Console.WriteLine("Enter your special number between 1 and 9 (excl. 3, 5, and 7");
        }

        public static Dictionary<string, Action> MenuOptions = new Dictionary<string, Action>()
            {
                {"1", Translate},
                {"2", Print},
                {"3", Add}
            };

        public enum NewMenuOptions
        {
            Translate = 1,
            Print = 2,
            Add = 3
        }
    }
}
