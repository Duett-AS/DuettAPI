namespace Duett.Model
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.2)")]
    public partial class HourRegistrationDocumentCreate 
    {
        [Newtonsoft.Json.JsonProperty("fileName", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string FileName { get; set; }
    
        [Newtonsoft.Json.JsonProperty("fileData", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public byte[] FileData { get; set; }
    
        [Newtonsoft.Json.JsonProperty("hourRegistrationId", Required = Newtonsoft.Json.Required.Always)]
        public int HourRegistrationId { get; set; }
    
    
    }
}