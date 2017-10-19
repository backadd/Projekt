using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Library.Models {
    public class Book {

        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [ForeignKey("Id")]
        public virtual Author Author { get; set; }
        [Required]
        public string ISBN { get; set; }
        public string Description { get; set; }
        [Required]
        public ICollection<BookCopy> Copies { get; set; }

        //public Book(int id, string title, Author author, string isbn, string description)
        //{
        //    Id = id;
        //    Title = title;
        //    Author = author;
        //    ISBN = isbn;
        //    Description = description;
        //    Copies = new List<BookCopy>();
        //}
        public override string ToString() {
            return String.Format("[{0}] -- {1}", this.Id, this.Title);
        }
    }
}