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
	[Register ("AboutViewController")]
	partial class AboutViewController
	{
		[Outlet]
		AppKit.NSTextField VersionField { get; set; }

		[Action ("ShowIcons8License:")]
		partial void ShowIcons8License (Foundation.NSObject sender);

		void ReleaseDesignerOutlets ()
		{
			if (VersionField != null) {
				VersionField.Dispose ();
				VersionField = null;
			}

		}
	}
}
