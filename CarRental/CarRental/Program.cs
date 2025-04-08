using CarRental.DataAccess;
using Microsoft.EntityFrameworkCore;
using CarRental.ApplicationServices.API.Domain;
using MediatR;
using CarRental.ApplicationServices.Mappings;
using CarRental.DataAccess.CQRS;
using FluentValidation.AspNetCore;
using CarRental.ApplicationServices.API.Validators;
using Microsoft.AspNetCore.Mvc;
using NLog.Web;


var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders();
builder.Logging.SetMinimumLevel(LogLevel.Trace);
builder.Host.UseNLog();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IQueryExecutor, QueryExecutor>();
builder.Services.AddTransient<ICommandExecutor, CommandExecutor>();
builder.Services.AddMvcCore()
    .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<AddCarRequestValidator>());

builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.SuppressModelStateInvalidFilter = true;
});

builder.Services.AddAutoMapper(typeof(CarsProfile).Assembly);
builder.Services.AddMediatR(typeof(ResponseBase<>).Assembly);
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddDbContext<CarRentalStorageContext>(
    opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("CarRentalDatabaseConnection")));


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
