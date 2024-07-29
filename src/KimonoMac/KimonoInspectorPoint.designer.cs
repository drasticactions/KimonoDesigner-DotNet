// WARNING
//
// This file has been generated automatically by Rider IDE
//   to store outlets and actions made in Xcode.
// If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace KimonoMac
{
	[Register ("KimonoInspectorPoint")]
	partial class KimonoInspectorPoint
	{
		[Outlet]
		AppKit.NSButton DeleteButton { get; set; }

		[Outlet]
		AppKit.NSButton DuplicateButton { get; set; }

		[Action ("DeletePoint:")]
		partial void DeletePoint (Foundation.NSObject sender);

		[Action ("DuplicatePoint:")]
		partial void DuplicatePoint (Foundation.NSObject sender);

		void ReleaseDesignerOutlets ()
		{
			if (DeleteButton != null) {
				DeleteButton.Dispose ();
				DeleteButton = null;
			}

			if (DuplicateButton != null) {
				DuplicateButton.Dispose ();
				DuplicateButton = null;
			}

		}
	}
}
