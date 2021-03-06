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
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
/**
 * CarrierCreate
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2021-11-25T13:43:16.684Z[GMT]")
public class CarrierCreate {
  @SerializedName("name")
  private String name = null;

  @SerializedName("key")
  private String key = null;

  @SerializedName("carrierTypeId")
  private Integer carrierTypeId = null;

  public CarrierCreate name(String name) {
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

  public CarrierCreate key(String key) {
    this.key = key;
    return this;
  }

   /**
   * Get key
   * @return key
  **/
  @Schema(required = true, description = "")
  public String getKey() {
    return key;
  }

  public void setKey(String key) {
    this.key = key;
  }

  public CarrierCreate carrierTypeId(Integer carrierTypeId) {
    this.carrierTypeId = carrierTypeId;
    return this;
  }

   /**
   * Get carrierTypeId
   * @return carrierTypeId
  **/
  @Schema(required = true, description = "")
  public Integer getCarrierTypeId() {
    return carrierTypeId;
  }

  public void setCarrierTypeId(Integer carrierTypeId) {
    this.carrierTypeId = carrierTypeId;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    CarrierCreate carrierCreate = (CarrierCreate) o;
    return Objects.equals(this.name, carrierCreate.name) &&
        Objects.equals(this.key, carrierCreate.key) &&
        Objects.equals(this.carrierTypeId, carrierCreate.carrierTypeId);
  }

  @Override
  public int hashCode() {
    return Objects.hash(name, key, carrierTypeId);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class CarrierCreate {\n");
    
    sb.append("    name: ").append(toIndentedString(name)).append("\n");
    sb.append("    key: ").append(toIndentedString(key)).append("\n");
    sb.append("    carrierTypeId: ").append(toIndentedString(carrierTypeId)).append("\n");
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
