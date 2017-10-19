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
        [ForeignKey("Id")]
        public Book TheBook { get; set; }
        [Key]
        public int Id { get; set; }

        public BookCopy(Book book)
        {
            TheBook = book;
            Id = new int();
        }
    }
}
