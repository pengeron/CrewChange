using CrewChange.Application.DTOs;
using CrewChange.Application.Interfaces;
using CrewChange.Infrastructure.Data;
using CrewChange.Infrastructure.Repositories;
using CrewChange.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IEmployeeCertificationRepository, EmployeeCertificationRepository>();
builder.Services.AddScoped<IBlobStorageService, BlobStorageService>();

// Register AutoMapper
builder.Services.AddAutoMapper(typeof(Program).Assembly, typeof(MappingProfile).Assembly);

builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
