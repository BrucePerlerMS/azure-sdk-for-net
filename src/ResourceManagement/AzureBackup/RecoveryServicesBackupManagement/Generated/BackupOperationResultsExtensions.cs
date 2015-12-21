// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.RecoveryServices.Backup;
using Microsoft.Azure.Management.RecoveryServices.Backup.Models;

namespace Microsoft.Azure.Management.RecoveryServices.Backup
{
    public static partial class BackupOperationResultsExtensions
    {
        /// <summary>
        /// Get the Delete Item Operation Result
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IBackupOperationResults.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. ResourceGroupName for recoveryServices Vault.
        /// </param>
        /// <param name='resourceName'>
        /// Required. ResourceName for recoveryServices Vault.
        /// </param>
        /// <param name='operationId'>
        /// Required.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The definition of a GetOperationResultResponse.
        /// </returns>
        public static GetOperationResultResponse GetBackupOperationResult(this IBackupOperationResults operations, string resourceGroupName, string resourceName, string operationId, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IBackupOperationResults)s).GetBackupOperationResultAsync(resourceGroupName, resourceName, operationId, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get the Delete Item Operation Result
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IBackupOperationResults.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. ResourceGroupName for recoveryServices Vault.
        /// </param>
        /// <param name='resourceName'>
        /// Required. ResourceName for recoveryServices Vault.
        /// </param>
        /// <param name='operationId'>
        /// Required.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The definition of a GetOperationResultResponse.
        /// </returns>
        public static Task<GetOperationResultResponse> GetBackupOperationResultAsync(this IBackupOperationResults operations, string resourceGroupName, string resourceName, string operationId, CustomRequestHeaders customRequestHeaders)
        {
            return operations.GetBackupOperationResultAsync(resourceGroupName, resourceName, operationId, customRequestHeaders, CancellationToken.None);
        }
    }
}
