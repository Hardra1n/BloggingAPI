using Microsoft.EntityFrameworkCore;
using Npgsql;

var builder = WebApplication.CreateBuilder(args);

string policyName = "SomeNamePolicy";

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
// builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();

// Microsoft.EntityFrameworkCore.DbContextOptionsBuilder;
builder.Services.AddScoped<IBlogService, BlogService>();
builder.Services.AddScoped<IBlogRepository, EntityRepository>();
builder.Services.AddDbContext<BloggingContext>(options =>
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("BloggingContext")));

builder.Services.AddSwaggerGen();
builder.Services.AddCors((options) =>
{
    options.AddPolicy(policyName, policy =>
    {
        string? webAddress = builder.Configuration.GetConnectionString("Web");
        if (webAddress != null)
        {
            policy.WithOrigins(webAddress);
        }
    });
});


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(policyName);
app.UseHttpsRedirection();

app.ConfigureData();

app.MapControllers();
app.Run();
