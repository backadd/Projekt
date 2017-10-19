using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    class LoanService : IService
    {

        LoanRepository _loanRepository;

        public LoanService(RepositoryFactory repoFactory)
        {
            _loanRepository = repoFactory.GetLoanRepository();
        }

        public event EventHandler Updated;

        public IEnumerable<Loan> All()
        {
            return _loanRepository.All();
        }

    }
}
