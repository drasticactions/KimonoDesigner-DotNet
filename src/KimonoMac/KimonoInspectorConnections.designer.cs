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
	[Register ("KimonoInspectorConnections")]
	partial class KimonoInspectorConnections
	{
		[Outlet]
		KimonoMac.SourceListView ConnectionList { get; set; }

		[Outlet]
		AppKit.NSPopUpButton PropertyDropdown { get; set; }

		[Action ("PropertyChanged:")]
		partial void PropertyChanged (Foundation.NSObject sender);

		void ReleaseDesignerOutlets ()
		{
			if (ConnectionList != null) {
				ConnectionList.Dispose ();
				ConnectionList = null;
			}

			if (PropertyDropdown != null) {
				PropertyDropdown.Dispose ();
				PropertyDropdown = null;
			}

		}
	}
}
