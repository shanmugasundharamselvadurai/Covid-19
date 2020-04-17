using Covid19Tracker.PageModels;
using FreshMvvm;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Covid19Tracker
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        // To set MainPage for the Application  
        var page = FreshPageModelResolver.ResolvePageModel<FirstPageModel>();
        var container = new FreshNavigationContainer(page)
            {
                BarTextColor = Color.White,
                BarBackgroundColor = Color.FromHex("#f54542")
            };
            MainPage = container;
            //Register Syncfusion license
            //  Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjI4ODUzQDMxMzcyZTM0MmUzMGdmQXlrNTBxUktlUWlrMGZSSGpyZEUyaUdYRzYxbkdQWDg1TE83eFZSM2c9");
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
