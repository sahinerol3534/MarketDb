using MarketDB.DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;


namespace MarketDB.UI
{
    public static class Program
    {

        [STAThread]
        static void Main()
        {
            //var configuration = new ConfigurationBuilder()
            //.SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            //.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            //.Build();
            //var connectionString = configuration["ConnectionStrings:MarketDbConnection"]
            //    ?? throw new InvalidOperationException("Veri Tabanına Bağlanılmadı! (Can not Connect Database)");
            //var optionsBuilder = new DbContextOptionsBuilder<MarketDbContext>();
            //optionsBuilder.UseSqlServer(connectionString);
            //var options = optionsBuilder.Options;
            //var dbContext = new MarketDbContext(options);
            ApplicationConfiguration.Initialize();
            var builder = Host.CreateApplicationBuilder();
            var connectionString = builder.Configuration["ConnectionStrings:MarketDbConnection"]
               ?? throw new InvalidOperationException("Veri Tabanına Bağlanılmadı! (Can not Connect Database)");
            builder.Services.AddDbContextFactory<MarketDbContext>(options =>
                options.UseSqlServer(connectionString));
            builder.Services.AddTransient<DashboardForm>();
            var host =builder.Build();
            var dashboardForm = host.Services.GetRequiredService<DashboardForm>();
            Application.Run(dashboardForm);
        }
    }
}