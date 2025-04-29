using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FBB.Engine.Classes.ConsoleDialogOptions;
namespace FBB.Engine.Extensions;

public static class Extensions
{
    public static bool IsInputValidNumber(this string input)
    {
        return int.TryParse(input, out int number);
    }

    public static bool IsOptionValid(this string input)
    {
        return MenuOptions.ContainsKey(input);
    }
    
    /* ORIGINAL METHOD AS I WROTE IT
    foreach (var option in MenuOptions)
    {
        if (MenuOptions.ContainsKey(input))
        {
            return true;
        }
    }
    return false;
*/

    //Kept this as its own function for experimentation
    public static bool DoesContainDigit(this string numberFromUser, string digitToCheck)//Accept key
    {
        return numberFromUser.Contains(digitToCheck);
    }
}

    //THIS IS THE ORIGINAL
    /*
    if (numberFromUser.Contains(digitToCheck))
    {
        return true;
    }
    return false;
    */

    /*
    public static bool IsInputValidNumber(this string input)
    {
        if (int.TryParse(input, out _))
        {
            return true;
        }
        return false;
    }
    */

    //THIS IS THE ORIGINAL
    /*
    public static bool IsInputValidNumber(this string input)
    {
        bool isValid = input.All(char.IsDigit);
        return isValid;
    }
    */

