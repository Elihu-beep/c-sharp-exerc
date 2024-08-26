using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T33_Delegate
{
    class Program
    {
        delegate string StringOperation(string input);

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string inputString = Console.ReadLine();

            StringOperation stringOperation = null;

            stringOperation += ConvertToUpper;
            stringOperation += ConvertToLower;
            stringOperation += ConvertToTitleCase;
            stringOperation += ReverseString;

            Console.WriteLine("Choose operations to perform, separate by comma for multiple options:");
            Console.WriteLine("1. Convert to uppercase");
            Console.WriteLine("2. Convert to lowercase");
            Console.WriteLine("3. Convert to title case");
            Console.WriteLine("4. Reverse the string");
            string[] choices = Console.ReadLine().Split(',');

            foreach (string choice in choices)
            {
                switch (choice.Trim())
                {
                    case "1":
                        StringOperation StringDelegate = ConvertToUpper;
                        Console.WriteLine($"Uppercase: {StringDelegate.Invoke(inputString)}");
                        break;
                    case "2":
                        StringDelegate = ConvertToLower;
                        Console.WriteLine($"Lowercase: {StringDelegate.Invoke(inputString)}");
                        break;
                    case "3":
                        StringDelegate = ConvertToTitleCase;
                        Console.WriteLine($"Title Case: {StringDelegate.Invoke(inputString)}");
                        break;
                    case "4":
                        StringDelegate = ReverseString;
                        Console.WriteLine($"Reversed: {StringDelegate.Invoke(inputString)}");
                        break;
                    default:
                        Console.WriteLine($"Invalid choice: {choice}");
                        break;
                }
            }
        }

        static string ConvertToUpper(string input)
        {
            return input.ToUpper();
        }

        static string ConvertToLower(string input)
        {
            return input.ToLower();
        }

        static string ConvertToTitleCase(string input)
        {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());
        }
        static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
