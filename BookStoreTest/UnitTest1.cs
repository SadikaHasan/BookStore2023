using BookStore.BookStorebl.Services;
using BookStore.DL.Interfaces;
using BookStore.DL.Repository;
using BookStore.Models.models;
using BookStorebl.Interfaces;
using BookStorebl.Services;
using Moq;

namespace BookStoreTest
{
    public class UnitTest1
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
        [Fact]
        public void CheckBookCount_OK()
        {
            //setup
            var input = 10;
            var expectedCount = 14;

            var mockedBookRepository = new Mock<IBookRepository> ();
            mockedBookRepository.Setup(x => x.GetAllBooks())
            .Returns(Books);

            var bookService =
                new BookService(mockedBookRepository.Object);
            var authorService = new AuthorServise(new AuthorRepository());
            var service = new LibraryServices(authorService, bookService);

            var result = service.CheckBookCount(input);

            Assert.Equal(expectedCount, result);
        }

        [Fact]
        public void CheckBookCount_Negative()
        {
            //setup
            var input = -10;
            var expectedCount = 0;

            var mockedBookRepository = new Mock<IBookRepository>();
            mockedBookRepository.Setup(x => x.GetAllBooks())
            .Returns(Books);

            var bookService =
                new BookService(mockedBookRepository.Object);
            var authorService = new AuthorServise(new AuthorRepository());

            var service = new LibraryServices(authorService, bookService);

            var result = service.CheckBookCount(input);

            Assert.Equal(expectedCount, result);
        }

        [Fact]
        public void GetAllBooksByAuthor_OK()
        {
            //setup
            var input = new GetAllBooksByAuthorRequest
            var expectedCount = 14;

            var mockedBookRepository = new Mock<IBookRepository>();
            mockedBookRepository.Setup(x => x.GetAllByAuthor())
            .Returns(Books);

            var bookService =
                new BookService(mockedBookRepository.Object);
            var authorService = new AuthorServise(new AuthorRepository());
            var service = new LibraryServices(authorService, bookService);

            var result = service.CheckBookCount(input);

            Assert.Equal(expectedCount, result);
        }

        [Fact]
        public void CheckBookCount_Negative()
        {
            //setup
            var input = -10;
            var expectedCount = 0;

            var mockedBookRepository = new Mock<IBookRepository>();
            mockedBookRepository.Setup(x => x.GetAllBooks())
            .Returns(Books);

            var bookService =
                new BookService(mockedBookRepository.Object);
            var authorService = new AuthorServise(new AuthorRepository());

            var service = new LibraryServices(authorService, bookService);

            var result = service.CheckBookCount(input);

            Assert.Equal(expectedCount, result);
        }
    }
}