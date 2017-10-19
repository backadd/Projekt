using Library.Models;
using Library.Repositories;
using Library.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library {
    public partial class LibraryForm : Form {

        BookService _bookService;

        public LibraryForm() {
            InitializeComponent();
            
            RepositoryFactory repoFactory = new RepositoryFactory();

            _bookService = new BookService(repoFactory);

            ListAllBooks();
        }

        private void ListAllBooks() {
            foreach (Book book in _bookService.All()) {
                lbBooks.Items.Add(book);
            }
        }
    }
}
