using Microsoft.Win32;
using My;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace I101DocumentViewer
{


    public static class SaveRestoreForm
    {
        
        static string gstrImaging101ClientIniFilePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Imaging101\\Imaging101Client.INI";

        static System.Collections.Specialized.StringCollection strWindowSettings;

        // SaveLastLocation / RestoreLastLocation  code from:
        // https://stackoverflow.com/questions/11613523/closing-and-opening-a-form-on-the-same-monitor-on-dual-monitor-setups

        public static void SaveLastLocation(this Form form, string UniqueName)
        {
            FormWindowState CurState = form.WindowState;
            if (CurState == FormWindowState.Minimized)
                CurState = FormWindowState.Normal;

            form.WindowState = FormWindowState.Normal;

            if (Settings.Default.WindowSettings == null)
                Settings.Default.WindowSettings = new System.Collections.Specialized.StringCollection();

            if (Settings.Default.WindowSettings.Count > 0)
                foreach (string S in Settings.Default.WindowSettings)
                    if (S.Split('|').First().ToLower() == UniqueName.ToLower())
                    {
                        Settings.Default.WindowSettings.Remove(S);
                        break;
                    }

            Settings.Default.WindowSettings.Add(string.Format("{0}|{1}|{2}|{3}|{4}|{5}",
                UniqueName, form.Left.ToString(), form.Top.ToString(),  form.Height.ToString(), form.Width.ToString(), form.WindowState.ToString()));

            Settings.Default.Save();
        }

        public static void RestoreLastLocation(this Form form, string UniqueName)
        {
            if (Settings.Default.WindowSettings != null && Settings.Default.WindowSettings.Count > 0)
                foreach (string S in Settings.Default.WindowSettings)
                {
                    string[] Parts = S.Split('|');
                    if (Parts[0].ToLower() == UniqueName.ToLower())
                    {
                        //Check if the SAVED position would be visible on the screen that the Coordinates point to
                        Rectangle rect =  new Rectangle(int.Parse(Parts[1]), int.Parse(Parts[2]), int.Parse(Parts[3]), int.Parse(Parts[4]));

                        if (IsVisibleOnAnyScreen(rect))
                        {     
                            form.Left = int.Parse(Parts[1]);
                            form.Top = int.Parse(Parts[2]);
                            form.Height = int.Parse(Parts[3]);
                            form.Width = int.Parse(Parts[4]);
                            form.WindowState = (FormWindowState)Enum.Parse(typeof(FormWindowState), Parts[5]);
                            break;
                        }
                        else
                        {

                        }
                    }
                }
        }


        public static void SaveLastLocationToIniFile(this Form form, string UniqueName)
        {
            FormWindowState CurState = form.WindowState;
            if (CurState == FormWindowState.Minimized)
                CurState = FormWindowState.Normal;

            form.WindowState = FormWindowState.Normal;

            string KeyName = UniqueName + "_" + "WindowSettings";

            string KeyValue = string.Format("{0}|{1}|{2}|{3}|{4}|{5}",
                                            UniqueName, form.Left.ToString(), form.Top.ToString(), form.Height.ToString(), form.Width.ToString(), form.WindowState.ToString());

            var iniwriter = new IniFileHandler(gstrImaging101ClientIniFilePath);
            iniwriter.WriteValue(KeyName, "Imaging101DocumentViewer", KeyValue);
            iniwriter.Save();

        }

        public static void RestoreLastLocationFromIniFile(this Form form, string UniqueName)
        {
            string KeyName = UniqueName + "_" + "WindowSettings";

            var iniwriter = new IniFileHandler(gstrImaging101ClientIniFilePath);
            string KeyValue = iniwriter.GetValue(KeyName, "Imaging101DocumentViewer", "frmMain|1|1|768|1052|Normal");

            string[] Parts = KeyValue.Split('|');
            if (Parts[0].ToLower() == UniqueName.ToLower())
            {
                //Check if the SAVED position would be visible on the screen that the Coordinates point to
                Rectangle rect = new Rectangle(int.Parse(Parts[1]), int.Parse(Parts[2]), int.Parse(Parts[3]), int.Parse(Parts[4]));

                if (IsVisibleOnAnyScreen(rect))
                {
                    form.Left = int.Parse(Parts[1]);
                    form.Top = int.Parse(Parts[2]);
                    form.Height = int.Parse(Parts[3]);
                    form.Width = int.Parse(Parts[4]);
                    form.WindowState = (FormWindowState)Enum.Parse(typeof(FormWindowState), Parts[5]);
                           
                }
                else
                {

                }
            }
               
        }

        private static bool IsVisibleOnAnyScreen(Rectangle rect)
        {
            //Check if the SAVED position would be visible on the screen that the Coordinates point to
            foreach (Screen screen in Screen.AllScreens)
            {
                if (screen.WorkingArea.IntersectsWith(rect))
                    return true;
            }
            return false;
        }
    }
}
