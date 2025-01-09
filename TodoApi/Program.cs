using Microsoft.EntityFrameworkCore;
using TodoApi.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(s => s.AddDefaultPolicy(p =>
{
    p.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
}));
// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(o => o.UseSqlServer(
        builder.Configuration.GetConnectionString("ApplicationDbContext")));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
