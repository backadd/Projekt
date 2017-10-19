using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class BookCopy
    {
        [ForeignKey("BookRef")]
        public Book theBook { get; set; }
        [Key]
        public int Id { get; set; }

        public BookCopy(Book book)
        {
            theBook = book;
            Id = new int();
        }
    }
}
