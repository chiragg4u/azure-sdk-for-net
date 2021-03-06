// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorageSync.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Sync Session status object.
    /// </summary>
    public partial class SyncProgressStatus
    {
        /// <summary>
        /// Initializes a new instance of the SyncProgressStatus class.
        /// </summary>
        public SyncProgressStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SyncProgressStatus class.
        /// </summary>
        /// <param name="progressTimestamp">Progress timestamp</param>
        /// <param name="syncDirection">Sync direction. Possible values
        /// include: 'none', 'initialize', 'download', 'upload',
        /// 'recall'</param>
        /// <param name="perItemErrorCount">Per item error count</param>
        /// <param name="appliedItemCount">Applied item count.</param>
        /// <param name="totalItemCount">Total item count</param>
        /// <param name="appliedBytes">Applied bytes</param>
        /// <param name="totalBytes">Total bytes</param>
        public SyncProgressStatus(System.DateTime? progressTimestamp = default(System.DateTime?), string syncDirection = default(string), int? perItemErrorCount = default(int?), int? appliedItemCount = default(int?), int? totalItemCount = default(int?), int? appliedBytes = default(int?), int? totalBytes = default(int?))
        {
            ProgressTimestamp = progressTimestamp;
            SyncDirection = syncDirection;
            PerItemErrorCount = perItemErrorCount;
            AppliedItemCount = appliedItemCount;
            TotalItemCount = totalItemCount;
            AppliedBytes = appliedBytes;
            TotalBytes = totalBytes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets progress timestamp
        /// </summary>
        [JsonProperty(PropertyName = "progressTimestamp")]
        public System.DateTime? ProgressTimestamp { get; set; }

        /// <summary>
        /// Gets or sets sync direction. Possible values include: 'none',
        /// 'initialize', 'download', 'upload', 'recall'
        /// </summary>
        [JsonProperty(PropertyName = "syncDirection")]
        public string SyncDirection { get; set; }

        /// <summary>
        /// Gets or sets per item error count
        /// </summary>
        [JsonProperty(PropertyName = "perItemErrorCount")]
        public int? PerItemErrorCount { get; set; }

        /// <summary>
        /// Gets or sets applied item count.
        /// </summary>
        [JsonProperty(PropertyName = "appliedItemCount")]
        public int? AppliedItemCount { get; set; }

        /// <summary>
        /// Gets or sets total item count
        /// </summary>
        [JsonProperty(PropertyName = "totalItemCount")]
        public int? TotalItemCount { get; set; }

        /// <summary>
        /// Gets or sets applied bytes
        /// </summary>
        [JsonProperty(PropertyName = "appliedBytes")]
        public int? AppliedBytes { get; set; }

        /// <summary>
        /// Gets or sets total bytes
        /// </summary>
        [JsonProperty(PropertyName = "totalBytes")]
        public int? TotalBytes { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PerItemErrorCount > 2147483647)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "PerItemErrorCount", 2147483647);
            }
            if (PerItemErrorCount < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "PerItemErrorCount", 0);
            }
            if (AppliedItemCount > 2147483647)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "AppliedItemCount", 2147483647);
            }
            if (AppliedItemCount < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "AppliedItemCount", 0);
            }
            if (TotalItemCount > 2147483647)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "TotalItemCount", 2147483647);
            }
            if (TotalItemCount < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "TotalItemCount", 0);
            }
            if (AppliedBytes > 2147483647)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "AppliedBytes", 2147483647);
            }
            if (AppliedBytes < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "AppliedBytes", 0);
            }
            if (TotalBytes > 2147483647)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "TotalBytes", 2147483647);
            }
            if (TotalBytes < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "TotalBytes", 0);
            }
        }
    }
}
