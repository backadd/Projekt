using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repositories
{
    public class MemberRepository : IRepository<Member, int>
    {

        LibraryContext _context;

        public MemberRepository(LibraryContext ctx)
        {
            _context = ctx;
        }

        public void Add(Member item)
        {
            _context.Members.Add(item);
        }

        public IEnumerable<Member> All()
        {
            return _context.Members.ToList();
        }

        public void Edit(Member item)
        {
            Member MemberToDelete = Find(item.Id);
            Remove(MemberToDelete);
            Add(item);
        }

        public Member Find(int id)
        {
            return _context.Members.Single(b => b.Id == id);
        }

        public void Remove(Member item)
        {
            _context.Members.Remove(item);
        }
    }
}
