using GdPicture14;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;


namespace I101DocumentViewer
{

    public partial class frmMain
    {
        //Define Global Variable to hold Command Arguments for use later.
        public string[] commandArgs;

        private Form formLoading = new frmLoadingGif();

        public frmMain(string[] args)
        {


            try
            {
                commandArgs = args;

                LicenseManager oLicenceManager = new LicenseManager();
                bool bolRegisterKEYResult = oLicenceManager.RegisterKEY("G0ovjZBq2ctIGka7-36XyKmcz8QnJ5y0Q8lmtR25h_VFy3WgpypkX5Pxzwz4DCbB0vKFagaxORJRR37Kkv40RCIg9o-B0NYITzZlgOmJOEKd4lTaR495gkSniunVJ9sH0ZBfgBIsDIIALvW7PsNTEZbrqenXHZX3J2HY7U-YjmMa7vZvC2R8Ou0bFBzYa0iiabfThloIXEGkS6MtcWQDVVdDWnJix6oATq-alsRty5Iexlukk3Hq02xs0PKGBj0gD8_Q_dx5RWFm_OfZ_XD3f8c-2J1VJw3d9sAV4OX6_P5wua12VYI-tzpWln0sgncnd8pFZELX-5eUMnIVpZgRpttPM0y1KScKrVtk4nzuff1UCXbkwPB6XSmwe463X_LjVFWvDUnQMWfWkPcBgraIaURfx_p_upHsOmISHReJW2eu7TOOJi49krrROpqiuq6InT81BTFBF8bnrkL0vdcOoNvZVUvgvEj49nijdtu_7EKB3DtOlCLqg2Baz_5IdDzJZrIFDbCh1Jbc1mJBWXNENvCl0HO7QZAswtD0qAveJ3UAEv64ddKuEXCsaQ5iF5DhBLD6Z72ZUCu7bp_hgzTZK9uZoZu2p5w10rWm9P6BlODSfuPklR9cvghCtGykgCfokbxAI9vAUEd17PsSekV_s597wpDihtu6dW9RWTI4i0YcceiXIEVFQrPc9dIe1nXXyz8Sn4ksPZ7TYLoY_U_kZjXBX8CIhiXtm3DL6WnQ32jJw-Lz4WpD0LMOIHc9IvRg60rWT1sxx_hwctfri96_RM8J8VwDnSrwbbbzdX3OP3iR1mlU46t47y-lO7a1ysiBovtfYoHTMyhTp1IQJW-y6p9tsB4WaHnpRhLyZ7-XOplGpFcM0LPhPbjSWZRs7XQ9yjBuDnWl9rFUOUkemOnGlP3euw7kmJFB5vv0ucfM9C6nx38HVXibCdpE4Lja6fLIM7I6m0jeKe7xWOpE8gpGwSc4DqGYIqY2ly0QlsflbOk=");
                if (bolRegisterKEYResult)
                {
                    //MessageBox.Show("RegisterKEY= TRUE | Viewer Toolkit Registration Successful ! ", "I101DocumentViewer");
                }
                else
                {
                    MessageBox.Show("RegisterKEY= FALSE | Viewer Toolkit Registration Failed ! ", "I101DocumentViewer");
                }

                //*** 2020-06-03 - Jacob - Added 'args' to allow passing a FilePath as a Command Line Argument

                InitializeComponent();
                tcLeftPanel.SelectedIndexChanged += new EventHandler(tcLeftPanel_SelectedIndexChanged);






                GenerateThumbnails();
                ResetSearch();
                UpdateMainUi();


            }
            catch (Exception ex)
            {

                MessageBox.Show("frmMain Initialization | Exception: " + ex.Message , "I101DocumentViewer"); ;
            }
        }

        private enum ZoomMode
        {
            Zoom50,
            Zoom100,
            Zoom150,
            Zoom200,
            ZoomSelectedArea,
            ZoomFitToViewer,
            ZoomFitWidth,
            ZoomFitHeight
        }

        private int _currentSearchOccurence = 0;
        private bool _toggleGamma = true;


        private void frmMain_Load(object sender, EventArgs e)
        {

             GdPictureStatus GdpStatus;

            ToolStripStatusLabel1.Text = "";
            ToolStripStatusLabel2.Text = "";

            // LOAD Form Settings.
            //SaveRestoreForm.RestoreLastLocation(this, "frmMain");
            SaveRestoreForm.RestoreLastLocationFromIniFile(this, "frmMain");

            /* GdPicture:  A browser is required to support HTML/EML/MSG content as input into the whole toolkit scope. That could explain why the issue occurs on your users' machines.
            Our viewer currently uses Chrome's rendering engine to display these document formats with the highest accuracy, whether Chrome is installed on the machine or not. */

            if (GdPictureDocumentUtilities.IsWebBrowserAvailable() != true)
            {
                // Set browser to Chrome Portable, which should be installed under the Application folder.
                GdPictureDocumentUtilities.SetWebBrowserPath(".\\chrome_portable\\chrome.exe");
            }


            switch (commandArgs.Length)
            {
                case 1:
                    {
                        if (commandArgs[0] != "")
                        {

                            Task.Factory.StartNew(() => {
                                formLoading.Top = this.Top + ((this.Height - formLoading.Height) / 2);
                                formLoading.Left = this.Left + ((this.Width - formLoading.Width) / 2);
                                formLoading.ShowDialog();
                            });


                            Thread.Sleep(2000);

                            GdpStatus = GdViewer1.DisplayFromFile(commandArgs[0]);

                            if (GdpStatus != GdPictureStatus.OK)
                            {
                                this.Hide();
                                MessageBox.Show("" +
                                    "SORRY!!!  I was NOT able to open this File. " + Environment.NewLine + GdViewer1.GetStat().ToString() + Environment.NewLine + "I will try to open it for you in another Windows program that may support it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                
                                //*** 2023-01-25 - Jacob - Disabled Auto-Launch to Associated Program
                                //                         If "Auto-Launch to" in I101 Client is set to "New Viewer"
                                //                         this viewer gets stuck in endless loop trying to launch into itself.
                                //System.Diagnostics.Process.Start(@commandArgs[0]);
                                //this.Close();
                                
                                Invoke(new MethodInvoker(() =>
                                        {
                                            formLoading.Close();
                                        })); 
                                
                                return;

                            }
                        }

                                    Invoke(new MethodInvoker(() =>
                                    {
                                        formLoading.Close();
                                    }));

                        break;
                    }
                case 2:
                    {
                        if (commandArgs[0] != "")
                        {
                            switch (commandArgs[0])
                            {
                                case "OpenFile":
                                    GdpStatus = GdViewer1.DisplayFromFile(commandArgs[1]);

                                    if (GdpStatus != GdPictureStatus.OK)
                                    {
                                        MessageBox.Show("" +
                                            "frmMain(0) | Switch Case 2 - OpenFile | FILE OPEN ERROR: " + GdViewer1.GetStat().ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        System.Diagnostics.Process.Start(@commandArgs[1]);
                                        this.Close();


                                        return;
                                    }

                                    break;

                                case "OpenI101Document":
                                    MessageBox.Show("Open I101 DocumentRECID: " + commandArgs[1]);
                                    break;

                                case "OpenI101DocumentList":
                                    //MessageBox.Show("Open List of Documents: " + commandArgs[1]);


                                    List<string> inputFiles = new List<string>();
                                    string strCommandArgs = commandArgs[1]; //.Replace("\\", "\\\\");
                                                                            //inputFiles = strCommandArgs.Split('|').ToList();
                                    //READ input file into a list
                                    try
                                    {
                                        ToolStripStatusLabel1.Text = "READ input file into a list:  " + strCommandArgs;
                                        inputFiles = File.ReadAllLines(strCommandArgs).ToList();
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("Exception: " + ex.Message + Environment.NewLine + "File.ReadAllLines(" + strCommandArgs + ").ToList()");
                                        break;
                                    }

                                    string strTempWorkFile = System.IO.Path.GetTempPath() + "Imaging101" + "\\I101DocumentViewer_" + Environment.UserName + "_" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".PDF";


                                    //using (Stream dstStream = File.Create(strTempWorkFile))
                                    //{

                                        using (var gdpictureDocumentConverter = new GdPictureDocumentConverter())
                                        {
                                            try
                                            {
                                                ToolStripStatusLabel1.Text = "Combine Multiple Documents Into PDF:  " + strTempWorkFile;
                                                //GdpStatus = gdpictureDocumentConverter.CombineToPDF(inputFiles, dstStream, PdfConformance.PDF_A_3u);
                                                GdpStatus = gdpictureDocumentConverter.CombineToPDF(inputFiles, strTempWorkFile, PdfConformance.PDF_A_3u);

                                                if (GdpStatus == GdPictureStatus.OK)
                                                {
                                                    // "gdpictureDocumentConverter.CombineToPDF SUCCESSFUL";

                                                }
                                                else
                                                {
                                                    MessageBox.Show("CombineToPDF ERROR: " + GdViewer1.GetStat().ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    break;

                                                }                                            }
                                            catch (Exception ex)
                                            {

                                                MessageBox.Show("CombineToPDF Exception: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                break;
                                            }
 
                                        }

                                    //}

                                    try
                                    {
                                        //ToolStripStatusLabel1.Text = "Display From STREAM";
                                        //GdpStatus = GdViewer1.DisplayFromStream(dstStream);
                                        ToolStripStatusLabel1.Text = "Display From FILE:  " + strTempWorkFile;
                                        GdpStatus = GdViewer1.DisplayFromFile(strTempWorkFile);


                                        if (GdpStatus == GdPictureStatus.OK)
                                        {
                                            // "gdpictureDocumentConverter.CombineToPDF SUCCESSFUL";
                                        }
                                        else
                                        {
                                            MessageBox.Show("DisplayFromFile ERROR: " + GdViewer1.GetStat().ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            break;

                                        }
                                    }
                                    catch (Exception ex)
                                    {

                                        MessageBox.Show("DisplayFromFile Exception: " + ex.Message + Environment.NewLine + GdViewer1.GetStat().ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        break;
                                    }
                                    break;


                                default:
                                    break;
                            }
                        }
                        break;
                    }
                default:
                    break;

            }



            this.Text = "Imaging101 Document Viewer v" + System.Windows.Forms.Application.ProductVersion + " - " + GdViewer1.GetLastPath();


            BookmarksTree1.GdViewer = GdViewer1;


            tcLeftPanel.Appearance = TabAppearance.FlatButtons;
            tcLeftPanel.ItemSize = new Size(0, 1);
            tcLeftPanel.SizeMode = TabSizeMode.Fixed;
            SelectSnapIn(0, "Thumbnails");

            Dictionary<ZoomMode, string> zoomModes = new Dictionary<ZoomMode, string>() {
                {ZoomMode.Zoom50, "50%"},
                {ZoomMode.Zoom100, "100%"},
                {ZoomMode.Zoom150, "150%"},
                {ZoomMode.Zoom200, "200%"},
                {ZoomMode.ZoomSelectedArea, "Zoom to selected area"},
                {ZoomMode.ZoomFitToViewer, "Fit to viewer"},
                {ZoomMode.ZoomFitWidth, "Fit to viewer width"},
                {ZoomMode.ZoomFitHeight, "Fit to viewer height"}
            };
            foreach (var item in zoomModes)
            {
                cbZoom.Items.Add(item.Value);
            }

            rbAllPages.Checked = true;
            ImageList imageListSearchResults = new ImageList { ImageSize = new Size(20, 20) };
            imageListSearchResults.Images.Add(My.Resources.Resources.search_result);
            lstSearchResults.LargeImageList = imageListSearchResults;
            lstSearchResults.Groups.Add(new ListViewGroup("SearchResult", "Search result"));

            pGamma.Visible = false;
            tbGamma.Value = (int)(GdViewer1.Gamma * 10);
            lblGamma.Text = "Current gamma: " + (GdViewer1.Gamma) + " (default: 1)";

            ResetSearch();
            UpdateMainUi();
        }


        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {


            SaveRestoreForm.SaveLastLocationToIniFile(this, "frmMain");

        }

        private void tcLeftPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tcLeftPanel.SelectedTab.Text)
            {
                case "tpSearch":
                    btnFindNext.Focus();
                    break;
                default:
                    break;
            }
        }

        private void UpdateMainUi()
        {
            //Text = "GdPicture.NET " + typeof(GdPictureImaging).Assembly.GetName().Version + " - Document Viewer Demo";


            if (GdViewer1.PageCount == 0)
            {
                btnClose.Enabled = false;
                btnPrint.Enabled = false;
                btnFirstPage.Enabled = false;
                btnPreviousPage.Enabled = false;
                tbCurrentPage.Enabled = false;
                lblPageCount.Enabled = false;
                btnNextPage.Enabled = false;
                btnLastPage.Enabled = false;
                btnZoomOut.Enabled = false;
                cbZoom.Enabled = false;
                btnZoomIn.Enabled = false;
                btnFitPage.Enabled = false;
                btnFitWidth.Enabled = false;
                btnAdjustGamma.Enabled = false;
                btnRotateLeft.Enabled = false;
                btnRotateRight.Enabled = false;
                btnFlipX.Enabled = false;
                btnFlipY.Enabled = false;
                tbCurrentPage.Text = "0";
                lblPageCount.Text = "/ 0";
                cbZoom.SelectedIndex = -1;
                tbSearch.Text = "";
                pSearch.Enabled = false;
            }
            else
            {
                btnClose.Enabled = true;
                btnPrint.Enabled = true;
                btnFirstPage.Enabled = true;
                btnPreviousPage.Enabled = true;
                tbCurrentPage.Enabled = true;
                lblPageCount.Enabled = true;
                btnNextPage.Enabled = true;
                btnLastPage.Enabled = true;
                btnZoomOut.Enabled = true;
                cbZoom.Enabled = true;
                btnZoomIn.Enabled = true;
                btnFitPage.Enabled = true;
                btnFitWidth.Enabled = true;
                btnAdjustGamma.Enabled = true;
                btnRotateLeft.Enabled = true;
                btnRotateRight.Enabled = true;
                btnFlipX.Enabled = true;
                btnFlipY.Enabled = true;
                UpdateaNavigationToolbar();
                pSearch.Enabled = true;
            }
            ResetSearch();
        }

        private void UpdateaNavigationToolbar()
        {
            int currentPage = GdViewer1.CurrentPage;
            tbCurrentPage.Text = currentPage.ToString();
            lblPageCount.Text = "/ " + GdViewer1.PageCount;
            if (currentPage == 1)
            {
                btnFirstPage.Enabled = false;
                btnPreviousPage.Enabled = false;
            }
            else
            {
                btnFirstPage.Enabled = true;
                btnPreviousPage.Enabled = true;
            }
            if (currentPage == GdViewer1.PageCount)
            {
                btnNextPage.Enabled = false;
                btnLastPage.Enabled = false;
            }
            else
            {
                btnNextPage.Enabled = true;
                btnLastPage.Enabled = true;
            }
            cbZoom.Text = string.Format(CultureInfo.InvariantCulture, "{0:#0.##%}", GdViewer1.Zoom);


            double widthInches = 0;
            double heightInches = 0;

            if (GdViewer1.GetDocumentType() == DocumentType.DocumentTypePDF)
            {
                widthInches = GdViewer1.PdfGetPageWidth() / 72;
                heightInches = GdViewer1.PdfGetPageHeight() / 72;
            }
            else
            {
                widthInches = GdViewer1.PageWidth / GdViewer1.HorizontalResolution;
                heightInches = GdViewer1.PageHeight / GdViewer1.VerticalResolution;
            }

            ToolStripStatusLabel1.Text = "Type: " + GetDocumentTypeLabel() + "  -  " +
                "Page Size (inches): " + (Math.Round(widthInches, 2)).ToString().Trim() + " × " + (Math.Round(heightInches, 2)).ToString().Trim() + "  -  " +
                "Page Size (pixels): " + (GdViewer1.PageWidth).ToString().Trim() + " × " + (GdViewer1.PageHeight).ToString().Trim() + "  -  " +
                "Horizontal resolution: " + (Math.Round(GdViewer1.HorizontalResolution, 2)).ToString().Trim() + " DPI  -  " +
                "Vertical resolution: " + (Math.Round(GdViewer1.VerticalResolution, 2)).ToString().Trim() + " DPI";
        }

        private string GetDocumentTypeLabel()
        {
            string result = "";
            switch (GdViewer1.GetDocumentType())
            {
                case DocumentType.DocumentTypeBitmap:
                    result = "Image";
                    break;
                case DocumentType.DocumentTypeMetaFile:
                    result = "Metafile";
                    break;
                case DocumentType.DocumentTypePDF:
                    result = "PDF";
                    break;
                case DocumentType.DocumentTypeSVG:
                    result = "SVG";
                    break;
                case DocumentType.DocumentTypeTXT:
                    result = "Text file";
                    break;
                case DocumentType.DocumentTypeUnknown:
                    result = "Unknown";
                    break;
                default:
                    //GdPictureDocumentUtilities.GetDocumentFormatFromFileName(FileName);
                    result = GdViewer1.GetDocumentType().ToString().Replace("DocumentType","");
                    break;
            }
            return result;
        }

        private void CloseDocument()
        {
            GdViewer1.CloseDocument();
            ThumbnailEx1.ClearAllItems();
            UpdateMainUi();
        }

        private void GenerateThumbnails()
        {
            GdViewer1.Focus();
            ThumbnailEx1.LoadFromGdViewer(GdViewer1);
            UpdateMainUi();
        }


        private void btnOpen_Click(object sender, EventArgs e)
        {
            CloseDocument();

            GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeWidthViewer;
            GdViewer1.DocumentAlignment = ViewerDocumentAlignment.DocumentAlignmentTopCenter;

            using (frmOpen frmOpen = new frmOpen(GdViewer1))
            {
                frmOpen.ShowDialog(this);
            }

            GenerateThumbnails();

            //Highlight the "Attachments:" word 
            //GdViewer1.SearchText("Attachments:", 1, false);

            //Highlight the "Attachments:"  
            string text_to_find = "Attachments:";
            int occurrence = 1;
            float left = 0, top = 0, width = 0, height = 0;
            
            GdViewer1.RemoveAllRegions();
            GdViewer1.SearchText(GdViewer1.CurrentPage, text_to_find, occurrence, true, ref left, ref top, ref width, ref height);
            
            GdViewer1.AddRegionInches("Region" + occurrence.ToString(), left , top, width, height * 3, ForegroundMixMode.ForegroundMixModeMASKPEN, GdViewer1.ARGB(255, 245, 250, 177));
            GdViewer1.AddRegionInches("Region" + occurrence.ToString(), left + width, top, width + 4, height * 3, ForegroundMixMode.ForegroundMixModeMASKPEN, GdViewer1.ARGB(255, 204, 250, 177));

        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            GdViewer1.DisplayFirstPage();
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            GdViewer1.DisplayPreviousPage();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            GdViewer1.DisplayNextPage();
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            GdViewer1.DisplayLastPage();
        }

        private void tbCurrentPage_Leave(object sender, EventArgs e)
        {
            int page = 0;
            if (!int.TryParse(tbCurrentPage.Text, out page)) return;
            if (!(page > 0 & page <= GdViewer1.PageCount)) return;
            GdViewer1.DisplayPage(page);
            UpdateaNavigationToolbar();
        }

        private void GdViewer1_PageChanged()
        {
            UpdateaNavigationToolbar();
        }

        private void ChangeZoomValue()
        {
            if (cbZoom.SelectedIndex != -1)
            {
                switch (((ZoomMode)cbZoom.SelectedIndex))
                {
                    case ZoomMode.Zoom50:
                        GdViewer1.Zoom = 50.0F / 100;
                        break;
                    case ZoomMode.Zoom100:
                        GdViewer1.Zoom = 100.0F / 100;
                        break;
                    case ZoomMode.Zoom150:
                        GdViewer1.Zoom = 150.0F / 100;
                        break;
                    case ZoomMode.Zoom200:
                        GdViewer1.Zoom = 250.0F / 100;
                        break;
                    case ZoomMode.ZoomSelectedArea:
                        if (GdViewer1.IsRect())
                        {
                            GdViewer1.ZoomRect();
                        }
                        else
                        {
                            GdViewer1.MouseMode = ViewerMouseMode.MouseModeAreaSelection;
                            GdViewer1.Focus();
                        }
                        break;
                    case ZoomMode.ZoomFitToViewer:
                        GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeFitToViewer;
                        break;
                    case ZoomMode.ZoomFitWidth:
                        GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeWidthViewer;
                        break;
                    case ZoomMode.ZoomFitHeight:
                        GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeHeightViewer;
                        break;
                }
            }
            else
            {
                float zoom;
                if (float.TryParse(Regex.Replace(cbZoom.Text, "[^0-9,.]", ""), out zoom))
                {
                    GdViewer1.Zoom = zoom;
                }
            }
            UpdateaNavigationToolbar();
        }

        private void cbZoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeZoomValue();
        }

        private void GdViewer1_AfterZoomChange()
        {
            UpdateaNavigationToolbar();
            GdViewer1.MouseMode = ViewerMouseMode.MouseModeAreaZooming;
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            GdViewer1.ZoomOUT();
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            GdViewer1.ZoomIN();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            using (frmAbout frmAbout = new frmAbout())
            {
                frmAbout.ShowDialog(this);
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (GdViewer1.PageCount == 0)
            {
                return;
            }
            using (frmPrint f = new frmPrint(GdViewer1))
            {
                f.ShowDialog(this);
                if (f.DialogResult != DialogResult.OK)
                {
                    return;
                }
                frmPrint.PrintSettings printSettings = f.printConfiguration;
                if (!GdViewer1.PrintSetActivePrinter(printSettings.Printer))
                {
                    return;
                }
                GdViewer1.PrintSetDocumentName("GdPicture Print Job " + DateTime.Now.ToString("yyyy-MM-dd HH\\mm"));
                GdViewer1.PrintSetAlignment(printSettings.PrintAlignment);
                switch (printSettings.Orientation)
                {
                    case frmPrint.PrintOrientation.AutoDetection:
                        GdViewer1.PrintSetAutoRotation(true);
                        break;
                    case frmPrint.PrintOrientation.Portrait:
                        GdViewer1.PrintSetAutoRotation(false);
                        GdViewer1.PrintSetOrientation(PrinterOrientation.PrinterOrientationPortrait);
                        break;
                    case frmPrint.PrintOrientation.Paysage:
                        GdViewer1.PrintSetAutoRotation(false);
                        GdViewer1.PrintSetOrientation(PrinterOrientation.PrinterOrientationLandscape);
                        break;
                }
                GdViewer1.PrintSetCopies(printSettings.Copies);
                if (printSettings.Copies > 1)
                {
                    GdViewer1.PrintSetCollate(printSettings.Collate);
                }
                switch (printSettings.PagesToPrint)
                {
                    case frmPrint.PagesToPrint.All:
                        GdViewer1.PrintSetFromToPage(1, GdViewer1.PageCount);
                        GdViewer1.Print(printSettings.PrintSize);
                        break;
                    case frmPrint.PagesToPrint.Current:
                        GdViewer1.PrintSetFromToPage(GdViewer1.CurrentPage, GdViewer1.CurrentPage);
                        GdViewer1.Print(printSettings.PrintSize);
                        break;
                    case frmPrint.PagesToPrint.Selection:
                        string range = GetSelectedItemAsRange();
                        if (!string.IsNullOrWhiteSpace(range))
                        {
                            GdViewer1.PrintSetPageSelection(range);
                            GdViewer1.Print(printSettings.PrintSize);
                        }
                        break;
                    case frmPrint.PagesToPrint.Range:
                        if (!string.IsNullOrEmpty(printSettings.PageRange))
                        {
                            if (printSettings.PageRange.Contains("-"))
                            {
                                int pageStart = 0;
                                if (int.TryParse(Convert.ToString(printSettings.PageRange.Split('-')[0]), out pageStart))
                                {
                                    int pageEnd = 0;
                                    if (int.TryParse(Convert.ToString(printSettings.PageRange.Split('-')[1]), out pageEnd))
                                    {
                                        if (pageEnd < pageStart)
                                        {
                                            GdViewer1.PrintSetFromToPage(pageEnd, pageStart);
                                            GdViewer1.Print(printSettings.PrintSize);
                                        }
                                        else
                                        {
                                            GdViewer1.PrintSetFromToPage(pageStart, pageEnd);
                                            GdViewer1.Print(printSettings.PrintSize);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Page range is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Page range is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                int page = 0;
                                if (int.TryParse(printSettings.PageRange, out page))
                                {
                                    GdViewer1.PrintSetFromToPage(page, page);
                                    GdViewer1.Print(printSettings.PrintSize);
                                }
                                else
                                {
                                    MessageBox.Show("Page range is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Page range is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                }
            }

        }

        private string GetSelectedItemAsRange()
        {
            int count = 0;
            for (int i = 0; i <= ThumbnailEx1.ItemCount - 1; i++)
            {
                if (ThumbnailEx1.GetItemCheckState(i) == true)
                {
                    count++;
                }
            }
            if (count == 0)
            {
                if (MessageBox.Show("No page has been selected, do you want to save all pages?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (int i = 0; i <= ThumbnailEx1.ItemCount - 1; i++)
                    {
                        ThumbnailEx1.SetItemCheckState(i, true);
                    }
                    count = ThumbnailEx1.ItemCount;
                }
            }
            if (count <= 0) return "";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i <= ThumbnailEx1.ItemCount; i++)
            {
                if (ThumbnailEx1.GetItemCheckState(i) != true) continue;
                if (sb.Length != 0)
                {
                    sb.Append(";");
                }
                sb.Append(i + 1);
            }

            return sb.ToString();
        }

        private void btnRotateLeft_Click(object sender, EventArgs e)
        {
            GdViewer1.Rotate(RotateFlipType.Rotate270FlipNone);
        }

        private void btnRotateRight_Click(object sender, EventArgs e)
        {
            GdViewer1.Rotate(RotateFlipType.Rotate90FlipNone);
        }

        private void btnFlipX_Click(object sender, EventArgs e)
        {
            GdViewer1.Rotate(RotateFlipType.RotateNoneFlipX);
        }

        private void btnFlipY_Click(object sender, EventArgs e)
        {
            GdViewer1.Rotate(RotateFlipType.RotateNoneFlipY);
        }

        private void GdViewer1_TransferEnded(GdPictureStatus status, bool download)
        {
            GdViewer1.Focus();
            ThumbnailEx1.LoadFromGdViewer(GdViewer1);
            UpdateMainUi();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //*** 2020-10-06 - Jacob - Disabled check for DocumentType - not really necessary
            //if ((GdViewer1.GetDocumentType() != DocumentType.DocumentTypePDF & GdViewer1.GetDocumentType() != DocumentType.DocumentTypeTXT) || string.IsNullOrWhiteSpace(tbSearch.Text))
            //{
            //    return;
            //}

            ResetSearch();
            int page = 0;
            bool found = false;
            page = rbAllPages.Checked ? 1 : GdViewer1.CurrentPage;
            bool finish = false;
            int countResults = 0;

            Cursor = Cursors.WaitCursor;
            searchProgressBar.Value = 1;
            searchProgressBar.Maximum = GdViewer1.PageCount;
            searchProgressBar.Visible = true;

            List<ListViewItem> items = new List<ListViewItem>();

            while (!finish)
            {
                lblSearchResults.Text = "Find results for page " + page + " of " + GdViewer1.PageCount;
                searchProgressBar.Increment(1);
                lblSearchResults.Invalidate();
                lblSearchResults.Update();
                lblSearchResults.Refresh();
                searchProgressBar.Invalidate();
                searchProgressBar.Update();
                searchProgressBar.Refresh();
                int count = GetSearchResultCount(page, tbSearch.Text);
                if (count > 0)
                {
                    found = true;
                    ListViewItem item = new ListViewItem(new string[] { "Page " + page, count + " occurence(s) found" }, 0)
                    {
                        Name = "Page" + page,
                        Tag = page,
                        Group = lstSearchResults.Groups[0]
                    };
                    items.Add(item);
                }
                countResults += count;
                page++;
                finish = rbCurrentPage.Checked || page > GdViewer1.PageCount;
            }

            lstSearchResults.Items.AddRange(items.ToArray());

            lstSearchResults.Groups[0].Header = "Search results (" + countResults + ")";
            Cursor = Cursors.Default;

            lblSearchResults.Text = "";
            searchProgressBar.Visible = false;

            if (!found)
            {
                MessageBox.Show("No match found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private int GetSearchResultCount(int page, string searchedTerm)
        {
            return GdViewer1.GetTextOccurrenceCount(page, searchedTerm, chkCaseSensitive.Checked, chkWholeWord.Checked);
        }

        private void ResetSearch()
        {
            btnFindPrevious.Enabled = !string.IsNullOrWhiteSpace(tbSearch.Text);
            btnFindNext.Enabled = !string.IsNullOrWhiteSpace(tbSearch.Text);
            btnSearch.Enabled = !string.IsNullOrWhiteSpace(tbSearch.Text);
            lstSearchResults.Items.Clear();
            GdViewer1.RemoveAllRegions();
            _currentSearchOccurence = 0;
            lblSearchResults.Text = "";
        }

        private void chkWholeWord_CheckedChanged(object sender, EventArgs e)
        {
            ResetSearch();
        }

        private void chkCaseSensitive_CheckedChanged(object sender, EventArgs e)
        {
            ResetSearch();
        }

        private void rbCurrentPage_CheckedChanged(object sender, EventArgs e)
        {
            ResetSearch();
        }

        private void rbAllPages_CheckedChanged(object sender, EventArgs e)
        {
            ResetSearch();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            ResetSearch();
        }

        private void cbZoom_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ChangeZoomValue();
        }

        private void lstSearchResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSearchResults.SelectedItems.Count == 0) return;
            GdViewer1.RemoveAllRegions();
            ListViewItem item = lstSearchResults.SelectedItems[0];
            int page = Convert.ToInt32(item.Tag);
            if (GdViewer1.CurrentPage != page)
            {
                GdViewer1.DisplayPage(page);
            }
            int occurence = 1;
            float occurenceLeft = 0;
            float occurenceTop = 0;
            float occurenceWidth = 0;
            float occurenceHeight = 0;
            while (GdViewer1.SearchText(page, tbSearch.Text, occurence, chkCaseSensitive.Checked, chkWholeWord.Checked, ref occurenceLeft, ref occurenceTop, ref occurenceWidth, ref occurenceHeight))
            {
                AddSearchRegion(occurence, occurenceLeft, occurenceTop, occurenceWidth, occurenceHeight, occurence == 1);
                occurence++;
            }
        }

        private void btnFindNext_Click(object sender, EventArgs e)
        {
            Search(true);
        }

        private void btnFindPrevious_Click(object sender, EventArgs e)
        {
            Search(false);
        }

        private void AddSearchRegion(int occurence, float leftCoordinate, float topCoordinate, float regionWidth, float regionheight, bool ensureVisibility)
        {
            int searchRegion = GdViewer1.AddRegionInches("SearchResult" + Convert.ToString(occurence), leftCoordinate, topCoordinate, regionWidth, regionheight, ForegroundMixMode.ForegroundMixModeMASKPEN, Color.Yellow);
            GdViewer1.SetRegionEditable(searchRegion, false);
            if (ensureVisibility)
            {
                GdViewer1.EnsureRegionVisibility(searchRegion);
            }
        }

        private bool Search(bool ascending)
        {
            bool go = true;
            int page = GdViewer1.CurrentPage;
            bool found = false;
            int newOccurence = 0;
            float occurenceLeft = 0;
            float occurenceTop = 0;
            float occurenceWidth = 0;
            float occurenceHeight = 0;
            if (ascending)
            {
                newOccurence = _currentSearchOccurence + 1;
            }
            else
            {
                newOccurence = _currentSearchOccurence - 1;
            }
            while (go)
            {
                if (GdViewer1.SearchText(page, tbSearch.Text, newOccurence, chkCaseSensitive.Checked, chkWholeWord.Checked, ref occurenceLeft, ref occurenceTop, ref occurenceWidth, ref occurenceHeight))
                {
                    if (page != GdViewer1.CurrentPage)
                    {
                        GdViewer1.DisplayPage(page);
                    }
                    GdViewer1.RemoveAllRegions();
                    AddSearchRegion(newOccurence, occurenceLeft, occurenceTop, occurenceWidth, occurenceHeight, true);
                    _currentSearchOccurence = newOccurence;
                    found = true;
                    go = false;
                }
                else
                {
                    if (rbAllPages.Checked)
                    {
                        if (ascending)
                        {
                            page++;
                            newOccurence = 1;
                        }
                        else
                        {
                            page--;
                            newOccurence = GetSearchResultCount(page, tbSearch.Text);
                        }
                        if (page == 0 | page > GdViewer1.PageCount)
                        {
                            go = false;
                        }
                    }
                    else
                    {
                        go = false;
                    }
                }
            }
            if (!found)
            {
                MessageBox.Show(this, "No match found !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return found;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseDocument();
            UpdateMainUi();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            using (frmSettings frmSettings = new frmSettings(GdViewer1))
            {
                frmSettings.ShowDialog(this);
            }

            //ThumbnailEx1.PdfRasterizerEngine = GdViewer1.PdfRasterizerEngine;
            ThumbnailEx1.PdfIncreaseTextContrast = GdViewer1.PdfIncreaseTextContrast;
            UpdateaNavigationToolbar();
        }

        private void btnFitWidth_Click(object sender, EventArgs e)
        {
            GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeWidthViewer;
        }

        private void btnFitPage_Click(object sender, EventArgs e)
        {
            GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeFitToViewer;
        }

        private void tbGamma_Scroll(object sender, EventArgs e)
        {
            GdViewer1.Gamma = (float)((double)tbGamma.Value / 10);
            lblGamma.Text = "Current gamma: " + (GdViewer1.Gamma) + " (default: 1)";
        }

        private void SelectSnapIn(int num, string title)
        {
            tcLeftPanel.SelectedIndex = num;
            lblSnapInPanel.Text = title;
            for (int i = 0; i <= pSnapInButtons.Controls.Count - 1; i++)
            {
                if (i == num)
                {
                    pSnapInButtons.Controls[i].BackColor = SystemColors.Control;
                    ((Button)(pSnapInButtons.Controls[i])).FlatAppearance.BorderColor = SystemColors.Control;
                }
                else
                {
                    pSnapInButtons.Controls[i].BackColor = Color.White;
                    ((Button)(pSnapInButtons.Controls[i])).FlatAppearance.BorderColor = Color.White;
                }
            }
        }

        private void btnSnapInThumbnails_Click(object sender, EventArgs e)
        {
            SelectSnapIn(0, "Thumbnails");
        }

        private void btnSnapInBookmarks_Click(object sender, EventArgs e)
        {
            SelectSnapIn(1, "Bookmarks");
        }

        private void btnSnapInSearch_Click(object sender, EventArgs e)
        {
            SelectSnapIn(2, "Search");
        }

        private void DefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GdViewer1.MouseMode = ViewerMouseMode.MouseModeAreaZooming;
            DefaultToolStripMenuItem.Checked = true;
            AreaSelectionToolStripMenuItem.Checked = false;
            PanToolStripMenuItem.Checked = false;
            AreaZoomingToolStripMenuItem.Checked = false;
            MagnifierToolStripMenuItem.Checked = false;
            GdViewer1.Focus();
        }

        private void AreaSelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GdViewer1.MouseMode = ViewerMouseMode.MouseModeAreaZooming;
            DefaultToolStripMenuItem.Checked = false;
            AreaSelectionToolStripMenuItem.Checked = true;
            PanToolStripMenuItem.Checked = false;
            AreaZoomingToolStripMenuItem.Checked = false;
            MagnifierToolStripMenuItem.Checked = false;
            GdViewer1.Focus();
        }

        private void PanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GdViewer1.MouseMode = ViewerMouseMode.MouseModePan;
            DefaultToolStripMenuItem.Checked = false;
            AreaSelectionToolStripMenuItem.Checked = false;
            PanToolStripMenuItem.Checked = true;
            AreaZoomingToolStripMenuItem.Checked = false;
            MagnifierToolStripMenuItem.Checked = false;
            GdViewer1.Focus();
        }

        private void AreaZoomingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GdViewer1.MouseMode = ViewerMouseMode.MouseModeAreaZooming;
            DefaultToolStripMenuItem.Checked = false;
            AreaSelectionToolStripMenuItem.Checked = false;
            PanToolStripMenuItem.Checked = false;
            AreaZoomingToolStripMenuItem.Checked = true;
            MagnifierToolStripMenuItem.Checked = false;
            GdViewer1.Focus();
        }

        private void MagnifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GdViewer1.MouseMode = ViewerMouseMode.MouseModeMagnifier;
            DefaultToolStripMenuItem.Checked = false;
            AreaSelectionToolStripMenuItem.Checked = false;
            PanToolStripMenuItem.Checked = false;
            AreaZoomingToolStripMenuItem.Checked = false;
            MagnifierToolStripMenuItem.Checked = true;
            GdViewer1.Focus();
        }

        private void SmallThumbnailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThumbnailEx1.ThumbnailSize = new Size(40, 64);
            SmallThumbnailsToolStripMenuItem1.Checked = true;
            MediumThumbnailsToolStripMenuItem1.Checked = false;
            LargeThumbnailsToolStripMenuItem1.Checked = false;
        }

        private void MediumThumbnailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThumbnailEx1.ThumbnailSize = new Size(90, 128);
            SmallThumbnailsToolStripMenuItem1.Checked = false;
            MediumThumbnailsToolStripMenuItem1.Checked = true;
            LargeThumbnailsToolStripMenuItem1.Checked = false;
        }

        private void LargeThumbnailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThumbnailEx1.ThumbnailSize = new Size(180, 256);
            SmallThumbnailsToolStripMenuItem1.Checked = false;
            MediumThumbnailsToolStripMenuItem1.Checked = false;
            LargeThumbnailsToolStripMenuItem1.Checked = true;
        }

        private void ToolStripButton1_Click_1(object sender, EventArgs e)
        {
            pGamma.Visible = _toggleGamma;
            _toggleGamma = !_toggleGamma;
        }

        private void GdViewer1_Load(object sender, EventArgs e)
        {

        }

        private void GdViewer1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeFitToViewer;
            GdViewer1.MouseMode = ViewerMouseMode.MouseModeAreaZooming;
            GdViewer1.Focus();
        }

        private void GdViewer1_DropFile(string FilePath)
        {
            CloseDocument();
            
            GdPictureStatus status = GdViewer1.DisplayFromFile(FilePath);
            if (status != GdPictureStatus.OK)
            {
                MessageBox.Show("" +
                    "GdViewer1_DropFile() | FILE OPEN ERROR: " + GdViewer1.GetStat().ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Process.Start(@FilePath);
                return;
            }


            GenerateThumbnails();
            ResetSearch();
            UpdateMainUi();

        }

        private void frmMain_ResizeEnd(object sender, EventArgs e)
        {

        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            pictureBoxImaging101Logo.Left = this.Width - pictureBoxImaging101Logo.Width - 20;

            if (pictureBoxImaging101Logo.Left > 900)
            {
                mainToolStrip.MaximumSize = new Size(pictureBoxImaging101Logo.Left, 31);
                mainToolStrip.Size = new Size(pictureBoxImaging101Logo.Left, 31);
                mainToolStrip.Refresh();
            } 
            else if (pictureBoxImaging101Logo.Left > 460)
            {
                mainToolStrip.MaximumSize = new Size(pictureBoxImaging101Logo.Left, 62);
                mainToolStrip.Size = new Size(pictureBoxImaging101Logo.Left, 62);
                mainToolStrip.Refresh();
            }
            else
            {
                mainToolStrip.MaximumSize = new Size(pictureBoxImaging101Logo.Left, 93);
                mainToolStrip.Size = new Size(pictureBoxImaging101Logo.Left, 93);
                mainToolStrip.Refresh();

            }
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(GdViewer1.GetLastPath());
        }

        private void btnStayOnTopMode_Click(object sender, EventArgs e)
        {
        }

        private void btnMouseMode_Click(object sender, EventArgs e)
        {

        }

        private void stayOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stayOnTopToolStripMenuItem.Checked = true;
            dontStayOnTopToolStripMenuItem.Checked = false;
            this.TopMost = true;
        }

        private void dontStayOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stayOnTopToolStripMenuItem.Checked = false;
            dontStayOnTopToolStripMenuItem.Checked = true;
            this.TopMost = false;
        }






    }


}
