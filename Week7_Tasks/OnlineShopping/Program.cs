
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using OnlineShopping.Models;
using OnlineShopping.Repository;
using OnlineShopping.UnitOfWorks;

namespace OnlineShopping
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
            builder.Services.AddDbContext<OnShoppingContext>(op => op.UseLazyLoadingProxies().UseSqlServer(builder.Configuration.GetConnectionString("OnShopConn")));
            builder.Services.AddIdentity<IdentityUser ,  IdentityRole>().AddEntityFrameworkStores<OnShoppingContext>();
            builder.Services.AddScoped<UnitOfWork>();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "OnlineShopping API - V1",
                    Version = "v1",
                    Description = "A sample API for Online Shopping Project",
                    Contact = new OpenApiContact
                    {
                        Name = "Ahmed Salah Mohammed", 
                        Email = "ahmedsalahmohammed98@gmail.com"
                    }
                });
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            //if (app.Environment.IsDevelopment())
            //{
            //}
            app.UseSwagger();
            app.UseSwaggerUI();

            app.UseHttpsRedirection();

            app.UseAuthentication();
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
