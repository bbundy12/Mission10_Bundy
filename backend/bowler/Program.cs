using bowler.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// This is the CORS policy that allows the React app to access the API
builder.Services.AddCors();

builder.Services.AddDbContext<BowlingContext>(options =>
    options.UseSqlite(builder.Configuration["ConnectionStrings:BowlingConnection"])
);

builder.Services.AddScoped<IBowlingRepository, EFBowlingRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// This is the CORS policy that allows the React app to access the API
app.UseCors(p => p.WithOrigins("http://localhost:3000"));

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
