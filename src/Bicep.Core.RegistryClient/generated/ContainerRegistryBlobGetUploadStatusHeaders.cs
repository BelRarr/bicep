// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;

namespace Bicep.Core.RegistryClient
{
    internal partial class ContainerRegistryBlobGetUploadStatusHeaders
    {
        private readonly Response _response;
        public ContainerRegistryBlobGetUploadStatusHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> Range indicating the current progress of the upload. </summary>
        public string Range => _response.Headers.TryGetValue("Range", out string value) ? value : null;
        /// <summary> Identifies the docker upload uuid for the current request. </summary>
        public string DockerUploadUuid => _response.Headers.TryGetValue("Docker-Upload-UUID", out string value) ? value : null;
    }
}
