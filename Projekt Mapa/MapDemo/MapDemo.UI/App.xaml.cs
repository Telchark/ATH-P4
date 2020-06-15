using Autofac;
using MapDemo.UI.Startup;
using System.Windows;

namespace MapDemo.UI
{
    /// <summary>
    /// Logika interakcji dla klasy App.xaml
    /// </summary>
    public partial class App : Application
    {
        //metoda wygenerowna przez startup
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            //magia DI
            var bootstrapper = new Bootstrapper();
            var container = bootstrapper.Bootstrap();

            var mainWindow = container.Resolve<MainWindow>();
            mainWindow.Show();
        }
    }
}
