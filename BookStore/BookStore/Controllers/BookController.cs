using BookStore.Models.models;
using BookStorebl.Interfaces;
using BookStorebl.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookServices _bookService;

        public BookController(IBookServices bookService)
        {
            _bookService = bookService;
        }

        [HttpGet("GetAll")]
        public List<Book> GetAll()
        {
            return _bookService.GetAllBooks();
        }

        [HttpGet("GetByAd")]
        public Book GetById(int Id)
        {
            return _bookService.GetBook(Id);
        }
        [HttpPost("Add")]
        public void Add(Book book)
        {
            _bookService.AddBook(book);
        }
        [HttpDelete("Delete")]
        public void Delete(Book book)
        {
            _bookService.RemoveBook(book);
        }
    }
}
