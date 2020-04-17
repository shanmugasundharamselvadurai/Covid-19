using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Covid19Tracker.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();

            Blink();
        }
        private async void Blink()
        {
            while (true)
            {
                await Task.Delay(1000);
                gotHomePage.TextColor = gotHomePage.TextColor == Color.Red ? Color.Black : Color.Red;
            }
        }
    }
}