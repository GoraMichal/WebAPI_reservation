using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using WebAPI_reservation.Models;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;
using HttpPutAttribute = System.Web.Http.HttpPutAttribute;

namespace WebAPI_reservation.Controllers
{
    public class WebController : ApiController
    {
        private BookRepository repository = BookRepository.Current;

        public IEnumerable<Book> GetAllBook()
        {
            return repository.GetAll();
        }

        public Book GetBook(int id)
        {
            return repository.Get(id);
        }

        [HttpPost]
        public Book CreateBook(Book addBook)
        {
            return repository.Add(addBook);
        }

        [HttpPut]
        public bool UpdateBook(Book upBook)
        {
            return repository.Update(upBook);
        }

        public void DeleteBook(int id)
        {
            repository.Remove(id);
        }
    }
}