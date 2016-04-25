﻿//
// Copyright (c) 2002-2016 Mirko Matytschak 
// (www.netdataobjects.de)
//
// Author: Mirko Matytschak
//
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
// documentation files (the "Software"), to deal in the Software without restriction, including without limitation 
// the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the 
// Software, and to permit persons to whom the Software is furnished to do so, subject to the following 
// conditions:

// The above copyright notice and this permission notice shall be included in all copies or substantial portions 
// of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED 
// TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
// THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
// CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
// DEALINGS IN THE SOFTWARE.


using System;
using System.Xml;
using WizardBase;

namespace ClassGenerator
{
	/// <summary>
	/// Zusammenfassung für Column.
	/// </summary>
	[Serializable]
#if DEBUG
	public class Column : IXmlStorable
#else
	internal class Column : IXmlStorable
#endif
	{
		public event EventHandler OnIsPrimaryChanged;
		public event EventHandler OnIsMappedChanged;

		string name;
		public string Name
		{
			get { return name; }
		}
		bool isPrimary;
		public bool IsPrimary
		{
			get { return isPrimary; }
			set 
			{ 
				isPrimary = value;
				OnIsPrimaryChanged(this, EventArgs.Empty);
			}
		}
		string type;
		public string Type
		{
			get { return type; }
		}

		bool isMapped;
		public bool IsMapped
		{
			get { return isMapped; }
			set 
			{ 
				isMapped = value;
				OnIsMappedChanged(this, EventArgs.Empty);
			}
		}

		/// <summary>
		/// For serialization only
		/// </summary>
		public Column()
		{
		}


		public Column(string name, bool isPrimary, bool isAutoIncremented, string type, bool useFieldNamePrefix, string summary)
		{
			this.name = name;
			this.isPrimary = isPrimary;
			this.autoIncremented = isAutoIncremented;
			this.type = type;
			this.isMapped = false;
            this.summary = summary;

			// Look if the column name is all upper chars
			bool hasLower = false;
			for(int i = 0; i < name.Length; i++)
			{
				if (char.IsLower(name[i]))
				{
					hasLower = true;
					break;
				}
			}
			if (!hasLower) // all upper chars
				this.fieldName = name.ToLower(); // just make all chars lower case
			else
				this.fieldName = name.Substring(0, 1).ToLower() + name.Substring(1);

			if (useFieldNamePrefix)
			    this.fieldName = "_" + this.fieldName;
		}

		bool autoIncremented;
		public bool AutoIncremented
		{
			get { return autoIncremented; }
			set { autoIncremented = value; }
		}

        string summary;
        public string Summary
        {
            get { return summary; }
            set { summary = value; }
        }

		string fieldName;
		public string FieldName
		{
			get { return fieldName; }
			set { fieldName = value; }
		}
		#region IXmlStorable Member

		public void ToXml(XmlElement element)
		{
			element.SetAttribute("FieldName", this.fieldName);
			element.SetAttribute("IsMapped", this.isMapped.ToString());
			element.SetAttribute("IsPrimary", this.isPrimary.ToString());
			element.SetAttribute("Name", this.name);
			element.SetAttribute("ColumnType", this.type);
		}

		public void FromXml(XmlElement element)
		{
			this.fieldName = element.Attributes["FieldName"].Value;
			this.isMapped = bool.Parse(element.Attributes["IsMapped"].Value);
			this.isPrimary = bool.Parse(element.Attributes["IsPrimary"].Value);
			this.name = element.Attributes["Name"].Value;
			this.type = element.Attributes["ColumnType"].Value;
		}

		#endregion
	}
}
