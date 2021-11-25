/*
 * OpenApi
 *  ## ![N|Solid](https://duett.no/wp-content/uploads/2018/10/cropped-Duett-favicon-32x32.png)  _How to take the Duett api in use_  To be able to use the API, you must have an interaction key and a client key.  Eksample curl: ```swift    curl -X 'GET' \\   'https://api.duett.no/article/v1 \\   -H 'accept: application/json' \\   -H 'X-Api-Integration-Key: 89ff1c42-9d90-435a-8a94-20207bc06e1a' \\   -H 'X-Api-Client-Key: 7896feb3-aaa2-4fd2-aaa2-c69de5fd1e5f' ``` ##### [Metode description][1] ##### [Filtering data in openApi][2]   ### Use a code generator as to auto-generate api client:  ##### [NSwagStudio](https://github.com/RicoSuter/NSwag/wiki/NSwagStudio) ##### [Visual studio add-in](https://marketplace.visualstudio.com/items?itemName=ChristianResmaHelle.ApiClientCodeGenerator) \\ ##### [Online code generator for many languages and versions](https://github.com/swagger-api/swagger-codegen)  *** [1]: ../metods-help.html [2]: ../query-help.html
 *
 * OpenAPI spec version: 1.0
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */

package io.swagger.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.client.model.Carrier;
import io.swagger.client.model.Customer;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import org.threeten.bp.OffsetDateTime;
/**
 * Project
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2021-11-25T13:43:16.684Z[GMT]")
public class Project {
  @SerializedName("id")
  private Integer id = null;

  @SerializedName("startDate")
  private OffsetDateTime startDate = null;

  @SerializedName("carrier")
  private Carrier carrier = null;

  @SerializedName("endDate")
  private OffsetDateTime endDate = null;

  @SerializedName("actualEndDate")
  private OffsetDateTime actualEndDate = null;

  @SerializedName("contractSum")
  private Double contractSum = null;

  @SerializedName("description")
  private String description = null;

  @SerializedName("customer")
  private Customer customer = null;

  @SerializedName("projectLeader")
  private Carrier projectLeader = null;

  @SerializedName("rowversion")
  private Long rowversion = null;

   /**
   * Get id
   * @return id
  **/
  @Schema(required = true, description = "")
  public Integer getId() {
    return id;
  }

  public Project startDate(OffsetDateTime startDate) {
    this.startDate = startDate;
    return this;
  }

   /**
   * Get startDate
   * @return startDate
  **/
  @Schema(required = true, description = "")
  public OffsetDateTime getStartDate() {
    return startDate;
  }

  public void setStartDate(OffsetDateTime startDate) {
    this.startDate = startDate;
  }

  public Project carrier(Carrier carrier) {
    this.carrier = carrier;
    return this;
  }

   /**
   * Get carrier
   * @return carrier
  **/
  @Schema(required = true, description = "")
  public Carrier getCarrier() {
    return carrier;
  }

  public void setCarrier(Carrier carrier) {
    this.carrier = carrier;
  }

  public Project endDate(OffsetDateTime endDate) {
    this.endDate = endDate;
    return this;
  }

   /**
   * Get endDate
   * @return endDate
  **/
  @Schema(description = "")
  public OffsetDateTime getEndDate() {
    return endDate;
  }

  public void setEndDate(OffsetDateTime endDate) {
    this.endDate = endDate;
  }

  public Project actualEndDate(OffsetDateTime actualEndDate) {
    this.actualEndDate = actualEndDate;
    return this;
  }

   /**
   * Get actualEndDate
   * @return actualEndDate
  **/
  @Schema(description = "")
  public OffsetDateTime getActualEndDate() {
    return actualEndDate;
  }

  public void setActualEndDate(OffsetDateTime actualEndDate) {
    this.actualEndDate = actualEndDate;
  }

  public Project contractSum(Double contractSum) {
    this.contractSum = contractSum;
    return this;
  }

   /**
   * Get contractSum
   * @return contractSum
  **/
  @Schema(description = "")
  public Double getContractSum() {
    return contractSum;
  }

  public void setContractSum(Double contractSum) {
    this.contractSum = contractSum;
  }

  public Project description(String description) {
    this.description = description;
    return this;
  }

   /**
   * Get description
   * @return description
  **/
  @Schema(description = "")
  public String getDescription() {
    return description;
  }

  public void setDescription(String description) {
    this.description = description;
  }

  public Project customer(Customer customer) {
    this.customer = customer;
    return this;
  }

   /**
   * Get customer
   * @return customer
  **/
  @Schema(description = "")
  public Customer getCustomer() {
    return customer;
  }

  public void setCustomer(Customer customer) {
    this.customer = customer;
  }

  public Project projectLeader(Carrier projectLeader) {
    this.projectLeader = projectLeader;
    return this;
  }

   /**
   * Get projectLeader
   * @return projectLeader
  **/
  @Schema(description = "")
  public Carrier getProjectLeader() {
    return projectLeader;
  }

  public void setProjectLeader(Carrier projectLeader) {
    this.projectLeader = projectLeader;
  }

   /**
   * Get rowversion
   * @return rowversion
  **/
  @Schema(required = true, description = "")
  public Long getRowversion() {
    return rowversion;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Project project = (Project) o;
    return Objects.equals(this.id, project.id) &&
        Objects.equals(this.startDate, project.startDate) &&
        Objects.equals(this.carrier, project.carrier) &&
        Objects.equals(this.endDate, project.endDate) &&
        Objects.equals(this.actualEndDate, project.actualEndDate) &&
        Objects.equals(this.contractSum, project.contractSum) &&
        Objects.equals(this.description, project.description) &&
        Objects.equals(this.customer, project.customer) &&
        Objects.equals(this.projectLeader, project.projectLeader) &&
        Objects.equals(this.rowversion, project.rowversion);
  }

  @Override
  public int hashCode() {
    return Objects.hash(id, startDate, carrier, endDate, actualEndDate, contractSum, description, customer, projectLeader, rowversion);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Project {\n");
    
    sb.append("    id: ").append(toIndentedString(id)).append("\n");
    sb.append("    startDate: ").append(toIndentedString(startDate)).append("\n");
    sb.append("    carrier: ").append(toIndentedString(carrier)).append("\n");
    sb.append("    endDate: ").append(toIndentedString(endDate)).append("\n");
    sb.append("    actualEndDate: ").append(toIndentedString(actualEndDate)).append("\n");
    sb.append("    contractSum: ").append(toIndentedString(contractSum)).append("\n");
    sb.append("    description: ").append(toIndentedString(description)).append("\n");
    sb.append("    customer: ").append(toIndentedString(customer)).append("\n");
    sb.append("    projectLeader: ").append(toIndentedString(projectLeader)).append("\n");
    sb.append("    rowversion: ").append(toIndentedString(rowversion)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}