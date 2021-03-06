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
    public partial class RedeemRequest :  IEquatable<RedeemRequest>
    { 
    
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum {
            
            [EnumMember(Value = "Submited")]
            Submited,
            
            [EnumMember(Value = "Approved")]
            Approved,
            
            [EnumMember(Value = "Rejected")]
            Rejected
        }

    
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public StatusEnum? Status { get; set; }
    
       
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; set; }
    
        /// <summary>
        /// Gets or Sets Submited
        /// </summary>
        [DataMember(Name="submited", EmitDefaultValue=true)]
        public DateTimeOffset? Submited { get; set; }
    
        /// <summary>
        /// Gets or Sets StatusComment
        /// </summary>
        [DataMember(Name="statusComment", EmitDefaultValue=true)]
        public string StatusComment { get; set; }
    
        /// <summary>
        /// Gets or Sets Closed
        /// </summary>
        [DataMember(Name="closed", EmitDefaultValue=true)]
        public DateTimeOffset? Closed { get; set; }
    
        /// <summary>
        /// Gets or Sets RewardId
        /// </summary>
        [DataMember(Name="rewardId", EmitDefaultValue=true)]
        public string RewardId { get; set; }
    
        /// <summary>
        /// Gets or Sets TableNumber
        /// </summary>
        [DataMember(Name="tableNumber", EmitDefaultValue=true)]
        public string TableNumber { get; set; }
    
        /// <summary>
        /// Gets or Sets MemberInfo
        /// </summary>
        [DataMember(Name="memberInfo", EmitDefaultValue=true)]
        public Member MemberInfo { get; set; }
    
        /// <summary>
        /// Gets or Sets RewardDetails
        /// </summary>
        [DataMember(Name="rewardDetails", EmitDefaultValue=true)]
        public RewardInfo RewardDetails { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RedeemRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
sb.Append("  Submited: ").Append(Submited).Append("\n");
sb.Append("  Status: ").Append(Status).Append("\n");
sb.Append("  StatusComment: ").Append(StatusComment).Append("\n");
sb.Append("  Closed: ").Append(Closed).Append("\n");
sb.Append("  RewardId: ").Append(RewardId).Append("\n");
sb.Append("  TableNumber: ").Append(TableNumber).Append("\n");
sb.Append("  MemberInfo: ").Append(MemberInfo).Append("\n");
sb.Append("  RewardDetails: ").Append(RewardDetails).Append("\n");
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
            return this.Equals(obj as RedeemRequest);
        }

        /// <summary>
        /// Returns true if RedeemRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of RedeemRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RedeemRequest other)
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
                    this.Submited == other.Submited ||
                    this.Submited != null &&
                    this.Submited.Equals(other.Submited)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.StatusComment == other.StatusComment ||
                    this.StatusComment != null &&
                    this.StatusComment.Equals(other.StatusComment)
                ) && 
                (
                    this.Closed == other.Closed ||
                    this.Closed != null &&
                    this.Closed.Equals(other.Closed)
                ) && 
                (
                    this.RewardId == other.RewardId ||
                    this.RewardId != null &&
                    this.RewardId.Equals(other.RewardId)
                ) && 
                (
                    this.TableNumber == other.TableNumber ||
                    this.TableNumber != null &&
                    this.TableNumber.Equals(other.TableNumber)
                ) && 
                (
                    this.MemberInfo == other.MemberInfo ||
                    this.MemberInfo != null &&
                    this.MemberInfo.Equals(other.MemberInfo)
                ) && 
                (
                    this.RewardDetails == other.RewardDetails ||
                    this.RewardDetails != null &&
                    this.RewardDetails.Equals(other.RewardDetails)
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
                if (this.Submited != null)
                    hash = hash * 59 + this.Submited.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.StatusComment != null)
                    hash = hash * 59 + this.StatusComment.GetHashCode();
                if (this.Closed != null)
                    hash = hash * 59 + this.Closed.GetHashCode();
                if (this.RewardId != null)
                    hash = hash * 59 + this.RewardId.GetHashCode();
                if (this.TableNumber != null)
                    hash = hash * 59 + this.TableNumber.GetHashCode();
                if (this.MemberInfo != null)
                    hash = hash * 59 + this.MemberInfo.GetHashCode();
                if (this.RewardDetails != null)
                    hash = hash * 59 + this.RewardDetails.GetHashCode();
                return hash;
            }
        }

    }
}
