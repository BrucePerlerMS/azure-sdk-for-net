// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure;

namespace Microsoft.Azure.Management.Automation.Models
{
    /// <summary>
    /// The response model for the get configuration operation.
    /// </summary>
    public partial class DscConfigurationGetContentResponse : AzureOperationResponse
    {
        private string _content;
        
        /// <summary>
        /// Optional. Gets or sets a configuration content.
        /// </summary>
        public string Content
        {
            get { return this._content; }
            set { this._content = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// DscConfigurationGetContentResponse class.
        /// </summary>
        public DscConfigurationGetContentResponse()
        {
        }
    }
}
