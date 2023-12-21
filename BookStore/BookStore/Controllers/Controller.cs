using BookStore.Models.models;
using BookStorebl.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Controller : ControllerBase
    {
        private readonly IBookServices _bookService;

        public Controller(IBookServices bookService)
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
        [HttpGet("Add")]
        public void Add(Book book)
        {
            _bookService.AddBook(book);
        }
    }
}
