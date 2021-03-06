// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.FrontDoor.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes azure managed provider.
    /// </summary>
    public partial class AzureManagedRuleSet : ManagedRuleSet
    {
        /// <summary>
        /// Initializes a new instance of the AzureManagedRuleSet class.
        /// </summary>
        public AzureManagedRuleSet()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureManagedRuleSet class.
        /// </summary>
        /// <param name="priority">Describes priority of the rule</param>
        /// <param name="version">defines version of the rule set</param>
        /// <param name="ruleGroupOverrides">List of azure managed provider
        /// override configuration (optional)</param>
        public AzureManagedRuleSet(int? priority = default(int?), int? version = default(int?), IList<AzureManagedOverrideRuleGroup> ruleGroupOverrides = default(IList<AzureManagedOverrideRuleGroup>))
            : base(priority, version)
        {
            RuleGroupOverrides = ruleGroupOverrides;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of azure managed provider override configuration
        /// (optional)
        /// </summary>
        [JsonProperty(PropertyName = "ruleGroupOverrides")]
        public IList<AzureManagedOverrideRuleGroup> RuleGroupOverrides { get; set; }

    }
}
