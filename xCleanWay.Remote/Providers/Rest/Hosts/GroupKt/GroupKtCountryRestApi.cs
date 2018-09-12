using System.Collections.Generic;
using System.Collections.ObjectModel;
using xCleanWay.Remote.Providers.Rest.Country;
using xCleanWay.Remote.RawModels;
using xCleanWay.Remote.RawModels.Mappers;

namespace xCleanWay.Remote.Providers.Rest.Hosts.GroupKt
{
    public class GroupKtCountryRestApi : CountryRestApi<GroupKtCountryModel>
    {
        private readonly string BASE_URL = "http://services.groupkt.com/";
        private readonly string COUNTRY_ROUTE = "country/get/all";
        private readonly string ISO_CODE_KEY = "isoCode";
            
        public GroupKtCountryRestApi(IRestFramework restFramework, RawCountryMapper rawCountryMapper) 
            : base(restFramework, rawCountryMapper) {}

        protected override IResponseAdapter<Collection<GroupKtCountryModel>> RequestCountries()
        {
            var respose = restFramework
                .ExecuteGet<GroupKtRestResponse<Collection<GroupKtCountryModel>>>(BASE_URL, COUNTRY_ROUTE, NoParameters());
            return new GroupKtResponseAdapter<Collection<GroupKtCountryModel>>(respose);
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