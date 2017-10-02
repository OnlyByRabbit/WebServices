using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AuthorService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AuthorService.svc or AuthorService.svc.cs at the Solution Explorer and start debugging.
    public class AuthorService : IAuthorService
    {
        BookDbContext db = new BookDbContext();
        public void addAuthor(Author author)
        {
            db.authors.Add(author);
            db.SaveChanges();
        }

        public void deleteAuthor(int authorID)
        {
             Author author = db.authors.Find(authorID);
              if (author != null)
            {
                db.authors.Remove(author);
                db.SaveChanges();
            }
        }

      
        public List<Author> getAuthorsList()
        {
            return db.authors.ToList();
        }

        public bool isAuthorInDatabase(string name)
        {
            var artist = db.authors.Find(name);

            if (artist != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
