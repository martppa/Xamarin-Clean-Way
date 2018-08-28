using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using xCleanWay.Remote.RawModels;
using xCleanWay.Remote.RawModels.Mappers;

namespace xCleanWay.Remote.Providers.Rest.Country
{
    public abstract class CountryRestApi<Entity> : ICountryRestApi where Entity : RawCountry
    {
        protected IRestFramework restFramework;
        private RawCountryMapper rawCountryMapper;
        
        protected CountryRestApi(IRestFramework restFramework, RawCountryMapper rawCountryMapper)
        {
            this.restFramework = restFramework;
            this.rawCountryMapper = rawCountryMapper;
        }
        
        public Collection<RawCountry> GetCountries()
        {
            var responseAdapter = RequestCountries();
            AssertRequestWasSuccessful(responseAdapter);
            return rawCountryMapper.Transform(responseAdapter.GetContent());
        }

        public RawCountry GetCountryByISOCode(string isoCode)
        {
            var responseAdapter = RequestCountryByISOCode(isoCode);
            AssertRequestWasSuccessful(responseAdapter);
            return responseAdapter.GetContent();
        }

        protected abstract IResponseAdapter<Collection<Entity>> RequestCountries();
        protected abstract IResponseAdapter<Entity> RequestCountryByISOCode(string iso);

        private void AssertRequestWasSuccessful<T>(IResponseAdapter<T> responseAdapter)
        {
            if (responseAdapter.GetStatus() != ResponseStatus.OK)
                throw new IOException(responseAdapter.GetErrorMessage());
        }
        
        protected Dictionary<string, string> NoParameters()
        {
            return new Dictionary<string, string>();
        }
    }
}