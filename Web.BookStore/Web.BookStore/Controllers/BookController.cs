using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.BookStore.Controllers
{
    public class BookController : Controller
    {
        // book/getAllBook
        public string GetAllBook()
        {
            return "Get All Book !";
        }
        // book/getbook/5
        public string GetBook(int id)
        {
            return $"Book with id={id}";
        }
        //searchbook?bookName=Algo&author=Mohammad
        public string SearchBook(string bookName , string author)
        {
            return $"Book with Book name = {bookName} & Autor={author} ";
        }
    }
}
