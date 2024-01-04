using BookStore.DL.Interfaces;
using BookStore.Models.models;
using BookStorebl.Interfaces;

namespace BookStorebl.Services
{
    public class BookService : IBookServices
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public void AddBook(Book book)
        {
            _bookRepository.GetAllBooks();
        }

        public List<Book> GetAllBooks()
        {
            return _bookRepository.GetAllBooks();
        }

        public Book GetBook(int id)
        {
            return _bookRepository.GetBook(id);
        }

        public void RemoveBook(Book book)
        {
            _bookRepository.RemoveBook(book);
        }

        public void UpdateBook(Book book)
        {
            _bookRepository.UpdateBook(book);
        }
        public List<Book> GetAllBooksByAuthor(int authorId, DateTime afterDate)
        {
        var result = _bookRepository.GetAllBooksByAuthor(authorId);

        return result
            .Where(b => b.ReleaseDate>=afterDate)
            .ToList();
    }
}
}
