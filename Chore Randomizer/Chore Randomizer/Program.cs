using System;

namespace Chore_Randomizer
{
    class Program
    {
        static void Chores()
        {
            Random r = new Random();
            // List of chores
            string[] chores = {"clean the bathrooms", "clean the counters", "vaccuum the floors",
            "clean the parents bedroom", "clean the kids room", "clean the living room", "clean the laundry room"};

            string randomString = $"{chores[r.Next(0, chores.Length)]}";
            
            Console.WriteLine($"Your task is to {randomString}");
            
            Selection();



        }

        static void Selection()
        {
            
            Console.WriteLine("Would you like another task? (y/n): ");
            //Console.WriteLine("");
            string choice = "";

            do
            {
                choice = Console.ReadLine();


                switch (choice)
                {
                    case "y":
                        Console.WriteLine();
                        Chores();
                        
                        break;
                    case "n":
                        Console.WriteLine();
                        Console.WriteLine("Great! Let's get to work!");
                        //Console.ReadKey(true);
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Invalid input.");
                        Console.WriteLine("Would you like another task? (y/n): ");
                        
                        choice = "x";

                        break;


                }

            } while (choice == "x");
        }

            static void Main(string[] args)
        {
            Chores();
        }
    }
}
