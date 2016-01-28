// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace System.Runtime.InteropServices
{
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Interface | AttributeTargets.Class | AttributeTargets.Struct, Inherited = false)]
    public sealed class BestFitMappingAttribute : Attribute
    {
        internal bool _bestFitMapping;

        public BestFitMappingAttribute(bool BestFitMapping)
        {
            _bestFitMapping = BestFitMapping;
        }

        public bool BestFitMapping { get { return _bestFitMapping; } }
        public bool ThrowOnUnmappableChar;
    }
}
