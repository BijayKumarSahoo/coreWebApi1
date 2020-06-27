using coreWebApi1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreWebApi1.Interfaces
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetBook();
            
    }
}
