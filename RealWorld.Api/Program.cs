using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using RealWorld.Api;
using RealWorld.Api.Data;
using RealWorld.Api.Repositories;
using RealWorld.Api.Services;

var builder = WebApplication.CreateBuilder(args);

var authOptions = new AuthOptions();
builder.Configuration.GetSection(AuthOptions.Auth).Bind(authOptions);
builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(x =>
{
    x.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(authOptions.JwtKey)),
        ValidateIssuer = false,
        ValidateAudience = false
    };
});


builder.Services.AddControllers();
builder.Services.AddDbContext<RealWorldDataContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("RealWorld"))
);
builder.Services.AddSingleton<AuthOptions>(authOptions);
builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<IArticleRepository, ArticleRepository>();
builder.Services.AddTransient<TokenService>();

var app = builder.Build();
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();
