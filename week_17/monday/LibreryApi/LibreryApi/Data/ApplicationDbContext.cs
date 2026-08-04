using LibreryApi.models;
using Microsoft.EntityFrameworkCore;

namespace LibreryApi.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options) { }
    
    public DbSet<Book> books => Set<Book>();
    public DbSet<Member> members => Set<Member>();
}

