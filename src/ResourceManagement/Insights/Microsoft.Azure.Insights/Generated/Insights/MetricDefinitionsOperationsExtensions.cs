// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Insights
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for MetricDefinitionsOperations.
    /// </summary>
    public static partial class MetricDefinitionsOperationsExtensions
    {
            /// <summary>
            /// Lists the metric definitions for the resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceUri'>
            /// The identifier of the resource.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static System.Collections.Generic.IEnumerable<MetricDefinition> List(this IMetricDefinitionsOperations operations, string resourceUri, Microsoft.Rest.Azure.OData.ODataQuery<MetricDefinition> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<MetricDefinition>))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IMetricDefinitionsOperations)s).ListAsync(resourceUri, odataQuery), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the metric definitions for the resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceUri'>
            /// The identifier of the resource.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<System.Collections.Generic.IEnumerable<MetricDefinition>> ListAsync(this IMetricDefinitionsOperations operations, string resourceUri, Microsoft.Rest.Azure.OData.ODataQuery<MetricDefinition> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<MetricDefinition>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceUri, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
