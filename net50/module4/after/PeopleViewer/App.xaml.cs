using PeopleViewer.Presentation;
using PersonDataReader.Service;
using PersonDataReader.CSV;
using System.Windows;
using PersonDataReader.SQL;
using PersonDataReader.Decorators;

namespace PeopleViewer
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            ComposeObjects();
            Application.Current.MainWindow.Title = "With Dependency Injection";
            Application.Current.MainWindow.Show();
        }

        private static void ComposeObjects()
        {
            var wrappedReader = new ServiceReader();
            var reader = new CachingReader(wrappedReader);
            var viewModel = new PeopleViewModel(reader);
            Application.Current.MainWindow = new PeopleViewerWindow(viewModel);
        }
    }
}
