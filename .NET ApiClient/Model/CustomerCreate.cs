namespace Duett.Model
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.2)")]
    public partial class CustomerCreate 
    {
        [Newtonsoft.Json.JsonProperty("externalId", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string ExternalId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("vatNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string VatNumber { get; set; }
    
        [Newtonsoft.Json.JsonProperty("bankAccountNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BankAccountNumber { get; set; }
    
        [Newtonsoft.Json.JsonProperty("invoiceEmail", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InvoiceEmail { get; set; }
    
        [Newtonsoft.Json.JsonProperty("hourAttestationMobile", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HourAttestationMobile { get; set; }
    
        [Newtonsoft.Json.JsonProperty("address", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public StreetAddress Address { get; set; } = new StreetAddress();
    
        [Newtonsoft.Json.JsonProperty("contactInfo", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Contact ContactInfo { get; set; } = new Contact();
    
        [Newtonsoft.Json.JsonProperty("contactPerson", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ContactPerson ContactPerson { get; set; }
    
    
    }
}