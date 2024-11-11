using Login.ClasesDB;
using Login.Views;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;

namespace Login
{
    public partial class App : Application
    {
        private ServiceProvider serviceProvider;

        public App()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);
            serviceProvider = services.BuildServiceProvider();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            // Configura el DbContext
            services.AddDbContext<Context>(options =>
            {
                options.UseSqlServer(
                    "Data Source=DESKTOP-K7L1ARV;Initial Catalog=SaludPlus;Integrated Security=True;TrustServerCertificate=True"
                );
            });

            // Registra MainWindow
            services.AddTransient<MainWindow>();
        }

       /* protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var sistema = new MainWindow();
            sistema.Show();
           
            
        }*/
    }
}