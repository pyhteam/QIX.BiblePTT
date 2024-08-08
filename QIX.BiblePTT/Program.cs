using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using QIX.BiblePTT.ControlViews;
using QIX.BiblePTT.Services;
using QIX.BiblePTT.Services.Interface;

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
                    services.AddTransient<IBibleService, BibleService>(); 
                    services.AddTransient<IBookService, BookService>(); 
                    services.AddTransient<IVerseService, VerseService>();
                    services.AddTransient<IHymnBookService, HymnBookService>();
                    services.AddSingleton<fmMain>();
                    services.AddSingleton<BibleControlView>(); 
                    services.AddSingleton<HymnsControlView>();
                });
        }
    }
}