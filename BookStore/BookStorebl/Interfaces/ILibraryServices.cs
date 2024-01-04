using BookStore.BookStore.Models.request;
using BookStore.BookStore.Models.response;
using BookStore.Models.models;

namespace BookStore.BookStorebl.Interfaces
{
    public interface ILibraryServices
    {
        public SellAllBooksByAuthotResponse GetAllBooksByAuthor(SellAllBooksByAuthotRequest request);
    }
}
