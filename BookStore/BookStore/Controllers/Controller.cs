using BookStore.DL.Interfaces;
using BookStore.DL.Repository;
using BookStore.Models.models;
using BookStorebl.Interfaces;
using BookStorebl.Services;
using Microsoft.AspNetCore.Http;
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
        public List<Book> GetAll();
        {
    return _bookService.GetAll();        
}
    [HttpGet("GetByAd")]
    public Book GetById(int Id)
    {
        return _bookService.GetById(Id);
    }
    [HttpGet("Add")]
    public void Add(book)
    {
        return _bookService.Add(book);
    }
}
}
