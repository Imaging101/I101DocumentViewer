

namespace I101DocumentViewer
{
	partial class frmAbout : System.Windows.Forms.Form
	{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
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
		private System.ComponentModel.Container components = null;
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCopyrightORPALIS = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblGdPictureDemo = new System.Windows.Forms.Label();
            this.lblGdPictureWebsite = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(498, 230);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCopyrightORPALIS
            // 
            this.lblCopyrightORPALIS.AutoSize = true;
            this.lblCopyrightORPALIS.Enabled = false;
            this.lblCopyrightORPALIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyrightORPALIS.Location = new System.Drawing.Point(8, 235);
            this.lblCopyrightORPALIS.Name = "lblCopyrightORPALIS";
            this.lblCopyrightORPALIS.Size = new System.Drawing.Size(184, 13);
            this.lblCopyrightORPALIS.TabIndex = 1;
            this.lblCopyrightORPALIS.Text = "Copyright © 2021 IMAGING101, INC.";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox1.Image = global::My.Resources.Resources.I101Logo201204_250x60;
            this.PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(585, 155);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBox1.TabIndex = 2;
            this.PictureBox1.TabStop = false;
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.PictureBox1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(585, 155);
            this.Panel1.TabIndex = 3;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.SystemColors.Window;
            this.Panel2.Controls.Add(this.lblVersion);
            this.Panel2.Controls.Add(this.lblGdPictureDemo);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel2.Location = new System.Drawing.Point(0, 155);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(585, 65);
            this.Panel2.TabIndex = 4;
            // 
            // lblVersion
            // 
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(148, 37);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(274, 18);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "2021";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVersion.Click += new System.EventHandler(this.lblVersion_Click);
            // 
            // lblGdPictureDemo
            // 
            this.lblGdPictureDemo.AutoSize = true;
            this.lblGdPictureDemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGdPictureDemo.Location = new System.Drawing.Point(170, 19);
            this.lblGdPictureDemo.Name = "lblGdPictureDemo";
            this.lblGdPictureDemo.Size = new System.Drawing.Size(230, 18);
            this.lblGdPictureDemo.TabIndex = 0;
            this.lblGdPictureDemo.Text = "Imaging101 Document Viewer";
            // 
            // lblGdPictureWebsite
            // 
            this.lblGdPictureWebsite.AutoSize = true;
            this.lblGdPictureWebsite.Location = new System.Drawing.Point(224, 235);
            this.lblGdPictureWebsite.Name = "lblGdPictureWebsite";
            this.lblGdPictureWebsite.Size = new System.Drawing.Size(147, 13);
            this.lblGdPictureWebsite.TabIndex = 6;
            this.lblGdPictureWebsite.TabStop = true;
            this.lblGdPictureWebsite.Text = "http://www.imaging101.com/";
            this.lblGdPictureWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblGdPictureWebsite_LinkClicked);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(585, 265);
            this.Controls.Add(this.lblGdPictureWebsite);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.lblCopyrightORPALIS);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About...";
            this.Load += new System.EventHandler(this.frmAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.Button btnClose;
		internal System.Windows.Forms.Label lblCopyrightORPALIS;
		internal System.Windows.Forms.PictureBox PictureBox1;
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.Panel Panel2;
		internal System.Windows.Forms.Label lblVersion;
		internal System.Windows.Forms.Label lblGdPictureDemo;
		internal System.Windows.Forms.LinkLabel lblGdPictureWebsite;
	}
	
}
