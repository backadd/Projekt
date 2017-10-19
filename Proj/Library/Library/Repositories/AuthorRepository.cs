using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repositories
{
    class AuthorRepository : IRepository<Book, int>
    {
        LibraryContext _context;

        public AuthorRepository(LibraryContext ctx)
        {
            _context = ctx;
        }

        public void Add(Book item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> All()
        {
            throw new NotImplementedException();
        }

        public void Edit(Book item)
        {
            throw new NotImplementedException();
        }

        public Book Find(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Book item)
        {
            throw new NotImplementedException();
        }
    }
}
