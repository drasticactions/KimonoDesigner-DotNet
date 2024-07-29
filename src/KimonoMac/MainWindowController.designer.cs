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
	[Register ("MainWindowController")]
	partial class MainWindowController
	{
		[Outlet]
		KimonoMac.ActivatableItem AlignBottomTool { get; set; }

		[Outlet]
		KimonoMac.ActivatableItem AlignLeftTool { get; set; }

		[Outlet]
		KimonoMac.ActivatableItem AlignRightTool { get; set; }

		[Outlet]
		KimonoMac.ActivatableItem AlignTopTool { get; set; }

		[Outlet]
		KimonoMac.ActivatableItem CenterHorizontalTool { get; set; }

		[Outlet]
		KimonoMac.ActivatableItem CenterTool { get; set; }

		[Outlet]
		KimonoMac.ActivatableItem CenterVerticalTool { get; set; }

		[Outlet]
		KimonoMac.ActivatableItem GroupShapes { get; set; }

		[Outlet]
		KimonoMac.ActivatableItem MoveBackwardsTool { get; set; }

		[Outlet]
		KimonoMac.ActivatableItem MoveBottomTool { get; set; }

		[Outlet]
		KimonoMac.ActivatableItem MoveForwardsTool { get; set; }

		[Outlet]
		KimonoMac.ActivatableItem MoveTopTool { get; set; }

		[Outlet]
		KimonoMac.ActivatableItem UngroupShapes { get; set; }

		[Action ("addColor:")]
		partial void addColor (Foundation.NSObject sender);

		[Action ("addGradient:")]
		partial void addGradient (Foundation.NSObject sender);

		[Action ("addSketch:")]
		partial void addSketch (Foundation.NSObject sender);

		[Action ("addStyle:")]
		partial void addStyle (Foundation.NSObject sender);

		[Action ("saveDocument:")]
		partial void saveDocument (Foundation.NSObject sender);

		[Action ("saveDocumentAs:")]
		partial void saveDocumentAs (Foundation.NSObject sender);

		void ReleaseDesignerOutlets ()
		{
			if (AlignBottomTool != null) {
				AlignBottomTool.Dispose ();
				AlignBottomTool = null;
			}

			if (AlignLeftTool != null) {
				AlignLeftTool.Dispose ();
				AlignLeftTool = null;
			}

			if (AlignRightTool != null) {
				AlignRightTool.Dispose ();
				AlignRightTool = null;
			}

			if (AlignTopTool != null) {
				AlignTopTool.Dispose ();
				AlignTopTool = null;
			}

			if (CenterHorizontalTool != null) {
				CenterHorizontalTool.Dispose ();
				CenterHorizontalTool = null;
			}

			if (CenterTool != null) {
				CenterTool.Dispose ();
				CenterTool = null;
			}

			if (CenterVerticalTool != null) {
				CenterVerticalTool.Dispose ();
				CenterVerticalTool = null;
			}

			if (GroupShapes != null) {
				GroupShapes.Dispose ();
				GroupShapes = null;
			}

			if (MoveBackwardsTool != null) {
				MoveBackwardsTool.Dispose ();
				MoveBackwardsTool = null;
			}

			if (MoveBottomTool != null) {
				MoveBottomTool.Dispose ();
				MoveBottomTool = null;
			}

			if (MoveForwardsTool != null) {
				MoveForwardsTool.Dispose ();
				MoveForwardsTool = null;
			}

			if (MoveTopTool != null) {
				MoveTopTool.Dispose ();
				MoveTopTool = null;
			}

			if (UngroupShapes != null) {
				UngroupShapes.Dispose ();
				UngroupShapes = null;
			}

		}
	}
}
