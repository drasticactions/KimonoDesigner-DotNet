﻿using System;
namespace KimonoCore
{
	/// <summary>
	/// Defines the OS that code will be generated for
	/// </summary>
	public enum CodeOutputOS
	{
		/// <summary>
		/// For Windows OS based machines.
		/// </summary>
		Windows,

		/// <summary>
		/// For Windows OS based machines using Universal Windows Platform.
		/// </summary>
		WindowsUWP,

		/// <summary>
		/// For Windows OS based machines using Windows Presentation Foundation.
		/// </summary>
		WindowsWPF,

		/// <summary>
		/// For Android OS based machines.
		/// </summary>
		Android,

		/// <summary>
		/// For iOS based machines.
		/// </summary>
		iOS,

		/// <summary>
		/// For tvOS based machines.
		/// </summary>
		tvOS,

		/// <summary>
		/// For macOS based machines.
		/// </summary>
		macOS,

		/// <summary>
		/// Cross-platform code.
		/// </summary>
		CrossPlatform
	}
}
