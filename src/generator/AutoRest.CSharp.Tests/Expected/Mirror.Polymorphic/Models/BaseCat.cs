// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.MirrorPolymorphic.Models
{
    using Fixtures.MirrorPolymorphic;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class BaseCat : Animal
    {
        /// <summary>
        /// Initializes a new instance of the BaseCat class.
        /// </summary>
        public BaseCat() { }

        /// <summary>
        /// Initializes a new instance of the BaseCat class.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <param name="description">Description of a Animal.</param>
        /// <param name="color">cat color</param>
        public BaseCat(string id = default(string), string description = default(string), string color = default(string))
            : base(id, description)
        {
            Color = color;
        }

        /// <summary>
        /// Gets or sets cat color
        /// </summary>
        [JsonProperty(PropertyName = "color")]
        public string Color { get; set; }

    }
}
