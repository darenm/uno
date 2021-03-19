// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace Windows.UI.Xaml.Controls
{
	public partial class SwipeItemInvokedEventArgs
	{
		public SwipeControl SwipeControl { get; }

		internal SwipeItemInvokedEventArgs(SwipeControl swipeControl)
		{
			SwipeControl = swipeControl;
		}
	}
}
