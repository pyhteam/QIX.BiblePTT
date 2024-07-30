using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using QIX.BiblePTT.ControlViews;
using QIX.BiblePTT.Services;

namespace QIX.BiblePTT
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static IServiceProvider? ServiceProvider { get; private set; }
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<fmMain>());
        }

        static IHostBuilder CreateHostBuilder()
        {
           return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddHttpClient(); // Register HttpClient
                    services.AddTransient<IBibleService, BibleService>(); // Register your BibleService
                    services.AddSingleton<fmMain>(); // Register your main form
                    services.AddTransient<BibleControlView>(); // Register your BibleControlView
                });
        }
    }
}