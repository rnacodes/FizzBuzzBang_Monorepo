using FBB.Engine.Classes;
using FBB.Engine.Extensions;
using static FBB.Engine.Classes.ConsoleDialogOptions;
namespace FBB.ConsoleApp;

public class Program
{
    static void Main()

    //Three dialogue options:
    //1. Translate user number into FizzBuzzBang language
    //2. Print number 1 through 1000 in FizzBuzz
    //3. Allow user to add their own special number and phrase
    {
        string numberInFBB;

        string userActionResponse;

        Console.WriteLine("Let's play a game! Choose from one of the following options:");

        Console.WriteLine("1. Translate a number 1 - 1000 into our special FizzBuzzBang Language! (Translate)");
        Console.WriteLine("2. Print from 1 to 1000 in FBB (Print)");
        Console.WriteLine("3. Add your own number and phrase (Add)");


        userActionResponse = Console.ReadLine() ?? string.Empty;

        ////THIS IS HOW I SET UP GUARDRAILS FOR MENU INPUT
        while (!userActionResponse.IsOptionValid())
        {
            Console.WriteLine("Please enter a valid response.");

            userActionResponse = Console.ReadLine().ToLower();
        }

        switch (userActionResponse)
        {
            //case ("translate"):
            case ("1"):
                Translate();
                break;

            //case "print":
            case ("2"):
                Print();
                break;

            //case "add":
            case ("3"):
                Add();
                break;
        }
        ;

        var asdf = ConsoleDialogOptions.NewMenuOptions.Translate;

        switch (asdf)
        {
            case ConsoleDialogOptions.NewMenuOptions.Translate:
                Console.WriteLine("Translate");
                break;
            case ConsoleDialogOptions.NewMenuOptions.Print:
                Console.WriteLine("Print");
                break;
            case ConsoleDialogOptions.NewMenuOptions.Add:
                Console.WriteLine("Add");
                break;
        }
    }
}