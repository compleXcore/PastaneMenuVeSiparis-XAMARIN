using PastaneMenuVeSiparis.DatabaseAccess;
using PastaneMenuVeSiparis.Views.KullaniciViews;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PastaneMenuVeSiparis
{
    public partial class App : Application
    {
        private static UnitOfWork _database;

        public static UnitOfWork Database
        {
            get
            {
                if (_database == null)
                {
                    string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "proje_21.db3");
                    _database = new UnitOfWork(dbPath);
                }
                return _database;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage();
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
