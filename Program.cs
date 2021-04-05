using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduction message welcoming User to the Application.
            Console.WriteLine("Hello! Welcome to my Vending Machine Program, written in C#!");

            //While Loop goes here.
            //Start of the loop. User will end up back here after every choice everntually. Asks the User if they would like to continue using the Application.
            Console.WriteLine("Would you like to continue? Y/N");
            //Takes User's keystroke and stores it in a variable.
            string userInput = Console.ReadLine();
            //if userInput is y or Y
                //Continue the program.
            //if userInput is n or N
                //Terminate the program by changing loop variable to False.
            
            //userInput is updated to take the User's choice to be used in the Switch statement.
            userInput = Console.ReadLine();

            //Main Switch statement that makes up the spine of the Application. Activates a different section of the loop based on which key the User pressed.
            switch (userInput)
            {
                default:
                    break;
            }
        }
    }
}
