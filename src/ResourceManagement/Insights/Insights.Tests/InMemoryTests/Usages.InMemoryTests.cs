﻿//
// Copyright (c) Microsoft.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using Insights.Tests.Helpers;
using Microsoft.Azure.Insights;
using Microsoft.Azure.Insights.Models;
using Newtonsoft.Json;
using Xunit;

namespace Insights.Tests.InMemoryTests
{
    public class UsagesInMemoryTests : TestBase
    {
        [Fact]
        public void ListUsageTest()
        {
            string resourceUri = "/subscriptions/123456789/resourceGroups/rg/providers/rp/rUri";
            string filterString = "name.value eq 'CPUTime' or name.value eq 'Requests'";

            List<UsageMetric> expectedUsageMetricCollection = GetUsageMetricCollection(resourceUri);

            var internalList = expectedUsageMetricCollection.ToJson();
            var content = string.Concat("{ \"value\":", internalList, ", \"nextLink\":\"\"}");

            var response = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(content)
            };

            var handler = new RecordedDelegatingHandler(response) { StatusCodeToReturn = HttpStatusCode.OK };
            var insightsClient = GetInsightsClient(handler);


            IEnumerable<UsageMetric> actualRespose = insightsClient.UsageMetrics.List(resourceUri: resourceUri, apiVersion: "2014-04-01", odataQuery: filterString);

            AreEqual(expectedUsageMetricCollection, actualRespose.GetEnumerator());
        }

        private static List<UsageMetric> GetUsageMetricCollection(string resourceUri)
        {
            return new List<UsageMetric>()
            {
                new UsageMetric(
                    id: "The id", 
                    currentValue: 10.1, 
                    limit: 100.2, 
                    name: new LocalizableString(
                        localizedValue: "Cpu Percentage",
                        value: "CpuPercentage"),
                    nextResetTime: DateTime.Now.AddDays(1),
                    quotaPeriod: TimeSpan.FromDays(1),
                    unit: Unit.Percent.ToString()
                )
            };
        }

        private static void AreEqual(List<UsageMetric> exp, IEnumerator<UsageMetric> act)
        {
            if (exp != null)
            {
                List<UsageMetric> actList = new List<UsageMetric>();
                while (act.MoveNext())
                {
                    actList.Add(act.Current);
                }

                Assert.Equal(exp.Count, actList.Count);

                for (int i = 0; i < exp.Count; i++)
                {
                    AreEqual(exp[i], actList[i]);
                }
            }
            else
            {
                Assert.Null(act);
            }
        }

        private static void AreEqual(UsageMetric exp, UsageMetric act)
        {
            if (exp != null)
            {
                Assert.Equal(exp.CurrentValue, act.CurrentValue);
                Assert.Equal(exp.Limit, act.Limit);
                Assert.Equal(exp.NextResetTime, act.NextResetTime);
                Assert.Equal(exp.QuotaPeriod, act.QuotaPeriod);
                Assert.Equal(exp.Unit, act.Unit);
                AreEqual(exp.Name, act.Name);
            }
        }
    }
}
