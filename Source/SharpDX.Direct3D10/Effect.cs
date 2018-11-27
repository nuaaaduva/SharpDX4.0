﻿// Copyright (c) 2010-2014 SharpDX - Alexandre Mutel
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using System;
using System.IO;
using System.Text;

using SharpDX.D3DCompiler;
using SharpDX.Direct3D;

namespace SharpDX.Direct3D10
{
    public partial class Effect
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Effect"/> class.
        /// </summary>
        /// <param name="device">The device.</param>
        /// <param name="effectByteCode">The effect byte code.</param>
        /// <param name="fxFlags">Effect compile options</param>
        /// <param name="effectPool">Optional. A reference to an memory space for effect variables that are shared across effects (see <see cref="SharpDX.Direct3D10.EffectPool"/>).</param>
        public unsafe Effect(Device device, byte[] effectByteCode, EffectFlags fxFlags = EffectFlags.None, EffectPool effectPool = null) 
        {
            fixed (void* ptr = effectByteCode)
                D3D10.CreateEffectFromMemory((IntPtr)ptr, effectByteCode.Length, (int)fxFlags, device, effectPool, this);
        }
  }
}