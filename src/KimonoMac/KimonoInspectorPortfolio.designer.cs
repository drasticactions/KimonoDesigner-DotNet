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
	[Register ("KimonoInspectorPortfolio")]
	partial class KimonoInspectorPortfolio
	{
		[Outlet]
		AppKit.NSTextField AuthorField { get; set; }

		[Outlet]
		KimonoMac.KimonoTextView CopyrightField { get; set; }

		[Outlet]
		AppKit.NSTextField NameField { get; set; }

		[Outlet]
		AppKit.NSTextField NamespaceField { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (AuthorField != null) {
				AuthorField.Dispose ();
				AuthorField = null;
			}

			if (CopyrightField != null) {
				CopyrightField.Dispose ();
				CopyrightField = null;
			}

			if (NameField != null) {
				NameField.Dispose ();
				NameField = null;
			}

			if (NamespaceField != null) {
				NamespaceField.Dispose ();
				NamespaceField = null;
			}

		}
	}
}
