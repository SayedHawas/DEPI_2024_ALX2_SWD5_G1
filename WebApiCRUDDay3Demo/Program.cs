using Microsoft.EntityFrameworkCore;
using WebApiCRUDDay3Demo.BL.Implement;
using WebApiCRUDDay3Demo.BL.Interface;
using WebApiCRUDDay3Demo.Core.UnitOfWorks.Implementing;
using WebApiCRUDDay3Demo.Core.UnitOfWorks.Interface;
using WebApiCRUDDay3Demo.Models;

namespace WebApiCRUDDay3Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddScoped<IService<Department>, ServiceDepartment>();
            builder.Services.AddScoped<IService<Employee>, ServiceEmployee>();
            builder.Services.AddScoped<IService<Company>, ServiceCompany>();


            //EFCore Using SQLServer Class  AppDbContext
            //Not HardCode 
            builder.Services.AddDbContext<AppDbContext>(
               options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
            );

            builder.Services.AddCors(options => options.AddPolicy("MyCors", CorsPolicyBuilder =>
            {
                CorsPolicyBuilder.AllowAnyOrigin();
            }));


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

            app.UseAuthorization();

            app.UseCors("MyCors");

            app.MapControllers();

            app.Run();
        }
    }
}
