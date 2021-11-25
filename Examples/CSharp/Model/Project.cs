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
    /// Project
    /// </summary>
    [DataContract]
        public partial class Project :  IEquatable<Project>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Project" /> class.
        /// </summary>
        /// <param name="startDate">startDate (required).</param>
        /// <param name="carrier">carrier (required).</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="actualEndDate">actualEndDate.</param>
        /// <param name="contractSum">contractSum.</param>
        /// <param name="description">description.</param>
        /// <param name="customer">customer.</param>
        /// <param name="projectLeader">projectLeader.</param>
        public Project(DateTime? startDate = default(DateTime?), Carrier carrier = default(Carrier), DateTime? endDate = default(DateTime?), DateTime? actualEndDate = default(DateTime?), double? contractSum = default(double?), string description = default(string), Customer customer = default(Customer), Carrier projectLeader = default(Carrier))
        {
            // to ensure "startDate" is required (not null)
            if (startDate == null)
            {
                throw new InvalidDataException("startDate is a required property for Project and cannot be null");
            }
            else
            {
                this.StartDate = startDate;
            }
            // to ensure "carrier" is required (not null)
            if (carrier == null)
            {
                throw new InvalidDataException("carrier is a required property for Project and cannot be null");
            }
            else
            {
                this.Carrier = carrier;
            }
            this.EndDate = endDate;
            this.ActualEndDate = actualEndDate;
            this.ContractSum = contractSum;
            this.Description = description;
            this.Customer = customer;
            this.ProjectLeader = projectLeader;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or Sets Carrier
        /// </summary>
        [DataMember(Name="carrier", EmitDefaultValue=false)]
        public Carrier Carrier { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or Sets ActualEndDate
        /// </summary>
        [DataMember(Name="actualEndDate", EmitDefaultValue=false)]
        public DateTime? ActualEndDate { get; set; }

        /// <summary>
        /// Gets or Sets ContractSum
        /// </summary>
        [DataMember(Name="contractSum", EmitDefaultValue=false)]
        public double? ContractSum { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name="customer", EmitDefaultValue=false)]
        public Customer Customer { get; set; }

        /// <summary>
        /// Gets or Sets ProjectLeader
        /// </summary>
        [DataMember(Name="projectLeader", EmitDefaultValue=false)]
        public Carrier ProjectLeader { get; set; }

        /// <summary>
        /// Gets or Sets Rowversion
        /// </summary>
        [DataMember(Name="rowversion", EmitDefaultValue=false)]
        public long? Rowversion { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Project {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  Carrier: ").Append(Carrier).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  ActualEndDate: ").Append(ActualEndDate).Append("\n");
            sb.Append("  ContractSum: ").Append(ContractSum).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  ProjectLeader: ").Append(ProjectLeader).Append("\n");
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
            return this.Equals(input as Project);
        }

        /// <summary>
        /// Returns true if Project instances are equal
        /// </summary>
        /// <param name="input">Instance of Project to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Project input)
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
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.Carrier == input.Carrier ||
                    (this.Carrier != null &&
                    this.Carrier.Equals(input.Carrier))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.ActualEndDate == input.ActualEndDate ||
                    (this.ActualEndDate != null &&
                    this.ActualEndDate.Equals(input.ActualEndDate))
                ) && 
                (
                    this.ContractSum == input.ContractSum ||
                    (this.ContractSum != null &&
                    this.ContractSum.Equals(input.ContractSum))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Customer == input.Customer ||
                    (this.Customer != null &&
                    this.Customer.Equals(input.Customer))
                ) && 
                (
                    this.ProjectLeader == input.ProjectLeader ||
                    (this.ProjectLeader != null &&
                    this.ProjectLeader.Equals(input.ProjectLeader))
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
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.Carrier != null)
                    hashCode = hashCode * 59 + this.Carrier.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.ActualEndDate != null)
                    hashCode = hashCode * 59 + this.ActualEndDate.GetHashCode();
                if (this.ContractSum != null)
                    hashCode = hashCode * 59 + this.ContractSum.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Customer != null)
                    hashCode = hashCode * 59 + this.Customer.GetHashCode();
                if (this.ProjectLeader != null)
                    hashCode = hashCode * 59 + this.ProjectLeader.GetHashCode();
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
