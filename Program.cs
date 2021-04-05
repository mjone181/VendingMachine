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
            //Start of the outermost loop. User will end up back here after every choice everntually. Asks the User if they would like to continue using the Application.
            Console.WriteLine("Would you like to continue? Y/N");
            //Takes User's keystroke and stores it in a variable.
            string userInput = Console.ReadLine();
            //if userInput is y or Y
            //Continue the program.
            //if userInput is n or N
            //Terminate the program by changing loop variable to False.

            //Start of the inner While loop.
            //userInput is updated to take the User's choice to be used in the Switch statement.
            Console.WriteLine("Which Product would you like to Purchase?");
            Console.WriteLine("The Options include: " +
                "1.) Coke " +
                "2.) Diet Coke  " +
                "3.) Sprite" +
                "4.) Sprite Zero" +
                "5.) Dr. Pepper" +
                "6.) Diet Dr. Pepper");
            Console.WriteLine("Please press the corresponding Number of the Product you would like to purchase.");
            userInput = Console.ReadLine();

            //Converts userInput into a number variable to be used in the Switch statement.
            int userNumber = Convert.ToInt32(userInput);

            //Main Switch statement that makes up the spine of the Application. Activates a different section of the loop based on which key the User pressed.
            switch (userNumber)
            {
                case 1:
                    Console.WriteLine("Coke, is this your choice? Y/N");
                    //if n/N, send User back to inner loop.
                    //if y/Y, end inner loop with a message.
                    Console.WriteLine("Thank you for your purchase! Come again!");
                    break;
                case 2:
                    Console.WriteLine("Diet Coke, is this your choice? Y/N");
                    //if n/N, send User back to inner loop.
                    //if y/Y, end inner loop with a message.
                    Console.WriteLine("Thank you for your purchase! Come again!");
                    break;
                case 3:
                    Console.WriteLine("Sprite, is this your choice? Y/N");
                    //if n/N, send User back to inner loop.
                    //if y/Y, end inner loop with a message.
                    Console.WriteLine("Thank you for your purchase! Come again!");
                    break;
                case 4:
                    Console.WriteLine("Sprite Zero, is this your choice? Y/N");
                    //if n/N, send User back to inner loop.
                    //if y/Y, end inner loop with a message.
                    Console.WriteLine("Thank you for your purchase! Come again!");
                    break;
                case 5:
                    Console.WriteLine("Dr. Pepper, is this your choice? Y/N");
                    //if n/N, send User back to inner loop.
                    //if y/Y, end inner loop with a message.
                    Console.WriteLine("Thank you for your purchase! Come again!");
                    break;
                case 6:
                    Console.WriteLine("Diet Dr. Pepper, is this your choice? Y/N");
                    //if n/N, send User back to inner loop.
                    //if y/Y, end inner loop with a message.
                    Console.WriteLine("Thank you for your purchase! Come again!");
                    break;
                default:
                    //Send User back to start of inner loop with a message.
                    Console.WriteLine("Please enter a Number corresponding to a Product.");                    
                    break;
            }//end switch
        }
    }//end class
}//end namespace
