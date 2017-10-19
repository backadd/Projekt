using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [ForeignKey("AuthorRef")]
        public virtual Author Author { get; set; }
        [Required]
        public string ISBN { get; set; }
        public string Description { get; set; }
        [Required]
        public ICollection<BookCopy> Copies { get; set; }

        public Book(int id, string title, Author author, string isbn, string description)
        {
            Id = id;
            Title = title;
            Author = author;
            ISBN = isbn;
            Description = description;
            Copies = new List<BookCopy>();
        }
    }

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

    public class Loan
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("BookCopyRef")]
        public BookCopy theBook { get; set; }
        [Required]
        public bool onLoan { get; set; }
        [ForeignKey("MemberRef")]
        public Member theMember { get; set; }
        [Required]
        public DateTime DueDate { get; set; }
        [Required]
        public DateTime TimeOfLoan { get; set; }
        [Required]
        public DateTime TimeOfReturn { get; set; }

        public Loan(BookCopy book, Member member, bool loanBool)
        {
            theBook = book;
            theMember = member;
            onLoan = loanBool;
            DueDate = new DateTime();
            TimeOfLoan = new DateTime();
            TimeOfReturn = new DateTime();
        }


    }

    public class Author
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public virtual ICollection<Book> Books { get; set; }

        Author(string name)
        {
            Name = name;
            Id = new int();
            Books = new List<Book>();
        }
    }

    public class Member
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int PersonalNumber { get; set;}
        [Required]
        public string Name { get; set; }
        [Required]
        public virtual ICollection<Loan> Loans { get; set; }

        Member(int prnN, string name)
        {
            PersonalNumber = prnN;
            Name = name;
            Id = new int();
            Loans = new List<Loan>();
        }
    }

    //public class LibraryContext : DbContext
    //{
    //    public DbSet<Book> Books { get; set; }
    //    public DbSet<Author> Authors { get; set; }
    //}
}
