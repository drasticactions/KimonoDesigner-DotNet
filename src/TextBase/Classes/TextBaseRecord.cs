﻿using System;
namespace TextBase
{
	/// <summary>
	/// Holds the instance of a Textbase record field.
	/// </summary>
	public class TextBaseRecord
	{
		#region Private Variables
		/// <summary>
		/// Holds the internal representation of the record's value.
		/// </summary>
		private string _value = "";
		#endregion

		#region Computed Properties
		/// <summary>
		/// Gets or sets the prefix that is used to encode sub values.
		/// </summary>
		/// <value>The prefix.</value>
		public string Prefix { get; set; } = "";

		/// <summary>
		/// Gets or sets the name of the record.
		/// </summary>
		/// <value>The name of the record.</value>
		public string RecordName { get; set; } = "";

		/// <summary>
		/// Gets or sets the record value.
		/// </summary>
		/// <value>The record value.</value>
		public string RecordValue
		{
			get { return _value; }
			set { _value = value; }
		}
		#endregion

		#region Type Conversion
		/// <summary>
		/// Converts a Record to a string.
		/// </summary>
		/// <returns>The Record as a string.</returns>
		/// <param name="field">The Record to convert.</param>
		public static implicit operator string(TextBaseRecord field)
		{
			return field.ToString();
		}

		/// <summary>
		/// Converts a string to a Record.
		/// </summary>
		/// <returns>The Record represented by the string.</returns>
		/// <param name="record">The string holding a Record.</param>
		public static implicit operator TextBaseRecord(string record)
		{
			return new TextBaseRecord(record);
		}
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="T:TextBase.TextBaseRecord"/> class.
		/// </summary>
		public TextBaseRecord()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:TextBase.TextBaseRecord"/> class.
		/// </summary>
		/// <param name="recordName">Record name.</param>
		/// <param name="recordValue">Record value.</param>
		public TextBaseRecord(string recordName, string recordValue)
		{
			// Initialize
			RecordName = recordName;
			RecordValue = recordValue;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:TextBase.TextBaseRecord"/> class.
		/// </summary>
		/// <param name="prefix">Prefix.</param>
		/// <param name="recordName">Record name.</param>
		/// <param name="recordValue">Record value.</param>
		public TextBaseRecord(string prefix, string recordName, string recordValue)
		{
			// Initialize
			RecordName = recordName;
			Prefix = prefix;
			RecordValue = recordValue;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:TextBase.TextBaseRecord"/> class.
		/// </summary>
		/// <param name="record">Record.</param>
		public TextBaseRecord(string record)
		{
			// Split the data into it's base parts
			char[] delimiterChars = { ':' };
			string[] parts = record.Split(delimiterChars);

			// Restore field
			try
			{
				RecordName = parts[0];
				_value = parts[1];
			}
			catch
			{
				// Ignore all errors
			}
		}
		#endregion

		#region Override Methods
		/// <summary>
		/// Returns a string that represents the current Record.
		/// </summary>
		/// <returns>A string that represents the current Record.</returns>
		public override string ToString()
		{
			// Anything to return?
			if (RecordValue == "")
			{
				return "";
			}
			else
			{
				return $"[{RecordName}:{RecordValue}]";
			}
		}
		#endregion
	}
}
