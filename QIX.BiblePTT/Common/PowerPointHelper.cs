using System.Diagnostics;
using Python.Runtime;

namespace QIX.BiblePTT.Common
{
    public static class PowerPointHelper
    {
        static string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs", "error.log");
        public static void ExportPPT(string showPTTX)
        {
            try
            {
                string pythonHome = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "libs");
                string pythonDllPath = Path.Combine(pythonHome, "python310.dll");

                if (!File.Exists(pythonDllPath))
                {
                    throw new FileNotFoundException("Python DLL not found", pythonDllPath);
                }

                if (!PythonEngine.IsInitialized)
                {
                    Runtime.PythonDLL = pythonDllPath;
                    PythonEngine.Initialize();
                }
                using (Py.GIL())
                {
                    dynamic sys = Py.Import("sys");
                    sys.path.append(pythonHome);
                    dynamic script = Py.Import("export_pptx");
                    dynamic export_pptx = script.export_pptx;
                    export_pptx(showPTTX);
                }
            }
            catch (Exception ex)
            {
                if (!Directory.Exists(Path.GetDirectoryName(logFilePath)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(logFilePath));
                }
                using (StreamWriter sw = new StreamWriter(logFilePath, true))
                {
                    sw.WriteLine($"{DateTime.Now} - {ex}");
                }
                throw ex;
            }
            finally
            {
                if (PythonEngine.IsInitialized)
                {
                    PythonEngine.Shutdown();
                }
            }
        }
        public async static void ExportWithApplication(string showPTTX)
        {

            string path_create_pptx = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "libs", "buil_to_exe.exe");
            // check exe file exists
            if (!File.Exists(path_create_pptx))
            {
                MessageBox.Show("Tsis muaj buid_to_exe", "Thoob Pom", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = path_create_pptx,
                    RedirectStandardInput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };
            process.Start();
            using (var writer = process.StandardInput)
            {
                if (writer.BaseStream.CanWrite)
                {
                    await writer.WriteLineAsync(showPTTX);
                }
            }
            process.WaitForExit();
        }
    }
}