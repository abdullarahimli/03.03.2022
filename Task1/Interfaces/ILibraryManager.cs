using System;
using System.Collections.Generic;
using System.Text;
using Task1.Models;

namespace Task1
{
    interface ILibraryManager
    {
        public List<Book> Books { get; }

        void Add(string name, string authorName, int pageCount);
        void ShowInfo(string name);
        void FilterBooks(string search);
        void Search(string name);

    }
}
