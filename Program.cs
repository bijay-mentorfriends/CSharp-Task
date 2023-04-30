using InternTask.Data;
using InternTask.Repository.Implement;
using InternTask.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ConceptContext>(options =>
{
    string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
}
);

// Add services to the container.

builder.Services.AddScoped<IConcept, Concept>();

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

/*string connString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ConceptContext>(options =>
{
   options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"));
});
*/







app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
