using System.Text.RegularExpressions;
using System.Diagnostics;

namespace lab8;

class Hello {         
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your string: ");

        string str = Console.ReadLine();

        /*
        ^ matches the start of the string (ie no characters are allowed before this point)
        [a-zA-Z0-9] matches any letter from a-z in lower or upper case, as well as digits 0-9
        * lets the previous match repeat zero or more times
        $ matches the end of the string (ie no characters are allowed after this point)
        */
        if( Regex.IsMatch(str, "^[a-zA-Z0-9]*$") )
        {
            Console.WriteLine("string is English");
        }
        else
        {
            Console.WriteLine("string is not English");
        }

        if (Debugger.IsAttached) 
        {
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
        }
    }
}