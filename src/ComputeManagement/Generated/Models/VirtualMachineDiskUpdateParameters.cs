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

namespace Microsoft.WindowsAzure.Management.Compute.Models
{
    /// <summary>
    /// Parameters supplied to the Update Virtual Disk Image operation.
    /// </summary>
    public partial class VirtualMachineDiskUpdateParameters
    {
        private bool? _hasOperatingSystem;
        
        /// <summary>
        /// Optional. Specifies whether the disk contains an operating system.
        /// Note: Only a disk with an operating system installed can be
        /// mounted as OS Drive.
        /// </summary>
        public bool? HasOperatingSystem
        {
            get { return this._hasOperatingSystem; }
            set { this._hasOperatingSystem = value; }
        }
        
        private string _label;
        
        /// <summary>
        /// Required. Specifies the friendly name of the disk.
        /// </summary>
        public string Label
        {
            get { return this._label; }
            set { this._label = value; }
        }
        
        private Uri _mediaLinkUri;
        
        /// <summary>
        /// Optional. Specifies the location of the blob in Azure storage. The
        /// blob location must belong to a storage account in the subscription
        /// specified by the SubscriptionId value in the operation call.
        /// Example: http://example.blob.core.windows.net/disks/mydisk.vhd.
        /// </summary>
        public Uri MediaLinkUri
        {
            get { return this._mediaLinkUri; }
            set { this._mediaLinkUri = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Required. Specifies a name for the disk. Azure uses the name to
        /// identify the disk when creating virtual machines from the disk.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private string _operatingSystemType;
        
        /// <summary>
        /// Optional. The operating system type of the disk. Possible values
        /// are: Linux or Windows.
        /// </summary>
        public string OperatingSystemType
        {
            get { return this._operatingSystemType; }
            set { this._operatingSystemType = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineDiskUpdateParameters class.
        /// </summary>
        public VirtualMachineDiskUpdateParameters()
        {
        }
    }
}
