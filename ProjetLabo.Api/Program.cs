using ProjetLabo.Api.Models.Services;
using ProjetLabo.Api.Models.Repositories;
using System.Data.Common;
using System.Data.SqlClient;

namespace ProjetLabo.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            IConfiguration configuration = builder.Configuration;

            // Add services to the container.
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddTransient<DbConnection>(sp => new SqlConnection(configuration.GetConnectionString("ProjetLabo_Cqs")));
            builder.Services.AddScoped<IAuthRepository, AuthService>();
            builder.Services.AddScoped<IClientRepository, ClientService>();

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