using Microsoft.EntityFrameworkCore;
using portrait.Data;

var builder = WebApplication.CreateBuilder(args);

// Activer CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});


// Configure le DbContext avec SQL Server
builder.Services.AddDbContext<ShapesTestContext>(options =>
    options.UseSqlServer());


// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();


var app = builder.Build();



app.UseHttpsRedirection();


app.UseCors("AllowAll");

app.UseRouting();
app.UseAuthorization();
app.MapControllers();

app.MapGet("/", () => "Bienvenue sur l'API !");

app.Run();