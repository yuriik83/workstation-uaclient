﻿// Copyright (c) Converter Systems LLC. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;

namespace Workstation.ServiceModel.Ua
{
    public static class MonitoredItemServiceSet
    {
        /// <summary>
        /// Creates and adds one or more MonitoredItems to a Subscription.
        /// </summary>
        /// <param name="client">A instance of <see cref="ISessionClient"/>.</param>
        /// <param name="request">A <see cref="CreateMonitoredItemsRequest"/>.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation that returns a <see cref="CreateMonitoredItemsResponse"/>.</returns>
        public static async Task<CreateMonitoredItemsResponse> CreateMonitoredItemsAsync(this ISessionClient client, CreateMonitoredItemsRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException("request");
            }

            return (CreateMonitoredItemsResponse)await client.RequestAsync(request).ConfigureAwait(false);
        }

        /// <summary>
        /// Modifies MonitoredItems of a Subscription.
        /// </summary>
        /// <param name="client">A instance of <see cref="ISessionClient"/>.</param>
        /// <param name="request">A <see cref="ModifyMonitoredItemsRequest"/>.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation that returns a <see cref="ModifyMonitoredItemsResponse"/>.</returns>
        public static async Task<ModifyMonitoredItemsResponse> ModifyMonitoredItemsAsync(this ISessionClient client, ModifyMonitoredItemsRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException("request");
            }

            return (ModifyMonitoredItemsResponse)await client.RequestAsync(request).ConfigureAwait(false);
        }

        /// <summary>
        /// Sets the monitoring mode for one or more MonitoredItems of a Subscription.
        /// </summary>
        /// <param name="client">A instance of <see cref="ISessionClient"/>.</param>
        /// <param name="request">A <see cref="SetMonitoringModeRequest"/>.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation that returns a <see cref="SetMonitoringModeResponse"/>.</returns>
        public static async Task<SetMonitoringModeResponse> SetMonitoringModeAsync(this ISessionClient client, SetMonitoringModeRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException("request");
            }

            return (SetMonitoringModeResponse)await client.RequestAsync(request).ConfigureAwait(false);
        }

        /// <summary>
        /// Creates and deletes triggering links for a triggering item.
        /// </summary>
        /// <param name="client">A instance of <see cref="ISessionClient"/>.</param>
        /// <param name="request">A <see cref="SetTriggeringRequest"/>.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation that returns a <see cref="SetTriggeringResponse"/>.</returns>
        public static async Task<SetTriggeringResponse> SetTriggeringAsync(this ISessionClient client, SetTriggeringRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException("request");
            }

            return (SetTriggeringResponse)await client.RequestAsync(request).ConfigureAwait(false);
        }

        /// <summary>
        /// Removes one or more MonitoredItems of a Subscription.
        /// </summary>
        /// <param name="client">A instance of <see cref="ISessionClient"/>.</param>
        /// <param name="request">A <see cref="DeleteMonitoredItemsRequest"/>.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation that returns a <see cref="DeleteMonitoredItemsResponse"/>.</returns>
        public static async Task<DeleteMonitoredItemsResponse> DeleteMonitoredItemsAsync(this ISessionClient client, DeleteMonitoredItemsRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException("request");
            }

            return (DeleteMonitoredItemsResponse)await client.RequestAsync(request).ConfigureAwait(false);
        }

    }
}
