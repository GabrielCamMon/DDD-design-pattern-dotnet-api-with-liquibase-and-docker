using Microsoft.EntityFrameworkCore;
using MyProject.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

// Adicionar Controllers e Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Registrar os serviços da aplicação
builder.Services.AddScoped<MyProject.Application.Interfaces.IProductService, MyProject.Application.Services.ProductService>();
builder.Services.AddScoped<MyProject.Domain.Interfaces.IProductRepository, MyProject.Infrastructure.Repositories.ProductRepository>();

// Configurar DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));


var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();