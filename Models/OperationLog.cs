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

    public partial class OperationLog
    {
        /// <summary>
        /// Initializes a new instance of the OperationLog class.
        /// </summary>
        public OperationLog()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationLog class.
        /// </summary>
        public OperationLog(string id = default(string), string name = default(string), string state = default(string), string operatorProperty = default(string), string node = default(string), bool? cancelable = default(bool?), System.DateTime? updateTime = default(System.DateTime?), IList<OperationLogEntry> entries = default(IList<OperationLogEntry>))
        {
            Id = id;
            Name = name;
            State = state;
            OperatorProperty = operatorProperty;
            Node = node;
            Cancelable = cancelable;
            UpdateTime = updateTime;
            Entries = entries;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "State")]
        public string State { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Operator")]
        public string OperatorProperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Node")]
        public string Node { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Cancelable")]
        public bool? Cancelable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UpdateTime")]
        public System.DateTime? UpdateTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Entries")]
        public IList<OperationLogEntry> Entries { get; set; }

    }
}
