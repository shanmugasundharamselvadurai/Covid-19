using Covid19Tracker.PageModels;
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
    public partial class PopUp 
    {
        public string value = string.Empty;
        public PopUp()
        {
            InitializeComponent();
            BindingContext = new CountryDetailsPageModel();

            totalcase.Text = Application.Current.Properties["total"].ToString();
            totalRecovered.Text = Application.Current.Properties["Recovered"].ToString();
            totalDeaths.Text = Application.Current.Properties["deaths"].ToString();
        }
    }
}