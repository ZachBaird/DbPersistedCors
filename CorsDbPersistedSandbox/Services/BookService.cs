using CorsDbPersistedSandbox.Models;
using System.Collections.Generic;
using System.Linq;

namespace CorsDbPersistedSandbox.Services
{
    public sealed class BookService
    {
        private readonly WhitelistContext _ctx;

        public BookService(WhitelistContext ctx)
        {
            _ctx = ctx;
        }

        public Book GetBook(int id)
        {
            return _ctx.Books.FirstOrDefault(b => b.Id == id);
        }

        public List<Book> GetBooks()
        {
            return _ctx.Books.ToList();
        }

        public void CreateBook(Book newBook)
        {
            _ctx.Books.Add(newBook);
            _ctx.SaveChanges();
        }
    }
}
