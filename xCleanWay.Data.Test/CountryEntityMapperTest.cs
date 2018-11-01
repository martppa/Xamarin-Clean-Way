/*
 * Copyright 2018 Humberto Martín Dieppa, Open source project
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
 
using System.Collections.Generic;
using NUnit.Framework;
using xCleanWay.Core.Models;
using xCleanWay.Data.Entities;
using xCleanWay.Data.Entities.Mappers;
using xCleanWay.Data.Repositories.Providers.Rest.Host.RestCountries;

namespace xCleanWay.Data.Test
{
    [TestFixture]
    public class CountryEntityMapperTest

    {
        private const string
            FAKE_NAME = "FakeName",
            FAKE_CODE = "FakeCode",
            FAKE_FLAG = "FakeFlag";


        private CountryEntityMapper countryEntityMapper;


        public CountryEntityMapperTest()

        {
            countryEntityMapper = new CountryEntityMapper();
        }


        [Test]
        public void TestSingleTransform()
        {
            Country transformedCountry = countryEntityMapper.Transform(CreateFakeCountryEntity(0));
            Assert.IsTrue(transformedCountry.Name.Equals(FAKE_NAME + 0)
                          && transformedCountry.IsoCode.Equals(FAKE_CODE + 0)
                          && transformedCountry.FlagUrl.Equals(FAKE_FLAG + 0));
        }

        [Test]
        public void TestCollectionTransform()
        {
            IList<ICountryEntity> countryEntityList = new List<ICountryEntity>
            {
                CreateFakeCountryEntity(0),
                CreateFakeCountryEntity(1),
                CreateFakeCountryEntity(2)
            };

            IList<Country> transformCountryList = countryEntityMapper.Transform(countryEntityList);

            for (var i = 0; i < 3; i++)
            {
                Assert.True(transformCountryList[i].Name.Equals(FAKE_NAME + i)
                            && transformCountryList[i].IsoCode.Equals(FAKE_CODE + i)
                            && transformCountryList[i].FlagUrl.Equals(FAKE_FLAG + i));
            }
        }

        private ICountryEntity CreateFakeCountryEntity(int i)
        {
            return new RestCountriesCountryModel(FAKE_NAME + i, FAKE_CODE + i, FAKE_FLAG + i);
        }
    }
}