using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.BookStore.Models;
using Web.BookStore.Repository;

namespace Web.BookStore.Controllers
{
    public class BookController : Controller
    {

        private readonly BookRepository _BookRepository = null;

        public BookController()
        {
            _BookRepository = new BookRepository();
        }
        
        // book/getAllBook
        public List<BookModel> GetAllBook()
        {
            return _BookRepository.GetAllBook();
        }
        // book/getbook/5
        public BookModel GetBook(int id)
        {
            return _BookRepository.GetBookById(id);
        }
        //searchbook?bookName=Algo&author=Mohammad
        public List<BookModel> SearchBook(string bookName , string author)
        {
            return _BookRepository.SearchBook(bookName, author);
        }


    }
}
