using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        public BookController()
        {
            _books = new List<Book>();
        }
        private List<Book> _books;
        public IActionResult Get()
        {
            if(_books.Count!=0)
            {
                return Ok(_books);;
            }

            return NoContent();
        }
        public IActionResult Post(Book book)
        {
            _books.Add(book);
            return Created("",book);
        }
    }

    public class Book
    {
        public int Count { get; set; }
        public string Title { get; set; }
    }
}
