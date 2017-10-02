using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBookService" in both code and config file together.
    [ServiceContract]
    public interface IBookService
    {
        
        [OperationContract]
        List<Book> getBooksList();

        [OperationContract]
        void addBook(Book book);

        [OperationContract]
        void Edit(Book book);

        [OperationContract]
        void deleteBook(int bookID);
    }
}
