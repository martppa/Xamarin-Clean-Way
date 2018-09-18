using System.Collections.Generic;
using System.Collections.ObjectModel;
using xCleanWay.Data.Repositories.Providers.RawModels.Mappers;
using xCleanWay.Data.Repositories.Providers.Rest;
using xCleanWay.Remote.Providers.Rest;
using xCleanWay.Remote.Providers.Rest.Hosts.GroupKt;

namespace xCleanWay.Data.Repositories.Providers.Country.Rest.Host.GroupKt
{
    public class GroupKtCountryRestApi : CountryRestApi<GroupKtCountryModel>
    {
        private readonly string BASE_URL = "http://services.groupkt.com/";
        private readonly string COUNTRY_ROUTE = "country/get/all";
        private readonly string ISO_CODE_KEY = "isoCode";
            
        public GroupKtCountryRestApi(IRestFramework restFramework, RawCountryMapper rawCountryMapper) 
            : base(restFramework, rawCountryMapper) {}

        protected override IResponseAdapter<List<GroupKtCountryModel>> RequestCountries()
        {
            var respose = restFramework
                .ExecuteGet<GroupKtRestResponse<List<GroupKtCountryModel>>>(BASE_URL, COUNTRY_ROUTE, NoParameters());
            return new GroupKtResponseAdapter<List<GroupKtCountryModel>>(respose);
        }

        protected override IResponseAdapter<GroupKtCountryModel> RequestCountryByISOCode(string isoCode)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string> {{ISO_CODE_KEY, isoCode}};
            var response = restFramework
                .ExecuteGet<GroupKtRestResponse<GroupKtCountryModel>>(BASE_URL, 
                    COUNTRY_ROUTE, parameters);
            return new GroupKtResponseAdapter<GroupKtCountryModel>(response);
        }
    }
}