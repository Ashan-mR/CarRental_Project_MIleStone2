
using CarRental_Project.Data;
using CarRental_Project.IRepositories;
using CarRental_Project.IServices;
using CarRental_Project.Repositories;
using CarRental_Project.Services;
using Microsoft.EntityFrameworkCore;

namespace CarRental_Project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<CarRentalDBContext>(opt=>opt.UseSqlServer(builder.Configuration.GetConnectionString("CarDbConnection")));

            builder.Services.AddScoped<ICustomerRepository,CustomerRepository>();
            builder.Services.AddScoped<ICustomerServices,CustomerServices>();

            builder.Services.AddScoped<IManagerRepository,ManagerRepository>();
            builder.Services.AddScoped<IManagerServices,ManagerServices>();

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
        }
    }
}
