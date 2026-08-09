using MorningEx.Models;

namespace MorningEx.DbHandlers;

public interface IChannelHandler
{
    Task<IEnumerable<Channel>> GetAllChannelsAsync();

    Task<Channel?> GetChannelAsync();

    Task<Channel> CreatChannelAsync(Channel channel);

    Task<bool> UpdatAsync(int id, Channel channel);
    Task<bool> DeleteChannelAsync(int id);
}