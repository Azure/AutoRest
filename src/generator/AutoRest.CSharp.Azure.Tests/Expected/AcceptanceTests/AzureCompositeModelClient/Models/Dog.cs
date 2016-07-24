// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AcceptanceTestsAzureCompositeModelClient.Models
{
    using System.Linq;

    public partial class Dog : Pet
    {
        /// <summary>
        /// Initializes a new instance of the Dog class.
        /// </summary>
        public Dog() { }

        /// <summary>
        /// Initializes a new instance of the Dog class.
        /// </summary>
        public Dog(System.Int32? id = default(System.Int32?), System.String name = default(System.String), System.String food = default(System.String))
            : base(id, name)
        {
            Food = food;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "food")]
        public System.String Food { get; set; }

    }
}
