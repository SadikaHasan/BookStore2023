﻿using BookStore.Models.models;

namespace BookStore.DL.Interfaces
{
    public interface IBookRepository
    {
        public void AddBook(Book book);


        public void RemoveBook(Book book);


        public void UpdateBook(Book book);


        public Book GetBook(int id);


        public List<Book> GetAllBooks();
    }
}
