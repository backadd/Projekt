using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
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
}
