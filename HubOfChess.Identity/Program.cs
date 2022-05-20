
using IdentityServer4.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddIdentityServer()
    .AddInMemoryApiResources(new List<ApiResource>())
    .AddInMemoryIdentityResources(new List<IdentityResource>())
    .AddInMemoryApiScopes(new List<ApiScope>())
    .AddInMemoryClients(new List<Client>())
    .AddDeveloperSigningCredential();
builder.Services.AddControllers();


var app = builder.Build();

app.UseRouting();
app.UseIdentityServer();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
