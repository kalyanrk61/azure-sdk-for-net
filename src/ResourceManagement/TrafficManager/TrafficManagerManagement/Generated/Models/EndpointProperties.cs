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

namespace Microsoft.Azure.Management.TrafficManager.Models
{
    /// <summary>
    /// Class containing the properties of a Traffic Manager endpoint.
    /// </summary>
    public partial class EndpointProperties
    {
        private string _endpointLocation;
        
        /// <summary>
        /// Optional. Specifies the location of the external or nested
        /// endpoints when using the ‘Performance’ traffic routing method.
        /// </summary>
        public string EndpointLocation
        {
            get { return this._endpointLocation; }
            set { this._endpointLocation = value; }
        }
        
        private string _endpointMonitorStatus;
        
        /// <summary>
        /// Optional. Gets or sets the monitoring status of the endpoint.
        /// </summary>
        public string EndpointMonitorStatus
        {
            get { return this._endpointMonitorStatus; }
            set { this._endpointMonitorStatus = value; }
        }
        
        private string _endpointStatus;
        
        /// <summary>
        /// Optional. Gets or sets the status of the endpoint..  If the
        /// endpoint is Enabled, it is probed for endpoint health and is
        /// included in the traffic routing method.  Possible values are
        /// 'Enabled' and 'Disabled'.
        /// </summary>
        public string EndpointStatus
        {
            get { return this._endpointStatus; }
            set { this._endpointStatus = value; }
        }
        
        private uint? _priority;
        
        /// <summary>
        /// Optional. Gets or sets the priority of this endpoint when using the
        /// ‘Priority’ traffic routing method. Possible values are from 1 to
        /// 1000, lower values represent higher priority. This is an optional
        /// parameter.  If specified, it must be specified on all endpoints,
        /// and no two endpoints can share the same priority value.
        /// </summary>
        public uint? Priority
        {
            get { return this._priority; }
            set { this._priority = value; }
        }
        
        private string _target;
        
        /// <summary>
        /// Optional. Gets or sets the fully-qualified DNS name of the
        /// endpoint.  Traffic Manager returns this value in DNS responses to
        /// direct traffic to this endpoint.
        /// </summary>
        public string Target
        {
            get { return this._target; }
            set { this._target = value; }
        }
        
        private string _targetResourceId;
        
        /// <summary>
        /// Optional. Gets or sets the Azure Resource URI of the of the
        /// endpoint.  Not applicable to endpoints of type 'ExternalEndpoints'.
        /// </summary>
        public string TargetResourceId
        {
            get { return this._targetResourceId; }
            set { this._targetResourceId = value; }
        }
        
        private uint? _weight;
        
        /// <summary>
        /// Optional. Gets or sets the weight of this endpoint when using the
        /// 'Weighted' traffic routing method. Possible values are from 1 to
        /// 1000.
        /// </summary>
        public uint? Weight
        {
            get { return this._weight; }
            set { this._weight = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the EndpointProperties class.
        /// </summary>
        public EndpointProperties()
        {
        }
    }
}
