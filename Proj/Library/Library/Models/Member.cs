using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Member
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int PersonalNumber { get; set; }
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
}
