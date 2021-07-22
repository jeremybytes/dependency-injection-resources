﻿using PeopleViewer.Presentation;
using PersonDataReader.Service;
using PersonDataReader.CSV;
using System.Windows;
using PersonDataReader.SQL;
using PersonDataReader.Decorators;
using PeopleViewer.Common;

namespace PeopleViewer.Ninject
{
    public partial class App : Application
    {
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

        }

        private void ComposeObjects()
        {

        }
    }
}
