//
// Copyright (C) 2002-2008 HoT - House of Tools Development GmbH 
// (www.netdataobjects.com)
//
// Author: Mirko Matytschak
//
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License (v3) as published by
// the Free Software Foundation.
//
// If you distribute copies of this program, whether gratis or for 
// a fee, you must pass on to the recipients the same freedoms that 
// you received.
//
// Commercial Licence:
// For those, who want to develop software with help of this program 
// and need to distribute their work with a more restrictive licence, 
// there is a commercial licence available at www.netdataobjects.com.
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//


using System;

namespace TestGenerator
{
	/// <summary>
	/// Zusammenfassung f�r RelInfo.
	/// </summary>
	public class RelInfo
	{
		bool isBi;
		public bool IsBi
		{
			get { return isBi; }
			set { isBi = value; }
		}
		bool isList;
		public bool IsList
		{
			get { return isList; }
			set { isList = value; }
		}
		bool foreignIsList;
		public bool ForeignIsList
		{
			get { return foreignIsList; }
			set { foreignIsList = value; }
		}
		bool isComposite;
		public bool IsComposite
		{
			get { return isComposite; }
			set { isComposite = value; }
		}
		bool hasTable;
		public bool HasTable
		{
			get { return hasTable; }
			set { hasTable = value; }
		}
		bool ownPoly;
		public bool OwnPoly
		{
			get { return ownPoly; }
			set { ownPoly = value; }
		}
		bool otherPoly;
		public bool OtherPoly
		{
			get { return otherPoly; }
			set { otherPoly = value; }
		}
		bool isAbstract;
		public bool IsAbstract
		{
			get { return isAbstract; }
			set { isAbstract = value; }
		}
		bool useGuid;
		public bool UseGuid
		{
			get { return useGuid; }
			set { useGuid = value; }
		}

        bool ownIsGeneric;
        public bool OwnIsGeneric
        {
            get { return ownIsGeneric; }
            set { ownIsGeneric = value; }
        }

        bool otherIsGeneric;
        public bool OtherIsGeneric
        {
            get { return otherIsGeneric; }
            set { otherIsGeneric = value; }
        }

		public RelInfo(bool isbi, bool islist, bool fislist, bool iscomp, bool ownpoly, bool othpoly, bool useguid, bool ownGen, bool otherGen)
		{
			this.isBi = isbi;
			this.isList = islist;
			this.foreignIsList = fislist;
			this.isComposite = iscomp;
			this.ownPoly = ownpoly;
			this.otherPoly = othpoly;
			this.hasTable = false;
			this.useGuid = useguid;
			if (isBi && isList && foreignIsList)
				this.hasTable = true;
			if (otherPoly && isList)
				this.hasTable = true;
			if (isBi && ownPoly && foreignIsList)
				this.hasTable = true;
            this.ownIsGeneric = ownGen;
            this.otherIsGeneric = otherGen;
		}

		public override string ToString()
		{
			string result = isComposite ? "Cmp" : "Agr";
			if (isBi)
				result += "Bi";
			else
				result += "Dir";
			if (isList)
				result += "n";
			else
				result += "1";
			if (isBi)
			{
				if (foreignIsList)
					result += "n";
				else
					result += "1";
			}
			if (ownPoly)
			{
				result += "Ownp";
				if (isAbstract)
					result += "abs";
				else
					result += "con";
			}
			if (otherPoly)
			{
				result += "Othp";
				if (isAbstract)
					result += "abs";
				else
					result += "con";
			}
            if (hasTable)
				result += "Tbl";
			else
				result += "NoTbl";
            if (this.ownIsGeneric)
                result += "OwGn";
            else
                result += "OwNgn";
            if (this.otherIsGeneric)
                result += "OtGn";
            else
                result += "OtNgn";

			if (useGuid)
				result += "Guid";
			else
				result += "Auto";
			return result;
		}

		public RelInfo Clone()
		{
			RelInfo ri = new RelInfo(this.isBi, this.isList,this.foreignIsList, this.isComposite, this.ownPoly, this.otherPoly, this.useGuid, this.ownIsGeneric, this.otherIsGeneric);
			ri.hasTable = this.hasTable;
			ri.isAbstract = this.isAbstract;
			return ri;
		}

		public RelInfo GetReverse()
		{
			RelInfo ri = new RelInfo(this.isBi, this.foreignIsList, this.IsList, false, this.otherPoly, this.ownPoly, this.useGuid, this.otherIsGeneric, this.ownIsGeneric);
			ri.hasTable = this.hasTable;
			ri.isAbstract = this.isAbstract;
			return ri;
		}

	}


}
