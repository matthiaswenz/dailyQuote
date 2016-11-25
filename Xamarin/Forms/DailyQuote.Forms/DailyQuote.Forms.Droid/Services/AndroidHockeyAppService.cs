using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DailyQuote.Forms.Services;
using HockeyApp.Android;
using HockeyApp.Android.Metrics;

namespace DailyQuote.Forms.Droid.Services
{
    public class AndroidHockeyAppService : IHockeyAppService
    {
        private const string hockeyAppId = "";

        public void Register()
        {
            CrashManager.Register(Application.Context, hockeyAppId);
            MetricsManager.Register(Application.Context, Application, hockeyAppId);
            UpdateManager.Register(Application.Context, hockeyAppId);
        }

        public void TrackEvent(string name)
        {
            throw new NotImplementedException();
        }
    }
}