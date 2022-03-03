using System;
using System.Collections.Generic;
using System.Text;
using Task1.Models;

namespace Task1
{
    class LibraryManager : ILibraryManager
    {
        public List<Book> Books;
        private object book;

        public LibraryManager()
        {
            Books = new List<Book>();
        }

        List<Book> ILibraryManager.Books => throw new NotImplementedException();

        public void Add(string name, string authorName, int pageCount)
        {
            Book book = new Book(name, authorName, pageCount);
            Books.Add(book);
            if (book.Name == name)
            {
                throw new Book("Kitab tapilmadi", new Book("book"));
            }
        }

        public List<Book> FilterBooks(string search)
        {
            return Books.FindAll(b => b.Name.ToLower().Contains(search.Trim().ToLower()) ||
            b.PageCount.ToString().Contains(search.Trim().ToLower()) ||
            b.Genre.ToLower().Contains(search.Trim().ToLower()));
        }

        public List<Book> Search(string name)
        {
            return Books.FindAll(book => book.Name.Contains(name));
        }

        public List<Book> ShowInfo(string name)
        {
            Book book = new Book(name);
            return Books.FindAll(book => book.Name.Contains(name));
            if (book.Name != name)
            {
                throw new Book("BookNotFoundException ", new Book("book"));
            }
        }





        public List<Book> Filter(string name)
        {
            return Books.FindAll(book => book.Name.Contains(name));

        }

        void ILibraryManager.ShowInfo(string name)
        {
            throw new NotImplementedException();
        }

        void ILibraryManager.FilterBooks(string search)
        {
            throw new NotImplementedException();
        }

        void ILibraryManager.Search(string name)
        {
            throw new NotImplementedException();
        }
    }
}
