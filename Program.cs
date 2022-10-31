using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Numerics;
using DockerCarRentalApi.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DockerCarRentalApiContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DockerCarRentalApiContext") ?? throw new InvalidOperationException("Connection string 'DockerCarRentalApiContext' not found.")));

builder.Services.AddControllers();

var app = builder.Build();
app.UseHttpsRedirection();
app.MapControllers();
//app.MapGet("/", () => "Hello World!");
app.Run();
