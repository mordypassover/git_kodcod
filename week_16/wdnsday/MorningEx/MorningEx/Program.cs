using MorningEx.Repositories;
using MorningEx.Services;
using MorningEx.Middleware;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Register repositories as Singleton (in-memory data persists) 
builder.Services.AddSingleton<IProductRepo, ProductRepo>();
builder.Services.AddSingleton<IOrderRepository, OrderRepository>();

// Register services as Scoped (one instance per HTTP request) 
builder.Services.AddScoped<IOrderService, OrderService>();

var app = builder.Build();

// Configure the HTTP request pipeline.


app.UseMiddleware<ExceptionHandlingMiddleware>();

app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
