using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);

// 1. Configure the MongoDB Client in the DI container
string connectionString = "mongodb://localhost:32770/store";
builder.Services.AddSingleton<IMongoClient>(new MongoClient(connectionString));

// Optional: Register a specific database instance
builder.Services.AddScoped(sp =>
{
    var client = sp.GetRequiredService<IMongoClient>();
    return client.GetDatabase("store");
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();