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

    public partial class PersianCat : BaseCat
    {
        /// <summary>
        /// Initializes a new instance of the PersianCat class.
        /// </summary>
        public PersianCat() { }

        /// <summary>
        /// Initializes a new instance of the PersianCat class.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <param name="description">Description of a Animal.</param>
        /// <param name="color">cat color</param>
        /// <param name="size">cat size</param>
        public PersianCat(string id = default(string), string description = default(string), string color = default(string), int? size = default(int?))
            : base(id, description, color)
        {
            Size = size;
        }

        /// <summary>
        /// Gets or sets cat size
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public int? Size { get; set; }

    }
}

