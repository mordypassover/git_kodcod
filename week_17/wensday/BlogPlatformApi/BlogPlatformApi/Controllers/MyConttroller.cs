using BlogPlatformApi.Models;
using BlogPlatformApi.Repos;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks.Dataflow;

namespace BlogPlatformApi.Controllers;

[ApiController]
[Route("Api/[Controller]")]
public class MyConttroller: ControllerBase
{
    IRepos _repo;

    public MyConttroller(IRepos repo)
    {
        _repo = repo;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Post>>> GetPostsWithAutherAndCommandsAsync()
    {
        var responce = await _repo.GetPostsWithAutherAndCommands();
        return Ok(responce);
    }

    [HttpGet("serch")]
    public async Task<ActionResult<IEnumerable<Post>>> filterAsynk(int? authorId, DateTime? fromDate,  DateTime? toDate)
    {
        return Ok(await _repo.filterPostsAsynk(authorId, fromDate, toDate));
    }
    [HttpGet("sort")]
    public async Task<ActionResult<IEnumerable<Post>>> SortAsynk(bool sortByDates = false, bool sortByTitle = false, bool isAscending = false)
    {
        return Ok(await _repo.DynamicSortingPostsAsynk(sortByDates, sortByTitle, isAscending));
    }
    [HttpGet("agregate")]
    public async Task<ActionResult<IEnumerable<object>>> GetAgrigatoionAsynk()
    {
        return Ok(await _repo.AggregationPerItemAsynk());
    }

    [HttpGet("authorCommentsCnt")]
    public async Task<ActionResult<IEnumerable<object>>> CommentsPerAuthorsynk()
    {
        return Ok(await _repo.CommentsPerAuthorsynk());
    }


}
