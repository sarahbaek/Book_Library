using System;

namespace Book_Library
{
    public class Book
    {
        /// <summary>
        /// The title of the book
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// The Author of the book
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// The number of Pages in the book
        /// </summary>
        public int  PageNumber { get; set; }
        /// <summary>
        /// The unique identifier of the book book
        /// </summary>
        public string ISBN13 { get; set; }

        public Book()
        {

        }

        public Book(string title, string author, int pageNumber, string isbn13)
        {
            Title = title;
            Author = author;
            PageNumber = pageNumber;
            ISBN13 = isbn13;
        }
    }
}
