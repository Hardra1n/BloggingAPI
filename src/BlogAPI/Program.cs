var builder = WebApplication.CreateBuilder(args);

string policyName = "SomeNamePolicy";

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
// builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();
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

app.MapControllers();
app.Run();
