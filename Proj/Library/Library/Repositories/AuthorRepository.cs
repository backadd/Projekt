using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repositories
{
    class AuthorRepository : IRepository<Author, int>
    {
        LibraryContext _context;

        public AuthorRepository(LibraryContext ctx)
        {
            _context = ctx;
        }

        public void Add(Author item)
        {
            _context.Authors.Add(item);
        }

        public IEnumerable<Author> All()
        {
            return _context.Authors.ToList();
        }

        public void Edit(Author item)
        {
            Author AuthorToDelete = Find(item.Id);
            Remove(AuthorToDelete);
            Add(item);
        }

        public Author Find(int id)
        {
            return _context.Authors.Single(b => b.Id == id);
        }

        public void Remove(Author item)
        {
            _context.Authors.Remove(item);
        }
    }
}
