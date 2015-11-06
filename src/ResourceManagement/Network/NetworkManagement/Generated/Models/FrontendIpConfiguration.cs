// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Frontend IP address of the load balancer
    /// </summary>
    public partial class FrontendIPConfiguration : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the FrontendIPConfiguration class.
        /// </summary>
        public FrontendIPConfiguration() { }

        /// <summary>
        /// Initializes a new instance of the FrontendIPConfiguration class.
        /// </summary>
        public FrontendIPConfiguration(string name = default(string), string etag = default(string), string privateIPAddress = default(string), string privateIPAllocationMethod = default(string), SubResource subnet = default(SubResource), SubResource publicIPAddress = default(SubResource), IList<SubResource> inboundNatRules = default(IList<SubResource>), IList<SubResource> inboundNatPools = default(IList<SubResource>), IList<SubResource> outboundNatRules = default(IList<SubResource>), IList<SubResource> loadBalancingRules = default(IList<SubResource>), string provisioningState = default(string))
        {
            Name = name;
            Etag = etag;
            PrivateIPAddress = privateIPAddress;
            PrivateIPAllocationMethod = privateIPAllocationMethod;
            Subnet = subnet;
            PublicIPAddress = publicIPAddress;
            InboundNatRules = inboundNatRules;
            InboundNatPools = inboundNatPools;
            OutboundNatRules = outboundNatRules;
            LoadBalancingRules = loadBalancingRules;
            ProvisioningState = provisioningState;
        }

        /// <summary>
        /// Gets name of the resource that is unique within a resource group.
        /// This name can be used to access the resource
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// A unique read-only string that changes whenever the resource is
        /// updated
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Gets or sets the IP address of the Load Balancer.This is only
        /// specified if a specific private IP address shall be allocated
        /// from the subnet specified in subnetRef
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateIPAddress")]
        public string PrivateIPAddress { get; set; }

        /// <summary>
        /// Gets or sets PrivateIP allocation method (Static/Dynamic).
        /// Possible values for this property include: 'Static', 'Dynamic'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateIPAllocationMethod")]
        public string PrivateIPAllocationMethod { get; set; }

        /// <summary>
        /// Gets or sets the reference of the subnet resource.A subnet from
        /// wher the load balancer gets its private frontend address
        /// </summary>
        [JsonProperty(PropertyName = "properties.subnet")]
        public SubResource Subnet { get; set; }

        /// <summary>
        /// Gets or sets the reference of the PublicIP resource
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicIPAddress")]
        public SubResource PublicIPAddress { get; set; }

        /// <summary>
        /// Read only.Inbound rules URIs that use this frontend IP
        /// </summary>
        [JsonProperty(PropertyName = "properties.inboundNatRules")]
        public IList<SubResource> InboundNatRules { get; set; }

        /// <summary>
        /// Read only.Inbound pools URIs that use this frontend IP
        /// </summary>
        [JsonProperty(PropertyName = "properties.inboundNatPools")]
        public IList<SubResource> InboundNatPools { get; set; }

        /// <summary>
        /// Read only.Outbound rules URIs that use this frontend IP
        /// </summary>
        [JsonProperty(PropertyName = "properties.outboundNatRules")]
        public IList<SubResource> OutboundNatRules { get; set; }

        /// <summary>
        /// Gets Load Balancing rules URIs that use this frontend IP
        /// </summary>
        [JsonProperty(PropertyName = "properties.loadBalancingRules")]
        public IList<SubResource> LoadBalancingRules { get; set; }

        /// <summary>
        /// Gets or sets Provisioning state of the PublicIP resource
        /// Updating/Deleting/Failed
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

    }
}
