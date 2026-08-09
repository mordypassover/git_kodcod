using BlogPlatformApi.Data;
using BlogPlatformApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text.RegularExpressions;

namespace BlogPlatformApi.Repos;

public class Repository:IRepos
{
    private readonly MyDbContext _context;

    public Repository(MyDbContext context)
    {
        _context = context; 
    }

    public async Task<IEnumerable<Post>> GetPostsWithAutherAndCommands()
    {
        var query =  _context.Posts
            .Include(p => p.Author)
            .Include(p => p.Comments);
        return await query.ToListAsync();
    }

    //2. Filtering - Get published posts(IsPublished == true) filtered by an optional author ID and an
    //optional date range(PublishedDate between two dates). All filters optional and combinable, like this
    //morning's product search.

    public async Task<IEnumerable<Post>> filterPostsAsynk(int? authorId, DateTime? fromDate, DateTime? toDate)
    {
        IQueryable<Post> query = _context.Posts.Where(p => p.IsPublished);
        if (authorId.HasValue)
        {
            query = query.Where(p => p.AuthorId == authorId.Value );
        }

        if (fromDate.HasValue && toDate.HasValue)
        {
            query = query.Where(p => p.PublishedDate < toDate && p.PublishedDate > fromDate);
        }

        return await query.ToListAsync();
    }

    //3. Dynamic sorting -Sort posts by PublishedDate or by Title, ascending or descending, chosen via
    //query parameters.

    public async Task<IEnumerable<Post>> DynamicSortingPostsAsynk(bool sortByDates = false,bool sortByTitle = false, bool isAscending = false)
    {
        IQueryable<Post> query = _context.Posts;
        if (sortByDates)
        {
            if (isAscending!)
            {
                query = query.OrderByDescending(p => p.PublishedDate);
            }
            query = query.OrderBy(p => p.PublishedDate);
        }
        else if (sortByTitle)
        {
            query = query.OrderByDescending(p => p.Title);
        }
        query = query.OrderBy(p => p.Title);

        return await query.ToListAsync();
    }
    //4. Aggregation per item(Projection) - For each post, return its title and its comment count, without
    //loading the full Comments collection into memory.This is Projection: shaping the query's result down
    //to exactly what you need. (Where should the counting happen -C# or the database? How will you
    //know if you got it right?)

    public async Task<IEnumerable<object>> AggregationPerItemAsynk()
    { 
        return await _context.Posts.Select(p => new { p.Title ,commentCnt= p.Comments.Count() }).ToListAsync();
    }

    //5. Aggregation across the relationship(GroupBy) - For each author, return how many posts they've
    //published.Then, as a harder variant: for each author, return their total comment count across all their
    //posts(this requires grouping across two levels of the relationship - think about what the SQL needs to
    //look like before you write the LINQ).

    public async Task<IEnumerable<object>> CommentsPerAuthorsynk()
    {
        var result = _context.Posts.GroupBy(p => p.AuthorId)
        .Select(g => new {AuthorId = g.Key, PostCount = g.Count()});
        return await result.ToListAsync();
    }

}
