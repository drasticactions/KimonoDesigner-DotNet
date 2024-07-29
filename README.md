# Kimono Designer - .NET Edition

A port of [Kimono Designer](https://github.com/xamarin/kimonodesigner) to .NET Mac. This app lets you draw shapes to turn into Skia/SkiaSharp objects to use in your .NET applications.

![](screenshots/screenshot.png)

This is experimental, I offer no support for this application. I did this as a way to try porting a larger scale Xamarin.Mac application into .NET.

## How to run:

### Dependencies
- .NET 8.0 SDK
- .NET macOS workload (`dotnet workload install macos`)
- **NOTE** The macOS workload is not installed by default with a .NET install, nor a .NET MAUI one.
- Xcode

### VSCode
- Open the root directory in VSCode and use the Launch tasks to start a debug session. It should automatically build and attach to the session.
- **NOTE** VSCode does not support Xcode Storyboard syncing. If you update the storyboards, you either need to update the bindings yourself, or use VSMac/Rider to do it for you.

### VSMac
- This is a .NET 8.0 macOS app and _should_ work with the last edition of VSMac. You need to enable experimental .NET support to launch it.

### Rider
- Open the solution, deploy. Done.

## What works:

- Generating SkiaSharp code. If you draw in the canvas, the SkiaSharp code should generate and it (should) work in a application running SkiaSharp 2.81.
- Loading, Saving, Editing existing Kimono Designer documents from previous versions.
- Dark/Light mode. Some icons need to be updated.

## What's been removed
- Obiscript support has been turned off
- KimonoCore support has been turned off
- Unsupported features within Skia/SkiaSharp. For example, StrikeThru and Underline text is disabled as that was removed from Skia.

Both depended on support for libraries that I don't want to write/port/support/etc. At this point it would make more sense to use SkiaSharp directly than depend on middleware.

## What could be done
- Support for SkiaSharp 2.81/3.0 features
- Removal of older Skia/SkiaSharp features
- Translations

