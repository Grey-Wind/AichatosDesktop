using System.Configuration;
using System.Data;
using System.Windows;

namespace Aichatos_WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private Mutex? mutex;

        public App()
        {
            Startup += new StartupEventHandler(App_Startup);
        }

        void App_Startup(object sender, StartupEventArgs e)
        {
            mutex = new Mutex(true, "aichatos", out bool ret);

            if (!ret)
            {
                Environment.Exit(0);
                return;
            }
        }
    }

}
