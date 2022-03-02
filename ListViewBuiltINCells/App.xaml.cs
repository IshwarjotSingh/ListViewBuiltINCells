using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewBuiltINCells
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

             //MainPage = new Views.TextCell();
            MainPage = new Views.EntryCell();
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
