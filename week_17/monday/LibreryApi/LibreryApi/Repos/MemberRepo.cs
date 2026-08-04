using Microsoft.EntityFrameworkCore;
using LibreryApi.Data;
using LibreryApi.models;

namespace LibreryApi.Repos;

public class MemberRepo : IMemberRepo
{
    private readonly ApplicationDbContext _context;

    public MemberRepo(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Member>> getAllAsync()
    {
        return await _context.members.ToListAsync();
    }

    public async Task<Member> getById(int id)
    {
        return await _context.members.FindAsync(id);
    }
    public async Task<Member> addAsync(Member member)
    {
        _context.members.Add(member);
        await _context.SaveChangesAsync();
        return member;
    }
    public async Task<bool> updateAsync(int id, Member member)
    {
        var existing = await _context.members.FindAsync(id);
        if (existing == null)
            return false;

        existing.FullName = member.FullName;
        existing.Email = member.Email;
        existing.MembershipNumber = member.MembershipNumber;

        await _context.SaveChangesAsync();
        
        return true;
    }

    public async Task<bool> deleteAsync(int id)
    {
        var existing = await getById(id);
        if (existing == null) 
        {
            return false; 
        }
        _context.members.Remove(existing);

        await _context.SaveChangesAsync();
        return true;
    }
}
