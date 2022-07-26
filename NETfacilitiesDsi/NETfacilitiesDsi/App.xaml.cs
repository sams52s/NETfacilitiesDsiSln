using System;
using NETfacilitiesDsi.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NETfacilitiesDsi
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            if (!IsUserLoggedIn)
                MainPage = new NavigationPage(new LoginView());
        }

        public static bool IsUserLoggedIn { get; set; }

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
