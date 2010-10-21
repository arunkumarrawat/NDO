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
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using NDOEnhancer;

namespace WizardBase
{
	/// <summary>
	/// Zusammenfassung f�r Form1.
	/// </summary>
#if DEBUG
	public class WizardFrame : System.Windows.Forms.Form
#else
	internal class WizardFrame : System.Windows.Forms.Form
#endif
	{
		private System.Windows.Forms.Label description;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnForward;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnFinish;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		private System.Windows.Forms.Panel viewPanel;
		IWizardController controller;
		ViewBase view;

		/// <summary>
		/// For the designer only
		/// </summary>
		public WizardFrame()
		{
			//
			// Erforderlich f�r die Windows Form-Designerunterst�tzung
			//
			InitializeComponent();
		}

		public WizardFrame(IWizardController controller)
		{
			//
			// Erforderlich f�r die Windows Form-Designerunterst�tzung
			//
			InitializeComponent();
			this.controller = controller;
			ViewBase newView = null;
			WizardState newState;
			controller.OnInit(out newView, out newState);
			this.SetWizardState(newState);
			this.View = newView;
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

		#region Vom Windows Form-Designer generierter Code
		/// <summary>
		/// Erforderliche Methode f�r die Designerunterst�tzung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor ge�ndert werden.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( WizardFrame ) );
			this.description = new System.Windows.Forms.Label();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnForward = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnFinish = new System.Windows.Forms.Button();
			this.viewPanel = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// description
			// 
			this.description.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.description.Location = new System.Drawing.Point( 16, 14 );
			this.description.Name = "description";
			this.description.Size = new System.Drawing.Size( 508, 76 );
			this.description.TabIndex = 0;
			// 
			// btnBack
			// 
			this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnBack.Location = new System.Drawing.Point( 120, 222 );
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size( 80, 28 );
			this.btnBack.TabIndex = 1;
			this.btnBack.Text = "Back";
			this.btnBack.Click += new System.EventHandler( this.btnBack_Click );
			// 
			// btnForward
			// 
			this.btnForward.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnForward.Location = new System.Drawing.Point( 220, 222 );
			this.btnForward.Name = "btnForward";
			this.btnForward.Size = new System.Drawing.Size( 80, 28 );
			this.btnForward.TabIndex = 2;
			this.btnForward.Text = "Next";
			this.btnForward.Click += new System.EventHandler( this.btnForward_Click );
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point( 20, 222 );
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size( 80, 28 );
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.Click += new System.EventHandler( this.btnCancel_Click );
			// 
			// btnFinish
			// 
			this.btnFinish.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnFinish.Location = new System.Drawing.Point( 320, 222 );
			this.btnFinish.Name = "btnFinish";
			this.btnFinish.Size = new System.Drawing.Size( 80, 28 );
			this.btnFinish.TabIndex = 4;
			this.btnFinish.Text = "Finish";
			this.btnFinish.Click += new System.EventHandler( this.btnFinish_Click );
			// 
			// viewPanel
			// 
			this.viewPanel.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.viewPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.viewPanel.Location = new System.Drawing.Point( 16, 97 );
			this.viewPanel.Name = "viewPanel";
			this.viewPanel.Size = new System.Drawing.Size( 508, 83 );
			this.viewPanel.TabIndex = 5;
			// 
			// WizardFrame
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size( 5, 13 );
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size( 540, 264 );
			this.Controls.Add( this.viewPanel );
			this.Controls.Add( this.btnFinish );
			this.Controls.Add( this.btnCancel );
			this.Controls.Add( this.btnForward );
			this.Controls.Add( this.btnBack );
			this.Controls.Add( this.description );
			this.Icon = ((System.Drawing.Icon) (resources.GetObject( "$this.Icon" )));
			this.Name = "WizardFrame";
			this.Text = "AssemblyWizard Step 1";
			this.ResumeLayout( false );

		}
		#endregion

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			this.view.OnLeaveView();
			this.controller.Cancel();
		}

		private void btnBack_Click(object sender, System.EventArgs e)
		{
			this.view.OnLeaveView();
			ViewBase newView;
			WizardState newState;
			this.controller.Back(out newView, out newState);
			this.SetWizardState(newState);
			this.View = newView;
		}

		private void btnForward_Click(object sender, System.EventArgs e)
		{
			this.view.OnLeaveView();
			ViewBase newView;
			WizardState newState;
			this.controller.Next(out newView, out newState);;
			this.SetWizardState(newState);
			this.View = newView;
		}

        public void Ignore()
        {
            this.controller.Finish(DialogResult.Ignore);
        }

		public void SkipToNextView()
		{
			btnForward_Click(this, EventArgs.Empty);
		}

		private void btnFinish_Click(object sender, System.EventArgs e)
		{
			this.view.OnLeaveView();
			this.controller.Finish(DialogResult.OK);
		}

		WizardState wizardState;

	
		private void SetWizardState(WizardState value)
		{
				wizardState = value;
				this.btnBack.Enabled = (wizardState & WizardState.Back) != 0;
				this.btnForward.Enabled = (wizardState & WizardState.Next) != 0;
				this.btnCancel.Enabled = (wizardState & WizardState.Cancel) != 0;
				this.btnFinish.Enabled = (wizardState & WizardState.Finish) != 0;
		}


		public string Description
		{
			get { return this.description.Text; }
			set { this.description.Text = value; }
		}

		private ViewBase View
		{
			set 
			{
				view = value;
				this.viewPanel.Controls.Clear();
				view.Location = new Point(0,0);
				this.viewPanel.Controls.Add(view);
			}
		}


	}
}
