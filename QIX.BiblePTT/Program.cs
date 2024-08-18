using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
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
            try
            {
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                var host = CreateHostBuilder().Build();
                ServiceProvider = host.Services;

                Application.Run(ServiceProvider.GetRequiredService<fmMain>());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //write log here
                // TODO: log error to a file or server
                string fileName = Path.Combine(Environment.CurrentDirectory, "error.log");
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(fileName, true))
                {
                    sw.WriteLine($"{DateTime.Now.ToString()} - {ex.Message}");
                }
                Application.Exit();
            }

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