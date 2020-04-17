using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19Servics.Interfaces
{
   public interface ICommonService
   {
        Task<IRestResponse> GetprovinceName();
        Task<IRestResponse> GetCountries();
        Task<IRestResponse> GetTotalCase();
        Task<IRestResponse> GetCountryName(string getcountry,string getcountryname);
        Task<IRestResponse> GetIndiaData();
        Task<IRestResponse> GetIndiaDistrictData();
    }
}
