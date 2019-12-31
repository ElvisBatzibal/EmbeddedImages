using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EmbeddedImages
{
    public partial class App : Application
    {
        /// <summary>
        /// Inicialization App
        /// </summary>
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
