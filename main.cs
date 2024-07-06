using System;

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************************************");
            Console.WriteLine("*  The stars shine in Greenville.  *");
            Console.WriteLine("************************************");
            Console.WriteLine();
            DisplayMenu();
        }

        static void DisplayMenu()
        {
            while (true)
            {
                Console.WriteLine("Please Enter the following number below from the following menu:");
                Console.WriteLine("1. CALCULATE Greenville Revenue Year-Over-Year");
                Console.WriteLine("2. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CalculateRevenue();
                        break;
                    case "2":
                        Console.WriteLine("Thank you for using the Greenville Revenue App, good-bye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }

        static void CalculateRevenue()
        {
            Console.WriteLine("Enter the number of contestants from the previous year:");
            int lastYearContestants = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of contestants for the current year:");
            int currentYearContestants = int.Parse(Console.ReadLine());

            int revenue = currentYearContestants * 25;
            bool isBigger = currentYearContestants > lastYearContestants;

            Console.WriteLine($"Last year's competition had {lastYearContestants} contestants, and this year's has {currentYearContestants} contestants");
            Console.WriteLine($"Revenue expected this year is ${revenue}");
            Console.WriteLine($"It is {(isBigger ? "true" : "false")} that this year's competition is bigger than last year's.");
            Console.WriteLine();
            Console.WriteLine("************************************");
            Console.WriteLine("*  The stars shine in Greenville.  *");
            Console.WriteLine("************************************");
            Console.WriteLine();
        }
    }

