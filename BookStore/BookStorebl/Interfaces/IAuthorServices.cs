using BookStore.Models.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStorebl.Interfaces
{
    public interface IAuthorServices
    {
        public void AddAuthor(Author author);


        public void RemoveAuthor(Author author);


        public void UpdateAuthor(Author author);


        public Author GetAuthor(int id);


        public List<Author> GetAllAuthors();
    }
}
