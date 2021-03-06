﻿// Copyright (c) Converter Systems LLC. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;

namespace Workstation.ServiceModel.Ua
{
    public static class ViewServiceSet
    {
        /// <summary>
        /// Discovers the References of a specified Node.
        /// </summary>
        /// <param name="client">A instance of <see cref="ISessionClient"/>.</param>
        /// <param name="request">A <see cref="BrowseRequest"/>.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation that returns a <see cref="BrowseResponse"/>.</returns>
        public static async Task<BrowseResponse> BrowseAsync(this ISessionClient client, BrowseRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return (BrowseResponse)await client.RequestAsync(request).ConfigureAwait(false);
        }

        /// <summary>
        /// Requests the next set of Browse responses, when the information is too large to be sent in a single response.
        /// </summary>
        /// <param name="client">A instance of <see cref="ISessionClient"/>.</param>
        /// <param name="request">A <see cref="BrowseNextRequest"/>.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation that returns a <see cref="BrowseNextResponse"/>.</returns>
        public static async Task<BrowseNextResponse> BrowseNextAsync(this ISessionClient client, BrowseNextRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return (BrowseNextResponse)await client.RequestAsync(request).ConfigureAwait(false);
        }

        /// <summary>
        /// Translates one or more browse paths to NodeIds.
        /// </summary>
        /// <param name="client">A instance of <see cref="ISessionClient"/>.</param>
        /// <param name="request">A <see cref="TranslateBrowsePathsToNodeIdsRequest"/>.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation that returns a <see cref="TranslateBrowsePathsToNodeIdsResponse"/>.</returns>
        public static async Task<TranslateBrowsePathsToNodeIdsResponse> TranslateBrowsePathsToNodeIdsAsync(this ISessionClient client, TranslateBrowsePathsToNodeIdsRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return (TranslateBrowsePathsToNodeIdsResponse)await client.RequestAsync(request).ConfigureAwait(false);
        }

        /// <summary>
        /// Registers the Nodes that will be accessed repeatedly (e.g. Write, Call).
        /// </summary>
        /// <param name="client">A instance of <see cref="ISessionClient"/>.</param>
        /// <param name="request">A <see cref="RegisterNodesRequest"/>.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation that returns a <see cref="RegisterNodesResponse"/>.</returns>
        public static async Task<RegisterNodesResponse> RegisterNodesAsync(this ISessionClient client, RegisterNodesRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException("request");
            }

            return (RegisterNodesResponse)await client.RequestAsync(request).ConfigureAwait(false);
        }

        /// <summary>
        /// Unregisters NodeIds that have been obtained via the RegisterNodes service.
        /// </summary>
        /// <param name="client">A instance of <see cref="ISessionClient"/>.</param>
        /// <param name="request">A <see cref="UnregisterNodesRequest"/>.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation that returns a <see cref="UnregisterNodesResponse"/>.</returns>
        public static async Task<UnregisterNodesResponse> UnregisterNodesAsync(this ISessionClient client, UnregisterNodesRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException("request");
            }

            return (UnregisterNodesResponse)await client.RequestAsync(request).ConfigureAwait(false);
        }
    }
}
