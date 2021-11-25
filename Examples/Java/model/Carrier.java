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
import io.swagger.client.model.CarrierType;
import io.swagger.client.model.Department;
import io.swagger.client.model.Employee;
import io.swagger.client.model.HourRegistrationCarrier;
import io.swagger.client.model.Project;
import io.swagger.client.model.WageType;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
/**
 * Carrier
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2021-11-25T13:43:16.684Z[GMT]")
public class Carrier {
  @SerializedName("id")
  private Integer id = null;

  @SerializedName("name")
  private String name = null;

  @SerializedName("key")
  private String key = null;

  @SerializedName("carrierTypeId")
  private Integer carrierTypeId = null;

  @SerializedName("carrierType")
  private CarrierType carrierType = null;

  @SerializedName("employee")
  private Employee employee = null;

  @SerializedName("project")
  private Project project = null;

  @SerializedName("department")
  private Department department = null;

  @SerializedName("wageType")
  private WageType wageType = null;

  @SerializedName("hourRegistrations")
  private List<HourRegistrationCarrier> hourRegistrations = null;

  @SerializedName("show")
  private Boolean show = null;

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

  public Carrier name(String name) {
    this.name = name;
    return this;
  }

   /**
   * Get name
   * @return name
  **/
  @Schema(required = true, description = "")
  public String getName() {
    return name;
  }

  public void setName(String name) {
    this.name = name;
  }

  public Carrier key(String key) {
    this.key = key;
    return this;
  }

   /**
   * Get key
   * @return key
  **/
  @Schema(description = "")
  public String getKey() {
    return key;
  }

  public void setKey(String key) {
    this.key = key;
  }

   /**
   * Get carrierTypeId
   * @return carrierTypeId
  **/
  @Schema(required = true, description = "")
  public Integer getCarrierTypeId() {
    return carrierTypeId;
  }

  public Carrier carrierType(CarrierType carrierType) {
    this.carrierType = carrierType;
    return this;
  }

   /**
   * Get carrierType
   * @return carrierType
  **/
  @Schema(description = "")
  public CarrierType getCarrierType() {
    return carrierType;
  }

  public void setCarrierType(CarrierType carrierType) {
    this.carrierType = carrierType;
  }

  public Carrier employee(Employee employee) {
    this.employee = employee;
    return this;
  }

   /**
   * Get employee
   * @return employee
  **/
  @Schema(description = "")
  public Employee getEmployee() {
    return employee;
  }

  public void setEmployee(Employee employee) {
    this.employee = employee;
  }

  public Carrier project(Project project) {
    this.project = project;
    return this;
  }

   /**
   * Get project
   * @return project
  **/
  @Schema(description = "")
  public Project getProject() {
    return project;
  }

  public void setProject(Project project) {
    this.project = project;
  }

  public Carrier department(Department department) {
    this.department = department;
    return this;
  }

   /**
   * Get department
   * @return department
  **/
  @Schema(description = "")
  public Department getDepartment() {
    return department;
  }

  public void setDepartment(Department department) {
    this.department = department;
  }

  public Carrier wageType(WageType wageType) {
    this.wageType = wageType;
    return this;
  }

   /**
   * Get wageType
   * @return wageType
  **/
  @Schema(description = "")
  public WageType getWageType() {
    return wageType;
  }

  public void setWageType(WageType wageType) {
    this.wageType = wageType;
  }

   /**
   * Get hourRegistrations
   * @return hourRegistrations
  **/
  @Schema(description = "")
  public List<HourRegistrationCarrier> getHourRegistrations() {
    return hourRegistrations;
  }

   /**
   * false if soft deleted
   * @return show
  **/
  @Schema(description = "false if soft deleted")
  public Boolean isShow() {
    return show;
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
    Carrier carrier = (Carrier) o;
    return Objects.equals(this.id, carrier.id) &&
        Objects.equals(this.name, carrier.name) &&
        Objects.equals(this.key, carrier.key) &&
        Objects.equals(this.carrierTypeId, carrier.carrierTypeId) &&
        Objects.equals(this.carrierType, carrier.carrierType) &&
        Objects.equals(this.employee, carrier.employee) &&
        Objects.equals(this.project, carrier.project) &&
        Objects.equals(this.department, carrier.department) &&
        Objects.equals(this.wageType, carrier.wageType) &&
        Objects.equals(this.hourRegistrations, carrier.hourRegistrations) &&
        Objects.equals(this.show, carrier.show) &&
        Objects.equals(this.rowversion, carrier.rowversion);
  }

  @Override
  public int hashCode() {
    return Objects.hash(id, name, key, carrierTypeId, carrierType, employee, project, department, wageType, hourRegistrations, show, rowversion);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Carrier {\n");
    
    sb.append("    id: ").append(toIndentedString(id)).append("\n");
    sb.append("    name: ").append(toIndentedString(name)).append("\n");
    sb.append("    key: ").append(toIndentedString(key)).append("\n");
    sb.append("    carrierTypeId: ").append(toIndentedString(carrierTypeId)).append("\n");
    sb.append("    carrierType: ").append(toIndentedString(carrierType)).append("\n");
    sb.append("    employee: ").append(toIndentedString(employee)).append("\n");
    sb.append("    project: ").append(toIndentedString(project)).append("\n");
    sb.append("    department: ").append(toIndentedString(department)).append("\n");
    sb.append("    wageType: ").append(toIndentedString(wageType)).append("\n");
    sb.append("    hourRegistrations: ").append(toIndentedString(hourRegistrations)).append("\n");
    sb.append("    show: ").append(toIndentedString(show)).append("\n");
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