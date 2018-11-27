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

namespace SharpDX.Direct3D9
{
    public partial class DisplayModeEx
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DisplayModeEx" /> class.
        /// </summary>
        public DisplayModeEx()
        {
            Size = Utilities.SizeOf<__Native>();
        }

        /// <summary>
        /// Gets the aspect ratio.
        /// </summary>
        public float AspectRatio
        {
            get
            {
                return (float)Width/Height;
            }
        }

        public override string ToString()
        {
            return string.Format("Width: {0}, Height: {1}, RefreshRate: {2}, Format: {3}", Width, Height, RefreshRate, Format);
        }

        internal static __Native __NewNative()
        {
            return new __Native { Size = Utilities.SizeOf<__Native>() };
        }
    }
}