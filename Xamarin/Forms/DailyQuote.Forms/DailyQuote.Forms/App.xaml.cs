using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DailyQuote.Forms.Services;

using Xamarin.Forms;

namespace DailyQuote.Forms
{
    public partial class App : Application
    {
        public IHockeyAppService HockeyAppService;
        public IMobileCenterService MobileCenterService;

        public App()
        {
            InitializeComponent();

            // Initialize HockeyApp

            // Initialize Visual Studio Mobile Center

            MainPage = new DailyQuote.Forms.MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
