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

    public partial class MetricData
    {
        /// <summary>
        /// Initializes a new instance of the MetricData class.
        /// </summary>
        public MetricData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MetricData class.
        /// </summary>
        public MetricData(string metricName = default(string), System.DateTime? fromTime = default(System.DateTime?), System.DateTime? toTime = default(System.DateTime?), IList<MetricInstanceData> instances = default(IList<MetricInstanceData>))
        {
            MetricName = metricName;
            FromTime = fromTime;
            ToTime = toTime;
            Instances = instances;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MetricName")]
        public string MetricName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FromTime")]
        public System.DateTime? FromTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ToTime")]
        public System.DateTime? ToTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Instances")]
        public IList<MetricInstanceData> Instances { get; set; }

    }
}
