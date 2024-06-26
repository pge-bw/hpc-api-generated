// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Hpc.Rest.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class NodeStatOfStateItem
    {
        /// <summary>
        /// Initializes a new instance of the NodeStatOfStateItem class.
        /// </summary>
        public NodeStatOfStateItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NodeStatOfStateItem class.
        /// </summary>
        /// <param name="name">Possible values include: 'Unknown',
        /// 'Provisioning', 'Offline', 'Starting', 'Online', 'Draining',
        /// 'Rejected', 'Removing', 'NotDeployed', 'Stopping'</param>
        public NodeStatOfStateItem(string name = default(string), double? value = default(double?))
        {
            Name = name;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'Unknown', 'Provisioning',
        /// 'Offline', 'Starting', 'Online', 'Draining', 'Rejected',
        /// 'Removing', 'NotDeployed', 'Stopping'
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Value")]
        public double? Value { get; set; }

    }
}
