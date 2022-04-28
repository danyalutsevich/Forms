using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;
using Microsoft.Practices.Unity;

namespace WinForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

        public static UnityContainer Container { get; set; }



        [STAThread]
        static void Main()
        {
            //WinForms configurator
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Additional configurations
            
            Container = new UnityContainer();

            var config = new NLog.Config.LoggingConfiguration();
            config.AddRule(LogLevel.Trace, LogLevel.Fatal, new NLog.Targets.FileTarget("file") { FileName = "log.txt" });
            LogManager.Configuration = config;

            Logger logger = LogManager.GetCurrentClassLogger();
            //Registration
            Container.RegisterInstance(logger);
            Container.RegisterInstance(new Random());
            Container.RegisterType<Services.IRandom, Services.SimpleRandom>();

            //Creation of Portal via Container
            Application.Run(Container.Resolve<Forms.Portal>());
        }
    }
}
