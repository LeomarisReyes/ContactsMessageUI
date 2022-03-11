using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ContactsMessageUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Views.MessagePage();
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
