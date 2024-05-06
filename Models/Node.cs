// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Hpc.Rest.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class Node
    {
        /// <summary>
        /// Initializes a new instance of the Node class.
        /// </summary>
        public Node()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Node class.
        /// </summary>
        /// <param name="state">Possible values include: 'Unknown',
        /// 'Provisioning', 'Offline', 'Starting', 'Online', 'Draining',
        /// 'Rejected', 'Removing', 'NotDeployed', 'Stopping'</param>
        /// <param name="health">Possible values include: 'OK', 'Warning',
        /// 'Error', 'Transitional', 'Unapproved'</param>
        public Node(string name = default(string), string state = default(string), string health = default(string), string template = default(string), string location = default(string), double? memorySize = default(double?), double? cores = default(double?), double? sockets = default(double?), string hpcPackVersion = default(string), bool? onAzure = default(bool?), IList<string> groups = default(IList<string>), IList<string> roles = default(IList<string>), IList<string> installedServiceRoles = default(IList<string>), IList<string> activeServiceRoles = default(IList<string>))
        {
            Name = name;
            State = state;
            Health = health;
            Template = template;
            Location = location;
            MemorySize = memorySize;
            Cores = cores;
            Sockets = sockets;
            HpcPackVersion = hpcPackVersion;
            OnAzure = onAzure;
            Groups = groups;
            Roles = roles;
            InstalledServiceRoles = installedServiceRoles;
            ActiveServiceRoles = activeServiceRoles;
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
        /// Gets or sets possible values include: 'Unknown', 'Provisioning',
        /// 'Offline', 'Starting', 'Online', 'Draining', 'Rejected',
        /// 'Removing', 'NotDeployed', 'Stopping'
        /// </summary>
        [JsonProperty(PropertyName = "State")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'OK', 'Warning', 'Error',
        /// 'Transitional', 'Unapproved'
        /// </summary>
        [JsonProperty(PropertyName = "Health")]
        public string Health { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Template")]
        public string Template { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Location")]
        public string Location { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MemorySize")]
        public double? MemorySize { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Cores")]
        public double? Cores { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Sockets")]
        public double? Sockets { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "HpcPackVersion")]
        public string HpcPackVersion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OnAzure")]
        public bool? OnAzure { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Groups")]
        public IList<string> Groups { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Roles")]
        public IList<string> Roles { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "InstalledServiceRoles")]
        public IList<string> InstalledServiceRoles { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ActiveServiceRoles")]
        public IList<string> ActiveServiceRoles { get; set; }

    }
}
