namespace MemberApi.Repository
{
    public interface IMemberRepository
    {
        Task<IList<Members>> GetAllMembers();
        Task<Members> Removed(int id);

        Task<Members> UpdateMember(int id, Members member);
        Members AddMember(Members member);

        Task<Members> IncrementAge(int id);

    }
}
