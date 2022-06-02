using Hoz1er.WebOS.Model;
using Microsoft.EntityFrameworkCore;

namespace Hoz1er.WebOS.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            IConfiguration configuration = new ConfigurationBuilder()
                .AddJsonFile($"appSettings.{builder.Environment.EnvironmentName}.json")
                            //.AddJsonFile("appSettings.{Environment}.json")
                            .Build();

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddDbContextPool<Hoz1erDBContext>(options =>
            {
                options.UseMySql(configuration.GetConnectionString("MySqlConnection"), ServerVersion.AutoDetect(configuration.GetConnectionString("MySqlConnection")));
            });


            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}