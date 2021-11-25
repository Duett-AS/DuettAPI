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
import io.swagger.client.model.Contact;
import io.swagger.client.model.ContactPerson;
import io.swagger.client.model.HourRegistration;
import io.swagger.client.model.StreetAddress;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
/**
 * Customer
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2021-11-25T13:43:16.684Z[GMT]")
public class Customer {
  @SerializedName("id")
  private Integer id = null;

  @SerializedName("externalId")
  private String externalId = null;

  @SerializedName("customerNumber")
  private String customerNumber = null;

  @SerializedName("vatNumber")
  private String vatNumber = null;

  @SerializedName("bankAccountNumber")
  private String bankAccountNumber = null;

  @SerializedName("invoiceEmail")
  private String invoiceEmail = null;

  @SerializedName("hourAttestationMobile")
  private String hourAttestationMobile = null;

  @SerializedName("show")
  private Boolean show = null;

  @SerializedName("address")
  private StreetAddress address = null;

  @SerializedName("contactInfo")
  private Contact contactInfo = null;

  @SerializedName("contactPerson")
  private ContactPerson contactPerson = null;

  @SerializedName("hourRegistrations")
  private List<HourRegistration> hourRegistrations = null;

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

  public Customer externalId(String externalId) {
    this.externalId = externalId;
    return this;
  }

   /**
   * Used for duplicate check
   * @return externalId
  **/
  @Schema(required = true, description = "Used for duplicate check")
  public String getExternalId() {
    return externalId;
  }

  public void setExternalId(String externalId) {
    this.externalId = externalId;
  }

   /**
   * Get customerNumber
   * @return customerNumber
  **/
  @Schema(required = true, description = "")
  public String getCustomerNumber() {
    return customerNumber;
  }

  public Customer vatNumber(String vatNumber) {
    this.vatNumber = vatNumber;
    return this;
  }

   /**
   * Get vatNumber
   * @return vatNumber
  **/
  @Schema(description = "")
  public String getVatNumber() {
    return vatNumber;
  }

  public void setVatNumber(String vatNumber) {
    this.vatNumber = vatNumber;
  }

  public Customer bankAccountNumber(String bankAccountNumber) {
    this.bankAccountNumber = bankAccountNumber;
    return this;
  }

   /**
   * Get bankAccountNumber
   * @return bankAccountNumber
  **/
  @Schema(description = "")
  public String getBankAccountNumber() {
    return bankAccountNumber;
  }

  public void setBankAccountNumber(String bankAccountNumber) {
    this.bankAccountNumber = bankAccountNumber;
  }

  public Customer invoiceEmail(String invoiceEmail) {
    this.invoiceEmail = invoiceEmail;
    return this;
  }

   /**
   * Get invoiceEmail
   * @return invoiceEmail
  **/
  @Schema(description = "")
  public String getInvoiceEmail() {
    return invoiceEmail;
  }

  public void setInvoiceEmail(String invoiceEmail) {
    this.invoiceEmail = invoiceEmail;
  }

  public Customer hourAttestationMobile(String hourAttestationMobile) {
    this.hourAttestationMobile = hourAttestationMobile;
    return this;
  }

   /**
   * Get hourAttestationMobile
   * @return hourAttestationMobile
  **/
  @Schema(description = "")
  public String getHourAttestationMobile() {
    return hourAttestationMobile;
  }

  public void setHourAttestationMobile(String hourAttestationMobile) {
    this.hourAttestationMobile = hourAttestationMobile;
  }

   /**
   * false if soft deleted
   * @return show
  **/
  @Schema(description = "false if soft deleted")
  public Boolean isShow() {
    return show;
  }

  public Customer address(StreetAddress address) {
    this.address = address;
    return this;
  }

   /**
   * Get address
   * @return address
  **/
  @Schema(required = true, description = "")
  public StreetAddress getAddress() {
    return address;
  }

  public void setAddress(StreetAddress address) {
    this.address = address;
  }

  public Customer contactInfo(Contact contactInfo) {
    this.contactInfo = contactInfo;
    return this;
  }

   /**
   * Get contactInfo
   * @return contactInfo
  **/
  @Schema(required = true, description = "")
  public Contact getContactInfo() {
    return contactInfo;
  }

  public void setContactInfo(Contact contactInfo) {
    this.contactInfo = contactInfo;
  }

  public Customer contactPerson(ContactPerson contactPerson) {
    this.contactPerson = contactPerson;
    return this;
  }

   /**
   * Get contactPerson
   * @return contactPerson
  **/
  @Schema(description = "")
  public ContactPerson getContactPerson() {
    return contactPerson;
  }

  public void setContactPerson(ContactPerson contactPerson) {
    this.contactPerson = contactPerson;
  }

   /**
   * Get hourRegistrations
   * @return hourRegistrations
  **/
  @Schema(description = "")
  public List<HourRegistration> getHourRegistrations() {
    return hourRegistrations;
  }

   /**
   * Get rowversion
   * @return rowversion
  **/
  @Schema(description = "")
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
    Customer customer = (Customer) o;
    return Objects.equals(this.id, customer.id) &&
        Objects.equals(this.externalId, customer.externalId) &&
        Objects.equals(this.customerNumber, customer.customerNumber) &&
        Objects.equals(this.vatNumber, customer.vatNumber) &&
        Objects.equals(this.bankAccountNumber, customer.bankAccountNumber) &&
        Objects.equals(this.invoiceEmail, customer.invoiceEmail) &&
        Objects.equals(this.hourAttestationMobile, customer.hourAttestationMobile) &&
        Objects.equals(this.show, customer.show) &&
        Objects.equals(this.address, customer.address) &&
        Objects.equals(this.contactInfo, customer.contactInfo) &&
        Objects.equals(this.contactPerson, customer.contactPerson) &&
        Objects.equals(this.hourRegistrations, customer.hourRegistrations) &&
        Objects.equals(this.rowversion, customer.rowversion);
  }

  @Override
  public int hashCode() {
    return Objects.hash(id, externalId, customerNumber, vatNumber, bankAccountNumber, invoiceEmail, hourAttestationMobile, show, address, contactInfo, contactPerson, hourRegistrations, rowversion);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Customer {\n");
    
    sb.append("    id: ").append(toIndentedString(id)).append("\n");
    sb.append("    externalId: ").append(toIndentedString(externalId)).append("\n");
    sb.append("    customerNumber: ").append(toIndentedString(customerNumber)).append("\n");
    sb.append("    vatNumber: ").append(toIndentedString(vatNumber)).append("\n");
    sb.append("    bankAccountNumber: ").append(toIndentedString(bankAccountNumber)).append("\n");
    sb.append("    invoiceEmail: ").append(toIndentedString(invoiceEmail)).append("\n");
    sb.append("    hourAttestationMobile: ").append(toIndentedString(hourAttestationMobile)).append("\n");
    sb.append("    show: ").append(toIndentedString(show)).append("\n");
    sb.append("    address: ").append(toIndentedString(address)).append("\n");
    sb.append("    contactInfo: ").append(toIndentedString(contactInfo)).append("\n");
    sb.append("    contactPerson: ").append(toIndentedString(contactPerson)).append("\n");
    sb.append("    hourRegistrations: ").append(toIndentedString(hourRegistrations)).append("\n");
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
