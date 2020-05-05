using Covid19Tracker.Base;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Covid19Tracker.PageModels
{
   public class FirstPageModel: BasePageModel
    {
        public Command gotoMainPage => new Command(async () => GoToHomepageAsync());

        public FirstPageModel()
        {

        }
        private async void GoToHomepageAsync()
        {
            await PushAsync<HomePageModel>();
        }

   }
}
