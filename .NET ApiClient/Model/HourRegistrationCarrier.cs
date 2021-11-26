namespace Duett.Model
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.2)")]
    public partial class HourRegistrationCarrier 
    {
        [Newtonsoft.Json.JsonProperty("hourRegistrationId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int HourRegistrationId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("hourRegistration", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public HourRegistration HourRegistration { get; set; }
    
        [Newtonsoft.Json.JsonProperty("carrierId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int CarrierId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("carrier", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Carrier Carrier { get; set; }
    
    
    }
}