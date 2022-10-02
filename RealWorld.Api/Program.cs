using Microsoft.EntityFrameworkCore;
using RealWorld.Api.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddDbContext<RealWorldDataContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("RealWorld"))
);

var app = builder.Build();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
