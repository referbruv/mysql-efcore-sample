using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MySqlReadersApp.Domain.Entities;
using MySqlReadersApp.Providers.Repositories;

namespace MySqlReadersApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var data = scope.ServiceProvider.GetRequiredService<IDataService>();
                SeedUsers(data);
            }

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        private static void SeedUsers(IDataService data)
        {
            data.UsersRepository.Insert(new User
            {
                EmailAddress = "user1001@yopmail.com",
                IsActive = true
            });
            data.UsersRepository.Insert(new User
            {
                EmailAddress = "user1001@yopmail.com",
                IsActive = true
            });
            data.UsersRepository.Insert(new User
            {
                EmailAddress = "user1002@yopmail.com",
                IsActive = true
            });
            data.UsersRepository.Insert(new User
            {
                EmailAddress = "user1003@yopmail.com",
                IsActive = true
            });
            data.UsersRepository.Insert(new User
            {
                EmailAddress = "user1004@yopmail.com",
                IsActive = true
            });
            data.UsersRepository.Insert(new User
            {
                EmailAddress = "user1005@yopmail.com",
                IsActive = true
            });
            data.UsersRepository.Insert(new User
            {
                EmailAddress = "user1006@yopmail.com",
                IsActive = true
            });
            data.UsersRepository.Insert(new User
            {
                EmailAddress = "user1007@yopmail.com",
                IsActive = true
            });
        }
    }
}
