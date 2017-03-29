using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            //User decides if they want to roll dice or not.
            Console.WriteLine("Welcome to the Grand Circus Casino! Roll the dice? (y/n):");
            
            bool run = false;
            run = Continue();

            //Track number of times dice have been rolled
            int numRolls = 1;

            //User wants to roll the dice
            while (run)
            {
                Console.WriteLine("Enter number of sides on each of the pair of dice:");
                int dieSides = GetDiceSides();

                //Roll dice
                Console.WriteLine("Roll " + numRolls + ":");
                RollDice(dieSides);
                numRolls++;

                //User decides if they want to roll again or leave.
                Console.WriteLine("Roll again? (y/n):");
                run = Continue();
            }
        }

        //Get and verify number of sides for dice. Is it at least 4 sides, and is it an even number?
        public static int GetDiceSides()
        {
            int input = int.Parse(Console.ReadLine());
            while (input < 4 || input % 2 != 0)
            {
                Console.WriteLine("Number of sides must be an even number 4 or greater. Try again:");
                input = int.Parse(Console.ReadLine());
            }
            return input;
        }

        //Roll dice and display results
        public static void RollDice(int dieSides)
        {
            Random randomNum = new Random();
            
            Console.WriteLine(randomNum.Next(1, (dieSides + 1)));
            Console.WriteLine(randomNum.Next(1, (dieSides + 1)));
        }

        //Continue program?
        public static bool Continue()
        {
            string input = Console.ReadLine().ToLower();
            bool run = false;

            if (input == "n")
            {
                Console.WriteLine("Cash out!");
                run = false;
            }
            else if (input == "y")
            {
                run = true;
            }
            else
            {
                Console.WriteLine("Invalid input! Please type y/n:");
                run = Continue();
            }

            return run;
        }
    }
}
