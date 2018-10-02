using System.Collections.Generic;
using System.IO;
using System.Linq;
using xCleanWay.Data.Entities;
using xCleanWay.Data.Repositories.Providers.Rest.Framework;
using xCleanWay.Data.Repositories.Providers.Rest.Response;

namespace xCleanWay.Data.Repositories.Providers.Rest.Country
{
    public abstract class CountryRestApi<Entity> : ICountryRestApi where Entity : ICountryEntity
    {
        protected readonly IRestFramework restFramework;
        
        protected CountryRestApi(IRestFramework restFramework)
        {
            this.restFramework = restFramework;
        }
        
        public List<ICountryEntity> GetCountries()
        {
            var responseAdapter = RequestCountries();
            AssertRequestWasSuccessful(responseAdapter);
            return responseAdapter.GetContent()
                .Select(item => (ICountryEntity) item).ToList();
        }

        public ICountryEntity GetCountryByISOCode(string isoCode)
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