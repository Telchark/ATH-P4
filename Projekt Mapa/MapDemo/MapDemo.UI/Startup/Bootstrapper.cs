using Autofac;
using MapDemo.DataAccess;
using MapDemo.UI.Data;
using MapDemo.UI.ViewModel;
using Prism.Events;

namespace MapDemo.UI.Startup
{
    public class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();

            //Prism.Core do publikowania i subskrybcji eventów trudne ale przydatne //TL
            builder.RegisterType<EventAggregator>().As<IEventAggregator>().SingleInstance();

            builder.RegisterType<MapDemoDbContext>();//as self jest domyślne i opcjonalne

            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainViewModel>().AsSelf();

            builder.RegisterType<WeaponLookupViewModel>().As<IWeaponLookupViewModel>();
            builder.RegisterType<ArmorLookupViewModel>().As<IArmorLookupViewModel>();
            builder.RegisterType<ResourceLookupViewModel>().As<IResourceLookupViewModel>();
            builder.RegisterType<CastleLookupViewModel>().As<ICastleLookupViewModel>();

            builder.RegisterType<WeaponDetailViewModel>().As<IWeaponDetailViewModel>();
            builder.RegisterType<ArmorDetailViewModel>().As<IArmorDetailViewModel>();
            builder.RegisterType<ResourceDetailViewModel>().As<IResourceDetailViewModel>();
            builder.RegisterType<CastleDetailViewModel>().As<ICastleDetailViewModel>();

            builder.RegisterType<LookupWeaponDataService>().As<ILookupWeaponDataService>();
            builder.RegisterType<LookupArmorDataService>().As<ILookupArmorDataService>();
            builder.RegisterType<LookupResourceDataService>().As<ILookupResourceDataService>();
            builder.RegisterType<LookupCastleDataService>().As<ILookupCastleDataService>();

            //AsImplementedInterfaces bierze WSZYSTKIE interfejsy jakch potrzbuje dana klasa czyli jeśli jest jeden to to samo co wyżej
            builder.RegisterType<WeaponDataService>().AsImplementedInterfaces();
            builder.RegisterType<ArmorDataService>().AsImplementedInterfaces();
            builder.RegisterType<ResourceDataService>().AsImplementedInterfaces();
            builder.RegisterType<CastleDataService>().AsImplementedInterfaces();

            return builder.Build();
        }
    }
}
