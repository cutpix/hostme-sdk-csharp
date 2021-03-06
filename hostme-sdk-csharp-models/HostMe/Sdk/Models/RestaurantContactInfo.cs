using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HostMe.Sdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class RestaurantContactInfo :  IEquatable<RestaurantContactInfo>
    { 
    
       
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public int? Id { get; set; }
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=true)]
        public string Address { get; set; }
    
        /// <summary>
        /// Gets or Sets ImageUrl
        /// </summary>
        [DataMember(Name="imageUrl", EmitDefaultValue=true)]
        public string ImageUrl { get; set; }
    
        /// <summary>
        /// Gets or Sets WebsiteUrl
        /// </summary>
        [DataMember(Name="websiteUrl", EmitDefaultValue=true)]
        public string WebsiteUrl { get; set; }
    
        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=true)]
        public string Phone { get; set; }
    
        /// <summary>
        /// Gets or Sets TimeZone
        /// </summary>
        [DataMember(Name="timeZone", EmitDefaultValue=true)]
        public string TimeZone { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestaurantContactInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
sb.Append("  Name: ").Append(Name).Append("\n");
sb.Append("  Address: ").Append(Address).Append("\n");
sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
sb.Append("  WebsiteUrl: ").Append(WebsiteUrl).Append("\n");
sb.Append("  Phone: ").Append(Phone).Append("\n");
sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as RestaurantContactInfo);
        }

        /// <summary>
        /// Returns true if RestaurantContactInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of RestaurantContactInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestaurantContactInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) && 
                (
                    this.ImageUrl == other.ImageUrl ||
                    this.ImageUrl != null &&
                    this.ImageUrl.Equals(other.ImageUrl)
                ) && 
                (
                    this.WebsiteUrl == other.WebsiteUrl ||
                    this.WebsiteUrl != null &&
                    this.WebsiteUrl.Equals(other.WebsiteUrl)
                ) && 
                (
                    this.Phone == other.Phone ||
                    this.Phone != null &&
                    this.Phone.Equals(other.Phone)
                ) && 
                (
                    this.TimeZone == other.TimeZone ||
                    this.TimeZone != null &&
                    this.TimeZone.Equals(other.TimeZone)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                if (this.ImageUrl != null)
                    hash = hash * 59 + this.ImageUrl.GetHashCode();
                if (this.WebsiteUrl != null)
                    hash = hash * 59 + this.WebsiteUrl.GetHashCode();
                if (this.Phone != null)
                    hash = hash * 59 + this.Phone.GetHashCode();
                if (this.TimeZone != null)
                    hash = hash * 59 + this.TimeZone.GetHashCode();
                return hash;
            }
        }

    }
}
