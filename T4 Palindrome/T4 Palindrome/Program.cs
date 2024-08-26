using System;

class Program
{
    public static void Palindrome()
    {
        Console.WriteLine("Enter a string to check if it a palindrome: ");
        string str = Console.ReadLine();
        char[] cArray = str.ToCharArray();
        Array.Reverse(cArray);
        string revStr = new string(cArray);

        Console.WriteLine(str == revStr ? true : false);
    }
    static void Main()
    {
        Palindrome();
    }

}

