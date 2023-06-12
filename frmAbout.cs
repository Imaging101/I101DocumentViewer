using System;
using System.Windows.Forms;

namespace I101DocumentViewer
{
	public partial class frmAbout
	{
		public frmAbout()
		{
			InitializeComponent();
		}

	    private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

	    private void lblGdPictureWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("http://www.gdpicture.com/");
		}

        private void lblVersion_Click(object sender, EventArgs e)
        {

        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
			this.Text = "Imaging101 Document Viewer v" + System.Windows.Forms.Application.ProductVersion;
			lblVersion.Text = "Version " + System.Windows.Forms.Application.ProductVersion;
		}
    }
}
