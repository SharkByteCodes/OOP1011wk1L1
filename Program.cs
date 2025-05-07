namespace _1011OOP_Wk1Class1;

class Program
{
/*   Methods
   Step 6 (optional) - Methods:
   Change the program to use at least one method.
*/
    public static void Main(string[] args)
    {
        //loopYear(); // TODO: what is this mess? I have 10 warnings..
        guessingGame();
        

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

    static string guessingGame()
    {
        /*
         * Exercise 2 - Guessing Game
           
           Generate a random number between 1 and 100.
           Ask the user to guess the secret random number.
           Tell the user if their guess was correct, too low, or too high.
           As long as they don't guess the correct number, keep doing this.
           When they guess the right number, tell them how many guesses it took!
         */
        
        // Generate a random number
        int randomNumber = new Random().Next(1, 100);
        int userGuessNumber = 0; // start with zero, no magic numbers
        
        Console.WriteLine("(debug): The random number is: " + randomNumber); // for debug
        
        //Prompt user for random number.
        Console.WriteLine("Please guess a number between 1 and 100.");
        userGuessNumber = int.Parse(Console.ReadLine());

        while (userGuessNumber < 1 || userGuessNumber > 10)
        {
            if (userGuessNumber != randomNumber) // user guess doesnt match random number
            {
                // Prompt user for new number
                Console.WriteLine("Your guess is not in range between 1 and 100.\n" +
                                  "Please try again: ");
                userGuessNumber = int.Parse(Console.ReadLine());
            }

            if (userGuessNumber == randomNumber) // user guess matches random number
            {
                    Console.WriteLine("Hooray!! You guessed it!!");
                    break;
            }
                
        }
        
            
        
        
        
        return null; //TODO: same as above..
    }
    
}

