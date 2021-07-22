using PeopleViewer.Presentation;
using PersonDataReader.Service;
using PersonDataReader.CSV;
using System.Windows;
using PersonDataReader.SQL;
using PersonDataReader.Decorators;
using Ninject;
using PeopleViewer.Common;

namespace PeopleViewer.Ninject
{
    public partial class App : Application
    {
        IKernel Container = new StandardKernel();

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            ConfigureContainer();
            ComposeObjects();
            Application.Current.MainWindow.Title = "With Dependency Injection - Ninject";
            Application.Current.MainWindow.Show();
        }

        private void ConfigureContainer()
        {
            Container.Bind<IPersonReader>().To<CachingReader>()
                .InSingletonScope()
                .WithConstructorArgument<IPersonReader>(Container.Get<ServiceReader>());
        }

        private void ComposeObjects()
        {
            Application.Current.MainWindow = Container.Get<PeopleViewerWindow>();
        }
    }
}
