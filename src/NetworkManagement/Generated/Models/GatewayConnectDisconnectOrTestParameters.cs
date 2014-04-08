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
using System.Linq;
using Microsoft.WindowsAzure.Management.Network.Models;

namespace Microsoft.WindowsAzure.Management.Network.Models
{
    /// <summary>
    /// The parameters for the Connect, Disconnect, or Test request
    /// </summary>
    public partial class GatewayConnectDisconnectOrTestParameters
    {
        private string _iPAddress;
        
        /// <summary>
        /// Optional. Required if operation is set to Test; otherwise not used.
        /// Specifies the IP address of the target local network site with
        /// which the gateway will test connectivity.
        /// </summary>
        public string IPAddress
        {
            get { return this._iPAddress; }
            set { this._iPAddress = value; }
        }
        
        private GatewayConnectionUpdateOperation _operation;
        
        /// <summary>
        /// Required. Specifies the operation to perform on the connection. Can
        /// be set to Connect, Disconnect, or Test to connect to a local
        /// network, disconnect from a local network, or test the gateway’s
        /// connection to a local network site.
        /// </summary>
        public GatewayConnectionUpdateOperation Operation
        {
            get { return this._operation; }
            set { this._operation = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// GatewayConnectDisconnectOrTestParameters class.
        /// </summary>
        public GatewayConnectDisconnectOrTestParameters()
        {
        }
    }
}
