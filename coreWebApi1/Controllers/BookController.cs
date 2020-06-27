using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coreWebApi1.Data;
using coreWebApi1.Interfaces;
using coreWebApi1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace coreWebApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository bookRepo=new BookRepository();

        //public BookController(IBookRepository bookRepo)
        //{
        //    this.bookRepo = bookRepo;
        //}
        [HttpGet]
        public string GetAllBooks()
        {
            return "bijat";
        }
    }
}