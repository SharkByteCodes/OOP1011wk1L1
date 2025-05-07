namespace _1011OOP_Wk1Class1;

class Program
{
/*   Leap years. I never understood modern calendars, or ancient ones..
   Step 5 - If-statements:
   Change the program so that leap-years are somehow highlighted!!!
   
   Happy New Year Aaron, 1976!! (leap year, yay!)
   Happy New Year Aaron, 1977!!
   Happy New Year Aaron, 1978!!
   ...
   Happy New Year Aaron, 2021!! 
   Happy New Year Aaron, 2022!!
   Happy New Year Aaron, 2023!!
   Happy New Year Aaron, 2024!! (leap year, yay!)
*/
    static void Main(string[] args)
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

        for (int i = Convert.ToInt16(userBirthYear); i <= currentYear; i++) // convert to int 16 is sloppy but works
        {
            Console.Write("Happy New Year " + userName + ", " + i + "!!");
            if (DateTime.IsLeapYear(i))
            {
                Console.Write(" leap year, yay!");
            }
            Console.WriteLine(""); //also sloppy, but works.

        }
    }
}