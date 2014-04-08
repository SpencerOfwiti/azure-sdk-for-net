// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Management.Monitoring.Metrics;
using Microsoft.WindowsAzure.Management.Monitoring.Metrics.Models;

namespace Microsoft.WindowsAzure
{
    public static partial class MetricValueOperationsExtensions
    {
        /// <summary>
        /// The List Metric Value operation lists the metric value sets for the
        /// resource metrics.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Monitoring.Metrics.IMetricValueOperations.
        /// </param>
        /// <param name='resourceId'>
        /// Required. The id of the resource.
        /// </param>
        /// <param name='metricNames'>
        /// Required. The names of the metrics.
        /// </param>
        /// <param name='metricNamespace'>
        /// Required. The namespace of the metrics.
        /// </param>
        /// <param name='timeGrain'>
        /// Required. The time grain of the metrics.
        /// </param>
        /// <param name='startTime'>
        /// Required. The start time (in UTC) of the metrics.
        /// </param>
        /// <param name='endTime'>
        /// Required. The end time (in UTC) of the metrics.
        /// </param>
        /// <returns>
        /// The List Metric values operation response.
        /// </returns>
        public static MetricValueListResponse List(this IMetricValueOperations operations, string resourceId, IList<string> metricNames, string metricNamespace, TimeSpan timeGrain, DateTime startTime, DateTime endTime)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IMetricValueOperations)s).ListAsync(resourceId, metricNames, metricNamespace, timeGrain, startTime, endTime);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The List Metric Value operation lists the metric value sets for the
        /// resource metrics.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Monitoring.Metrics.IMetricValueOperations.
        /// </param>
        /// <param name='resourceId'>
        /// Required. The id of the resource.
        /// </param>
        /// <param name='metricNames'>
        /// Required. The names of the metrics.
        /// </param>
        /// <param name='metricNamespace'>
        /// Required. The namespace of the metrics.
        /// </param>
        /// <param name='timeGrain'>
        /// Required. The time grain of the metrics.
        /// </param>
        /// <param name='startTime'>
        /// Required. The start time (in UTC) of the metrics.
        /// </param>
        /// <param name='endTime'>
        /// Required. The end time (in UTC) of the metrics.
        /// </param>
        /// <returns>
        /// The List Metric values operation response.
        /// </returns>
        public static Task<MetricValueListResponse> ListAsync(this IMetricValueOperations operations, string resourceId, IList<string> metricNames, string metricNamespace, TimeSpan timeGrain, DateTime startTime, DateTime endTime)
        {
            return operations.ListAsync(resourceId, metricNames, metricNamespace, timeGrain, startTime, endTime, CancellationToken.None);
        }
    }
}
