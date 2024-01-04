namespace BookStore.BookStore.Models.request
{
    public class SellAllBooksByAuthotRequest
    {
        public int authorId { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}
