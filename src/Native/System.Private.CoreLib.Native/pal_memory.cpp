// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
#include <stdlib.h>

extern "C" void *MemAlloc(size_t size)
{
    return malloc(size);
}

extern "C" void *MemReAlloc(void *ptr, size_t size)
{
    return realloc(ptr, size);
}

extern "C" void MemFree(void *ptr)
{
    free(ptr);
}
