using Microsoft.EntityFrameworkCore;
using MorningEx.Models;

namespace MorningEx.Data;

public class MessageChannelContext : DbContext
{
    public MessageChannelContext(DbContextOptions<MessageChannelContext> options) : base(options) { }

    public DbSet<Message> Messages { get; set; } = null!;
    public DbSet<Channel> Channels { get; set; } = null!;

}
