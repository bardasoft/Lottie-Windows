// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.Toolkit.Uwp.UI.Lottie.WinCompData
{
#if !WINDOWS_UWP
    public
#endif
    sealed class CompositionColorBrush : CompositionBrush
    {
        internal CompositionColorBrush(Wui.Color color)
        {
            Color = color;
        }

        public Wui.Color Color { get; set; }

        /// <inheritdoc/>
        public override CompositionObjectType Type => CompositionObjectType.CompositionColorBrush;
    }
}