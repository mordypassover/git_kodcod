using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using EtlConsumer.Models;

namespace EtlConsumer.Data;

public class MyDbContaxt:DbContext
{
    public MyDbContaxt(DbContextOptions<MyDbContaxt> options)
        : base(options)
    {
    }
    public DbSet<Analyst> Analysts { get; set; }
    public DbSet<Call> Calls { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Analyst>()
            .HasMany(e => e.Calls)
            .WithOne(e => e.Analyst)
            .HasForeignKey(e => e.analyst_id)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Analyst>()
            .HasKey(e => e.analyst_id);

        modelBuilder.Entity<Call>()
            .HasKey(e => e.call_id);
    }
}
