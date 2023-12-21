using BookStore.DL.DL;
using BookStore.DL.Interfaces;
using BookStore.Models.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DL.Repository
{
    public class AuthorRepository: IAuthorRepository
    {
        public void AddAuthor(Author author)
        {
            StaticData.Authors.Add(author);
        }

        public List<Author> GetAllAuthors()
        {
            return StaticData.Authors;
        }

        public Author? GetAuthor(int id)
        {
            return
                StaticData.Authors
                .FirstOrDefault(b => b.Id == id);
        }

        public void RemoveAuthor(Author author)
        {
            if (author == null) return;
            StaticData.Authors.Remove(author);
        }

        public void UpdateAuthor(Author author)
        {
            var existAuthor =
                StaticData.Authors
                .FirstOrDefault(b => b.Id == author.Id);
            if (existAuthor == null) return;
            existAuthor.Name = author.Name;
        }
    }
}
