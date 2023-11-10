using API_6._0_SQRC.Repositories.Entities;
using API_6._0_SQRC.Repositories.IRepositories;
using API_6._0_SQRC.Repositories.Repositories;
using API_6._0_SQRC.Services.IServices;
using API_6._0_SQRC.Services.Services;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Serilog.Formatting.Json;
using Services_4.Mapper;
using Services_SQRC.MediatR.Command.ICommandHandler;
using Services_SQRC.MediatR.Query.IQuery;
using Services_SQRC.MediatR.Query.IQueryHandler;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Add DB
builder.Services.AddDbContext<EFcontext>(o => o.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddAutoMapper(typeof(MappingProfile));


//builder.Services.AddMediatR(typeof(Program));
builder.Services.AddMediatR(typeof(ProvinceQueryHandler).Assembly);
builder.Services.AddMediatR(typeof(ProvinceCommandHandler).Assembly);

//Add injection
builder.Services.AddScoped<ICommandDistrictRepository, CommandDistrictRepository>();
builder.Services.AddScoped<ICommandProvinceRepository, CommandProvinceRepository>();
builder.Services.AddScoped<ICommandWardRepository, CommandWardRepository>();
builder.Services.AddScoped<IQueryDistrictRepository, QueryDistrictRepository>();
builder.Services.AddScoped<IQueryProvinceRepository, QueryProvinceRepository>();
builder.Services.AddScoped<IQueryWardRepository, QueryWardRepository>();

builder.Services.AddScoped<ICommandDistrictService, CommandDistrictService>();
builder.Services.AddScoped<ICommandProvinceService, CommandProvinceService>();
builder.Services.AddScoped<ICommandWardService, CommandWardService>();
builder.Services.AddScoped<IQueryDistrictService, QueryDistrictService>();
builder.Services.AddScoped<IQueryProvinceService, QueryProvinceService>();
builder.Services.AddScoped<IQueryWardService, QueryWardService>();



builder.Host.UseSerilog((ttx, config) =>
{
    config.WriteTo.Console().MinimumLevel.Information();
    config.WriteTo.File(
        path: AppDomain.CurrentDomain.BaseDirectory + "/logs/log-.txt",
        rollingInterval: RollingInterval.Day,
        rollOnFileSizeLimit: true,
        formatter: new JsonFormatter()
        ).MinimumLevel.Information();
}
);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var app = builder.Build();
app.UseSerilogRequestLogging();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
