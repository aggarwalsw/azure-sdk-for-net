// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Storage.Common;
using Azure.Storage.Files.DataLake.Models;

namespace Azure.Storage.Files.DataLake
{
    internal partial class ServiceRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly string _url;
        private readonly string _version;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of ServiceRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="url"> The URL of the service account, container, or blob that is the target of the desired operation. </param>
        /// <param name="version"> Specifies the version of the operation to use for this request. The default value is "2025-01-05". </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/>, <paramref name="url"/> or <paramref name="version"/> is null. </exception>
        public ServiceRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string url, string version)
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _url = url ?? throw new ArgumentNullException(nameof(url));
            _version = version ?? throw new ArgumentNullException(nameof(version));
        }

        internal HttpMessage CreateListFileSystemsRequest(string prefix, string continuation, int? maxResults, int? timeout)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_url, false);
            uri.AppendPath("/", false);
            uri.AppendQuery("resource", "account", true);
            if (prefix != null)
            {
                uri.AppendQuery("prefix", prefix, true);
            }
            if (continuation != null)
            {
                uri.AppendQuery("continuation", continuation, true);
            }
            if (maxResults != null)
            {
                uri.AppendQuery("maxResults", maxResults.Value, true);
            }
            if (timeout != null)
            {
                uri.AppendQuery("timeout", timeout.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("x-ms-version", _version);
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> List FileSystems. </summary>
        /// <param name="prefix"> Filters results to filesystems within the specified prefix. </param>
        /// <param name="continuation"> Optional.  When deleting a directory, the number of paths that are deleted with each invocation is limited.  If the number of paths to be deleted exceeds this limit, a continuation token is returned in this response header.  When a continuation token is returned in the response, it must be specified in a subsequent invocation of the delete operation to continue deleting the directory. </param>
        /// <param name="maxResults"> An optional value that specifies the maximum number of items to return. If omitted or greater than 5,000, the response will include up to 5,000 items. </param>
        /// <param name="timeout"> The timeout parameter is expressed in seconds. For more information, see &lt;a href="https://docs.microsoft.com/en-us/rest/api/storageservices/fileservices/setting-timeouts-for-blob-service-operations"&gt;Setting Timeouts for Blob Service Operations.&lt;/a&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> List filesystems and their properties in given account. </remarks>
        public async Task<ResponseWithHeaders<FileSystemList, ServiceListFileSystemsHeaders>> ListFileSystemsAsync(string prefix = null, string continuation = null, int? maxResults = null, int? timeout = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateListFileSystemsRequest(prefix, continuation, maxResults, timeout);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new ServiceListFileSystemsHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FileSystemList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = FileSystemList.DeserializeFileSystemList(document.RootElement);
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List FileSystems. </summary>
        /// <param name="prefix"> Filters results to filesystems within the specified prefix. </param>
        /// <param name="continuation"> Optional.  When deleting a directory, the number of paths that are deleted with each invocation is limited.  If the number of paths to be deleted exceeds this limit, a continuation token is returned in this response header.  When a continuation token is returned in the response, it must be specified in a subsequent invocation of the delete operation to continue deleting the directory. </param>
        /// <param name="maxResults"> An optional value that specifies the maximum number of items to return. If omitted or greater than 5,000, the response will include up to 5,000 items. </param>
        /// <param name="timeout"> The timeout parameter is expressed in seconds. For more information, see &lt;a href="https://docs.microsoft.com/en-us/rest/api/storageservices/fileservices/setting-timeouts-for-blob-service-operations"&gt;Setting Timeouts for Blob Service Operations.&lt;/a&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> List filesystems and their properties in given account. </remarks>
        public ResponseWithHeaders<FileSystemList, ServiceListFileSystemsHeaders> ListFileSystems(string prefix = null, string continuation = null, int? maxResults = null, int? timeout = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateListFileSystemsRequest(prefix, continuation, maxResults, timeout);
            _pipeline.Send(message, cancellationToken);
            var headers = new ServiceListFileSystemsHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FileSystemList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = FileSystemList.DeserializeFileSystemList(document.RootElement);
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
