// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Hpc.Rest.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class MetricDefinition
    {
        /// <summary>
        /// Initializes a new instance of the MetricDefinition class.
        /// </summary>
        public MetricDefinition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MetricDefinition class.
        /// </summary>
        public MetricDefinition(string name = default(string), string displayName = default(string), string description = default(string))
        {
            Name = name;
            DisplayName = displayName;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DisplayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

    }
}