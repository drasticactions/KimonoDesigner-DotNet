﻿// WARNING
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
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		KimonoMac.KimonoInspectorArrow ArrowInspector { get; set; }

		[Outlet]
		KimonoMac.KimonoInspectorAttachedStyle AttachedStyleInspector { get; set; }

		[Outlet]
		AppKit.NSButton BackButton { get; set; }

		[Outlet]
		KimonoMac.KimonoInspectorPropertyBoolean BooleanPropertyInspector { get; set; }

		[Outlet]
		AppKit.NSButton BorderInspectorsButton { get; set; }

		[Outlet]
		KimonoMac.KimonoInspectorPaleteColor ColorPaletteInspector { get; set; }

		[Outlet]
		AppKit.NSButton ConnectionInspectorsButton { get; set; }

		[Outlet]
		KimonoMac.KimonoInspectorConnections ConnectionsInspector { get; set; }

		[Outlet]
		KimonoCore.Mac.KimonoDesignSurface DesignSurface { get; set; }

		[Outlet]
		AppKit.NSButton DetailsInspectorButton { get; set; }

		[Outlet]
		AppKit.NSScrollView DocumentScrollView { get; set; }

		[Outlet]
		AppKit.NSView DocumentView { get; set; }

		[Outlet]
		AppKit.NSLayoutConstraint DocumentViewHeight { get; set; }

		[Outlet]
		AppKit.NSLayoutConstraint DocumentViewWidth { get; set; }

		[Outlet]
		AppKit.NSButton ExportButton { get; set; }

		[Outlet]
		KimonoMac.KimonoInspectorFill FillInspector { get; set; }

		[Outlet]
		AppKit.NSButton FillInspectorsButton { get; set; }

		[Outlet]
		KimonoMac.KimonoInspectorFont FontInspector { get; set; }

		[Outlet]
		KimonoMac.KimonoInspectorFrame FrameInspector { get; set; }

		[Outlet]
		KimonoMac.KimonoInspectorGeneralInfo GeneralInfoInspector { get; set; }

		[Outlet]
		KimonoMac.KimonoInspectorGradient GradientInspector { get; set; }

		[Outlet]
		KimonoMac.KimonoInspectorGroup GroupInspector { get; set; }

		[Outlet]
		AppKit.NSScrollView InspectorScrollView { get; set; }

		[Outlet]
		AppKit.NSView InspectorView { get; set; }

		[Outlet]
		AppKit.NSPopUpButton LanguageSelector { get; set; }

		[Outlet]
		AppKit.NSPopUpButton LibrarySelector { get; set; }

		[Outlet]
		KimonoMac.KimonoInspectorPropertyNumber NumberPropertyInspector { get; set; }

		[Outlet]
		AppKit.NSPopUpButton OSSelector { get; set; }

		[Outlet]
		KimonoMac.KimonoInspectorPoint PointInspector { get; set; }

		[Outlet]
		KimonoMac.KimonoInspectorPolygon PolygonInspector { get; set; }

		[Outlet]
		KimonoMac.KimonoInspectorPortfolio PortfolioInspector { get; set; }

		[Outlet]
		KimonoMac.KimonoInspectorProperty PropertyInspector { get; set; }

		[Outlet]
		KimonoMac.KimonoInspectorRoundRect RoundRectInspector { get; set; }

		[Outlet]
		KimonoMac.KimonoInspectorScriptDebugger ScriptDebuggerInspector { get; set; }

		[Outlet]
		KimonoMac.KimonoInspectorSketch SketchInspector { get; set; }

		[Outlet]
		AppKit.NSTextField SketchPath { get; set; }

		[Outlet]
		KimonoMac.SourceListView SourceList { get; set; }

		[Outlet]
		KimonoMac.KimonoInspectorStar StarInspector { get; set; }

		[Outlet]
		KimonoMac.KimonoInspectorStyle StyleInspector { get; set; }
		
		[Outlet]
		KimonoMac.KimonoInspectorPropertyRect RectPropertyInspector { get; set; }

		[Outlet]
		AppKit.TextKit.Formatter.SourceTextView TextEditor { get; set; }

		[Outlet]
		AppKit.NSTextField TextEditorMode { get; set; }

		[Outlet]
		AppKit.NSTextField TextEditorTitle { get; set; }

		[Outlet]
		KimonoMac.KimonoInspectorText TextInspector { get; set; }

		[Outlet]
		KimonoMac.KimonoInspectorPropertyText TextPropertyInspector { get; set; }

		[Outlet]
		AppKit.NSButton ToolArrow { get; set; }

		[Outlet]
		AppKit.NSButtonCell ToolBezier { get; set; }

		[Outlet]
		AppKit.NSButtonCell ToolCursor { get; set; }

		[Outlet]
		AppKit.NSButton ToolLine { get; set; }

		[Outlet]
		AppKit.NSButton ToolOval { get; set; }

		[Outlet]
		AppKit.NSButton ToolPolygon { get; set; }

		[Outlet]
		AppKit.NSButton ToolRect { get; set; }

		[Outlet]
		AppKit.NSButton ToolRoundRect { get; set; }

		[Outlet]
		AppKit.NSButton ToolStar { get; set; }

		[Outlet]
		AppKit.NSButton ToolText { get; set; }

		[Outlet]
		AppKit.NSButton ToolTriangle { get; set; }

		[Outlet]
		AppKit.NSButton ToolVector { get; set; }

		[Action ("addPropertyBoolean:")]
		partial void addPropertyBoolean (Foundation.NSObject sender);

		[Action ("addPropertyColor:")]
		partial void addPropertyColor (Foundation.NSObject sender);

		[Action ("addPropertyGradient:")]
		partial void addPropertyGradient (Foundation.NSObject sender);

		[Action ("addPropertyLibrary:")]
		partial void addPropertyLibrary (Foundation.NSObject sender);

		[Action ("addPropertyNumber:")]
		partial void addPropertyNumber (Foundation.NSObject sender);

		[Action ("addPropertyRect:")]
		partial void addPropertyRect (Foundation.NSObject sender);

		[Action ("addPropertyStyle:")]
		partial void addPropertyStyle (Foundation.NSObject sender);

		[Action ("addPropertyText:")]
		partial void addPropertyText (Foundation.NSObject sender);

		[Action ("alignShapeBottom:")]
		partial void alignShapeBottom (Foundation.NSObject sender);

		[Action ("alignShapeCenter:")]
		partial void alignShapeCenter (Foundation.NSObject sender);

		[Action ("alignShapeCenterHorizontal:")]
		partial void alignShapeCenterHorizontal (Foundation.NSObject sender);

		[Action ("alignShapeCenterVertical:")]
		partial void alignShapeCenterVertical (Foundation.NSObject sender);

		[Action ("alignShapeLeft:")]
		partial void alignShapeLeft (Foundation.NSObject sender);

		[Action ("alignShapeRight:")]
		partial void alignShapeRight (Foundation.NSObject sender);

		[Action ("alignShapeTop:")]
		partial void alignShapeTop (Foundation.NSObject sender);

		[Action ("delete:")]
		partial void delete (Foundation.NSObject sender);

		[Action ("duplicateSelectedShape:")]
		partial void duplicateSelectedShape (Foundation.NSObject sender);

		[Action ("ExportSource:")]
		partial void ExportSource (Foundation.NSObject sender);

		[Action ("GoBackToSketch:")]
		partial void GoBackToSketch (Foundation.NSObject sender);

		[Action ("groupUngroupSelectedShapes:")]
		partial void groupUngroupSelectedShapes (Foundation.NSObject sender);

		[Action ("LanguageSelectionChanged:")]
		partial void LanguageSelectionChanged (Foundation.NSObject sender);

		[Action ("LibrarySelectionChanged:")]
		partial void LibrarySelectionChanged (Foundation.NSObject sender);

		[Action ("moveBackwards:")]
		partial void moveBackwards (Foundation.NSObject sender);

		[Action ("moveForwards:")]
		partial void moveForwards (Foundation.NSObject sender);

		[Action ("moveToBottom:")]
		partial void moveToBottom (Foundation.NSObject sender);

		[Action ("moveToTop:")]
		partial void moveToTop (Foundation.NSObject sender);

		[Action ("OSSelectionChanged:")]
		partial void OSSelectionChanged (Foundation.NSObject sender);

		[Action ("redo:")]
		partial void redo (Foundation.NSObject sender);

		[Action ("selectAll:")]
		partial void selectAll (Foundation.NSObject sender);

		[Action ("SwitchToBorderInspectors:")]
		partial void SwitchToBorderInspectors (Foundation.NSObject sender);

		[Action ("SwitchToConnectionInspectors:")]
		partial void SwitchToConnectionInspectors (Foundation.NSObject sender);

		[Action ("SwitchToDetailsInspectors:")]
		partial void SwitchToDetailsInspectors (Foundation.NSObject sender);

		[Action ("SwitchToFillInspectors:")]
		partial void SwitchToFillInspectors (Foundation.NSObject sender);

		[Action ("ToolArrowSelected:")]
		partial void ToolArrowSelected (Foundation.NSObject sender);

		[Action ("ToolBezierSelected:")]
		partial void ToolBezierSelected (Foundation.NSObject sender);

		[Action ("ToolCursorSelected:")]
		partial void ToolCursorSelected (Foundation.NSObject sender);

		[Action ("ToolLineSelected:")]
		partial void ToolLineSelected (Foundation.NSObject sender);

		[Action ("ToolOvalSelected:")]
		partial void ToolOvalSelected (Foundation.NSObject sender);

		[Action ("ToolPolygonSelected:")]
		partial void ToolPolygonSelected (Foundation.NSObject sender);

		[Action ("ToolRectSelected:")]
		partial void ToolRectSelected (Foundation.NSObject sender);

		[Action ("ToolRoundRectSelected:")]
		partial void ToolRoundRectSelected (Foundation.NSObject sender);

		[Action ("ToolStarSelected:")]
		partial void ToolStarSelected (Foundation.NSObject sender);

		[Action ("ToolTextSelected:")]
		partial void ToolTextSelected (Foundation.NSObject sender);

		[Action ("ToolTriangleSelected:")]
		partial void ToolTriangleSelected (Foundation.NSObject sender);

		[Action ("ToolVectorSelected:")]
		partial void ToolVectorSelected (Foundation.NSObject sender);

		[Action ("undo:")]
		partial void undo (Foundation.NSObject sender);

		[Action ("validateMenuItem:")]
		partial void validateMenuItem (AppKit.NSMenuItem item);

		void ReleaseDesignerOutlets ()
		{
			if (ArrowInspector != null) {
				ArrowInspector.Dispose ();
				ArrowInspector = null;
			}

			if (AttachedStyleInspector != null) {
				AttachedStyleInspector.Dispose ();
				AttachedStyleInspector = null;
			}

			if (BackButton != null) {
				BackButton.Dispose ();
				BackButton = null;
			}

			if (BooleanPropertyInspector != null) {
				BooleanPropertyInspector.Dispose ();
				BooleanPropertyInspector = null;
			}

			if (BorderInspectorsButton != null) {
				BorderInspectorsButton.Dispose ();
				BorderInspectorsButton = null;
			}

			if (ColorPaletteInspector != null) {
				ColorPaletteInspector.Dispose ();
				ColorPaletteInspector = null;
			}

			if (ConnectionInspectorsButton != null) {
				ConnectionInspectorsButton.Dispose ();
				ConnectionInspectorsButton = null;
			}

			if (ConnectionsInspector != null) {
				ConnectionsInspector.Dispose ();
				ConnectionsInspector = null;
			}

			if (DesignSurface != null) {
				DesignSurface.Dispose ();
				DesignSurface = null;
			}

			if (DetailsInspectorButton != null) {
				DetailsInspectorButton.Dispose ();
				DetailsInspectorButton = null;
			}

			if (DocumentScrollView != null) {
				DocumentScrollView.Dispose ();
				DocumentScrollView = null;
			}

			if (DocumentView != null) {
				DocumentView.Dispose ();
				DocumentView = null;
			}

			if (DocumentViewHeight != null) {
				DocumentViewHeight.Dispose ();
				DocumentViewHeight = null;
			}

			if (DocumentViewWidth != null) {
				DocumentViewWidth.Dispose ();
				DocumentViewWidth = null;
			}

			if (ExportButton != null) {
				ExportButton.Dispose ();
				ExportButton = null;
			}

			if (FillInspector != null) {
				FillInspector.Dispose ();
				FillInspector = null;
			}

			if (FillInspectorsButton != null) {
				FillInspectorsButton.Dispose ();
				FillInspectorsButton = null;
			}

			if (FontInspector != null) {
				FontInspector.Dispose ();
				FontInspector = null;
			}

			if (FrameInspector != null) {
				FrameInspector.Dispose ();
				FrameInspector = null;
			}

			if (GeneralInfoInspector != null) {
				GeneralInfoInspector.Dispose ();
				GeneralInfoInspector = null;
			}

			if (GradientInspector != null) {
				GradientInspector.Dispose ();
				GradientInspector = null;
			}

			if (GroupInspector != null) {
				GroupInspector.Dispose ();
				GroupInspector = null;
			}

			if (InspectorScrollView != null) {
				InspectorScrollView.Dispose ();
				InspectorScrollView = null;
			}

			if (InspectorView != null) {
				InspectorView.Dispose ();
				InspectorView = null;
			}

			if (LanguageSelector != null) {
				LanguageSelector.Dispose ();
				LanguageSelector = null;
			}

			if (LibrarySelector != null) {
				LibrarySelector.Dispose ();
				LibrarySelector = null;
			}

			if (NumberPropertyInspector != null) {
				NumberPropertyInspector.Dispose ();
				NumberPropertyInspector = null;
			}

			if (OSSelector != null) {
				OSSelector.Dispose ();
				OSSelector = null;
			}

			if (PointInspector != null) {
				PointInspector.Dispose ();
				PointInspector = null;
			}

			if (PolygonInspector != null) {
				PolygonInspector.Dispose ();
				PolygonInspector = null;
			}

			if (PortfolioInspector != null) {
				PortfolioInspector.Dispose ();
				PortfolioInspector = null;
			}

			if (PropertyInspector != null) {
				PropertyInspector.Dispose ();
				PropertyInspector = null;
			}

			if (RoundRectInspector != null) {
				RoundRectInspector.Dispose ();
				RoundRectInspector = null;
			}

			if (ScriptDebuggerInspector != null) {
				ScriptDebuggerInspector.Dispose ();
				ScriptDebuggerInspector = null;
			}

			if (SketchInspector != null) {
				SketchInspector.Dispose ();
				SketchInspector = null;
			}

			if (SketchPath != null) {
				SketchPath.Dispose ();
				SketchPath = null;
			}

			if (SourceList != null) {
				SourceList.Dispose ();
				SourceList = null;
			}

			if (StarInspector != null) {
				StarInspector.Dispose ();
				StarInspector = null;
			}

			if (StyleInspector != null) {
				StyleInspector.Dispose ();
				StyleInspector = null;
			}

			if (TextEditor != null) {
				TextEditor.Dispose ();
				TextEditor = null;
			}

			if (TextEditorMode != null) {
				TextEditorMode.Dispose ();
				TextEditorMode = null;
			}

			if (TextEditorTitle != null) {
				TextEditorTitle.Dispose ();
				TextEditorTitle = null;
			}

			if (TextInspector != null) {
				TextInspector.Dispose ();
				TextInspector = null;
			}

			if (TextPropertyInspector != null) {
				TextPropertyInspector.Dispose ();
				TextPropertyInspector = null;
			}

			if (ToolArrow != null) {
				ToolArrow.Dispose ();
				ToolArrow = null;
			}

			if (ToolBezier != null) {
				ToolBezier.Dispose ();
				ToolBezier = null;
			}

			if (ToolCursor != null) {
				ToolCursor.Dispose ();
				ToolCursor = null;
			}

			if (ToolLine != null) {
				ToolLine.Dispose ();
				ToolLine = null;
			}

			if (ToolOval != null) {
				ToolOval.Dispose ();
				ToolOval = null;
			}

			if (ToolPolygon != null) {
				ToolPolygon.Dispose ();
				ToolPolygon = null;
			}

			if (ToolRect != null) {
				ToolRect.Dispose ();
				ToolRect = null;
			}

			if (ToolRoundRect != null) {
				ToolRoundRect.Dispose ();
				ToolRoundRect = null;
			}

			if (ToolStar != null) {
				ToolStar.Dispose ();
				ToolStar = null;
			}

			if (ToolText != null) {
				ToolText.Dispose ();
				ToolText = null;
			}

			if (ToolTriangle != null) {
				ToolTriangle.Dispose ();
				ToolTriangle = null;
			}

			if (ToolVector != null) {
				ToolVector.Dispose ();
				ToolVector = null;
			}

		}
	}
}
