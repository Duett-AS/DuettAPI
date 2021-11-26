namespace Duett.Model
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.2)")]
    public partial class CarrierType 
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
        public int Id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("carrierTypeKind", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CarrierTypeKind CarrierTypeKind { get; set; }
    
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; }
    
        [Newtonsoft.Json.JsonProperty("usedInAccounting", Required = Newtonsoft.Json.Required.Always)]
        public bool UsedInAccounting { get; set; }
    
        [Newtonsoft.Json.JsonProperty("usedInHour", Required = Newtonsoft.Json.Required.Always)]
        public bool UsedInHour { get; set; }
    
        [Newtonsoft.Json.JsonProperty("usedInInvoice", Required = Newtonsoft.Json.Required.Always)]
        public bool UsedInInvoice { get; set; }
    
        [Newtonsoft.Json.JsonProperty("usedInLedger", Required = Newtonsoft.Json.Required.Always)]
        public bool UsedInLedger { get; set; }
    
        [Newtonsoft.Json.JsonProperty("usedInSalary", Required = Newtonsoft.Json.Required.Always)]
        public bool UsedInSalary { get; set; }
    
        [Newtonsoft.Json.JsonProperty("carriers", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Carrier> Carriers { get; set; }
    
        [Newtonsoft.Json.JsonProperty("rowversion", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long Rowversion { get; set; }
    
    
    }
}