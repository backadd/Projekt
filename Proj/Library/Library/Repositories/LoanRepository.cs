using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repositories
{
    public class LoanRepository : IRepository<Loan, int>
    {
        LibraryContext _context;

        public LoanRepository(LibraryContext ctx)
        {
            _context = ctx;
        }

        public void Add(Loan item)
        {
            _context.Loans.Add(item);
        }

        public IEnumerable<Loan> All()
        {
            return _context.Loans.ToList();
        }

        public void Edit(Loan item)
        {
            Loan LoanToDelete = Find(item.Id);
            Remove(LoanToDelete);
            Add(item);
        }

        public Loan Find(int id)
        {
            return _context.Loans.Single(b => b.Id == id);
        }

        public void Remove(Loan item)
        {
            _context.Loans.Remove(item);
        }
    }
}
