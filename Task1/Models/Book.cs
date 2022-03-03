using System;
using System.Collections.Generic;
using System.Text;

namespace Task1.Models
{
    public class Book : Exception
    {
        private string _authorName;

        public string Name { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }
        public string Genre { get; set; }


        public Book(string message) : base(message)
        {

        }

        public Book(string message, Book studentNotFoundException) : base(message, studentNotFoundException)
        {

        }
        public Book(string name, string authorName, int pageCount, string genre)
        {
            Name = name;
            Author = authorName;
            PageCount = pageCount;
            Genre = genre;
        }

        public Book(string message, string authorName, int pageCount) : this(message)
        {
            this._authorName = authorName;
            PageCount = pageCount;
        }
    }
}
