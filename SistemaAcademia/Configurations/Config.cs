using System;
using System.IO;

namespace SistemaAcademia.Configurations
{
    public static class Config
    {

        public static string GetLogPath()
        {
            string logPath = System.Configuration.ConfigurationManager.AppSettings["logPath"];

            logPath = Path.Combine(logPath, $"{DateTime.Now.ToString("yyyy-MM-dd")}.txt");

            return logPath;
        }

        public static string GetConnectionStringSQLServer()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["sistemaAcademia"].ToString();
        }

        public static int GetCacheExpirationTimeInSeconds(string chave)
        {
            return Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings[chave]);
        }

    }
}