using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repositories
{
    class BookCopyRepository : IRepository<BookCopy, int>
    {
        LibraryContext _context;

        public BookCopyRepository(LibraryContext ctx)
        {
            _context = ctx;
        }

        public void Add(BookCopy item)
        {
            _context.BookCopies.Add(item);
        }

        public IEnumerable<BookCopy> All()
        {
            return _context.BookCopies.ToList();
        }

        public void Edit(BookCopy item)
        {
            BookCopy BookCopyToDelete = Find(item.Id);
            Remove(BookCopyToDelete);
            Add(item);
        }

        public BookCopy Find(int id)
        {
            return _context.BookCopies.Single(b => b.Id == id);
        }

        public void Remove(BookCopy item)
        {
            _context.BookCopies.Remove(item);
        }
    }
}
