using System;

// Daniel Svenssson .(dot)NET22

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Declaring Variables for use in this program, (normally you want dedicated classes and or constructors/containers for the clarity it provides*)
            But considering this is just a small "starter" get you feet wet in programming assignment, 
            then it's not really needed and would add extra bloat to the entire thing

            ^* unless it's global spanning variables or used directly in "Main"

            */
            int myNumber = 15;  //simple variable to hold the number 15 ( or whatever number is used in the decleration)


            //below this is a commented out User input for the number instead with no error handeling
            /*
            Console.WriteLine("Välj ditt nummer"); 
            int myNumber = Convert.ToInt32(Console.ReadLine());
            */

            string userInputName = "";  // variable to save User's Name
            int countingNumberMcCounty = 0; // a Counting variable for the while loop that's dynamic to stop at users number if input is active for it.

            if (myNumber > 10) //if the number is equal or below 10 execute the block below
            { 
                Console.WriteLine("Talet är stort!");
            }
            else // if the number is Greater than 10, then do this instead 
            {
                Console.WriteLine("Oj, Lågt tal!");
            }

            Console.WriteLine("Vad heter du?");  // prints the line to the console window

            userInputName = Console.ReadLine(); // get's the users input and saves it

            Console.WriteLine("Hej på dig " + userInputName); // outputs a greeting message and the saved input


            while (countingNumberMcCounty != myNumber + 1)  
                /* a basic "Do this While This is correct, I:E keep looping until it's no longer True. in this case keep counting up and printing it to console until myNumber then stop
                    i personally belive this is a simpler option than doing a "For" loop for this, and it shaves off some bulk in the code, 
                    and it can also be expanded upon with the number being User input
                 */
            {
                Console.WriteLine(countingNumberMcCounty);
                countingNumberMcCounty++;
            }
        }
    }
}
