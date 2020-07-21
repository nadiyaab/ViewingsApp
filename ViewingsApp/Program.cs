using System.Collections.Generic;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ViewingsApp.Data;
using ViewingsApp.Models.Database;

namespace ViewingsApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            CreateDbIfNotExists(host);
            
            host.Run();
        }

        private static void CreateDbIfNotExists(IHost host)
        {
            using var scope = host.Services.CreateScope();
            var services = scope.ServiceProvider;

            var context = services.GetRequiredService<DatabaseContext>();
            if (context.Database.EnsureCreated())
            {
                // if we just built a new DB, add some data.
                var properties = SamplePropertyGenerator.GetSampleProperties();
                context.Properties.AddRange(properties);
                context.SaveChanges();

                var agents = SampleAgentGenerator.GetSampleAgents();
                context.Agents.AddRange(agents);
                context.SaveChanges();

                var bookings = SampleBookingGenerator.GetSampleBookings(properties, agents);
                context.Bookings.AddRange(bookings);
                context.SaveChanges();
            }
        }
        
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}