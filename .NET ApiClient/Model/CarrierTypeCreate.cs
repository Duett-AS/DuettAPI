namespace Duett.Model
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.2)")]
    public partial class CarrierTypeCreate 
    {
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(250)]
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
    
    
    }
}