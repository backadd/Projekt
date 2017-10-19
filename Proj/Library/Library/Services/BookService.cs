using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services {
    class BookService
    {
        BookRepository _bookRepository;

        public BookService(RepositoryFactory repoFactory)
        {
            _bookRepository = repoFactory.GetBookRepository();
        }

        public IEnumerable<Book> All()
        {
            return _bookRepository.All();
        } 
    }
}
