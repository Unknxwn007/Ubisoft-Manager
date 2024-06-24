using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UbiHelper
{
    public static class Variables
    {
        public static string username = Environment.UserName;
        static string UbisoftConnect = @"C:\Program Files (x86)\Ubisoft\Ubisoft Game Launcher";

        public static string executablePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        public static string dataDirectory = Path.Combine(executablePath, "data");

        public static string savegameDirectory = Path.Combine(dataDirectory, "savegames");
        public static string screenshotDirectory = Path.Combine(dataDirectory, "screenshots");

        public static string savegameDirectoryUbi = Path.Combine(UbisoftConnect, "savegames");
        public static string userIdFolder = Directory.GetDirectories(savegameDirectoryUbi)[0];
        //public static string screenshotDirectoryUbi = Path.Combine(dataDirectory, "test");
        public static string screenshotDirectoryUbi = Path.Combine("C:\\Users\\", username, "Pictures\\UbisoftConnect");

        public static string errorLog = Path.Combine(dataDirectory, "error.log");
    }
}