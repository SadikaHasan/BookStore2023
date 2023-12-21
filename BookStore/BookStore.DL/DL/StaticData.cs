using BookStore.Models.models;
using System.Reflection;

namespace BookStore.DL.DL
{
    public class StaticData
    {
        public static List<Book> Books = new List<Book>()
        {
            new Book()
            {
                Id = 1,
                Title = "1 Book",
            },
            new Book()
            {
                Id = 2,
                Title = "2 Book",
            },
            new Book()
            {
                Id = 3,
                Title = "3 Book",
            },

        };
        public static List<Author> Authors = new List<Author>()
        {
            new Author()
            {
                Id = 1,
                Name = "1 Author",
            },
            new Author()
            {
                Id = 2,
                Name = "2 Author",
            },
            new Author()
            {
                Id = 3,
                Name = "3 Book",
            },

        };
    }
}
