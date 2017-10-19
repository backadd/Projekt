using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    class MemberService : IService
    {
        MemberRepository _memberRepository;

        public MemberService(RepositoryFactory repoFactory)
        {
            _memberRepository = repoFactory.GetMemberRepository();
        }

        public event EventHandler Updated;

        public IEnumerable<Member> All()
        {
            return _memberRepository.All();
        }
    }
}
