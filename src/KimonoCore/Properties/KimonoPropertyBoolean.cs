﻿using System;
using SkiaSharp;
using TextBase;

namespace KimonoCore
{
	/// <summary>
	/// Defines a `KimonoProperty` that represents a `bool` value.
	/// </summary>
	[Table("BooleanProperty")]
	public class KimonoPropertyBoolean : KimonoProperty
	{
		#region Computed Properties
		/// <summary>
		/// Gets or sets the value.
		/// </summary>
		/// <value>The `bool` value.</value>
		public bool Value { get; set; } = false;
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:KimonoCore.KimonoPropertyBoolean"/> class.
		/// </summary>
		public KimonoPropertyBoolean()
		{
			// Initialize
			Name = "Boolean Property";
		}
		#endregion

		#region Public Methods
		/// <summary>
		/// Evaluate this instance by executing any attached Obi Script to get the new
		/// value for the `KimonoProperty`.
		/// </summary>
		/// <returns>The result of the Obi Script execution as a `ObiScriptResult`.</returns>
		public override ObiScriptResult Evaluate()
		{
			// Is there a script attached?
			if (GetsValueFromScript)
			{
				// Execute the script to get the new value
				ObiScriptEngine.Runtime.Execute(ObiScript);

				// Was the script successful?
				if (ObiScriptEngine.EvaluationResult.Successful)
				{
					// Was the right type returned?
					if (ObiScriptEngine.EvaluationResult.Value is bool)
					{
						// Yes, save it
						Value = (bool)ObiScriptEngine.EvaluationResult.Value;
					}
					else
					{
						// Report this as an error
						ObiScriptEngine.EvaluationResult.Successful = false;
						ObiScriptEngine.EvaluationResult.ErrorMessage = "Error: Script did not return a boolean value. " +
							"Call `Return.bool(true);` to return the required value.";
					}
				}
			}

			// Return the result of executing the script
			return ObiScriptEngine.EvaluationResult;
		}
		#endregion

		#region Conversion Routines
		/// <summary>
		/// Converts this `KimonoProperty` to a `bool`.
		/// </summary>
		/// <returns>The value for the property.</returns>
		public override bool ToBool()
		{
			return Value;
		}

		/// <summary>
		/// Converts to KimonoCore based source code
		/// </summary>
		/// <returns>The property as a KimonoCore object.</returns>
		public override string ToKimonoCore()
		{
			var sourceCode = "new KimonoPropertyBoolean() {\n" +
				$"\tName = \"{Name}\",\n" +
				$"\tGetsValueFromScript = {GetsValueFromScript.ToString().ToLower()},\n" +
				$"\tObiScript = \"{ScriptToString()}\",\n" +
				$"\tValue = {Value.ToString().ToLower()}\n" +
				"};\n";

			// Return results
			return sourceCode;
		}

		/// <summary>
		/// Converts this property to Global scoped C# code.
		/// </summary>
		/// <returns>The property as C# code.</returns>
		/// <param name="outputLibrary">The `CodeOutputLibrary` to use.</param>
		public override string ToCSharpGlobal(CodeOutputLibrary outputLibrary)
		{
			var sourceCode = "";

			// Make base
			sourceCode += $"// Global property {Name}\n";

			// Take action based on usage
			switch (outputLibrary)
			{
				case CodeOutputLibrary.SkiaSharp:
					sourceCode += $"public static string {ElementName} " +
						"{get; set;}" +
						$" = {Value.ToString().ToLower()};\n";
					break;
				case CodeOutputLibrary.KimonoCore:
					sourceCode += $"public static KimonoPropertyBoolean {ElementName} " +
						"{get; set;}" +
						$" = {ToKimonoCore()}\n";
					break;

			}

			// Return results
			return sourceCode;
		}

		/// <summary>
		/// Converts this property to Local scoped C# code.
		/// </summary>
		/// <returns>The property as C# code.</returns>
		/// <param name="outputLibrary">The `CodeOutputLibrary` to use.</param>
		public override string ToCSharpLocal(CodeOutputLibrary outputLibrary)
		{
			var sourceCode = "";

			// Make base
			sourceCode += $"// Local property {Name}\n" +
				$"var {ElementName}";

			// Take action based on usage
			switch (outputLibrary)
			{
				case CodeOutputLibrary.SkiaSharp:
					sourceCode += $" = {Value.ToString().ToLower()};\n";
					break;
				case CodeOutputLibrary.KimonoCore:
					sourceCode += $" = {ToKimonoCore()}\n";
					break;

			}

			// Return results
			return sourceCode;
		}

		/// <summary>
		/// Converts this property to Parameter scoped C# code.
		/// </summary>
		/// <returns>The property as C# code.</returns>
		/// <param name="outputLibrary">The `CodeOutputLibrary` to use.</param>
		public override string ToCSharpParameter(CodeOutputLibrary outputLibrary)
		{
			var sourceCode = $"KimonoPropertyBoolean {ElementName}";

			// Return results
			return sourceCode;
		}
		#endregion

		#region Cloning
		/// <summary>
		/// Clone this instance.
		/// </summary>
		/// <returns>The clone.</returns>
		public override KimonoProperty Clone()
		{
			// Make copy
			var newProperty = new KimonoPropertyBoolean()
			{
				UniqueID = this.UniqueID,
				Name = this.Name,
				Usage = this.Usage,
				IsObiScriptValue = this.IsObiScriptValue,
				GetsValueFromScript = this.GetsValueFromScript,
				ObiScript = this.ObiScript,
				Value = this.Value
			};

			// Return clone
			return newProperty;
		}
		#endregion
	}
}
