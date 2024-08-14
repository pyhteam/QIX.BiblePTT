
using Python.Runtime;

namespace QIX.BiblePTT.Common
{
    public static class PowerPointHelper
    {
        public static void ExportPPT(string showPTTX)
        {
            // Initialize Python Engine
            Runtime.PythonDLL = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "libs", "python310.dll");
            PythonEngine.Initialize();

            // Load Python script
            using (Py.GIL())
            {
                dynamic sys = Py.Import("sys");
                sys.path.append(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "libs"));

                dynamic script = Py.Import("export_pptx");  // Tên file Python (không có phần mở rộng .py)
                dynamic export_pptx = script.export_pptx;  // Lấy hàm export_pptx từ Python
                // Gọi hàm Python từ C#
                export_pptx(showPTTX);
            }

            // Shutdown Python Engine
            PythonEngine.Shutdown();
        }
    }
}