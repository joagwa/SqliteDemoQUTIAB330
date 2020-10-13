using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SqliteDemo.Services;
using SqliteDemo.Views;

namespace SqliteDemo
{
    public partial class App : Application
    {
        static MyDatabase database;

        public static MyDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new MyDatabase();
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
