using CleanArchitectureCQRs.Application.IReposatories;
using CleanArchitectureCQRs.Infrastructure.Context;
using CleanArchitectureCQRs.Infrastructure.Repositories.QueryRepo;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TestDBConnection")));

builder.Services.AddDbContext<ApplicationIdentityDbContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("TestIdentityConnection")));

builder.Services.AddScoped(typeof(IQueryGenericRepo<>), typeof(GeneraicQueryRepo<>));

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
