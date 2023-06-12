
namespace I101DocumentViewer
{
    partial class frmLoadingGif
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxLoadingGif = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadingGif)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLoadingGif
            // 
            this.pictureBoxLoadingGif.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLoadingGif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLoadingGif.Image = global::My.Resources.Resources.LoadingAnimatedGif5;
            this.pictureBoxLoadingGif.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLoadingGif.Name = "pictureBoxLoadingGif";
            this.pictureBoxLoadingGif.Size = new System.Drawing.Size(105, 104);
            this.pictureBoxLoadingGif.TabIndex = 41;
            this.pictureBoxLoadingGif.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 42;
            this.label1.Text = "LOADING";
            // 
            // frmLoadingGif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(105, 104);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxLoadingGif);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLoadingGif";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmLoadingGif";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmLoadingGif_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadingGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLoadingGif;
        private System.Windows.Forms.Label label1;
    }
}