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
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
            NavigationPage.SetBackButtonTitle(this, string.Empty);
             Blink();

        }
        private async void Blink()
        {
            while (true)
            {
                await Task.Delay(500);
                confirmedLabel.TextColor = confirmedLabel.TextColor == Color.Red ? Color.Black : Color.Red;
                recoveredLabel.TextColor = recoveredLabel.TextColor == Color.Green ? Color.Red : Color.Green;
                deasedLabel.TextColor = recoveredLabel.TextColor == Color.Green ? Color.Red : Color.Green;
                gotoCountry.TextColor = gotoCountry.TextColor == Color.Red ? Color.Black : Color.Red;
                gotoState.TextColor = gotoState.TextColor == Color.Red ? Color.Black : Color.Red;

                DeceasedCasesColor.TextColor = DeceasedCasesColor.TextColor == Color.Red ? Color.Black : Color.Red;
                RecoveredCasesColor.TextColor = RecoveredCasesColor.TextColor == Color.Green ? Color.Black : Color.Green;
                TotalCasesColor.TextColor = TotalCasesColor.TextColor == Color.Red ? Color.Black : Color.Red;
            }
        }
    }
}