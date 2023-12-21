using BookStore.Models.models;
using BookStorebl.Interfaces;
using BookStorebl.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorServices _authorService;

        public AuthorController(IAuthorServices authorService)
        {
            _authorService = authorService;
        }

        [HttpGet("GetAll")]
        public List<Author> GetAll()
        {
            return _authorService.GetAllAuthors();
        }

        [HttpGet("GetByAd")]
        public Author GetById(int Id)
        {
            return _authorService.GetAuthor(Id);
        }
        [HttpPost("Add")]
        public void Add(Author author)
        {
            _authorService.AddAuthor(author);
        }
        [HttpDelete("Delete")]
        public void Delete(Author author)
        {
            _authorService.RemoveAuthor(author);
        }
    }
}
