using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BookService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select BookService.svc or BookService.svc.cs at the Solution Explorer and start debugging.
    public class BookService : IBookService
    {
        BookDbContext db = new BookDbContext();
        public void addBook(Book book)
        {
           
                db.books.Add(book);
                db.SaveChanges();
           }

        public void deleteBook(int bookID)
        {
            Book book = db.books.Find(bookID);
            if (book != null)
            {
                db.books.Remove(book);
                db.SaveChanges();
            }
        }

       
        public void Edit(Book book)
        {
            db.Entry(book).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public List<Book> getBooksList()
        {
            return db.books.ToList();
        }
    }
}
