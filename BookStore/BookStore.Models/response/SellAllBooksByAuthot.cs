using BookStore.Models.models;

namespace BookStore.BookStore.Models.response
{
    public class SellAllBooksByAuthotResponse
    {
        public Author Author { get; set; }

        public List<Book> Books { get; set; }
    }
}
