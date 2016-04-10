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
    public partial class ExternalLoginViewModel :  IEquatable<ExternalLoginViewModel>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalLoginViewModel" /> class.
        /// Initializes a new instance of the <see cref="ExternalLoginViewModel" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Url">Url.</param>
        /// <param name="State">State.</param>

        public ExternalLoginViewModel(string Name = null, string Url = null, string State = null)
        {
            this.Name = Name;
            this.Url = Url;
            this.State = State;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=true)]
        public string Url { get; set; }
    
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=true)]
        public string State { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalLoginViewModel {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
sb.Append("  Url: ").Append(Url).Append("\n");
sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(obj as ExternalLoginViewModel);
        }

        /// <summary>
        /// Returns true if ExternalLoginViewModel instances are equal
        /// </summary>
        /// <param name="other">Instance of ExternalLoginViewModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalLoginViewModel other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                return hash;
            }
        }

    }
}
