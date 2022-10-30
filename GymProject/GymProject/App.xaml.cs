using GymProject.Vistas;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GymProject
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new VRegistro());
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
