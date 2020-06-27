using coreWebApi1.Interfaces;
using coreWebApi1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreWebApi1.Data
{
    public class BookRepository:IBookRepository
    {
        List<Book> books = new List<Book>()
        {
            new Book(){id=1,Title="Mystery and Magic"},
            new Book(){id=2,Title="The Alchemist"},
            new Book(){id=3,Title="The Witcher"}
        };


        public IEnumerable<Book> GetBook()
        {
            return books.ToArray();
        }
    }
}
