// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace BatchManagement.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for PoolAllocationMode.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PoolAllocationMode
    {
        [EnumMember(Value = "BatchService")]
        BatchService,
        [EnumMember(Value = "UserSubscription")]
        UserSubscription
    }
}
