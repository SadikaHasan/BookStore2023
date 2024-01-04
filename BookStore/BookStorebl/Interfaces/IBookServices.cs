using BookStore.Models.models;
using System.Reflection.Metadata.Ecma335;

namespace BookStorebl.Interfaces
{
    public interface IBookServices
    {
        public void AddBook(Book book);


        public void RemoveBook(Book book);


        public void UpdateBook(Book book);


        public Book GetBook(int id);


        public List<Book> GetAllBooks();

        public List<Book> GetAllBooksByAuthor(int authorId, DateTime afterDate);
        
    }
}
