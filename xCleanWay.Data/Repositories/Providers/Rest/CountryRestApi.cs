using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using xCleanWay.Data.Repositories.Providers.RawModels;
using xCleanWay.Data.Repositories.Providers.RawModels.Mappers;
using xCleanWay.Data.Repositories.Providers.Rest.Framework;
using xCleanWay.Data.Repositories.Providers.Rest.Response;

namespace xCleanWay.Data.Repositories.Providers.Rest
{
    public abstract class CountryRestApi<Entity> : ICountryRestApi where Entity : RawCountry
    {
        protected readonly IRestFramework restFramework;
        private readonly RawCountryMapper rawCountryMapper;
        
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

        protected abstract IResponseAdapter<List<Entity>> RequestCountries();
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