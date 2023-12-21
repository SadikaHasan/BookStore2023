using BookStore.Models.models;
using System.Reflection;

namespace BookStore.DL.DL
{
    internal class StaticData
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
    }
}
