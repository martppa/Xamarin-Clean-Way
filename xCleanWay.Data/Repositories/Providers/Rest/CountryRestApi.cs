﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using xCleanWay.Data.Entities;
using xCleanWay.Data.Repositories.Providers.Rest.Framework;
using xCleanWay.Data.Repositories.Providers.Rest.Response;

namespace xCleanWay.Data.Repositories.Providers.Rest
{
    public abstract class CountryRestApi<Entity> : ICountryRestApi where Entity : ICountryEntity
    {
        protected readonly IRestFramework restFramework;
        
        protected CountryRestApi(IRestFramework restFramework)
        {
            this.restFramework = restFramework;
        }
        
        public Collection<ICountryEntity> GetCountries()
        {
            var responseAdapter = RequestCountries();
            AssertRequestWasSuccessful(responseAdapter);
            var content = responseAdapter.GetContent();
            var transformedCollection = new Collection<ICountryEntity>();
            foreach (var entity in content)
            {
                transformedCollection.Add(entity);
            }

            return transformedCollection;
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