﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

internal static partial class Interop
{
    internal static partial class User32
    {
        [Flags]
        public enum MDITILE : uint
        {
            VERTICAL = 0x0000,
            HORIZONTAL = 0x0001,
            SKIPDISABLED = 0x0002,
            ZORDER = 0x0004
        }
    }
}
