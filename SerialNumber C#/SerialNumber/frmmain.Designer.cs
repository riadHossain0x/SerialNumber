using System.Runtime.CompilerServices;

//========================================================================
// This conversion was produced by the Free Edition of
// Instant C# courtesy of Tangible Software Solutions.
// Order the Premium Edition at https://www.tangiblesoftwaresolutions.com
//========================================================================

//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
using System.Threading.Tasks;

namespace SerialNumber
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	public partial class frmmain : System.Windows.Forms.Form
	{
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;

		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.Label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			//
			//Label1
			//
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.Label1.Location = new System.Drawing.Point(183, 112);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(229, 25);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Get Serial Number";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//frmmain
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(8.0F, 16.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(595, 301);
			this.Controls.Add(this.Label1);
			this.Name = "frmmain";
			this.Text = "Form1";
			this.ResumeLayout(false);

//INSTANT C# NOTE: Converted design-time event handler wireups:
			base.Load += new System.EventHandler(frmmain_Load);
		}

		internal Label Label1;
	}

}