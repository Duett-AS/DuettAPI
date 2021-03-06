/* 
 * OpenApi
 *
 *  ## ![N|Solid](https://duett.no/wp-content/uploads/2018/10/cropped-Duett-favicon-32x32.png)  _How to take the Duett api in use_  To be able to use the API, you must have an interaction key and a client key.  Eksample curl: ```swift    curl -X 'GET' \\   'https://api.duett.no/article/v1 \\   -H 'accept: application/json' \\   -H 'X-Api-Integration-Key: 89ff1c42-9d90-435a-8a94-20207bc06e1a' \\   -H 'X-Api-Client-Key: 7896feb3-aaa2-4fd2-aaa2-c69de5fd1e5f' ``` ##### [Metode description][1] ##### [Filtering data in openApi][2]   ### Use a code generator as to auto-generate api client:  ##### [NSwagStudio](https://github.com/RicoSuter/NSwag/wiki/NSwagStudio) ##### [Visual studio add-in](https://marketplace.visualstudio.com/items?itemName=ChristianResmaHelle.ApiClientCodeGenerator) \\ ##### [Online code generator for many languages and versions](https://github.com/swagger-api/swagger-codegen)  *** [1]: ../metods-help.html [2]: ../query-help.html
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Department
    /// </summary>
    [DataContract]
        public partial class Department :  IEquatable<Department>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Department" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="address1">address1.</param>
        /// <param name="address2">address2.</param>
        /// <param name="organizationNumber">organizationNumber.</param>
        /// <param name="cadastralNumber">cadastralNumber.</param>
        /// <param name="rowversion">rowversion.</param>
        public Department(int? id = default(int?), string address1 = default(string), string address2 = default(string), string organizationNumber = default(string), string cadastralNumber = default(string), long? rowversion = default(long?))
        {
            this.Id = id;
            this.Address1 = address1;
            this.Address2 = address2;
            this.OrganizationNumber = organizationNumber;
            this.CadastralNumber = cadastralNumber;
            this.Rowversion = rowversion;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Address1
        /// </summary>
        [DataMember(Name="address1", EmitDefaultValue=false)]
        public string Address1 { get; set; }

        /// <summary>
        /// Gets or Sets Address2
        /// </summary>
        [DataMember(Name="address2", EmitDefaultValue=false)]
        public string Address2 { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationNumber
        /// </summary>
        [DataMember(Name="organizationNumber", EmitDefaultValue=false)]
        public string OrganizationNumber { get; set; }

        /// <summary>
        /// Gets or Sets CadastralNumber
        /// </summary>
        [DataMember(Name="cadastralNumber", EmitDefaultValue=false)]
        public string CadastralNumber { get; set; }

        /// <summary>
        /// Gets or Sets Rowversion
        /// </summary>
        [DataMember(Name="rowversion", EmitDefaultValue=false)]
        public long? Rowversion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Department {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Address1: ").Append(Address1).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  OrganizationNumber: ").Append(OrganizationNumber).Append("\n");
            sb.Append("  CadastralNumber: ").Append(CadastralNumber).Append("\n");
            sb.Append("  Rowversion: ").Append(Rowversion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Department);
        }

        /// <summary>
        /// Returns true if Department instances are equal
        /// </summary>
        /// <param name="input">Instance of Department to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Department input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Address1 == input.Address1 ||
                    (this.Address1 != null &&
                    this.Address1.Equals(input.Address1))
                ) && 
                (
                    this.Address2 == input.Address2 ||
                    (this.Address2 != null &&
                    this.Address2.Equals(input.Address2))
                ) && 
                (
                    this.OrganizationNumber == input.OrganizationNumber ||
                    (this.OrganizationNumber != null &&
                    this.OrganizationNumber.Equals(input.OrganizationNumber))
                ) && 
                (
                    this.CadastralNumber == input.CadastralNumber ||
                    (this.CadastralNumber != null &&
                    this.CadastralNumber.Equals(input.CadastralNumber))
                ) && 
                (
                    this.Rowversion == input.Rowversion ||
                    (this.Rowversion != null &&
                    this.Rowversion.Equals(input.Rowversion))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Address1 != null)
                    hashCode = hashCode * 59 + this.Address1.GetHashCode();
                if (this.Address2 != null)
                    hashCode = hashCode * 59 + this.Address2.GetHashCode();
                if (this.OrganizationNumber != null)
                    hashCode = hashCode * 59 + this.OrganizationNumber.GetHashCode();
                if (this.CadastralNumber != null)
                    hashCode = hashCode * 59 + this.CadastralNumber.GetHashCode();
                if (this.Rowversion != null)
                    hashCode = hashCode * 59 + this.Rowversion.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
