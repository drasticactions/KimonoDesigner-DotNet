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
	[Register ("KimonoInspectorPropertyNumber")]
	partial class KimonoInspectorPropertyNumber
	{
		[Outlet]
		AppKit.NSTextField ValueField { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (ValueField != null) {
				ValueField.Dispose ();
				ValueField = null;
			}

		}
	}
}
