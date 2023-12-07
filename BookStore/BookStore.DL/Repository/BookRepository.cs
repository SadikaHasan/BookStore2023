using BookStore.DL.DL;
using BookStore.DL.Interfaces;
using BookStore.Models.models;

namespace BookStore.DL.Repository
{
    public class BookRepository : IBookRepository
    {
        public void AddBook(Book book)
        {
            StaticData.Books.Add(book);
        }

        public List<Book> GetAllBooks()
        {
            return StaticData.Books;
        }

        public Book? GetBook(int id)
        {
            return
                StaticData.Books
                .FirstOrDefault(b => b.Id == id);
        }

        public void RemoveBook(Book book)
        {
            if (book == null) return;
            StaticData.Books.Remove(book);
        }

        public void UpdateBook(Book book)
        {
            var existBook =
                StaticData.Books
                .FirstOrDefault(b => b.Id == book.Id);
            if (existBook == null) return;
            existBook.Title = book.Title;
        }
    }
}

