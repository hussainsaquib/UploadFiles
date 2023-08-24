using ImageFunc.Models.Domain;
using ImageFunc.Repository.Abstract;
using ImageFunc.Repository.Implementation;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<DatabaseContext>(options=>
options.UseSqlServer(builder.Configuration.GetConnectionString("conn")));
builder.Services.AddTransient<IFileService,FileService>();
builder.Services.AddTransient<IProductRepository, ProductRepostory>();


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
