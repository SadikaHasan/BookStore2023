using BookStore.Models.models;

namespace BookStore.DL.Interfaces
{
    public interface IAuthorRepository
    {
        public void AddAuthor(Author author);


        public void RemoveAuthor(Author author);


        public void UpdateAuthor(Author author);


        public Author GetAuthor(int id);


        public List<Author> GetAllAuthors();
    }
}
