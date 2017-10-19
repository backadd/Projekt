using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual Author Author { get; set; }
        public string ISBN { get; set; }
        public string Description { get; set; }
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
        public Book theBook { get; set; }
        public int Id { get; set; }

        public BookCopy(Book book)
        {
            theBook = book;
            Id = new int();
        }
    }

    public class Loan
    {
        public BookCopy theBook { get; set; }
        public bool onLoan { get; set; }
        public Member theMember { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime TimeOfLoan { get; set; }
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
        public int Id { get; set; }
        public int PersonalNumber { get; set;}
        public string Name { get; set; }
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
