using System.Collections.Generic;
using System.IO;
using xCleanWay.Data.Repositories.Providers.RawModels.Mappers;
using xCleanWay.Data.Repositories.Providers.Rest.Framework;
using xCleanWay.Data.Repositories.Providers.Rest.Response;

namespace xCleanWay.Data.Repositories.Providers.Rest.Host.GroupKt
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
            try
            {
                var response = restFramework
                    .ExecuteGet<GroupKtRestResponse<List<GroupKtCountryModel>>>(BASE_URL, COUNTRY_ROUTE,
                        NoParameters());
                return new GroupKtResponseAdapter<List<GroupKtCountryModel>>(response);
            }
            catch (IOException ioex)
            {
                return new GroupKtResponseAdapter<List<GroupKtCountryModel>>(ResponseStatus.ERROR, ioex.Message);
            }
        }

        protected override IResponseAdapter<GroupKtCountryModel> RequestCountryByISOCode(string isoCode)
        {
            try
            {
                Dictionary<string, string> parameters = new Dictionary<string, string> {{ISO_CODE_KEY, isoCode}};
                var response = restFramework
                    .ExecuteGet<GroupKtRestResponse<GroupKtCountryModel>>(BASE_URL,
                        COUNTRY_ROUTE, parameters);
                return new GroupKtResponseAdapter<GroupKtCountryModel>(response);
            }
            catch (IOException ioex)
            {
                return new GroupKtResponseAdapter<GroupKtCountryModel>(ResponseStatus.ERROR, ioex.Message);
            }
        }
    }
}