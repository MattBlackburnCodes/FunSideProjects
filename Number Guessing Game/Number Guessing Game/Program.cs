using System;

namespace Number_Guessing_Game
{
    class Program
    {
        
        static void Game()
        {
            Random r = new Random();

            int winNum = r.Next(0, 100);
            bool win = false;

            do
            {
                Console.Write("Guess a number inbetween 0 and 100: ");
                string num = Console.ReadLine();
                int i = int.Parse(num);
                                       
                
                if (i < 0 || i > 100)
                {
                    Console.WriteLine("Number selected is invalid. Please insert a number inbetween 0 and 100");
                }
                else
                {
                    if (i > winNum)
                    {
                        Console.WriteLine("To high. Guess lower...");
                    }
                    else if (i < winNum)
                    {
                        Console.WriteLine("To low. Guess higher...");
                    }
                    else if (i == winNum)
                    {
                        Console.WriteLine("You Win!");
                        win = true;
                        Choice();
                    }
                }


                

                Console.WriteLine();

            } while (win == false);
        }

        static void Choice()
        {
            
            Console.WriteLine("Would you like to play again? (y/n): ");
            string choice = "";

            do
            {
                choice = Console.ReadLine();


                switch (choice)
                {
                    case "y":
                        Game();
                        break;
                    case "n":
                        Console.WriteLine("Thank you for playing the game!");
                        Console.WriteLine("Press any key to finish.");
                        Console.ReadKey(true);
                        
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        Console.WriteLine("Would you like to play again? (y/n): ");
                        choice = "x";
                        
                        break;


                }

            } while (choice == "x");

            
        }
        static void Main(string[] args)
        {
            
            Game();

            

            



        }
    }
}

// Different methods of doing loops I was trying out to see which I like better.
/*Console.WriteLine("Would you like to play again? (y/n)");
            //string choice = Console.ReadLine();
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Console.WriteLine("");
                Game();
            }
            else if (Console.ReadKey().Key == ConsoleKey.N)
            {
                Console.WriteLine("Thank you for playing!");
                
            }
            else
            {
                Console.WriteLine("Invalid input.");
                Console.WriteLine("Would you like to play again?");
            }*/



/*do
{


    if (choice == "y")
    {

        Game();        

    }
    else if (choice == "n")
    {
        Console.WriteLine("Thank you for playing the game!");
        Console.WriteLine("Press any key to finish.");
        Console.ReadKey(true);
        break;
    }
    else
    {
        Console.WriteLine("Invalid option.");
        Console.WriteLine("Try again");
        choice = Console.ReadLine();
    }
} while (choice != "n");*/
