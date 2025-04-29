using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FBB.Engine.Extensions;

namespace FBB.Engine.Classes;


public static class MagicTranslator
{
    public static string TranslateNumber(this string numberToTranslate) //Turn into extension method
    {
        string numberTranslatedToFBB = "";

        foreach (var digitToCheck in FunPhrases)
        {
            if (numberToTranslate.DoesContainDigit(digitToCheck.Key) || int.Parse(numberToTranslate) % int.Parse(digitToCheck.Key) == 0)
            {
                numberTranslatedToFBB += digitToCheck.Value;
            }
        }

        if (numberTranslatedToFBB == "")
        {
            numberTranslatedToFBB = numberToTranslate;
        }
        return numberTranslatedToFBB;
    }

    public static string TranslateNumberForm(this int? numberToTranslate) //Turn into extension method
    {
        string numberTranslatedToFBB = "";

        foreach (var digitToCheck in FunPhrases)
        {
            if (numberToTranslate.ToString().DoesContainDigit(digitToCheck.Key) || numberToTranslate % int.Parse(digitToCheck.Key) == 0)
            {
                numberTranslatedToFBB += digitToCheck.Value;
            }
        }

        if (numberTranslatedToFBB == "")
        {
            numberTranslatedToFBB = numberToTranslate.ToString();
        }
        return numberTranslatedToFBB;
    }

    public static Dictionary<string, string> FunPhrases = new Dictionary<string, string>()
     {
        {"3","Fizz"},
        {"5","Buzz" },
        {"7","Bang"}//,
        //{"9","Clink"} 
     };
}

