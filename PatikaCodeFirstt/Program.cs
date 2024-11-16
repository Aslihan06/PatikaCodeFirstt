using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PatikaCodeFirst.Data;

var builder = WebApplication.CreateBuilder(args);

// Veritabanı bağlantısını yapılandırma
builder.Services.AddDbContext<PatikaSecondDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Veritabanı oluşturma
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<PatikaSecondDbContext>();
    dbContext.Database.Migrate(); // Veritabanını oluşturur ve tabloları ekler
}

app.Run();
