using Microsoft.AspNetCore.Mvc;
using MongoCrud.models;
using MongoDB.Bson;
using MongoDB.Driver;


namespace MongoCrud.Controllers;

[ApiController]
[Route("[controller]")]
public class StoregeController : ControllerBase
{
    private readonly IMongoDatabase _database;

    public StoregeController(IMongoDatabase database)
    {
        _database = database;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Product>>> Get()
    {
        var collection = _database.GetCollection<Product>("storege");
        var products = await collection.Find(p => true).ToListAsync();
        return Ok(products);
    }
    [HttpGet("{id}")]
    public async Task<ActionResult<Product>> GetById(string id)
    {
        if (!ObjectId.TryParse(id,out ObjectId _))
        {
            return NotFound();
        }

        var collection = _database.GetCollection<Product>("storege");
        var product = await collection.Find(p => p._Id == id).ToListAsync();
        return Ok(product);
    }
    //[HttpPost]

}
