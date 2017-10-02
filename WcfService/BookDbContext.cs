using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WcfService
{
  
    public class BookDbContext : DbContext
    {
        public BookDbContext()
            : base("BookDbContext")
        { }

        public DbSet<Book> books { get; set; }
        public DbSet<Author> authors { get; set; }
    }
}