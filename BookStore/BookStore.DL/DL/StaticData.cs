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
                AuthorId=1,
                ReleaseDate=new DateTime(year:2005, month:05, day:07)
            },
            new Book()
            {
                Id = 2,
                Title = "2 Book",
                AuthorId=1,
                ReleaseDate=new DateTime(year:2007, month:06, day:17)
            },
            new Book()
            {
                Id = 3,
                Title = "3 Book",
                AuthorId=1,
                ReleaseDate=new DateTime(year:2009, month:10, day:27)
            },
            new Book()
            {
                Id = 4,
                Title = "4 Book",
                AuthorId=1,
                ReleaseDate=new DateTime(year:2015, month:01, day:07)
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
