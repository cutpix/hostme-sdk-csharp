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
    public partial class ChangePassword :  IEquatable<ChangePassword>
    { 
    
       
        
    
        /// <summary>
        /// Gets or Sets OldPassword
        /// </summary>
        [DataMember(Name="oldPassword", EmitDefaultValue=true)]
        public string OldPassword { get; set; }
    
        /// <summary>
        /// Gets or Sets NewPassword
        /// </summary>
        [DataMember(Name="newPassword", EmitDefaultValue=true)]
        public string NewPassword { get; set; }
    
        /// <summary>
        /// Gets or Sets ConfirmPassword
        /// </summary>
        [DataMember(Name="confirmPassword", EmitDefaultValue=true)]
        public string ConfirmPassword { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangePassword {\n");
            sb.Append("  OldPassword: ").Append(OldPassword).Append("\n");
sb.Append("  NewPassword: ").Append(NewPassword).Append("\n");
sb.Append("  ConfirmPassword: ").Append(ConfirmPassword).Append("\n");
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
            return this.Equals(obj as ChangePassword);
        }

        /// <summary>
        /// Returns true if ChangePassword instances are equal
        /// </summary>
        /// <param name="other">Instance of ChangePassword to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChangePassword other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.OldPassword == other.OldPassword ||
                    this.OldPassword != null &&
                    this.OldPassword.Equals(other.OldPassword)
                ) && 
                (
                    this.NewPassword == other.NewPassword ||
                    this.NewPassword != null &&
                    this.NewPassword.Equals(other.NewPassword)
                ) && 
                (
                    this.ConfirmPassword == other.ConfirmPassword ||
                    this.ConfirmPassword != null &&
                    this.ConfirmPassword.Equals(other.ConfirmPassword)
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
                if (this.OldPassword != null)
                    hash = hash * 59 + this.OldPassword.GetHashCode();
                if (this.NewPassword != null)
                    hash = hash * 59 + this.NewPassword.GetHashCode();
                if (this.ConfirmPassword != null)
                    hash = hash * 59 + this.ConfirmPassword.GetHashCode();
                return hash;
            }
        }

    }
}
