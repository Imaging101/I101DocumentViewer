using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I101DocumentViewer
{
    public partial class frmLoadingGif : Form
    {
        public frmLoadingGif()
        {
            InitializeComponent();

        }

        private void frmLoadingGif_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Turquoise;
            this.TransparencyKey = this.BackColor ;
        }
    }
}
