using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademia.Utils
{
    public static class Logger
    {
        public static async Task RegistraLog(string logPath, Exception ex)
        {
            StringBuilder sb = new StringBuilder(); 

            sb.Append("Dia e Hora: ");
            sb.Append(DateTime.Now.ToString("g"));
            sb.Append("\nMensagem: ");
            sb.Append(ex.Message);
            sb.Append("\nStackTrace: ");
            sb.Append(ex.StackTrace);
            sb.Append("\n----------------------------------------------------");

            using (StreamWriter sw = new StreamWriter(logPath, true))
            {
                await sw.WriteLineAsync(sb.ToString());
            }
        }
    }
}