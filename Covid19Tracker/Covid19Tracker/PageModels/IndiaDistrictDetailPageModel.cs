using Covid19Servics.Interfaces;
using Covid19Servics.Services;
using Covid19Tracker.Base;
using Covid19Tracker.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Covid19Tracker.PageModels
{
    public class IndiaDistrictDetailPageModel : BasePageModel
    {
        readonly ICommonService _commonServices;
        public ObservableCollection<Covid19IdistrictModel> districtList { get; set; }
        public IndiaDistrictDetailPageModel()
        {
            _commonServices = new CommonService();
            districtList = new ObservableCollection<Covid19IdistrictModel>();
            Task.Run(GetCountryListcases);
        }

        private async void GetCountryListcases()
        {
            // Device.BeginInvokeOnMainThread(() => { IsBusy = true; });
            IRestResponse response = await _commonServices.GetIndiaDistrictData();
            if (response.StatusCode == HttpStatusCode.OK)
            {
               var DistrictData = JsonConvert.DeserializeObject <List<Covid19IdistrictModel>>(response.Content);
               foreach (var data in DistrictData)
                {
                    districtList.Add(new Covid19IdistrictModel()
                    {
                        Kerala = data.Kerala,
                        TamilNadu = data.TamilNadu,
                    });
                }
            }
        }
    }
}
