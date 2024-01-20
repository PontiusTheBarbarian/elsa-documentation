using Elsa.Extensions;
using ElsaWeb.Workflows;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddElsa(elsa =>
{
    elsa.AddWorkflow<HttpHelloWorld>();
    elsa.UseHttp();
});

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.UseWorkflows();
app.Run();