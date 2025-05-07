namespace _1011OOP_Wk1Class1;

class Program
{
/*    Getting batter at comments..
 
   Step 3 - User input:
   Change the program so that both the name and year are collected through user-input (don't forget your prompts).
*/
    static void Main(string[] args)
    {
        
        // Declare name and current year in variables
        string userName = ""; // empty string, not null (I think).
        int currentYear = 0; // non-magical number.
        
        // Prompt user for username
        Console.WriteLine("What's your name?");
        userName = Console.ReadLine(); // collect user input
        
        // Prompt user for year
        Console.WriteLine("What's the current year?");
        currentYear = int.Parse(Console.ReadLine()); // Parse user input (string) int.
        
        
        Console.WriteLine("Happy New Year " + userName + ", " + currentYear + "!!");
    }
}