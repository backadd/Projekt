using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repositories
{
    class Member : IRepository<Member, int>
    {

        LibraryContext _context;

        public MemberRepository(LibraryContext ctx)
        {
            _context = ctx;
        }

        public void Add(Member item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Member> All()
        {
            throw new NotImplementedException();
        }

        public void Edit(Member item)
        {
            throw new NotImplementedException();
        }

        public Member Find(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Member item)
        {
            throw new NotImplementedException();
        }
    }
}
