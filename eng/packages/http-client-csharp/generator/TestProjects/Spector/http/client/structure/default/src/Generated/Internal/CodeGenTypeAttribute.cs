// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Client.Structure.Service
{
    [AttributeUsage((AttributeTargets.Class | AttributeTargets.Struct))]
    internal partial class CodeGenTypeAttribute : Attribute
    {
        public CodeGenTypeAttribute(string originalName)
        {
            OriginalName = originalName;
        }

        /// <summary> Gets the OriginalName. </summary>
        public string OriginalName { get; }
    }
}
