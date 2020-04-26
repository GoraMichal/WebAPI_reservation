using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI_reservation.Models
{
    public class BookRepository
    {
        private static BookRepository repository = new BookRepository();

        public static BookRepository Current
        {
            get { return repository; }
        }


        private List<Book> data = new List<Book>
    {
        new Book{ BookId = 1, CustomerName = "Andrzej Ciastko", Room="Conference Room 1"},
        new Book{ BookId = 2, CustomerName = "Kamil Udręka", Room="Conference Room 2"},
        new Book{ BookId = 3, CustomerName = "Anna Katorga", Room="Assembly Hall 1"},
        new Book{ BookId = 4, CustomerName = "Katarzyna Lipa", Room="Assembly Hall 2"}
    };

        public IEnumerable<Book> GetAll() { return data; }

        public Book Get(int id)
        {
            return data.Where(b => b.BookId == id).FirstOrDefault();
        }

        public Book Add(Book newBook)
        {
            newBook.BookId = data.Count + 1;
            data.Add(newBook);
            return newBook;
        }

        public bool Update(Book upBook)
        {
            Book currentBook = Get(upBook.BookId);

            if (currentBook != null)
            {
                currentBook.CustomerName = upBook.CustomerName;
                currentBook.Room = upBook.Room;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Remove(int id)
        {
            Book book = Get(id);
            data.Remove(book);
        }
    }
}
