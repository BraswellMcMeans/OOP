using System;

namespace FileHandling
{
    public class Menu
    {
        public int MainMenu()
        {
            System.Console.WriteLine("Enter 1 for Search\nEnter 2 for Reports\nEnter 3 to exit");
            string userInput = Console.ReadLine();
            while (userInput != "1" && userInput != "2" && userInput != "3")
            {
                System.Console.WriteLine("Invalid choice.  Please enter a valid option");
                System.Console.WriteLine("Enter 1 for Search\nEnter 2 for Reports\nEnter 3 to exit");
                userInput = Console.ReadLine();
            }

            return int.Parse(userInput);
        }

        public int ReportMenu()
        {
            System.Console.WriteLine("Enter 1 for GPA Report\nEnter 2 for Hours by Year Report");
            System.Console.WriteLine("Enter 3 for Excess Credit Report\n Enter 4 to return");
            string userInput = Console.ReadLine();
            while (userInput != "1" && userInput != "2" && userInput != "3" && userInput != "4")
            {
                System.Console.WriteLine("Invalid choice.  Please enter a valid option");
                System.Console.WriteLine("Enter 1 for GPA Report\nEnter 2 for Hours by Year Report");
                System.Console.WriteLine("Enter 3 for Excess Credit Report\n Enter 4 to return");
                userInput = Console.ReadLine();
            }

            return int.Parse(userInput);
        }
    }
}