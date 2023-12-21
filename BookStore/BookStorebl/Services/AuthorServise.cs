using BookStore.DL.Interfaces;
using BookStore.DL.Repository;
using BookStore.Models.models;
using BookStorebl.Interfaces;

namespace BookStorebl.Services
{
    public class AuthorServise: IAuthorServices
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorServise(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }
        public void AddAuthor(Author author)
        {
            _authorRepository.GetAllAuthors();
        }

        public List<Author> GetAllAuthors()
        {
            return _authorRepository.GetAllAuthors();
        }

        public Author GetAuthor(int id)
        {
            return _authorRepository.GetAuthor(id);
        }

        public void RemoveAuthor(Author author)
        {
            _authorRepository.RemoveAuthor(author);
        }

        public void UpdateAuthor(Author author)
        {
            _authorRepository.UpdateAuthor(author);
        }
    }
}
