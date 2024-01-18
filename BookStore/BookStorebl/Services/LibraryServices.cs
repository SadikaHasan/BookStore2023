﻿using BookStore.BookStore.Models.request;
using BookStore.BookStore.Models.response;
using BookStore.BookStorebl.Interfaces;
using BookStorebl.Interfaces;

namespace BookStore.BookStorebl.Services
{
    public class LibraryServices : ILibraryServices
    {
        private readonly IAuthorServices _authorServices;
        private readonly IBookServices _bookServices;
        public LibraryServices(IAuthorServices authorServices, IBookServices bookServices)
        {
            _authorServices = authorServices;
            _bookServices = bookServices;
        }

        public int CheckBookCount(int input)
        {
            if (input < 0) return 0;

            var result = _bookServices.GetAllBooks();

            return result.Count + input;
        }

        public SellAllBooksByAuthotResponse GetAllBooksByAuthor(SellAllBooksByAuthotRequest request)
        {
            return new SellAllBooksByAuthotResponse
            {
                Author = _authorServices.GetAuthor(request.authorId),
                Books = _bookServices.GetAllBooksByAuthor(request.authorId, request.ReleaseDate)
            };
        }
    }
}
