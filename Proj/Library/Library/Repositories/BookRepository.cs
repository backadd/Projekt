using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories {
    public class BookRepository : IRepository<Book, int> {
        LibraryContext _context;

        public BookRepository(LibraryContext ctx) {
            _context = ctx;
        }

        public void Add(Book item)
        {
            _context.Books.Add(item);
        }

        public IEnumerable<Book> All() {
            return _context.Books.ToList();
        }

        public void Edit(Book item)
        {
            Book BookToDelete = Find(item.Id);
            Remove(BookToDelete);
            Add(item);
        }

        public Book Find(int id)
        {
            return _context.Books.Single(b => b.Id == id);
        }

        public void Remove(Book item)
        {
            _context.Books.Remove(item);
        }
    }
}