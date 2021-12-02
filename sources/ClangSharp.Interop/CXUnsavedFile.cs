// Copyright (c) .NET Foundation and Contributors. All Rights Reserved. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from https://github.com/llvm/llvm-project/tree/llvmorg-13.0.0/clang/include/clang-c
// Original source is Copyright (c) the LLVM Project and Contributors. Licensed under the Apache License v2.0 with LLVM Exceptions. See NOTICE.txt in the project root for license information.

using System;

namespace ClangSharp.Interop
{
    public unsafe partial struct CXUnsavedFile
    {
        [NativeTypeName("const char *")]
        public sbyte* Filename;

        [NativeTypeName("const char *")]
        public sbyte* Contents;

        [NativeTypeName("unsigned long")]
        public UIntPtr Length;
    }
}