using System.Collections.Generic;

namespace Acm.BusinessLogic
{
    public interface IMemberRepository
    {
        void InsertMember(Member member);
        List<Member> GetMembers();
        Member GetMember(int memberId);
        void EditMember(Member member);
        void DeleteMember(int memberId);
    }
}
