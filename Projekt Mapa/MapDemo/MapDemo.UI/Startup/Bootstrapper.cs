using Autofac;
using MapDemo.UI.Data;
using MapDemo.UI.ViewModel;

namespace MapDemo.UI.Startup
{
    public class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<WeaponDataService>().As<IWeaponDataService>();

            return builder.Build();
        }
    }
}
