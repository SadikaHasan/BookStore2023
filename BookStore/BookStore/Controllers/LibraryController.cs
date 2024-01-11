using BookStore.BookStore.Models.request;
using BookStore.BookStore.Models.response;
using BookStore.BookStore.Validator;
using BookStore.BookStorebl.Interfaces;
using BookStore.BookStorebl.Services;
using BookStore.Models.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private readonly ILibraryServices _libraryServices;
        public LibraryController(ILibraryServices libraryServices)
        {
            _libraryServices = libraryServices;
        }
        [HttpPost("GetAllBooksByAuthor")]
        public SellAllBooksByAuthotResponse
            GetAllBooksByAuthor([FromBody] SellAllBooksByAuthotRequest request)
        {
            return _libraryServices
                .GetAllBooksByAuthor(request);

        }
        [HttpPost(template:"SomeEndPoint")]
        public string GetSomeData([FromBody] SomeRequest request)
        {
            return ("1");

        }

    }
}
