// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.Azure.AcceptanceTestsAzureParameterGrouping.Models
{
    using System.Linq;

    /// <summary>
    /// Additional parameters for the parameterGrouping_postMultiParamGroups
    /// operation.
    /// </summary>
    public partial class ParameterGroupingPostMultiParamGroupsSecondParamGroup
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ParameterGroupingPostMultiParamGroupsSecondParamGroup class.
        /// </summary>
        public ParameterGroupingPostMultiParamGroupsSecondParamGroup() { }

        /// <summary>
        /// Initializes a new instance of the
        /// ParameterGroupingPostMultiParamGroupsSecondParamGroup class.
        /// </summary>
        /// <param name="queryTwo">Query parameter with default</param>
        public ParameterGroupingPostMultiParamGroupsSecondParamGroup(System.String headerTwo = default(System.String), System.Int32? queryTwo = default(System.Int32?))
        {
            HeaderTwo = headerTwo;
            QueryTwo = queryTwo;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "")]
        public System.String HeaderTwo { get; set; }

        /// <summary>
        /// Gets or sets query parameter with default
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "")]
        public System.Int32? QueryTwo { get; set; }

    }
}
