namespace _1011OOP_Wk1Class1;

class Program
{
/*   Methods
   Step 6 (optional) - Methods:
   Change the program to use at least one method.
*/
    public static void Main(string[] args)
    {
        loopYear(); // TODO: what is this mess? I have 10 warnings..


    }

    static string loopYear()
    {

        // Declare name, user birth year and current year in variables
        // int changed to double for more precision, down the line
        string userName = ""; // empty string, not null (I think).
        double userBirthYear = 0; // non-magical number.
        double currentYear = 0; // non-magical number.
        double leapYear = 4; // used for checking if year is divisable by 4 (leap year).

        // Prompt user for username
        Console.WriteLine("What's your name?");
        userName = Console.ReadLine(); // collect user input: name
        Console.WriteLine("What's your birth year?");
        userBirthYear = double.Parse(Console.ReadLine()); // collect user birth year

        // Prompt user for year
        Console.WriteLine("What's the current year?");
        currentYear = double.Parse(Console.ReadLine()); // Parse user input (string) int.

        // print to console for a while
        for (int i = Convert.ToInt16(userBirthYear); i <= currentYear; i++) // convert to int 16 is sloppy but works
        {
            Console.Write("Happy New Year " + userName + ", " + i + "!!");
            if (DateTime.IsLeapYear(i))
            {
                Console.Write(" leap year, yay!");
            }

            // set a new line
            Console.WriteLine(""); //also sloppy, but works.

        }

        return null; // TODO: learn why this is is a bad idea.
    }
   
}

