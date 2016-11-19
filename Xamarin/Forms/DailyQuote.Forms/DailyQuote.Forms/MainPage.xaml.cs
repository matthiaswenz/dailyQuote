using ModernHttpClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json;

namespace DailyQuote.Forms
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
			QuoteLabel.GestureRecognizers.Add(new TapGestureRecognizer { Command = new Command(async () => await FetchQuoteAsync()) });
        }

		protected override async void OnAppearing()
		{
			base.OnAppearing();
			await FetchQuoteAsync();
		}

		private async Task FetchQuoteAsync()
		{			
            var httpClient = new HttpClient(new NativeMessageHandler());
			var json = await httpClient.GetStringAsync("https://myrandomfuncs.azurewebsites.net/api/BullshitBingo?maxlength=180");
			var quoteResult = JsonConvert.DeserializeObject<QuoteResult>(json);

			QuoteLabel.Text = $"\"{quoteResult.Strings[0]}\"";
		}
    }
}
