using FluentMigrator.Runner;
using Microsoft.EntityFrameworkCore;
using SmartTaskManager.Database;
using SmartTaskManager.Service;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEntityFrameworkNpgsql().AddDbContext<TaskDbContext>(options => options.UseNpgsql
           (builder.Configuration.GetConnectionString("DbConnection")));

builder.Services.AddLogging(c => c.AddFluentMigratorConsole())
    .AddFluentMigratorCore()
    .ConfigureRunner(c => c
        .AddPostgres()
        .WithGlobalConnectionString(builder.Configuration.GetConnectionString("DbConnection"))
        .ScanIn(Assembly.GetExecutingAssembly()).For.Migrations().For.EmbeddedResources());

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MigrateDatabase();

app.UseAuthorization();

app.MapControllers();

app.Run();
