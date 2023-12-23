using System;
using System.Collections.Generic;
using ReadingLogPractice;

class Program
{
   
    static void Main()
    {
        BookManager bookManager = new BookManager();

        //use a while(true) because it creates a infitie loop
        while (true)
        {
            Console.WriteLine("Welcome to the reading log app");
            Console.WriteLine("1: Add an entry");
            Console.WriteLine("2: View entries");
            Console.WriteLine("3: Exit app");
            Console.WriteLine();
            Console.WriteLine("Enter your choice");


            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    bookManager.AddReadingEntry();
                    break;
                case "2":
                    bookManager.ViewEntries();
                    break;
                case "3":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice; please select a number between 1 and 3");
                    Console.WriteLine("");
                    break;
                        
            }



        }

    }
}
