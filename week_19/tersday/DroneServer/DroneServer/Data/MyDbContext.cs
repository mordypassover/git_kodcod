using DronesConsumer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DronesConsumer.Data;

public class MyDbContext:DbContext
{
    public MyDbContext(DbContextOptions<MyDbContext> options):base(options) {}

    public DbSet<UavModel> Models {  get; set; }
    public DbSet<Unit> Units { get; set; }
    public DbSet<Track> Tracks { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UavModel>()
            .HasMany(e => e.Units)
            .WithOne(e => e.UavModel)
            .HasForeignKey(e => e.model_id)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Unit>()
            .HasMany(e => e.Tracks)
            .WithOne(e => e.Unit)
            .HasForeignKey(e => e.unit_id)
            .IsRequired();
    }
}
