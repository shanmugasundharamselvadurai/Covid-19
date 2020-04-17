
using Covid19Servics.Interfaces;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19Servics.Services
{
    public class CommonService : ICommonService
    {

        const string baseUrl = ServiceURL.BASEADDRESS;
        const string baseUrlIndia = ServiceURL.BASEADDRESSFORINDIA;
        //Paramater
        const string provianceName = ServiceURL.provinceName;
        const string country = ServiceURL.countries;
        const string all = ServiceURL.all;
        const string IndiaData = ServiceURL.IndiaData;
        const string distictData = ServiceURL.DistrictData;

        public Task<IRestResponse> GetCountries()
        {
            var client = new RestClient(baseUrl + country);
            RestRequest request = new RestRequest() { Method = Method.GET };
            request.Timeout = 10000;
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("Accept", "application/json");
            return client.ExecuteAsync(request);
        }

        public Task<IRestResponse> GetCountryName(string getcountry, string getcountryname)
        {
            var client = new RestClient(baseUrl +"/"+ getcountry+"/"+ getcountryname);
            RestRequest request = new RestRequest() { Method = Method.GET };
            request.Timeout = 10000;
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("Accept", "application/json");
            return client.ExecuteAsync(request);
        }
        public Task<IRestResponse> GetIndiaData()
        {
            var client = new RestClient(baseUrlIndia + IndiaData);
            RestRequest request = new RestRequest() { Method = Method.GET };
            request.Timeout = 10000;
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("Accept", "application/json");
            return client.ExecuteAsync(request);
        }
        public Task<IRestResponse> GetIndiaDistrictData()
        {
            var client = new RestClient(baseUrlIndia + distictData);
            RestRequest request = new RestRequest() { Method = Method.GET };
            request.Timeout = 10000;
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("Accept", "application/json");
            return client.ExecuteAsync(request);
        }

        public Task<IRestResponse> GetprovinceName()
        {
            var client = new RestClient(baseUrl + provianceName);
            RestRequest request = new RestRequest() { Method = Method.GET };
            request.Timeout = 10000;
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("Accept", "application/json");
            return client.ExecuteAsync(request);
        }

        public Task<IRestResponse> GetTotalCase()
        {
            var client = new RestClient(baseUrl+ all);
            RestRequest request = new RestRequest() { Method = Method.GET };
            request.Timeout = 10000;
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("Accept", "application/json");
            return client.ExecuteAsync(request);
        }
    }
}
