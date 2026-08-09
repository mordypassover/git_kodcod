
using BlogPlatformApi.Models;

namespace BlogPlatformApi.Repos
{
    public interface IRepos
    {
        Task<IEnumerable<Post>> GetPostsWithAutherAndCommands();

        Task<IEnumerable<Post>> filterPostsAsynk(int? authorId, DateTime? fromDate, DateTime? toDate);

        Task<IEnumerable<Post>> DynamicSortingPostsAsynk(bool sortByDates , bool sortByTitle , bool isAscending );

        Task<IEnumerable<object>> AggregationPerItemAsynk();

        Task<IEnumerable<object>> CommentsPerAuthorsynk();
    }
}
