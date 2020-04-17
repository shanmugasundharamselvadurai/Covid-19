using Covid19Servics.Interfaces;
using Covid19Servics.Services;
using Covid19Tracker.Base;
using Covid19Tracker.Models;
using Covid19Tracker.Pages;
using Covid19Tracker.Util;
using Newtonsoft.Json;
using RestSharp;
using Rg.Plugins.Popup.Animations;
using Rg.Plugins.Popup.Enums;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Covid19Tracker.PageModels
{
    public class CountryDetailsPageModel : BasePageModel
    {
        readonly ICommonService _commonServices;
        public  ObservableCollection<NinjaCovid19CountriesModel> NiCovid19Model { get; set; }
        public CountryDetailsPageModel()
        {   
            _commonServices = new CommonService();
            GetCountryListcases();
            NiCovid19Model = new ObservableCollection<NinjaCovid19CountriesModel>();
        }   

        public Command totalCommand => new Command(async () => totalCommandayncAsync());
        public Command SearchCommand => new Command(Search);

        
        CountriesModel selectedCountry;
        public CountriesModel SelectedCountry { get { return selectedCountry; } set { selectedCountry = value; RaisePropertyChanged(); } }

        private string _deaths;
        public string Deaths { get { return _deaths; } set   { if (!Equals(_deaths, value)) { _deaths = value; RaisePropertyChanged(nameof(Deaths));}}}
       
        private string _confirmed;
        public string Confirmed
        {
            get { return _confirmed; }
            set { if (!Equals(_confirmed, value)) { _confirmed = value; RaisePropertyChanged(nameof(Confirmed)); } }
        }
        private string _recovered;
        public string Recovered
        {
            get { return _recovered; }
            set { if (!Equals(_recovered, value)) { _recovered = value; RaisePropertyChanged(nameof(Recovered)); } }
        }

        private string _searchText;
        public string SearchText
        {
            get
            { return _searchText; }
            set { if (!Equals(_searchText, value))
                { _searchText = value;
                    Search();
                    RaisePropertyChanged(nameof(SearchText)); } }

        }

        private Label _newCasesTextColor;
        public Label newCasesTextColor
        {
            get
            { return _newCasesTextColor; }
            set
            {
                if (!Equals(_newCasesTextColor, value))
                {
                    _newCasesTextColor = value;
                    RaisePropertyChanged(nameof(newCasesTextColor));
                }
            }
        }

        private Label _newDeathsTextColor;
        public Label newDeathsTextColor
        {
            get
            { return _newDeathsTextColor; }
            set
            {
                if (!Equals(_newDeathsTextColor, value))
                {
                    _newDeathsTextColor = value;
                    RaisePropertyChanged(nameof(newDeathsTextColor));
                }
            }

        }
        private Label _seriousTextColor;
        public Label seriousTextColor
        {
            get
            { return _seriousTextColor; }
            set
            {
                if (!Equals(_seriousTextColor, value))
                {
                    _seriousTextColor = value;
                    RaisePropertyChanged(nameof(seriousTextColor));
                }
            }

        }

        private List<CountryDetailModel> countryDetailsModel;
        public List<CountryDetailModel> CountryDetailsModel
        {
            get { return countryDetailsModel; }
            set
            {
                if (!Equals(countryDetailsModel, value))
                {
                    countryDetailsModel = value;
                    RaisePropertyChanged(nameof(CountryDetailsModel));
                }
            }
        }

        private async Task totalCommandayncAsync()
        {
            var pr = new PopUp();
            var scaleAnimation = new ScaleAnimation
            {
                PositionIn = MoveAnimationOptions.Right,
                PositionOut = MoveAnimationOptions.Left
            };
            pr.Animation = scaleAnimation;
            await PopupNavigation.PushAsync(pr);

          

        }
        private async void GetCountryListcases()
        {
            Device.BeginInvokeOnMainThread(() => { IsBusy = true; });
            IRestResponse response = await _commonServices.GetCountries();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var totalCae = JsonConvert.DeserializeObject<List<NinjaCovid19CountriesModel>>(response.Content);

                foreach (var data in totalCae)
                {
                    double dcases = CommonUtils.ConvertToDouble(data.cases);
                    var cases = dcases.ToString("N0", CultureInfo.InvariantCulture);

                    double dtodayCases = CommonUtils.ConvertToDouble(data.todayCases);
                    var todayCases = dtodayCases.ToString("N0", CultureInfo.InvariantCulture);

                    double ddeaths = CommonUtils.ConvertToDouble(data.deaths);
                    var deaths = ddeaths.ToString("N0", CultureInfo.InvariantCulture);


                    double dtodayDeaths = CommonUtils.ConvertToDouble(data.todayDeaths);
                    var todayDeaths = dtodayDeaths.ToString("N0", CultureInfo.InvariantCulture);

                    double drecovered = CommonUtils.ConvertToDouble(data.recovered);
                    var recovered = drecovered.ToString("N0", CultureInfo.InvariantCulture);

                    double dactive = CommonUtils.ConvertToDouble(data.active);
                    var active = dactive.ToString("N0", CultureInfo.InvariantCulture);

                    double dcritical = CommonUtils.ConvertToDouble(data.critical);
                    var critical = dcritical.ToString("N0", CultureInfo.InvariantCulture);

                    double dcasesPerOneMillion = CommonUtils.ConvertToDouble(data.casesPerOneMillion);
                    var casesPerOneMillion = dcasesPerOneMillion.ToString("N0", CultureInfo.InvariantCulture);

                 
                    DateTime start = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                    Double db = Convert.ToDouble(data.updated);
                    var CountryUpdatetime = start.AddMilliseconds(db).ToLocalTime();
                    var DateCurrent = CountryUpdatetime.ToString("dddd, dd MMMM yyyy HH:mm:ss");


                    // Recovered = data.recovered.ToString();
                    NiCovid19Model.Add(new NinjaCovid19CountriesModel()
                    {
                        countryInfo = data.countryInfo,
                        country = data.country,
                        cases = cases,
                        todayCases = "+ " + todayCases+"",
                        deaths = deaths,
                        todayDeaths = "+ " +todayDeaths+"",
                        recovered = recovered,
                        active = active,
                        critical = "+ " + critical+"",
                        casesPerOneMillion = data.casesPerOneMillion,
                        deathsPerOneMillion = data.deathsPerOneMillion,
                        updated = DateCurrent,
                       
                    });

                    Device.BeginInvokeOnMainThread(() => { IsBusy = false; });
                }
              
            }

        }

        private void Search()
        {
            if (string.IsNullOrWhiteSpace(SearchText))
            {
                NiCovid19Model.Clear();
                GetCountryListcases();
                NiCovid19Model.Clear();
            }
            else
            {
                var countrySearch = NiCovid19Model.Where(c => c.country.ToLower().StartsWith(SearchText.ToLower())).ToList();
                NiCovid19Model.Clear();
                foreach (var country in countrySearch)
                    NiCovid19Model.Add(country);
            
            }
        }

        //public ICommand SearchCommand
        //{
        //    get
        //    {
        //        return new Command<string>((text) => {

        //          if (text.Length >= 1)
        //            {
        //                NiCovid19Model.Clear();

        //                var suggestions = NiCovid19Model.Where(c => c.country.ToLower().StartsWith(text.ToLower())).ToList();
        //                NiCovid19Model.Clear();
        //                foreach (var recipe in suggestions)
        //                    NiCovid19Model.Add(recipe);

        //            }
        //            else
        //            {
        //                NiCovid19Model.Clear();
        //            }

        //        });
        //    }
        //}


        //public async Task GetCountyItemDetailsAsync()
        //{
        //    //CountriesModel item = JsonConvert.DeserializeObject<CountriesModel>(Application.Current.Properties["SelectedCountryValue"].ToString());
        //    //SelectedCountry = item;
        //    //string county = "countries";

        //    IRestResponse response = await _commonServices.GetCountries();
        //    if (response.StatusCode == HttpStatusCode.OK)
        //    {
        //        var totalCae = JsonConvert.DeserializeObject<NinjaCovid19CountriesModel>(response.Content);
        //        //Deaths = totalCae.deaths;
        //        //Confirmed = totalCae.confirmed;
        //        //Recovered = totalCae.recovered;

        //        //LatestUpdate = totalCae.lastUpdate;
        //    }
        //}
    }
}
