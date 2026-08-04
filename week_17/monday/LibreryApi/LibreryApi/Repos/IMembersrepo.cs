using LibreryApi.models;

namespace LibreryApi.Repos;

public interface IMemberRepo
{
    Task<List<Member>> getAllAsync();

    Task<Member> getById(int id);
    Task<Member> addAsync(Member member);

    Task<bool> updateAsync(int id, Member member);

    Task<bool> deleteAsync(int id);
}
