using System;
namespace ReadingLogPractice
{
	public class BookManager
	{
		
		public List<BookInfo> books = new List<BookInfo>();


        //creates object of the book info class and parses it in these 2 functions
        public void AddReadingEntry()
        {
            Console.WriteLine("Enter the book's title");
            string title = Console.ReadLine();

            Console.WriteLine("Enter the book's author");
            string author = Console.ReadLine();
        
            Console.WriteLine("Enter the number of pages read");
            if (int.TryParse(Console.ReadLine(), out int pagesRead))
        {
            BookInfo entry = new BookInfo(title, author, pagesRead);

            books.Add(entry);

            Console.WriteLine("Reading entry added successfully.");
        }
            else
            {
                Console.WriteLine("Please select a number value for pages read entered");
            }


        }

        //displays the items inside the bookinfo list
        public void ViewEntries()
        {
            Console.WriteLine("Reading Log");
            foreach(var book in books)
            {
                Console.WriteLine($"Author:{book.Author}, Title:{book.Title}, Pages read:{book.PagesRead}");
            }
            Console.WriteLine();
        }
    }
}

