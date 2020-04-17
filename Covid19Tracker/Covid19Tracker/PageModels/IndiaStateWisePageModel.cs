using Covid19Servics.Interfaces;
using Covid19Servics.Services;
using Covid19Tracker.Base;
using Covid19Tracker.Models;
using Covid19Tracker.Util;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Net;
using System.Text;
using System.Linq;
using Xamarin.Forms;
using Newtonsoft.Json.Linq;

namespace Covid19Tracker.PageModels
{
  public class IndiaStateWisePageModel: BasePageModel
    {
        readonly ICommonService _commonServices;
        public ObservableCollection<covid19IndiaModel> covid19indiaDataDetail { get; set; }
        public ObservableCollection<Statewise> countryDetailsModel { get; set; }

        public IndiaStateWisePageModel()
        {
            _commonServices = new CommonService();
            GetCountryListcases();
            covid19indiaDataDetail = new ObservableCollection<covid19IndiaModel>();
            countryDetailsModel = new ObservableCollection<Statewise>();
        }


        private string _TextValue;
        public string TextValue
        {
            get { return _TextValue; }
            set { if (!Equals(_TextValue, value)) { _TextValue = value; RaisePropertyChanged(nameof(TextValue)); } }
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


        private string _SearchSatesText;
        public string SearchSatesText
        {
            get
            { return _SearchSatesText; }
            set
            {
                if (!Equals(_SearchSatesText, value))
                {
                    _SearchSatesText = value;
                    Search();
                    RaisePropertyChanged(nameof(SearchSatesText));
                }
            }
        }

        private async void GetCountryListcases()
        {
           // Device.BeginInvokeOnMainThread(() => { IsBusy = true; });
            IRestResponse response = await _commonServices.GetIndiaData();
            if (response.StatusCode == HttpStatusCode.OK)
            {
               covid19IndiaModel totalCae = JsonConvert.DeserializeObject <covid19IndiaModel> (response.Content);
                var state = totalCae.statewise;
                totalCae.statewise.RemoveAt(0);
                
                foreach(var data in state)
                {

                    var confi = "+ " + data.confirmed + "";
                    var recovered = "+ " + data.recovered + "";
                    var deceased = "+ " + data.deaths + "";
                 
                    countryDetailsModel.Add(new Statewise()
                    {
                        state = data.state,
                        confirmed = confi,
                        recovered = recovered,
                        active = data.active,
                        deaths = deceased,
                        lastupdatedtime = data.lastupdatedtime,
                    });
                   }
                //var keyvalues = totalCae.key_values;
                //var statewises = totalCae.statewise;
                //var casestested = totalCae.tested;
            }
        }

        private void Search()
        {
            if (string.IsNullOrWhiteSpace(SearchSatesText))
            {
                countryDetailsModel.Clear();
                GetCountryListcases();
                countryDetailsModel.Clear();
            }
            else
            {
                var stateSearch = countryDetailsModel.Where(c => c.state.ToLower().StartsWith(SearchSatesText.ToLower())).ToList();
                countryDetailsModel.Clear();
                foreach (var states in stateSearch)
                countryDetailsModel.Add(states);
            }
        }
    }
}
