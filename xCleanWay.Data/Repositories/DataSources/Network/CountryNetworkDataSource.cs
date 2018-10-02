﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reactive.Linq;
using xCleanWay.Data.Entities;
using xCleanWay.Data.Repositories.Providers;

namespace xCleanWay.Data.Repositories.DataSources.Network
{
    public class CountryNetworkDataSource : ICountryDataSource
    {
        private readonly ICountryProvider countryProvider;
        
        public CountryNetworkDataSource(ICountryProvider countryProvider)
        {
            this.countryProvider = countryProvider;
        }
        
        public IObservable<List<ICountryEntity>> GetCountries()
        {
            return Observable.Create<List<ICountryEntity>>(emitter =>
            {
                var countryEntities = countryProvider.GetCountries();
                emitter.OnNext(countryEntities);
                emitter.OnCompleted();
                return () => { };
                
            });
        }

        public IObservable<ICountryEntity> getCountryByISOCode(string isoCode)
        {
            return Observable.Create<ICountryEntity>(emitter =>
            {
                var countryEntity = countryProvider.GetCountryByISOCode(isoCode);
                emitter.OnNext(countryEntity);
                emitter.OnCompleted();
                return () => { };
            });
        }
    }
}