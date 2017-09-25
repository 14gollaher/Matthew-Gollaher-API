using System.Collections.Generic;
using System.Linq;

namespace Acm.BusinessLogic
{
    public class MockMemberRepository : IMemberRepository
    {
        public List<Member> GetMembers()
        {
            return MemberDataStore.Current.Members;
        }

        public Member GetMember(int memberId)
        {
            return MemberDataStore.Current.Members.FirstOrDefault(m => m.Id == memberId);
        }

        public void InsertMember(Member member)
        {
            MemberDataStore.Current.Members.Add(member);
        }

        public void EditMember(Member member)
        {
            Member oldMember = MemberDataStore.Current.Members.FirstOrDefault(m => m.Id == member.Id);
            MemberDataStore.Current.Members.Remove(oldMember);
            MemberDataStore.Current.Members.Add(member);
        }

        public void DeleteMember(int memberId)
        {
            Member oldMember = MemberDataStore.Current.Members.FirstOrDefault(m => m.Id == memberId);
            MemberDataStore.Current.Members.Remove(oldMember);
        }
    }
}
