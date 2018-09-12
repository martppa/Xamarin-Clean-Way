using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using xCleanWay.Remote.Providers.Rest.Country;
using xCleanWay.Remote.RawModels.Mappers;

namespace xCleanWay.Remote.Providers.Rest.Hosts.RestCountries
{
    public class RestCountriesCountryRestApi : CountryRestApi<RestCountriesCountryModel>
    {
        private readonly string BASE_URL = "https://restcountries.eu/";
        private readonly string COUNTRY_ROUTE = "rest/v2/all";
        private readonly string ISO_CODE_KEY = "isoCode";
        
        public RestCountriesCountryRestApi(IRestFramework restFramework, RawCountryMapper rawCountryMapper) 
            : base(restFramework, rawCountryMapper) {}

        protected override IResponseAdapter<Collection<RestCountriesCountryModel>> RequestCountries()
        {
            RestCountriesResponse<Collection<RestCountriesCountryModel>> response;
            try
            {
                var data = restFramework
                    .ExecuteGet<List<RestCountriesCountryModel>>(BASE_URL,
                        COUNTRY_ROUTE, NoParameters());
                if (data == null)
                    throw new Exception("No data from server");
                var countries = new Collection<RestCountriesCountryModel>(data);
                response = new RestCountriesResponse<Collection<RestCountriesCountryModel>>(ResponseStatus.OK, countries);
            }
            catch (Exception exception)
            {
                response = new RestCountriesResponse
                    <Collection<RestCountriesCountryModel>>(ResponseStatus.ERROR, exception.Message);
            }

            return new RestCountriesResponseAdapter<Collection<RestCountriesCountryModel>>(response);
        }

        protected override IResponseAdapter<RestCountriesCountryModel> RequestCountryByISOCode(string iso)
        {
            throw new System.NotImplementedException();
        }
    }
}