namespace Duett.Model
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.2)")]
    public partial class HourRegistration 
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
        public int Id { get; set; }
    
        /// <summary>Your reference</summary>
        [Newtonsoft.Json.JsonProperty("externalId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExternalId { get; set; }
    
        /// <summary>The reference to the master hourRegistration in a group</summary>
        [Newtonsoft.Json.JsonProperty("masterRefId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? MasterRefId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("hourDate", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTimeOffset HourDate { get; set; }
    
        [Newtonsoft.Json.JsonProperty("hourCount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? HourCount { get; set; }
    
        [Newtonsoft.Json.JsonProperty("hourPrice", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? HourPrice { get; set; }
    
        [Newtonsoft.Json.JsonProperty("hoursInvoiced", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? HoursInvoiced { get; set; }
    
        [Newtonsoft.Json.JsonProperty("totalPrice", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalPrice { get; set; }
    
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }
    
        [Newtonsoft.Json.JsonProperty("attestationStatus", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AttestationStatus AttestationStatus { get; set; }
    
        [Newtonsoft.Json.JsonProperty("invoiceStatus", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public InvoiceStatus InvoiceStatus { get; set; }
    
        [Newtonsoft.Json.JsonProperty("salaryStatus", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SalaryStatus SalaryStatus { get; set; }
    
        [Newtonsoft.Json.JsonProperty("articleId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ArticleId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("article", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Article Article { get; set; }
    
        [Newtonsoft.Json.JsonProperty("carriers", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<HourRegistrationCarrier> Carriers { get; set; }
    
        [Newtonsoft.Json.JsonProperty("customerId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? CustomerId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("customer", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Customer Customer { get; set; }
    
        [Newtonsoft.Json.JsonProperty("documentationIds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> DocumentationIds { get; set; }
    
        [Newtonsoft.Json.JsonProperty("rowversion", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long Rowversion { get; set; }
    
    
    }
}