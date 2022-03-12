using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookstore.Models
{
    public class EFBookstoreRepository : IBookstoreRepository
    {
        private BookstoreContext context { get; set; }

        public EFBookstoreRepository(BookstoreContext temp)
        {
            context = temp;
        }

        public IQueryable<Book> Books => context.Books;

        public void SaveBook(Book book)
        {
            context.SaveChanges();
        }

        public void CreateBook(Book book)
        {
            context.Add(book);
            context.SaveChanges();
        }

        public void DeleteBook(Book book)
        {
            context.Remove(book);
            context.SaveChanges();
        }
    }
}
