// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Hpc.Rest.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class OperationLogEntry
    {
        /// <summary>
        /// Initializes a new instance of the OperationLogEntry class.
        /// </summary>
        public OperationLogEntry()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationLogEntry class.
        /// </summary>
        /// <param name="severity">Possible values include: 'Error', 'Warning',
        /// 'Information', 'Trace'</param>
        public OperationLogEntry(string message = default(string), string severity = default(string), string source = default(string), System.DateTime? createTime = default(System.DateTime?))
        {
            Message = message;
            Severity = severity;
            Source = source;
            CreateTime = createTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Error', 'Warning',
        /// 'Information', 'Trace'
        /// </summary>
        [JsonProperty(PropertyName = "Severity")]
        public string Severity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Source")]
        public string Source { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CreateTime")]
        public System.DateTime? CreateTime { get; set; }

    }
}