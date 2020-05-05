using Covid19Servics.Interfaces;
using Covid19Servics.Services;
using Covid19Tracker.Base;
using Covid19Tracker.Models;
using Covid19Tracker.Util;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Covid19Tracker.PageModels
{
    public class HomePageModel : BasePageModel
    {
        readonly ICommonService _commonServices;
        public ObservableCollection<RecoveredModel> listModel { get; set; }
        public ObservableCollection<Covid19Model> totalCasess { get; set; }
        public ObservableCollection<NinjaCovid19AllModel> ninjaTotalCases { get; set; }
        public ObservableCollection <covid19IndiaModel> covid19indiaData { get; set; }
        public ObservableCollection <CasesTimeSery> casetime { get; set; }
        public ObservableCollection <Statewise> satewise { get; set; }
        
        public List<CountriesModel> CountryList { get; set; }
        public Command refreshCommand => new Command(async () => refreshdata());
        public Command viewbyCountry => new Command(async () => viewbyCountryAsync());
        public Command viewbyState => new Command(async () => viewbyStateAsync());

        public HomePageModel()
        {
            _commonServices = new CommonService();
            Task.Run(getTotalCase);
            Task.Run(getIndiaData);
            
            //list data
            listModel = new ObservableCollection<RecoveredModel>();
            totalCasess = new ObservableCollection<Covid19Model>();
            ninjaTotalCases = new ObservableCollection<NinjaCovid19AllModel>();
            covid19indiaData = new ObservableCollection<covid19IndiaModel>();
            satewise = new ObservableCollection<Statewise>();
        }

        private void refreshdata()
        {
            Task.Run(getTotalCase);
            Task.Run(getIndiaData);
        }

        private List<RecoveredModel> listOfItems;
        public List<RecoveredModel> ListOfItems
        {
            get { return listOfItems; }
            set
            {
                if (!Equals(listOfItems, value))
                {
                    listOfItems = value;
                    RaisePropertyChanged(nameof(ListOfItems));
                }
            }
        }

        private List<CountriesModel> listOfItemse;
        public List<CountriesModel> ListOfItemse
        {
            get { return listOfItemse; }
            set
            {
                if (!Equals(listOfItemse, value))
                {
                    listOfItemse = value;
                    RaisePropertyChanged(nameof(ListOfItemse));
                }
            }
        }

        private List<Covid19Model> _Covid19Model;
        public List<Covid19Model> Covid19Model
        {
            get { return _Covid19Model; }
            set
            {
                if (!Equals(_Covid19Model, value))
                {
                    _Covid19Model = value;
                    RaisePropertyChanged(nameof(Covid19Model));
                }
            }
        }
        
        private List<NinjaCovid19AllModel> _NinjaCovid19Model;
        public List<NinjaCovid19AllModel> NinjaCovid19Model
        {
            get { return _NinjaCovid19Model; }
            set
            {
                if (!Equals(_NinjaCovid19Model, value))
                {
                    _NinjaCovid19Model = value;
                    RaisePropertyChanged(nameof(NinjaCovid19Model));
                }
            }
        }

        private string isVibleSearchBar;
        public string IsVibleSearchBar
        {
            get { return isVibleSearchBar; }
            set
            {
                if (!Equals(isVibleSearchBar, value))
                {
                    isVibleSearchBar = value;
                    RaisePropertyChanged(nameof(IsVibleSearchBar));
                }
            }
        }

        private string _totalCases;
        public string totalCases
        {
            get { return _totalCases; }
            set
            {
                if (!Equals(_totalCases, value))
                {
                    _totalCases = value;
                    RaisePropertyChanged(nameof(totalCases));
                }
            }
        }
        private string _recovered;
        public string Recovered
        {
            get { return _recovered; }
            set
            {
                if (!Equals(_recovered, value))
                {
                    _recovered = value;
                    RaisePropertyChanged(nameof(Recovered));
                }
            }
        }
        private string _deaths;
        public string deaths
        {
            get { return _deaths; }
            set
            {
                if (!Equals(_deaths, value))
                {
                    _deaths = value;
                    RaisePropertyChanged(nameof(deaths));
                }
            }
        }

        private string _activecases;
        public string Activecases
        {
            get { return _activecases; }
            set
            {
                if (!Equals(_activecases, value))
                {
                    _activecases = value;
                    RaisePropertyChanged(nameof(Activecases));
                }
            }
        }

        private string _total;
        public string Total
        {
            get { return _total; }
            set
            {
                if (!Equals(_total, value))
                {
                    _total = value;
                    RaisePropertyChanged(nameof(Total));
                }
            }
        }

        private string _LatestUpdate;
        public string LatestUpdate
        {
            get { return _LatestUpdate; }
            set
            {
                if (!Equals(_LatestUpdate, value))
                {
                    _LatestUpdate = value;
                    RaisePropertyChanged(nameof(LatestUpdate));
                }
            }
        }


        // india Data
        private string _indConfirmerd;
        public string IndConfirmerd
        {
            get { return _indConfirmerd; }
            set
            {
                if (!Equals(_indConfirmerd, value))
                {
                    _indConfirmerd = value;
                    RaisePropertyChanged(nameof(IndConfirmerd));
                }
            }
        }

        private string _indactive;
        public string Indactive
        {
            get { return _indactive; }
            set
            {
                if (!Equals(_indactive, value))
                {
                    _indactive = value;
                    RaisePropertyChanged(nameof(Indactive));
                }
            }
        }

        private string _inddeaths;
        public string Inddeaths
        {
            get { return _inddeaths; }
            set
            {
                if (!Equals(_inddeaths, value))
                {
                    _inddeaths = value;
                    RaisePropertyChanged(nameof(Inddeaths));
                }
            }
        }

        private string _indlastupdatedtime;
        public string Indlastupdatedtime
        {
            get { return _indlastupdatedtime; }
            set
            {
                if (!Equals(_indlastupdatedtime, value))
                {
                    _indlastupdatedtime = value;
                    RaisePropertyChanged(nameof(Indlastupdatedtime));
                }
            }
        }

        private string _indrecovered;
        public string Indrecovered
        {
            get { return _indrecovered; }
            set
            {
                if (!Equals(_indrecovered, value))
                {
                    _indrecovered = value;
                    RaisePropertyChanged(nameof(Indrecovered));
                }
            }
        }


        private string _IndPulsConfirmed;
        public string IndPulsConfirmed
        {
            get { return _IndPulsConfirmed; }
            set
            {
                if (!Equals(_IndPulsConfirmed, value))
                {
                    _IndPulsConfirmed = value;
                    RaisePropertyChanged(nameof(IndPulsConfirmed));
                }
            }
        }

        private string _IndPulsrecoveded;
        public string IndPulsrecoveded
        {
            get { return _IndPulsrecoveded; }
            set
            {
                if (!Equals(_IndPulsrecoveded, value))
                {
                    _IndPulsrecoveded = value;
                    RaisePropertyChanged(nameof(IndPulsrecoveded));
                }
            }
        }

        private string _IndPulsDeceased;
        public string IndPulsDeceased
        {
            get { return _IndPulsDeceased; }
            set
            {
                if (!Equals(_IndPulsDeceased, value))
                {
                    _IndPulsDeceased = value;
                    RaisePropertyChanged(nameof(IndPulsDeceased));
                }
            }
        }

        private async Task getTotalCase()
        {
            Device.BeginInvokeOnMainThread(() => { IsBusy = true; });
            IRestResponse response = await _commonServices.GetTotalCase();
            if (response.StatusCode == HttpStatusCode.OK)
            {

                var totalCae = JsonConvert.DeserializeObject<NinjaCovid19AllModel>(response.Content);
                double total = CommonUtils.ConvertToDouble(totalCae.cases.ToString());
                totalCases = total.ToString("N0", CultureInfo.InvariantCulture) ;

                double recoverd = CommonUtils.ConvertToDouble(totalCae.recovered.ToString());
                Recovered = recoverd.ToString("N0", CultureInfo.InvariantCulture);

                double death = CommonUtils.ConvertToDouble(totalCae.deaths.ToString());
                deaths = death.ToString("N0", CultureInfo.InvariantCulture);

                double active = CommonUtils.ConvertToDouble(totalCae.active.ToString());
                Activecases = active.ToString("N0", CultureInfo.InvariantCulture);

                DateTime start = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                Double db = Convert.ToDouble("1585499881120");
                var CountryUpdatetime = start.AddMilliseconds(totalCae.updated).ToLocalTime();
                LatestUpdate = CountryUpdatetime.ToString("dddd, dd MMMM yyyy HH:mm:ss");

                Application.Current.Properties["total"] = totalCases;
                Application.Current.Properties["Recovered"] = Recovered;
                Application.Current.Properties["deaths"] = deaths;

                Device.BeginInvokeOnMainThread(() => {  IsBusy = false;  });
            }
        }
        private async Task getIndiaData()
        {
            Device.BeginInvokeOnMainThread(() => { IsBusy = true; });
            IRestResponse response = await _commonServices.GetIndiaData();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var totalCae = JsonConvert.DeserializeObject<covid19IndiaModel>(response.Content);

                IndConfirmerd = totalCae.statewise[0].confirmed;
                Indactive = totalCae.statewise[0].active;
                Inddeaths = totalCae.statewise[0].deaths;
                Indlastupdatedtime = totalCae.statewise[0].lastupdatedtime;
                Indrecovered = totalCae.statewise[0].recovered;

                var confi = "[+" +totalCae.statewise[0].deltaconfirmed + "]";
                IndPulsConfirmed = confi;

                var recovered = "[+" + totalCae.statewise[0].deltarecovered + "]";
                IndPulsrecoveded = recovered;

                 var deceased = "[+" + totalCae.statewise[0].deltadeaths + "]";
                IndPulsDeceased = deceased;

                    var casetimeseries = totalCae.cases_time_series;
                    var statewises = totalCae.statewise;
                    var casestested = totalCae.tested;
                    Device.BeginInvokeOnMainThread(() => { IsBusy = false; });
                
            }
        }


        CountriesModel selectedItem;
        public CountriesModel SelectedItem
        {
            get
            {
                return selectedItem;
            }
            set
            {
                if (value == null)
                {
                    selectedItem = value;
                    return;
                }
                else
                {
                    selectedItem = value;
                    GotoDetailScreen();
                    selectedItem = null;
                    RaisePropertyChanged(nameof(SelectedItem));
                }

            }
        }

        public object ItemSelectedCommand { get; private set; }

        private async Task GotoDetailScreen()
        {
            CountriesModel _selectedItem = SelectedItem;
            Application.Current.Properties["SelectedCountryValue"] = JsonConvert.SerializeObject(SelectedItem);
            await Application.Current.SavePropertiesAsync();
            await PushAsync<CountryDetailsPageModel>();
            }
        private async Task viewbyCountryAsync()
        {
            await PushAsync<CountryDetailsPageModel>();
        }
        private async Task viewbyStateAsync()
        {
            await PushAsync<IndiaStateWisePageModel>();
        }
    }
}
