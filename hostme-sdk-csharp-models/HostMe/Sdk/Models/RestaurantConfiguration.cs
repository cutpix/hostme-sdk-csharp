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
    public partial class RestaurantConfiguration :  IEquatable<RestaurantConfiguration>
    { 
    
       
        
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or Sets TimeZone
        /// </summary>
        [DataMember(Name="timeZone", EmitDefaultValue=true)]
        public string TimeZone { get; set; }
    
        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=true)]
        public string Address { get; set; }
    
        /// <summary>
        /// Gets or Sets Settings
        /// </summary>
        [DataMember(Name="settings", EmitDefaultValue=true)]
        public RestaurantSettings Settings { get; set; }
    
        /// <summary>
        /// Gets or Sets WaitingSettings
        /// </summary>
        [DataMember(Name="waitingSettings", EmitDefaultValue=true)]
        public WaitingSettings WaitingSettings { get; set; }
    
        /// <summary>
        /// Gets or Sets LoyaltySettings
        /// </summary>
        [DataMember(Name="loyaltySettings", EmitDefaultValue=true)]
        public LoyaltySettings LoyaltySettings { get; set; }
    
        /// <summary>
        /// Gets or Sets ReservationSettings
        /// </summary>
        [DataMember(Name="reservationSettings", EmitDefaultValue=true)]
        public ReservationSettings ReservationSettings { get; set; }
    
        /// <summary>
        /// Gets or Sets TableStates
        /// </summary>
        [DataMember(Name="tableStates", EmitDefaultValue=true)]
        public List<TableState> TableStates { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestaurantConfiguration {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
sb.Append("  Address: ").Append(Address).Append("\n");
sb.Append("  Settings: ").Append(Settings).Append("\n");
sb.Append("  WaitingSettings: ").Append(WaitingSettings).Append("\n");
sb.Append("  LoyaltySettings: ").Append(LoyaltySettings).Append("\n");
sb.Append("  ReservationSettings: ").Append(ReservationSettings).Append("\n");
sb.Append("  TableStates: ").Append(TableStates).Append("\n");
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
            return this.Equals(obj as RestaurantConfiguration);
        }

        /// <summary>
        /// Returns true if RestaurantConfiguration instances are equal
        /// </summary>
        /// <param name="other">Instance of RestaurantConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestaurantConfiguration other)
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
                    this.TimeZone == other.TimeZone ||
                    this.TimeZone != null &&
                    this.TimeZone.Equals(other.TimeZone)
                ) && 
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) && 
                (
                    this.Settings == other.Settings ||
                    this.Settings != null &&
                    this.Settings.Equals(other.Settings)
                ) && 
                (
                    this.WaitingSettings == other.WaitingSettings ||
                    this.WaitingSettings != null &&
                    this.WaitingSettings.Equals(other.WaitingSettings)
                ) && 
                (
                    this.LoyaltySettings == other.LoyaltySettings ||
                    this.LoyaltySettings != null &&
                    this.LoyaltySettings.Equals(other.LoyaltySettings)
                ) && 
                (
                    this.ReservationSettings == other.ReservationSettings ||
                    this.ReservationSettings != null &&
                    this.ReservationSettings.Equals(other.ReservationSettings)
                ) && 
                (
                    this.TableStates == other.TableStates ||
                    this.TableStates != null &&
                    this.TableStates.SequenceEqual(other.TableStates)
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
                if (this.TimeZone != null)
                    hash = hash * 59 + this.TimeZone.GetHashCode();
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                if (this.Settings != null)
                    hash = hash * 59 + this.Settings.GetHashCode();
                if (this.WaitingSettings != null)
                    hash = hash * 59 + this.WaitingSettings.GetHashCode();
                if (this.LoyaltySettings != null)
                    hash = hash * 59 + this.LoyaltySettings.GetHashCode();
                if (this.ReservationSettings != null)
                    hash = hash * 59 + this.ReservationSettings.GetHashCode();
                if (this.TableStates != null)
                    hash = hash * 59 + this.TableStates.GetHashCode();
                return hash;
            }
        }

    }
}
