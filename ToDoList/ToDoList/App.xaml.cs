using System;
using ToDoList.Clases;
using Xamarin.Forms;
using System.IO;

namespace ToDoList
{
    public partial class App : Application
    {
        private static DB db;
        public static DB Db
        {
            get
            {
                if (db == null)
                {
                    db = new DB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "DB.sqlite"));
                }
                return db;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());

        }
    }
}
