using System.Text;
using DatingApp.Data;
using DatingApp.Extentions;
using DatingApp.Interfaces;
using DatingApp.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddApplicationServices(builder.Configuration);
builder.Services.AddIdentityServices(builder.Configuration);


var app = builder.Build();

// Configure the HTTP request pipeline.
//app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod().WithOrigins("https://localhost:4200") );
app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin() );

app.UseAuthentication(); //do you have valid token
app.UseAuthorization(); // what can you do with token

app.MapControllers();

app.Run();
