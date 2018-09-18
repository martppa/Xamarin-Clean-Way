using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using xCleanWay.Data.Repositories.Providers.RawModels.Mappers;
using xCleanWay.Data.Repositories.Providers.Rest;
using xCleanWay.Remote.Providers.Rest;

namespace xCleanWay.Data.Repositories.Providers.Country.Rest.Host.RestCountries
{
    public class RestCountriesCountryRestApi : CountryRestApi<RestCountriesCountryModel>
    {
        private readonly string BASE_URL = "https://restcountries.eu/";
        private readonly string COUNTRY_ROUTE = "rest/v2/all";
        private readonly string ISO_CODE_KEY = "isoCode";
        
        public RestCountriesCountryRestApi(IRestFramework restFramework, RawCountryMapper rawCountryMapper) 
            : base(restFramework, rawCountryMapper) {}

        protected override IResponseAdapter<List<RestCountriesCountryModel>> RequestCountries()
        {
            try
            {
                var response = restFramework
                    .ExecuteGet<RestCountriesResponse>(BASE_URL,
                        COUNTRY_ROUTE, NoParameters());
                if (response == null)
                    throw new Exception("No data from server");
                return new RestCountriesResponseAdapter(response);
            }
            catch (Exception exception)
            {
                return new RestCountriesResponseAdapter(ResponseStatus.ERROR, exception.Message);
            }
        }

        protected override IResponseAdapter<RestCountriesCountryModel> RequestCountryByISOCode(string iso)
        {
            throw new System.NotImplementedException();
        }
    }
}