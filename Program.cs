namespace _1011OOP_Wk1Class1;

class Program
{
/*    Getting batter at comments.. << batter???
   Step 4 - Loops:
   Change the program so that it prints "Happy New Year (yourname), (the year)!!" from the year you were born until the year the user entered. Something like this:
   
  ... clipped ...
*/
    static void Main(string[] args)
    {
        
        // Declare name, user birth year and current year in variables
        // int changed to double for more precision, down the line
        string userName = ""; // empty string, not null (I think).
        double userBirthYear = 0; // non-magical number.
        double currentYear = 0; // non-magical number.
        
        // Prompt user for username
        Console.WriteLine("What's your name?");
        userName = Console.ReadLine(); // collect user input: name
        Console.WriteLine("What's your birth year?");
        userBirthYear = double.Parse(Console.ReadLine()); // collect user birth year
        
        // Prompt user for year
        Console.WriteLine("What's the current year?");
        currentYear = double.Parse(Console.ReadLine()); // Parse user input (string) int.

        for (double i = userBirthYear; i <= currentYear; i++)
        {
            Console.WriteLine("Happy New Year " + userName + ", " + currentYear + "!!");
        }
    }
}