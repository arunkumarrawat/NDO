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
using System.Windows.Forms;
using WizardBase;
using NDOInterfaces;
using NDO;

namespace ClassGenerator.AssemblyWizard
{
	internal class AssemblyWiz2 : WizardBase.ViewBase
	{
		private System.Windows.Forms.TextBox txtConnectionString;
		private System.Windows.Forms.Button btnSelectConnection;
		private System.Windows.Forms.TextBox txtOwner;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Timer timerOpenDialog;
		private Panel panelDatabase;
		private Panel panelSchema;
		private Label label2;
		private Button btnSchemaFileName;
		private TextBox txtSchemaFileName;
		private System.ComponentModel.IContainer components = null;

		public AssemblyWiz2()
		{
			// Dieser Aufruf ist f�r den Windows Form-Designer erforderlich.
			InitializeComponent();

			// TODO: Initialisierungen nach dem Aufruf von InitializeComponent hinzuf�gen
		}
		AssemblyWizModel model;
		public AssemblyWiz2(IModel model)
		{
			// Dieser Aufruf ist f�r den Windows Form-Designer erforderlich.
			InitializeComponent();
			this.model = (AssemblyWizModel) model;
		}

		/// <summary>
		/// Die verwendeten Ressourcen bereinigen.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Vom Designer generierter Code
		/// <summary>
		/// Erforderliche Methode f�r die Designerunterst�tzung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor ge�ndert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.txtConnectionString = new System.Windows.Forms.TextBox();
			this.btnSelectConnection = new System.Windows.Forms.Button();
			this.txtOwner = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.timerOpenDialog = new System.Windows.Forms.Timer( this.components );
			this.panelDatabase = new System.Windows.Forms.Panel();
			this.panelSchema = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.btnSchemaFileName = new System.Windows.Forms.Button();
			this.txtSchemaFileName = new System.Windows.Forms.TextBox();
			this.panelDatabase.SuspendLayout();
			this.panelSchema.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtConnectionString
			// 
			this.txtConnectionString.Location = new System.Drawing.Point( 8, 16 );
			this.txtConnectionString.Name = "txtConnectionString";
			this.txtConnectionString.Size = new System.Drawing.Size( 448, 20 );
			this.txtConnectionString.TabIndex = 0;
			// 
			// btnSelectConnection
			// 
			this.btnSelectConnection.Location = new System.Drawing.Point( 464, 16 );
			this.btnSelectConnection.Name = "btnSelectConnection";
			this.btnSelectConnection.Size = new System.Drawing.Size( 40, 24 );
			this.btnSelectConnection.TabIndex = 1;
			this.btnSelectConnection.Text = "...";
			this.btnSelectConnection.Click += new System.EventHandler( this.btnSelectConnection_Click );
			// 
			// txtOwner
			// 
			this.txtOwner.Location = new System.Drawing.Point( 224, 56 );
			this.txtOwner.Name = "txtOwner";
			this.txtOwner.Size = new System.Drawing.Size( 232, 20 );
			this.txtOwner.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point( 8, 56 );
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size( 216, 24 );
			this.label1.TabIndex = 4;
			this.label1.Text = "Optional Owner/Schema Name";
			// 
			// timerOpenDialog
			// 
			this.timerOpenDialog.Interval = 1;
			this.timerOpenDialog.Tick += new System.EventHandler( this.timerOpenDialog_Tick );
			// 
			// panelDatabase
			// 
			this.panelDatabase.Controls.Add( this.txtOwner );
			this.panelDatabase.Controls.Add( this.txtConnectionString );
			this.panelDatabase.Controls.Add( this.label1 );
			this.panelDatabase.Controls.Add( this.btnSelectConnection );
			this.panelDatabase.Location = new System.Drawing.Point( 6, 7 );
			this.panelDatabase.Name = "panelDatabase";
			this.panelDatabase.Size = new System.Drawing.Size( 506, 96 );
			this.panelDatabase.TabIndex = 6;
			// 
			// panelSchema
			// 
			this.panelSchema.Controls.Add( this.label2 );
			this.panelSchema.Controls.Add( this.btnSchemaFileName );
			this.panelSchema.Controls.Add( this.txtSchemaFileName );
			this.panelSchema.Location = new System.Drawing.Point( 6, 8 );
			this.panelSchema.Name = "panelSchema";
			this.panelSchema.Size = new System.Drawing.Size( 506, 104 );
			this.panelSchema.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point( 8, 22 );
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size( 216, 22 );
			this.label2.TabIndex = 5;
			this.label2.Text = "Schema File Name";
			// 
			// btnSchemaFileName
			// 
			this.btnSchemaFileName.Location = new System.Drawing.Point( 361, 47 );
			this.btnSchemaFileName.Name = "btnSchemaFileName";
			this.btnSchemaFileName.Size = new System.Drawing.Size( 40, 24 );
			this.btnSchemaFileName.TabIndex = 2;
			this.btnSchemaFileName.Text = "...";
			this.btnSchemaFileName.Click += new System.EventHandler( this.btnSchemaFileName_Click );
			// 
			// txtSchemaFileName
			// 
			this.txtSchemaFileName.Location = new System.Drawing.Point( 8, 47 );
			this.txtSchemaFileName.Name = "txtSchemaFileName";
			this.txtSchemaFileName.Size = new System.Drawing.Size( 335, 20 );
			this.txtSchemaFileName.TabIndex = 0;
			// 
			// AssemblyWiz2
			// 
			this.Controls.Add( this.panelSchema );
			this.Controls.Add( this.panelDatabase );
			this.Name = "AssemblyWiz2";
			this.Size = new System.Drawing.Size( 520, 119 );
			this.Load += new System.EventHandler( this.AssemblyWiz2_Load );
			this.panelDatabase.ResumeLayout( false );
			this.panelDatabase.PerformLayout();
			this.panelSchema.ResumeLayout( false );
			this.panelSchema.PerformLayout();
			this.ResumeLayout( false );

		}
		#endregion

		private void AssemblyWiz2_Load(object sender, System.EventArgs e)
		{
			this.panelSchema.Visible = model.IsXmlSchema;
			this.panelDatabase.Visible = !model.IsXmlSchema;
			if ( !model.IsXmlSchema )
			{
				this.txtConnectionString.DataBindings.Add( "Text", this.model, "ConnectionString" );
				Frame.Description = "Choose a database connection here. Note that, if available, the ADO.NET native providers are used instead of the OleDb providers.";
				if ( this.model.ConnectionString == null || this.model.ConnectionString == string.Empty )
					this.timerOpenDialog.Enabled = true;
			}
			else
			{
				Frame.Description = "Choose an Xml schema (.xsd) file.";
				this.txtSchemaFileName.DataBindings.Add("Text", this.model, "XmlSchemaFile");
			}
		}

		private void OpenDialog()
		{
			IProvider provider = NDOProviderFactory.Instance[model.ConnectionType];
			string text = txtConnectionString.Text;
			this.txtOwner.DataBindings.Clear();
			this.txtOwner.DataBindings.Add("Text", this.model, "OwnerName");
			DialogResult result = provider.ShowConnectionDialog(ref text);
			if (result != DialogResult.Cancel)
			{
				txtConnectionString.Text = text;
				this.model.ConnectionString = text;
			}
		}

		private void btnSelectConnection_Click(object sender, System.EventArgs e)
		{
			OpenDialog();
		}

		private void timerOpenDialog_Tick(object sender, System.EventArgs e)
		{
			this.timerOpenDialog.Enabled = false;
			OpenDialog();
		}

		private void btnSchemaFileName_Click( object sender, EventArgs e )
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "Xml Schema Files (*.xsd)|*.xsd";
			ofd.DefaultExt = "xsd";
			DialogResult r = ofd.ShowDialog();

			if ( r == DialogResult.OK )
			{
				this.txtSchemaFileName.Text = ofd.FileName;
				this.model.XmlSchemaFile = ofd.FileName;
			}
		}
	}
}

