using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories {
    public class BookRepository {
        LibraryContext _context;

        public BookRepository(LibraryContext ctx) {
            _context = ctx;
        }

        public IEnumerable<Book> All() {
            return _context.Books.ToList();
        }
    }
}