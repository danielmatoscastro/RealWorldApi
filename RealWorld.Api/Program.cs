using Microsoft.EntityFrameworkCore;
using RealWorld.Api;
using RealWorld.Api.Data;

var builder = WebApplication.CreateBuilder(args);

var authOptions = new AuthOptions();
builder.Configuration.GetSection(AuthOptions.Auth).Bind(authOptions);

builder.Services.AddControllers();
builder.Services.AddDbContext<RealWorldDataContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("RealWorld"))
);
builder.Services.AddSingleton<AuthOptions>(authOptions);

var app = builder.Build();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
