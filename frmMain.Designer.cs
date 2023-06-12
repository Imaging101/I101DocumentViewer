using System;
using System.Windows.Forms;

namespace I101DocumentViewer
{
    partial class frmMain : System.Windows.Forms.Form
    {
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                //*** 2020-06-03 - Jacob - Added 'args' to allow passing a FilePath as a Command Line Argument
                System.Windows.Forms.Application.Run(new frmMain(args));
            }
            catch (System.NullReferenceException ne) 
            {
                //Just ignore it... for now.
            }
            catch (Exception e)
            {
                //*** IGNORE ANY ERRORS... Exception occurs when we Close the frmMain if we couldn't open a document
                
                //string message = "frmMain Designer Exception: " + e.Message;
                //string title = "frmMain Designer Exception: "  ;
                //MessageBoxButtons buttons = MessageBoxButtons.OK;
                //DialogResult result = MessageBox.Show(message, title, buttons);
                
            }
        }

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
        private System.ComponentModel.Container components = null;

        //NOTE: The following procedure is required by the Windows Form Designer
        //It can be modified using the Windows Form Designer.
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tcLeftPanel = new System.Windows.Forms.TabControl();
            this.tpThumbnails = new System.Windows.Forms.TabPage();
            this.ToolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.thumbnailPanelToolstrip = new System.Windows.Forms.ToolStrip();
            this.btnThumbSize = new System.Windows.Forms.ToolStripDropDownButton();
            this.LargeThumbnailsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MediumThumbnailsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SmallThumbnailsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ThumbnailEx1 = new GdPicture14.ThumbnailEx();
            this.tpBookmarks = new System.Windows.Forms.TabPage();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.BookmarksTree1 = new GdPicture14.BookmarksTree();
            this.tpSearch = new System.Windows.Forms.TabPage();
            this.pSearch = new System.Windows.Forms.Panel();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.lstSearchResults = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Panel3 = new System.Windows.Forms.Panel();
            this.searchProgressBar = new System.Windows.Forms.ProgressBar();
            this.lblSearchResults = new System.Windows.Forms.Label();
            this.chkWholeWord = new System.Windows.Forms.CheckBox();
            this.chkCaseSensitive = new System.Windows.Forms.CheckBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.rbCurrentPage = new System.Windows.Forms.RadioButton();
            this.rbAllPages = new System.Windows.Forms.RadioButton();
            this.btnFindPrevious = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnFindNext = new System.Windows.Forms.Button();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSearchFor = new System.Windows.Forms.Label();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.Panel6 = new System.Windows.Forms.Panel();
            this.Panel9 = new System.Windows.Forms.Panel();
            this.Panel7 = new System.Windows.Forms.Panel();
            this.lblSnapInPanel = new System.Windows.Forms.Label();
            this.pSnapInButtons = new System.Windows.Forms.Panel();
            this.btnSnapInThumbnails = new System.Windows.Forms.Button();
            this.btnSnapInBookmarks = new System.Windows.Forms.Button();
            this.btnSnapInSearch = new System.Windows.Forms.Button();
            this.pGamma = new System.Windows.Forms.Panel();
            this.lblGamma = new System.Windows.Forms.Label();
            this.tbGamma = new System.Windows.Forms.TrackBar();
            this.GdViewer1 = new GdPicture14.GdViewer();
            this.statusbar = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSettings = new System.Windows.Forms.ToolStripButton();
            this.btnMouseMode = new System.Windows.Forms.ToolStripDropDownButton();
            this.DefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AreaSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AreaZoomingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MagnifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFirstPage = new System.Windows.Forms.ToolStripButton();
            this.btnPreviousPage = new System.Windows.Forms.ToolStripButton();
            this.tbCurrentPage = new System.Windows.Forms.ToolStripTextBox();
            this.lblPageCount = new System.Windows.Forms.ToolStripLabel();
            this.btnNextPage = new System.Windows.Forms.ToolStripButton();
            this.btnLastPage = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnZoomOut = new System.Windows.Forms.ToolStripButton();
            this.cbZoom = new System.Windows.Forms.ToolStripComboBox();
            this.btnZoomIn = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFitWidth = new System.Windows.Forms.ToolStripButton();
            this.btnFitPage = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRotateLeft = new System.Windows.Forms.ToolStripButton();
            this.btnRotateRight = new System.Windows.Forms.ToolStripButton();
            this.btnFlipX = new System.Windows.Forms.ToolStripButton();
            this.btnFlipY = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdjustGamma = new System.Windows.Forms.ToolStripButton();
            this.btnStayOnTopMode = new System.Windows.Forms.ToolStripDropDownButton();
            this.stayOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dontStayOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLaunch = new System.Windows.Forms.ToolStripButton();
            this.btnAbout = new System.Windows.Forms.ToolStripButton();
            this.pMain = new System.Windows.Forms.Panel();
            this.pictureBoxImaging101Logo = new System.Windows.Forms.PictureBox();
            this.ToolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tcLeftPanel.SuspendLayout();
            this.tpThumbnails.SuspendLayout();
            this.ToolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.ToolStripContainer1.ContentPanel.SuspendLayout();
            this.ToolStripContainer1.SuspendLayout();
            this.thumbnailPanelToolstrip.SuspendLayout();
            this.tpBookmarks.SuspendLayout();
            this.Panel5.SuspendLayout();
            this.tpSearch.SuspendLayout();
            this.pSearch.SuspendLayout();
            this.Panel4.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.Panel6.SuspendLayout();
            this.Panel9.SuspendLayout();
            this.Panel7.SuspendLayout();
            this.pSnapInButtons.SuspendLayout();
            this.pGamma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbGamma)).BeginInit();
            this.statusbar.SuspendLayout();
            this.mainToolStrip.SuspendLayout();
            this.pMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImaging101Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // tcLeftPanel
            // 
            this.tcLeftPanel.Controls.Add(this.tpThumbnails);
            this.tcLeftPanel.Controls.Add(this.tpBookmarks);
            this.tcLeftPanel.Controls.Add(this.tpSearch);
            this.tcLeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcLeftPanel.Location = new System.Drawing.Point(0, 32);
            this.tcLeftPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tcLeftPanel.Multiline = true;
            this.tcLeftPanel.Name = "tcLeftPanel";
            this.tcLeftPanel.Padding = new System.Drawing.Point(0, 0);
            this.tcLeftPanel.SelectedIndex = 0;
            this.tcLeftPanel.Size = new System.Drawing.Size(239, 642);
            this.tcLeftPanel.TabIndex = 1;
            // 
            // tpThumbnails
            // 
            this.tpThumbnails.BackColor = System.Drawing.SystemColors.Control;
            this.tpThumbnails.Controls.Add(this.ToolStripContainer1);
            this.tpThumbnails.Location = new System.Drawing.Point(4, 22);
            this.tpThumbnails.Name = "tpThumbnails";
            this.tpThumbnails.Size = new System.Drawing.Size(231, 616);
            this.tpThumbnails.TabIndex = 0;
            this.tpThumbnails.Text = "Thumbnails";
            // 
            // ToolStripContainer1
            // 
            // 
            // ToolStripContainer1.BottomToolStripPanel
            // 
            this.ToolStripContainer1.BottomToolStripPanel.Controls.Add(this.thumbnailPanelToolstrip);
            // 
            // ToolStripContainer1.ContentPanel
            // 
            this.ToolStripContainer1.ContentPanel.Controls.Add(this.ThumbnailEx1);
            this.ToolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ToolStripContainer1.ContentPanel.Size = new System.Drawing.Size(231, 566);
            this.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.ToolStripContainer1.Name = "ToolStripContainer1";
            this.ToolStripContainer1.Size = new System.Drawing.Size(231, 616);
            this.ToolStripContainer1.TabIndex = 1;
            this.ToolStripContainer1.Text = "ToolStripContainer1";
            // 
            // thumbnailPanelToolstrip
            // 
            this.thumbnailPanelToolstrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.thumbnailPanelToolstrip.Dock = System.Windows.Forms.DockStyle.None;
            this.thumbnailPanelToolstrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.thumbnailPanelToolstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThumbSize});
            this.thumbnailPanelToolstrip.Location = new System.Drawing.Point(0, 0);
            this.thumbnailPanelToolstrip.Name = "thumbnailPanelToolstrip";
            this.thumbnailPanelToolstrip.Padding = new System.Windows.Forms.Padding(0);
            this.thumbnailPanelToolstrip.Size = new System.Drawing.Size(231, 25);
            this.thumbnailPanelToolstrip.Stretch = true;
            this.thumbnailPanelToolstrip.TabIndex = 0;
            // 
            // btnThumbSize
            // 
            this.btnThumbSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnThumbSize.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LargeThumbnailsToolStripMenuItem1,
            this.MediumThumbnailsToolStripMenuItem1,
            this.SmallThumbnailsToolStripMenuItem1});
            this.btnThumbSize.Image = ((System.Drawing.Image)(resources.GetObject("btnThumbSize.Image")));
            this.btnThumbSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThumbSize.Name = "btnThumbSize";
            this.btnThumbSize.Size = new System.Drawing.Size(29, 22);
            this.btnThumbSize.Text = "btnThumbnailSize";
            this.btnThumbSize.ToolTipText = "Thumbnail size";
            // 
            // LargeThumbnailsToolStripMenuItem1
            // 
            this.LargeThumbnailsToolStripMenuItem1.Name = "LargeThumbnailsToolStripMenuItem1";
            this.LargeThumbnailsToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.LargeThumbnailsToolStripMenuItem1.Text = "Large thumbnails";
            this.LargeThumbnailsToolStripMenuItem1.Click += new System.EventHandler(this.LargeThumbnailsToolStripMenuItem1_Click);
            // 
            // MediumThumbnailsToolStripMenuItem1
            // 
            this.MediumThumbnailsToolStripMenuItem1.Checked = true;
            this.MediumThumbnailsToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MediumThumbnailsToolStripMenuItem1.Name = "MediumThumbnailsToolStripMenuItem1";
            this.MediumThumbnailsToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.MediumThumbnailsToolStripMenuItem1.Text = "Medium thumbnails";
            this.MediumThumbnailsToolStripMenuItem1.Click += new System.EventHandler(this.MediumThumbnailsToolStripMenuItem1_Click);
            // 
            // SmallThumbnailsToolStripMenuItem1
            // 
            this.SmallThumbnailsToolStripMenuItem1.Name = "SmallThumbnailsToolStripMenuItem1";
            this.SmallThumbnailsToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.SmallThumbnailsToolStripMenuItem1.Text = "Small thumbnails";
            this.SmallThumbnailsToolStripMenuItem1.Click += new System.EventHandler(this.SmallThumbnailsToolStripMenuItem1_Click);
            // 
            // ThumbnailEx1
            // 
            this.ThumbnailEx1.AllowDropFiles = false;
            this.ThumbnailEx1.AllowMoveItems = false;
            this.ThumbnailEx1.BackColor = System.Drawing.SystemColors.Control;
            this.ThumbnailEx1.CheckBoxes = false;
            this.ThumbnailEx1.CheckBoxesMarginLeft = 0;
            this.ThumbnailEx1.CheckBoxesMarginTop = 0;
            this.ThumbnailEx1.DefaultItemCheckState = false;
            this.ThumbnailEx1.DefaultItemTextPrefix = "Page ";
            this.ThumbnailEx1.DisplayAnnotations = true;
            this.ThumbnailEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThumbnailEx1.EnableDropShadow = true;
            this.ThumbnailEx1.HorizontalTextAlignment = GdPicture14.TextAlignment.TextAlignmentCenter;
            this.ThumbnailEx1.HotTracking = false;
            this.ThumbnailEx1.Location = new System.Drawing.Point(0, 0);
            this.ThumbnailEx1.LockGdViewerEvents = false;
            this.ThumbnailEx1.MultiSelect = false;
            this.ThumbnailEx1.Name = "ThumbnailEx1";
            this.ThumbnailEx1.OwnDrop = false;
            this.ThumbnailEx1.PauseThumbsLoading = false;
            this.ThumbnailEx1.PdfIncreaseTextContrast = false;
            this.ThumbnailEx1.PreloadAllItems = true;
            this.ThumbnailEx1.RotateExif = true;
            this.ThumbnailEx1.SelectedThumbnailBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.ThumbnailEx1.SelectedThumbnailBackColorAlpha = 100;
            this.ThumbnailEx1.ShowText = true;
            this.ThumbnailEx1.Size = new System.Drawing.Size(231, 566);
            this.ThumbnailEx1.TabIndex = 0;
            this.ThumbnailEx1.TextMarginLeft = 0;
            this.ThumbnailEx1.TextMarginTop = 0;
            this.ThumbnailEx1.ThumbnailAlignment = GdPicture14.ThumbnailAlignment.ThumbnailAlignmentVertical;
            this.ThumbnailEx1.ThumbnailBackColor = System.Drawing.Color.Transparent;
            this.ThumbnailEx1.ThumbnailBorder = false;
            this.ThumbnailEx1.ThumbnailForeColor = System.Drawing.Color.Black;
            this.ThumbnailEx1.ThumbnailSize = new System.Drawing.Size(90, 128);
            this.ThumbnailEx1.ThumbnailSpacing = new System.Drawing.Size(0, 0);
            this.ThumbnailEx1.VerticalTextAlignment = GdPicture14.TextAlignment.TextAlignmentCenter;
            // 
            // tpBookmarks
            // 
            this.tpBookmarks.BackColor = System.Drawing.SystemColors.Control;
            this.tpBookmarks.Controls.Add(this.Panel5);
            this.tpBookmarks.Location = new System.Drawing.Point(4, 22);
            this.tpBookmarks.Name = "tpBookmarks";
            this.tpBookmarks.Size = new System.Drawing.Size(231, 616);
            this.tpBookmarks.TabIndex = 1;
            this.tpBookmarks.Text = "Bookmarks";
            // 
            // Panel5
            // 
            this.Panel5.Controls.Add(this.BookmarksTree1);
            this.Panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel5.Location = new System.Drawing.Point(0, 0);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(231, 616);
            this.Panel5.TabIndex = 1;
            // 
            // BookmarksTree1
            // 
            this.BookmarksTree1.AutoGenerate = true;
            this.BookmarksTree1.BackColor = System.Drawing.SystemColors.Control;
            this.BookmarksTree1.DisableZoomDestination = false;
            this.BookmarksTree1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BookmarksTree1.FontName = "Helvetica";
            this.BookmarksTree1.FontSize = 10F;
            this.BookmarksTree1.GdViewer = null;
            this.BookmarksTree1.ItemHeight = 20;
            this.BookmarksTree1.Location = new System.Drawing.Point(0, 0);
            this.BookmarksTree1.Name = "BookmarksTree1";
            this.BookmarksTree1.Padding = new System.Windows.Forms.Padding(10);
            this.BookmarksTree1.RightToLeftLayout = false;
            this.BookmarksTree1.Size = new System.Drawing.Size(231, 616);
            this.BookmarksTree1.TabIndex = 0;
            // 
            // tpSearch
            // 
            this.tpSearch.BackColor = System.Drawing.SystemColors.Control;
            this.tpSearch.Controls.Add(this.pSearch);
            this.tpSearch.Location = new System.Drawing.Point(4, 22);
            this.tpSearch.Name = "tpSearch";
            this.tpSearch.Size = new System.Drawing.Size(231, 616);
            this.tpSearch.TabIndex = 2;
            this.tpSearch.Text = "Search";
            // 
            // pSearch
            // 
            this.pSearch.BackColor = System.Drawing.SystemColors.Control;
            this.pSearch.Controls.Add(this.Panel4);
            this.pSearch.Controls.Add(this.Panel3);
            this.pSearch.Controls.Add(this.Panel2);
            this.pSearch.Controls.Add(this.Panel1);
            this.pSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pSearch.Location = new System.Drawing.Point(0, 0);
            this.pSearch.Name = "pSearch";
            this.pSearch.Padding = new System.Windows.Forms.Padding(10);
            this.pSearch.Size = new System.Drawing.Size(231, 616);
            this.pSearch.TabIndex = 0;
            // 
            // Panel4
            // 
            this.Panel4.Controls.Add(this.lstSearchResults);
            this.Panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel4.Location = new System.Drawing.Point(10, 283);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(211, 323);
            this.Panel4.TabIndex = 17;
            // 
            // lstSearchResults
            // 
            this.lstSearchResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3});
            this.lstSearchResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSearchResults.FullRowSelect = true;
            this.lstSearchResults.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstSearchResults.HideSelection = false;
            this.lstSearchResults.Location = new System.Drawing.Point(0, 0);
            this.lstSearchResults.MultiSelect = false;
            this.lstSearchResults.Name = "lstSearchResults";
            this.lstSearchResults.Size = new System.Drawing.Size(211, 323);
            this.lstSearchResults.TabIndex = 10;
            this.lstSearchResults.UseCompatibleStateImageBehavior = false;
            this.lstSearchResults.View = System.Windows.Forms.View.Tile;
            this.lstSearchResults.SelectedIndexChanged += new System.EventHandler(this.lstSearchResults_SelectedIndexChanged);
            // 
            // Panel3
            // 
            this.Panel3.Controls.Add(this.searchProgressBar);
            this.Panel3.Controls.Add(this.lblSearchResults);
            this.Panel3.Controls.Add(this.chkWholeWord);
            this.Panel3.Controls.Add(this.chkCaseSensitive);
            this.Panel3.Controls.Add(this.GroupBox2);
            this.Panel3.Controls.Add(this.btnFindPrevious);
            this.Panel3.Controls.Add(this.btnSearch);
            this.Panel3.Controls.Add(this.btnFindNext);
            this.Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel3.Location = new System.Drawing.Point(10, 63);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(211, 220);
            this.Panel3.TabIndex = 16;
            // 
            // searchProgressBar
            // 
            this.searchProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.searchProgressBar.Location = new System.Drawing.Point(0, 210);
            this.searchProgressBar.Minimum = 1;
            this.searchProgressBar.Name = "searchProgressBar";
            this.searchProgressBar.Size = new System.Drawing.Size(211, 10);
            this.searchProgressBar.TabIndex = 15;
            this.searchProgressBar.Value = 1;
            this.searchProgressBar.Visible = false;
            // 
            // lblSearchResults
            // 
            this.lblSearchResults.AutoSize = true;
            this.lblSearchResults.Location = new System.Drawing.Point(6, 191);
            this.lblSearchResults.Name = "lblSearchResults";
            this.lblSearchResults.Size = new System.Drawing.Size(78, 13);
            this.lblSearchResults.TabIndex = 14;
            this.lblSearchResults.Text = "Find result from";
            // 
            // chkWholeWord
            // 
            this.chkWholeWord.AutoSize = true;
            this.chkWholeWord.Location = new System.Drawing.Point(3, 3);
            this.chkWholeWord.Name = "chkWholeWord";
            this.chkWholeWord.Size = new System.Drawing.Size(113, 17);
            this.chkWholeWord.TabIndex = 1;
            this.chkWholeWord.Text = "Match whole word";
            this.chkWholeWord.UseVisualStyleBackColor = true;
            this.chkWholeWord.CheckedChanged += new System.EventHandler(this.chkWholeWord_CheckedChanged);
            // 
            // chkCaseSensitive
            // 
            this.chkCaseSensitive.AutoSize = true;
            this.chkCaseSensitive.Location = new System.Drawing.Point(3, 26);
            this.chkCaseSensitive.Name = "chkCaseSensitive";
            this.chkCaseSensitive.Size = new System.Drawing.Size(82, 17);
            this.chkCaseSensitive.TabIndex = 2;
            this.chkCaseSensitive.Text = "Match case";
            this.chkCaseSensitive.UseVisualStyleBackColor = true;
            this.chkCaseSensitive.CheckedChanged += new System.EventHandler(this.chkCaseSensitive_CheckedChanged);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.rbCurrentPage);
            this.GroupBox2.Controls.Add(this.rbAllPages);
            this.GroupBox2.Location = new System.Drawing.Point(3, 49);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(113, 70);
            this.GroupBox2.TabIndex = 7;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Search in";
            // 
            // rbCurrentPage
            // 
            this.rbCurrentPage.AutoSize = true;
            this.rbCurrentPage.Location = new System.Drawing.Point(6, 19);
            this.rbCurrentPage.Name = "rbCurrentPage";
            this.rbCurrentPage.Size = new System.Drawing.Size(85, 17);
            this.rbCurrentPage.TabIndex = 3;
            this.rbCurrentPage.TabStop = true;
            this.rbCurrentPage.Text = "current page";
            this.rbCurrentPage.UseVisualStyleBackColor = true;
            this.rbCurrentPage.CheckedChanged += new System.EventHandler(this.rbCurrentPage_CheckedChanged);
            // 
            // rbAllPages
            // 
            this.rbAllPages.AutoSize = true;
            this.rbAllPages.Location = new System.Drawing.Point(6, 42);
            this.rbAllPages.Name = "rbAllPages";
            this.rbAllPages.Size = new System.Drawing.Size(67, 17);
            this.rbAllPages.TabIndex = 4;
            this.rbAllPages.TabStop = true;
            this.rbAllPages.Text = "all pages";
            this.rbAllPages.UseVisualStyleBackColor = true;
            this.rbAllPages.CheckedChanged += new System.EventHandler(this.rbAllPages_CheckedChanged);
            // 
            // btnFindPrevious
            // 
            this.btnFindPrevious.Location = new System.Drawing.Point(3, 125);
            this.btnFindPrevious.Name = "btnFindPrevious";
            this.btnFindPrevious.Size = new System.Drawing.Size(81, 23);
            this.btnFindPrevious.TabIndex = 13;
            this.btnFindPrevious.Text = "Find previous";
            this.btnFindPrevious.UseVisualStyleBackColor = true;
            this.btnFindPrevious.Click += new System.EventHandler(this.btnFindPrevious_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(3, 154);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search All";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnFindNext
            // 
            this.btnFindNext.Location = new System.Drawing.Point(86, 125);
            this.btnFindNext.Name = "btnFindNext";
            this.btnFindNext.Size = new System.Drawing.Size(80, 23);
            this.btnFindNext.TabIndex = 12;
            this.btnFindNext.Text = "Find next";
            this.btnFindNext.UseVisualStyleBackColor = true;
            this.btnFindNext.Click += new System.EventHandler(this.btnFindNext_Click);
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.tbSearch);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel2.Location = new System.Drawing.Point(10, 36);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(211, 27);
            this.Panel2.TabIndex = 15;
            // 
            // tbSearch
            // 
            this.tbSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbSearch.Location = new System.Drawing.Point(0, 0);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(166, 20);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.PictureBox1);
            this.Panel1.Controls.Add(this.lblSearchFor);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(10, 10);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(211, 26);
            this.Panel1.TabIndex = 14;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(3, 3);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(20, 20);
            this.PictureBox1.TabIndex = 11;
            this.PictureBox1.TabStop = false;
            // 
            // lblSearchFor
            // 
            this.lblSearchFor.AutoSize = true;
            this.lblSearchFor.Location = new System.Drawing.Point(29, 7);
            this.lblSearchFor.Name = "lblSearchFor";
            this.lblSearchFor.Size = new System.Drawing.Size(56, 13);
            this.lblSearchFor.TabIndex = 8;
            this.lblSearchFor.Text = "Search for";
            // 
            // scMain
            // 
            this.scMain.BackColor = System.Drawing.SystemColors.Control;
            this.scMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.BackColor = System.Drawing.SystemColors.Window;
            this.scMain.Panel1.Controls.Add(this.Panel6);
            this.scMain.Panel1MinSize = 150;
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.pGamma);
            this.scMain.Panel2.Controls.Add(this.GdViewer1);
            this.scMain.Panel2MinSize = 200;
            this.scMain.Size = new System.Drawing.Size(1264, 676);
            this.scMain.SplitterDistance = 273;
            this.scMain.TabIndex = 2;
            // 
            // Panel6
            // 
            this.Panel6.Controls.Add(this.Panel9);
            this.Panel6.Controls.Add(this.pSnapInButtons);
            this.Panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel6.Location = new System.Drawing.Point(0, 0);
            this.Panel6.Margin = new System.Windows.Forms.Padding(0);
            this.Panel6.Name = "Panel6";
            this.Panel6.Size = new System.Drawing.Size(271, 674);
            this.Panel6.TabIndex = 2;
            // 
            // Panel9
            // 
            this.Panel9.BackColor = System.Drawing.SystemColors.Control;
            this.Panel9.Controls.Add(this.tcLeftPanel);
            this.Panel9.Controls.Add(this.Panel7);
            this.Panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel9.Location = new System.Drawing.Point(32, 0);
            this.Panel9.Name = "Panel9";
            this.Panel9.Size = new System.Drawing.Size(239, 674);
            this.Panel9.TabIndex = 5;
            // 
            // Panel7
            // 
            this.Panel7.BackColor = System.Drawing.SystemColors.Control;
            this.Panel7.Controls.Add(this.lblSnapInPanel);
            this.Panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel7.Location = new System.Drawing.Point(0, 0);
            this.Panel7.Name = "Panel7";
            this.Panel7.Size = new System.Drawing.Size(239, 32);
            this.Panel7.TabIndex = 6;
            // 
            // lblSnapInPanel
            // 
            this.lblSnapInPanel.AutoSize = true;
            this.lblSnapInPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSnapInPanel.Location = new System.Drawing.Point(6, 8);
            this.lblSnapInPanel.Name = "lblSnapInPanel";
            this.lblSnapInPanel.Size = new System.Drawing.Size(82, 15);
            this.lblSnapInPanel.TabIndex = 0;
            this.lblSnapInPanel.Text = "Thumbnails";
            // 
            // pSnapInButtons
            // 
            this.pSnapInButtons.AutoSize = true;
            this.pSnapInButtons.BackColor = System.Drawing.Color.White;
            this.pSnapInButtons.Controls.Add(this.btnSnapInThumbnails);
            this.pSnapInButtons.Controls.Add(this.btnSnapInBookmarks);
            this.pSnapInButtons.Controls.Add(this.btnSnapInSearch);
            this.pSnapInButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.pSnapInButtons.Location = new System.Drawing.Point(0, 0);
            this.pSnapInButtons.Name = "pSnapInButtons";
            this.pSnapInButtons.Size = new System.Drawing.Size(32, 674);
            this.pSnapInButtons.TabIndex = 4;
            // 
            // btnSnapInThumbnails
            // 
            this.btnSnapInThumbnails.BackColor = System.Drawing.Color.White;
            this.btnSnapInThumbnails.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnSnapInThumbnails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnapInThumbnails.Image = ((System.Drawing.Image)(resources.GetObject("btnSnapInThumbnails.Image")));
            this.btnSnapInThumbnails.Location = new System.Drawing.Point(0, 0);
            this.btnSnapInThumbnails.Margin = new System.Windows.Forms.Padding(0);
            this.btnSnapInThumbnails.Name = "btnSnapInThumbnails";
            this.btnSnapInThumbnails.Size = new System.Drawing.Size(32, 32);
            this.btnSnapInThumbnails.TabIndex = 0;
            this.btnSnapInThumbnails.UseVisualStyleBackColor = false;
            this.btnSnapInThumbnails.Click += new System.EventHandler(this.btnSnapInThumbnails_Click);
            // 
            // btnSnapInBookmarks
            // 
            this.btnSnapInBookmarks.BackColor = System.Drawing.Color.White;
            this.btnSnapInBookmarks.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnSnapInBookmarks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnapInBookmarks.Image = ((System.Drawing.Image)(resources.GetObject("btnSnapInBookmarks.Image")));
            this.btnSnapInBookmarks.Location = new System.Drawing.Point(0, 31);
            this.btnSnapInBookmarks.Margin = new System.Windows.Forms.Padding(0);
            this.btnSnapInBookmarks.Name = "btnSnapInBookmarks";
            this.btnSnapInBookmarks.Size = new System.Drawing.Size(32, 32);
            this.btnSnapInBookmarks.TabIndex = 1;
            this.btnSnapInBookmarks.UseVisualStyleBackColor = false;
            this.btnSnapInBookmarks.Click += new System.EventHandler(this.btnSnapInBookmarks_Click);
            // 
            // btnSnapInSearch
            // 
            this.btnSnapInSearch.BackColor = System.Drawing.Color.White;
            this.btnSnapInSearch.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnSnapInSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnapInSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSnapInSearch.Image")));
            this.btnSnapInSearch.Location = new System.Drawing.Point(0, 62);
            this.btnSnapInSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSnapInSearch.Name = "btnSnapInSearch";
            this.btnSnapInSearch.Size = new System.Drawing.Size(32, 32);
            this.btnSnapInSearch.TabIndex = 2;
            this.btnSnapInSearch.UseVisualStyleBackColor = false;
            this.btnSnapInSearch.Click += new System.EventHandler(this.btnSnapInSearch_Click);
            // 
            // pGamma
            // 
            this.pGamma.AutoSize = true;
            this.pGamma.BackColor = System.Drawing.SystemColors.Control;
            this.pGamma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pGamma.Controls.Add(this.lblGamma);
            this.pGamma.Controls.Add(this.tbGamma);
            this.pGamma.Location = new System.Drawing.Point(3, 3);
            this.pGamma.Name = "pGamma";
            this.pGamma.Size = new System.Drawing.Size(317, 62);
            this.pGamma.TabIndex = 1;
            // 
            // lblGamma
            // 
            this.lblGamma.AutoSize = true;
            this.lblGamma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGamma.Location = new System.Drawing.Point(3, 42);
            this.lblGamma.Name = "lblGamma";
            this.lblGamma.Size = new System.Drawing.Size(76, 13);
            this.lblGamma.TabIndex = 1;
            this.lblGamma.Text = "Current value: ";
            // 
            // tbGamma
            // 
            this.tbGamma.Location = new System.Drawing.Point(3, 0);
            this.tbGamma.Maximum = 50;
            this.tbGamma.Minimum = 1;
            this.tbGamma.Name = "tbGamma";
            this.tbGamma.Size = new System.Drawing.Size(309, 45);
            this.tbGamma.TabIndex = 0;
            this.tbGamma.Value = 1;
            this.tbGamma.Scroll += new System.EventHandler(this.tbGamma_Scroll);
            // 
            // GdViewer1
            // 
            this.GdViewer1.AllowDropFile = true;
            this.GdViewer1.AnimateGIF = true;
            this.GdViewer1.AnnotationDropShadow = false;
            this.GdViewer1.AnnotationEnableMultiSelect = true;
            this.GdViewer1.AnnotationResizeRotateHandlesColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.GdViewer1.AnnotationResizeRotateHandlesScale = 1F;
            this.GdViewer1.AnnotationSelectionLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GdViewer1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.GdViewer1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.GdViewer1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.GdViewer1.BackgroundImage = null;
            this.GdViewer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GdViewer1.ClipAnnotsToPageBounds = true;
            this.GdViewer1.ClipRegionsToPageBounds = true;
            this.GdViewer1.ContinuousViewMode = true;
            this.GdViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.GdViewer1.DisplayQuality = GdPicture14.DisplayQuality.DisplayQualityAutomatic;
            this.GdViewer1.DisplayQualityAuto = true;
            this.GdViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GdViewer1.DocumentAlignment = GdPicture14.ViewerDocumentAlignment.DocumentAlignmentMiddleCenter;
            this.GdViewer1.DocumentPosition = GdPicture14.ViewerDocumentPosition.DocumentPositionMiddleCenter;
            this.GdViewer1.DrawPageBorders = true;
            this.GdViewer1.EnableDeferredPainting = true;
            this.GdViewer1.EnabledProgressBar = true;
            this.GdViewer1.EnableICM = false;
            this.GdViewer1.EnableMenu = true;
            this.GdViewer1.EnableMouseWheel = true;
            this.GdViewer1.EnableTextSelection = true;
            this.GdViewer1.ForceScrollBars = false;
            this.GdViewer1.ForceTemporaryMode = false;
            this.GdViewer1.ForeColor = System.Drawing.Color.Black;
            this.GdViewer1.Gamma = 1F;
            this.GdViewer1.HQAnnotationRendering = true;
            this.GdViewer1.IgnoreDocumentResolution = false;
            this.GdViewer1.KeepDocumentPosition = false;
            this.GdViewer1.Location = new System.Drawing.Point(0, 0);
            this.GdViewer1.LockViewer = false;
            this.GdViewer1.MagnifierHeight = 90;
            this.GdViewer1.MagnifierWidth = 160;
            this.GdViewer1.MagnifierZoomX = 2F;
            this.GdViewer1.MagnifierZoomY = 2F;
            this.GdViewer1.MouseButtonForMouseMode = GdPicture14.MouseButton.MouseButtonLeft;
            this.GdViewer1.MouseMode = GdPicture14.ViewerMouseMode.MouseModePan;
            this.GdViewer1.MouseWheelMode = GdPicture14.ViewerMouseWheelMode.MouseWheelModeVerticalScroll;
            this.GdViewer1.Name = "GdViewer1";
            this.GdViewer1.PageBordersColor = System.Drawing.Color.Black;
            this.GdViewer1.PageBordersPenSize = 1;
            this.GdViewer1.PageDisplayMode = GdPicture14.PageDisplayMode.MultiplePagesView;
            this.GdViewer1.PdfDisplayFormField = true;
            this.GdViewer1.PdfEnableFileLinks = true;
            this.GdViewer1.PdfEnableLinks = true;
            this.GdViewer1.PdfIncreaseTextContrast = false;
            this.GdViewer1.PdfShowDialogForPassword = true;
            this.GdViewer1.PdfShowOpenFileDialogForDecryption = true;
            this.GdViewer1.PdfVerifyDigitalCertificates = false;
            this.GdViewer1.PreserveViewRotation = true;
            this.GdViewer1.RectBorderColor = System.Drawing.Color.DodgerBlue;
            this.GdViewer1.RectBorderSize = 2;
            this.GdViewer1.RectIsEditable = true;
            this.GdViewer1.RegionsAreEditable = true;
            this.GdViewer1.RenderGdPictureAnnots = true;
            this.GdViewer1.ScrollBars = true;
            this.GdViewer1.ScrollLargeChange = ((short)(50));
            this.GdViewer1.ScrollSmallChange = ((short)(1));
            this.GdViewer1.SilentMode = true;
            this.GdViewer1.Size = new System.Drawing.Size(985, 674);
            this.GdViewer1.TabIndex = 0;
            this.GdViewer1.ViewRotation = System.Drawing.RotateFlipType.RotateNoneFlipNone;
            this.GdViewer1.Zoom = 0D;
            this.GdViewer1.ZoomCenterAtMousePosition = false;
            this.GdViewer1.ZoomMode = GdPicture14.ViewerZoomMode.ZoomModeFitToViewer;
            this.GdViewer1.ZoomStep = 25;
            this.GdViewer1.DropFile += new GdPicture14.GdViewer.DropFileEventHandler(this.GdViewer1_DropFile);
            this.GdViewer1.TransferEnded += new GdPicture14.GdViewer.TransferEndedEventHandler(this.GdViewer1_TransferEnded);
            this.GdViewer1.AfterZoomChange += new GdPicture14.GdViewer.AfterZoomChangeEventHandler(this.GdViewer1_AfterZoomChange);
            this.GdViewer1.PageChanged += new GdPicture14.GdViewer.PageChangedEventHandler(this.GdViewer1_PageChanged);
            this.GdViewer1.Load += new System.EventHandler(this.GdViewer1_Load);
            this.GdViewer1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.GdViewer1_MouseDoubleClick);
            // 
            // statusbar
            // 
            this.statusbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel1,
            this.ToolStripStatusLabel2});
            this.statusbar.Location = new System.Drawing.Point(0, 707);
            this.statusbar.Name = "statusbar";
            this.statusbar.Size = new System.Drawing.Size(1264, 22);
            this.statusbar.TabIndex = 3;
            this.statusbar.Text = "StatusStrip1";
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.AutoSize = false;
            this.mainToolStrip.BackColor = System.Drawing.Color.White;
            this.mainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mainToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpen,
            this.btnClose,
            this.btnPrint,
            this.ToolStripSeparator3,
            this.btnSettings,
            this.btnMouseMode,
            this.ToolStripSeparator6,
            this.btnFirstPage,
            this.btnPreviousPage,
            this.tbCurrentPage,
            this.lblPageCount,
            this.btnNextPage,
            this.btnLastPage,
            this.ToolStripSeparator1,
            this.btnZoomOut,
            this.cbZoom,
            this.btnZoomIn,
            this.ToolStripSeparator2,
            this.btnFitWidth,
            this.btnFitPage,
            this.ToolStripSeparator5,
            this.btnRotateLeft,
            this.btnRotateRight,
            this.btnFlipX,
            this.btnFlipY,
            this.toolStripSeparator4,
            this.btnAdjustGamma,
            this.btnStayOnTopMode,
            this.toolStripSeparator7,
            this.btnLaunch,
            this.btnAbout});
            this.mainToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.mainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(1264, 31);
            this.mainToolStrip.TabIndex = 5;
            this.mainToolStrip.Text = "ToolStrip1";
            // 
            // btnOpen
            // 
            this.btnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(28, 28);
            this.btnOpen.Text = "Open Document";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 28);
            this.btnClose.Text = "Close document";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(28, 28);
            this.btnPrint.Text = "Print document";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // btnSettings
            // 
            this.btnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(28, 28);
            this.btnSettings.Text = "Viewer settings";
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnMouseMode
            // 
            this.btnMouseMode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMouseMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DefaultToolStripMenuItem,
            this.AreaSelectionToolStripMenuItem,
            this.PanToolStripMenuItem,
            this.AreaZoomingToolStripMenuItem,
            this.MagnifierToolStripMenuItem});
            this.btnMouseMode.Image = ((System.Drawing.Image)(resources.GetObject("btnMouseMode.Image")));
            this.btnMouseMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMouseMode.Name = "btnMouseMode";
            this.btnMouseMode.Size = new System.Drawing.Size(37, 28);
            this.btnMouseMode.Text = "Mouse mode";
            this.btnMouseMode.Click += new System.EventHandler(this.btnMouseMode_Click);
            // 
            // DefaultToolStripMenuItem
            // 
            this.DefaultToolStripMenuItem.CheckOnClick = true;
            this.DefaultToolStripMenuItem.Name = "DefaultToolStripMenuItem";
            this.DefaultToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.DefaultToolStripMenuItem.Text = "Default";
            this.DefaultToolStripMenuItem.Click += new System.EventHandler(this.DefaultToolStripMenuItem_Click);
            // 
            // AreaSelectionToolStripMenuItem
            // 
            this.AreaSelectionToolStripMenuItem.CheckOnClick = true;
            this.AreaSelectionToolStripMenuItem.Name = "AreaSelectionToolStripMenuItem";
            this.AreaSelectionToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.AreaSelectionToolStripMenuItem.Text = "Area selection";
            this.AreaSelectionToolStripMenuItem.Click += new System.EventHandler(this.AreaSelectionToolStripMenuItem_Click);
            // 
            // PanToolStripMenuItem
            // 
            this.PanToolStripMenuItem.CheckOnClick = true;
            this.PanToolStripMenuItem.Name = "PanToolStripMenuItem";
            this.PanToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.PanToolStripMenuItem.Text = "Pan";
            this.PanToolStripMenuItem.Click += new System.EventHandler(this.PanToolStripMenuItem_Click);
            // 
            // AreaZoomingToolStripMenuItem
            // 
            this.AreaZoomingToolStripMenuItem.Checked = true;
            this.AreaZoomingToolStripMenuItem.CheckOnClick = true;
            this.AreaZoomingToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AreaZoomingToolStripMenuItem.Name = "AreaZoomingToolStripMenuItem";
            this.AreaZoomingToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.AreaZoomingToolStripMenuItem.Text = "Area zooming";
            this.AreaZoomingToolStripMenuItem.Click += new System.EventHandler(this.AreaZoomingToolStripMenuItem_Click);
            // 
            // MagnifierToolStripMenuItem
            // 
            this.MagnifierToolStripMenuItem.CheckOnClick = true;
            this.MagnifierToolStripMenuItem.Name = "MagnifierToolStripMenuItem";
            this.MagnifierToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.MagnifierToolStripMenuItem.Text = "Magnifier";
            this.MagnifierToolStripMenuItem.Click += new System.EventHandler(this.MagnifierToolStripMenuItem_Click);
            // 
            // ToolStripSeparator6
            // 
            this.ToolStripSeparator6.Margin = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.ToolStripSeparator6.Name = "ToolStripSeparator6";
            this.ToolStripSeparator6.Size = new System.Drawing.Size(6, 23);
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFirstPage.Image = ((System.Drawing.Image)(resources.GetObject("btnFirstPage.Image")));
            this.btnFirstPage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFirstPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(28, 28);
            this.btnFirstPage.Text = "Go to first page";
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPreviousPage.Image = ((System.Drawing.Image)(resources.GetObject("btnPreviousPage.Image")));
            this.btnPreviousPage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPreviousPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(28, 28);
            this.btnPreviousPage.Text = "Go to previous page";
            this.btnPreviousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);
            // 
            // tbCurrentPage
            // 
            this.tbCurrentPage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurrentPage.Name = "tbCurrentPage";
            this.tbCurrentPage.Size = new System.Drawing.Size(40, 25);
            this.tbCurrentPage.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbCurrentPage.Leave += new System.EventHandler(this.tbCurrentPage_Leave);
            // 
            // lblPageCount
            // 
            this.lblPageCount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageCount.Name = "lblPageCount";
            this.lblPageCount.Size = new System.Drawing.Size(25, 17);
            this.lblPageCount.Text = "/ X";
            // 
            // btnNextPage
            // 
            this.btnNextPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNextPage.Image = ((System.Drawing.Image)(resources.GetObject("btnNextPage.Image")));
            this.btnNextPage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNextPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(28, 28);
            this.btnNextPage.Text = "Go to next page";
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnLastPage
            // 
            this.btnLastPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLastPage.Image = ((System.Drawing.Image)(resources.GetObject("btnLastPage.Image")));
            this.btnLastPage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLastPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(28, 28);
            this.btnLastPage.Text = "Go to last page";
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomOut.Image")));
            this.btnZoomOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(28, 28);
            this.btnZoomOut.Text = "Zoom out";
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // cbZoom
            // 
            this.cbZoom.DropDownWidth = 200;
            this.cbZoom.Name = "cbZoom";
            this.cbZoom.Size = new System.Drawing.Size(75, 23);
            this.cbZoom.SelectedIndexChanged += new System.EventHandler(this.cbZoom_SelectedIndexChanged);
            this.cbZoom.Validating += new System.ComponentModel.CancelEventHandler(this.cbZoom_Validating);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomIn.Image")));
            this.btnZoomIn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(28, 28);
            this.btnZoomIn.Text = "Zoom In";
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // btnFitWidth
            // 
            this.btnFitWidth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFitWidth.Image = ((System.Drawing.Image)(resources.GetObject("btnFitWidth.Image")));
            this.btnFitWidth.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFitWidth.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFitWidth.Name = "btnFitWidth";
            this.btnFitWidth.Size = new System.Drawing.Size(28, 28);
            this.btnFitWidth.Text = "Adjust to page width";
            this.btnFitWidth.Click += new System.EventHandler(this.btnFitWidth_Click);
            // 
            // btnFitPage
            // 
            this.btnFitPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFitPage.Image = ((System.Drawing.Image)(resources.GetObject("btnFitPage.Image")));
            this.btnFitPage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFitPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFitPage.Name = "btnFitPage";
            this.btnFitPage.Size = new System.Drawing.Size(28, 28);
            this.btnFitPage.Text = "Adjust to whole page";
            this.btnFitPage.Click += new System.EventHandler(this.btnFitPage_Click);
            // 
            // ToolStripSeparator5
            // 
            this.ToolStripSeparator5.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ToolStripSeparator5.Name = "ToolStripSeparator5";
            this.ToolStripSeparator5.Size = new System.Drawing.Size(6, 23);
            // 
            // btnRotateLeft
            // 
            this.btnRotateLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRotateLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnRotateLeft.Image")));
            this.btnRotateLeft.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRotateLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRotateLeft.Name = "btnRotateLeft";
            this.btnRotateLeft.Size = new System.Drawing.Size(28, 28);
            this.btnRotateLeft.Text = "Rotate left";
            this.btnRotateLeft.Click += new System.EventHandler(this.btnRotateLeft_Click);
            // 
            // btnRotateRight
            // 
            this.btnRotateRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRotateRight.Image = ((System.Drawing.Image)(resources.GetObject("btnRotateRight.Image")));
            this.btnRotateRight.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRotateRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRotateRight.Name = "btnRotateRight";
            this.btnRotateRight.Size = new System.Drawing.Size(28, 28);
            this.btnRotateRight.Text = "Rotate right";
            this.btnRotateRight.Click += new System.EventHandler(this.btnRotateRight_Click);
            // 
            // btnFlipX
            // 
            this.btnFlipX.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFlipX.Image = ((System.Drawing.Image)(resources.GetObject("btnFlipX.Image")));
            this.btnFlipX.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFlipX.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFlipX.Name = "btnFlipX";
            this.btnFlipX.Size = new System.Drawing.Size(28, 28);
            this.btnFlipX.Text = "Vertical flip";
            this.btnFlipX.Click += new System.EventHandler(this.btnFlipX_Click);
            // 
            // btnFlipY
            // 
            this.btnFlipY.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFlipY.Image = ((System.Drawing.Image)(resources.GetObject("btnFlipY.Image")));
            this.btnFlipY.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFlipY.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFlipY.Name = "btnFlipY";
            this.btnFlipY.Size = new System.Drawing.Size(28, 28);
            this.btnFlipY.Text = "Horizontal flip";
            this.btnFlipY.Click += new System.EventHandler(this.btnFlipY_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 23);
            // 
            // btnAdjustGamma
            // 
            this.btnAdjustGamma.CheckOnClick = true;
            this.btnAdjustGamma.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdjustGamma.Image = ((System.Drawing.Image)(resources.GetObject("btnAdjustGamma.Image")));
            this.btnAdjustGamma.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdjustGamma.Name = "btnAdjustGamma";
            this.btnAdjustGamma.Size = new System.Drawing.Size(28, 28);
            this.btnAdjustGamma.Text = "Adjust gamma (Darkness Level)";
            this.btnAdjustGamma.Click += new System.EventHandler(this.ToolStripButton1_Click_1);
            // 
            // btnStayOnTopMode
            // 
            this.btnStayOnTopMode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStayOnTopMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stayOnTopToolStripMenuItem,
            this.dontStayOnTopToolStripMenuItem});
            this.btnStayOnTopMode.Image = ((System.Drawing.Image)(resources.GetObject("btnStayOnTopMode.Image")));
            this.btnStayOnTopMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStayOnTopMode.Name = "btnStayOnTopMode";
            this.btnStayOnTopMode.Size = new System.Drawing.Size(37, 28);
            this.btnStayOnTopMode.Text = "toolStripDropDownButton1";
            this.btnStayOnTopMode.ToolTipText = "Stay-On-Top Options";
            this.btnStayOnTopMode.Click += new System.EventHandler(this.btnStayOnTopMode_Click);
            // 
            // stayOnTopToolStripMenuItem
            // 
            this.stayOnTopToolStripMenuItem.CheckOnClick = true;
            this.stayOnTopToolStripMenuItem.Name = "stayOnTopToolStripMenuItem";
            this.stayOnTopToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.stayOnTopToolStripMenuItem.Text = "Stay On Top";
            this.stayOnTopToolStripMenuItem.Click += new System.EventHandler(this.stayOnTopToolStripMenuItem_Click);
            // 
            // dontStayOnTopToolStripMenuItem
            // 
            this.dontStayOnTopToolStripMenuItem.Checked = true;
            this.dontStayOnTopToolStripMenuItem.CheckOnClick = true;
            this.dontStayOnTopToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dontStayOnTopToolStripMenuItem.Name = "dontStayOnTopToolStripMenuItem";
            this.dontStayOnTopToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.dontStayOnTopToolStripMenuItem.Text = "Don\'t Stay On Top";
            this.dontStayOnTopToolStripMenuItem.Click += new System.EventHandler(this.dontStayOnTopToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 23);
            // 
            // btnLaunch
            // 
            this.btnLaunch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLaunch.Image = ((System.Drawing.Image)(resources.GetObject("btnLaunch.Image")));
            this.btnLaunch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(28, 28);
            this.btnLaunch.Text = "Launch - Open in Associated Windows Application";
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(28, 28);
            this.btnAbout.Text = "About";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // pMain
            // 
            this.pMain.Controls.Add(this.scMain);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 31);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(1264, 676);
            this.pMain.TabIndex = 6;
            // 
            // pictureBoxImaging101Logo
            // 
            this.pictureBoxImaging101Logo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBoxImaging101Logo.ErrorImage = null;
            this.pictureBoxImaging101Logo.Image = global::My.Resources.Resources.I101Logo201204_250x60;
            this.pictureBoxImaging101Logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxImaging101Logo.InitialImage")));
            this.pictureBoxImaging101Logo.Location = new System.Drawing.Point(1070, 2);
            this.pictureBoxImaging101Logo.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxImaging101Logo.Name = "pictureBoxImaging101Logo";
            this.pictureBoxImaging101Logo.Size = new System.Drawing.Size(127, 28);
            this.pictureBoxImaging101Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImaging101Logo.TabIndex = 37;
            this.pictureBoxImaging101Logo.TabStop = false;
            // 
            // ToolStripStatusLabel2
            // 
            this.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
            this.ToolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.ToolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.pictureBoxImaging101Logo);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.mainToolStrip);
            this.Controls.Add(this.statusbar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Imaging101 Document Viewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResizeEnd += new System.EventHandler(this.frmMain_ResizeEnd);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.tcLeftPanel.ResumeLayout(false);
            this.tpThumbnails.ResumeLayout(false);
            this.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.ToolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.ToolStripContainer1.ContentPanel.ResumeLayout(false);
            this.ToolStripContainer1.ResumeLayout(false);
            this.ToolStripContainer1.PerformLayout();
            this.thumbnailPanelToolstrip.ResumeLayout(false);
            this.thumbnailPanelToolstrip.PerformLayout();
            this.tpBookmarks.ResumeLayout(false);
            this.Panel5.ResumeLayout(false);
            this.tpSearch.ResumeLayout(false);
            this.pSearch.ResumeLayout(false);
            this.Panel4.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            this.scMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.Panel6.ResumeLayout(false);
            this.Panel6.PerformLayout();
            this.Panel9.ResumeLayout(false);
            this.Panel7.ResumeLayout(false);
            this.Panel7.PerformLayout();
            this.pSnapInButtons.ResumeLayout(false);
            this.pGamma.ResumeLayout(false);
            this.pGamma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbGamma)).EndInit();
            this.statusbar.ResumeLayout(false);
            this.statusbar.PerformLayout();
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.pMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImaging101Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal GdPicture14.ThumbnailEx ThumbnailEx1;
        internal System.Windows.Forms.TabControl tcLeftPanel;
        internal System.Windows.Forms.TabPage tpThumbnails;
        internal System.Windows.Forms.TabPage tpBookmarks;
        internal System.Windows.Forms.SplitContainer scMain;
        internal GdPicture14.GdViewer GdViewer1;
        internal System.Windows.Forms.StatusStrip statusbar;
        internal System.Windows.Forms.ToolStrip mainToolStrip;
        internal System.Windows.Forms.Panel pMain;
        internal GdPicture14.BookmarksTree BookmarksTree1;
        internal System.Windows.Forms.ToolStripButton btnOpen;
        internal System.Windows.Forms.ToolStripButton btnClose;
        internal System.Windows.Forms.ToolStripButton btnPrint;
        internal System.Windows.Forms.ToolStripButton btnAbout;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
        internal System.Windows.Forms.TabPage tpSearch;
        internal System.Windows.Forms.Panel pSearch;
        internal System.Windows.Forms.RadioButton rbAllPages;
        internal System.Windows.Forms.RadioButton rbCurrentPage;
        internal System.Windows.Forms.CheckBox chkCaseSensitive;
        internal System.Windows.Forms.CheckBox chkWholeWord;
        internal System.Windows.Forms.TextBox tbSearch;
        internal System.Windows.Forms.Button btnSearch;
        internal System.Windows.Forms.Label lblSearchFor;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.ToolStripButton btnFirstPage;
        internal System.Windows.Forms.ToolStripButton btnPreviousPage;
        internal System.Windows.Forms.ToolStripTextBox tbCurrentPage;
        internal System.Windows.Forms.ToolStripLabel lblPageCount;
        internal System.Windows.Forms.ToolStripButton btnNextPage;
        internal System.Windows.Forms.ToolStripButton btnLastPage;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton btnZoomOut;
        internal System.Windows.Forms.ToolStripComboBox cbZoom;
        internal System.Windows.Forms.ToolStripButton btnZoomIn;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        internal System.Windows.Forms.ToolStripButton btnRotateLeft;
        internal System.Windows.Forms.ToolStripButton btnRotateRight;
        internal System.Windows.Forms.ToolStripButton btnFlipX;
        internal System.Windows.Forms.ToolStripButton btnFlipY;
        internal System.Windows.Forms.ListView lstSearchResults;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader2;
        internal System.Windows.Forms.ColumnHeader ColumnHeader3;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Button btnFindPrevious;
        internal System.Windows.Forms.Button btnFindNext;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Panel Panel4;
        internal System.Windows.Forms.Panel Panel5;
        internal System.Windows.Forms.ToolStripButton btnSettings;
        internal System.Windows.Forms.Label lblSearchResults;
        internal System.Windows.Forms.ProgressBar searchProgressBar;
        internal System.Windows.Forms.ToolStripButton btnFitWidth;
        internal System.Windows.Forms.ToolStripButton btnFitPage;
        internal System.Windows.Forms.ToolStripContainer ToolStripContainer1;
        internal System.Windows.Forms.ToolStrip thumbnailPanelToolstrip;
        internal System.Windows.Forms.Panel pGamma;
        internal System.Windows.Forms.TrackBar tbGamma;
        internal System.Windows.Forms.Label lblGamma;
        internal System.Windows.Forms.Panel Panel6;
        internal System.Windows.Forms.Button btnSnapInThumbnails;
        internal System.Windows.Forms.Button btnSnapInSearch;
        internal System.Windows.Forms.Button btnSnapInBookmarks;
        internal System.Windows.Forms.Panel Panel9;
        internal System.Windows.Forms.Panel pSnapInButtons;
        internal System.Windows.Forms.Panel Panel7;
        internal System.Windows.Forms.Label lblSnapInPanel;
        internal System.Windows.Forms.ToolStripDropDownButton btnMouseMode;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator6;
        internal System.Windows.Forms.ToolStripMenuItem DefaultToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem AreaSelectionToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem PanToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem AreaZoomingToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem MagnifierToolStripMenuItem;
        internal System.Windows.Forms.ToolStripDropDownButton btnThumbSize;
        internal System.Windows.Forms.ToolStripMenuItem LargeThumbnailsToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem MediumThumbnailsToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem SmallThumbnailsToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator5;
        internal System.Windows.Forms.ToolStripButton btnAdjustGamma;
        private System.Windows.Forms.PictureBox pictureBoxImaging101Logo;
        private ToolStripButton btnLaunch;
        private ToolStripDropDownButton btnStayOnTopMode;
        private ToolStripMenuItem stayOnTopToolStripMenuItem;
        private ToolStripMenuItem dontStayOnTopToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripStatusLabel ToolStripStatusLabel2;
    }

}
