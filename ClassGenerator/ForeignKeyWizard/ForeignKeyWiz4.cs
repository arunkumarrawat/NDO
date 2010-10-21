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
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using WizardBase;


namespace ClassGenerator.ForeignKeyWizard
{
	/// <summary>
	/// Zusammenfassung f�r ForeignKeyWiz4.
	/// </summary>
	internal class ForeignKeyWiz4 : WizardBase.ViewBase
	{
		private System.Windows.Forms.TextBox txtRelationName;
		private System.Windows.Forms.Label label2;
		ForeignKeyWizModel model;

		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ForeignKeyWiz4()
		{
			InitializeComponent();
		}

		public ForeignKeyWiz4(IModel model)
		{
			InitializeComponent();
			this.model = (ForeignKeyWizModel) model;
		}

		/// <summary> 
		/// Die verwendeten Ressourcen bereinigen.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Vom Komponenten-Designer generierter Code
		/// <summary> 
		/// Erforderliche Methode f�r die Designerunterst�tzung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor ge�ndert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtRelationName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtRelationName
			// 
			this.txtRelationName.Location = new System.Drawing.Point(136, 88);
			this.txtRelationName.Name = "txtRelationName";
			this.txtRelationName.Size = new System.Drawing.Size(152, 22);
			this.txtRelationName.TabIndex = 9;
			this.txtRelationName.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 24);
			this.label2.TabIndex = 8;
			this.label2.Text = "Relation Name:";
			// 
			// ForeignKeyWiz4
			// 
			this.Controls.Add(this.txtRelationName);
			this.Controls.Add(this.label2);
			this.Name = "ForeignKeyWiz4";
			this.Size = new System.Drawing.Size(528, 200);
			this.Load += new System.EventHandler(this.ForeignKeyWiz4_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void ForeignKeyWiz4_Load(object sender, System.EventArgs e)
		{
			FkRelation relation = (FkRelation) model.RelationNode.Relation;
			this.txtRelationName.DataBindings.Add("Text", relation, "RelationName");
			Frame.Description = "The relation name is used to distinguish between different relations to the same target type. If there aren't more than one relation to the same target type, leave this field empty.";
		}
	}
}
