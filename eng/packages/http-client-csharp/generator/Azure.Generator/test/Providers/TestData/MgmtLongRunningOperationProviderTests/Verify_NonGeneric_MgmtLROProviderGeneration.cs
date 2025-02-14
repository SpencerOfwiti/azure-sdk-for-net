﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Samples
{
    internal partial class SamplesArmOperation : global::Azure.ResourceManager.ArmOperation
    {
        private readonly global::Azure.Core.OperationInternal _operation;
        private readonly global::Azure.Core.RehydrationToken? _completeRehydrationToken;
        private readonly global::Azure.Core.NextLinkOperationImplementation _nextLinkOperation;
        private readonly string _operationId;

        protected SamplesArmOperation()
        {
        }

        internal SamplesArmOperation(global::Azure.Response response, global::Azure.Core.RehydrationToken? rehydrationToken = null)
        {
            _operation = global::Azure.Core.OperationInternal.Succeeded(response);
            _completeRehydrationToken = rehydrationToken;
            _operationId = this.GetOperationId(rehydrationToken);
        }

        internal SamplesArmOperation(global::Azure.Core.Pipeline.ClientDiagnostics clientDiagnostics, global::Azure.Core.Pipeline.HttpPipeline pipeline, global::Azure.Core.Request request, global::Azure.Response response, global::Azure.Core.OperationFinalStateVia finalStateVia, bool skipApiVersionOverride = false, string apiVersionOverrideValue = null)
        {
            global::Azure.Core.IOperation nextLinkOperation = global::Azure.Core.NextLinkOperationImplementation.Create(pipeline, request.Method, request.Uri.ToUri(), response, finalStateVia, skipApiVersionOverride, apiVersionOverrideValue);
            if ((nextLinkOperation is global::Azure.Core.NextLinkOperationImplementation nextLinkOperationImplementation))
            {
                _nextLinkOperation = nextLinkOperationImplementation;
                _operationId = _nextLinkOperation.OperationId;
            }
            else
            {
                _completeRehydrationToken = global::Azure.Core.NextLinkOperationImplementation.GetRehydrationToken(request.Method, request.Uri.ToUri(), response, finalStateVia);
                _operationId = this.GetOperationId(_completeRehydrationToken);
            }
            _operation = new global::Azure.Core.OperationInternal(
                nextLinkOperation,
                clientDiagnostics,
                response,
                "SamplesArmOperation",
                null,
                new global::Azure.Core.SequentialDelayStrategy());
        }

        /// <summary> Gets the Id. </summary>
        public override string Id => (_operationId ?? global::Azure.Core.NextLinkOperationImplementation.NotSet);

        /// <summary> Gets the HasCompleted. </summary>
        public override bool HasCompleted => _operation.HasCompleted;

        private string GetOperationId(global::Azure.Core.RehydrationToken? rehydrationToken)
        {
            if ((rehydrationToken is null))
            {
                return null;
            }
            global::System.Collections.Generic.Dictionary<string, string> lroDetails = global::System.ClientModel.Primitives.ModelReaderWriter.Write(rehydrationToken, global::System.ClientModel.Primitives.ModelReaderWriterOptions.Json).ToObjectFromJson<global::System.Collections.Generic.Dictionary<string, string>>();
            return lroDetails["id"];
        }

        /// <inheritdoc/>
        public override global::Azure.Core.RehydrationToken? GetRehydrationToken() => (_nextLinkOperation?.GetRehydrationToken() ?? _completeRehydrationToken);

        /// <inheritdoc/>
        public override global::Azure.Response GetRawResponse() => _operation.RawResponse;

        /// <inheritdoc/>
        public override global::Azure.Response UpdateStatus(global::System.Threading.CancellationToken cancellationToken = ((global::System.Threading.CancellationToken)default)) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc/>
        public override global::System.Threading.Tasks.ValueTask<global::Azure.Response> UpdateStatusAsync(global::System.Threading.CancellationToken cancellationToken = ((global::System.Threading.CancellationToken)default)) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc/>
        public override global::Azure.Response WaitForCompletionResponse(global::System.Threading.CancellationToken cancellationToken = ((global::System.Threading.CancellationToken)default)) => _operation.WaitForCompletionResponse(cancellationToken);

        /// <inheritdoc/>
        public override global::Azure.Response WaitForCompletionResponse(global::System.TimeSpan pollingInterval, global::System.Threading.CancellationToken cancellationToken = ((global::System.Threading.CancellationToken)default)) => _operation.WaitForCompletionResponse(pollingInterval, cancellationToken);

        /// <inheritdoc/>
        public override global::System.Threading.Tasks.ValueTask<global::Azure.Response> WaitForCompletionResponseAsync(global::System.Threading.CancellationToken cancellationToken = ((global::System.Threading.CancellationToken)default)) => _operation.WaitForCompletionResponseAsync(cancellationToken);

        /// <inheritdoc/>
        public override global::System.Threading.Tasks.ValueTask<global::Azure.Response> WaitForCompletionResponseAsync(global::System.TimeSpan pollingInterval, global::System.Threading.CancellationToken cancellationToken = ((global::System.Threading.CancellationToken)default)) => _operation.WaitForCompletionResponseAsync(pollingInterval, cancellationToken);
    }
}
