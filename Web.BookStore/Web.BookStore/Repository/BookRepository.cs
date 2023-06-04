using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.BookStore.Models;

namespace Web.BookStore.Repository
{
    public class BookRepository
    {
        

        public List<BookModel> GetAllBook()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string Title, string author)
        {
            return DataSource().Where(x => x.Title.Contains(Title) && x.author.Contains(author)).ToList();
        }


        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel() { id = 1, Title = "Algorithm", author = "Mohammad"},
                new BookModel() { id = 2, Title = "Cyber Security", author = "Hasan" },
                new BookModel() { id = 3, Title = "MVC", author = "Mazen" },
                new BookModel() { id = 4, Title = "ASPNETCore", author = "Mohammad" },
            };
        }
    }
}
