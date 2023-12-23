using System;
namespace ReadingLogPractice
{
	public class BookInfo
	{
        public string Title { get; set; }
        public string Author { get; set; }
        public int PagesRead { get; set; }

        public BookInfo(string title, string author, int pagesread)
        {
            Title = title;
            Author = author;
            PagesRead = pagesread;
        }


       
    }
}

