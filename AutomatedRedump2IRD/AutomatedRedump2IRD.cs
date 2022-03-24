using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using IsoTools;
using Ionic.Zip;

namespace AutomatedRedump2IRD
{
    /// <summary>
    /// AutomatedRedump2IRD Class
    /// </summary>
    public partial class AutomatedRedump2IRD : Form
    {
        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        public AutomatedRedump2IRD()
        {
            // Initialize the form.
            InitializeComponent();

            // Hide the Help and License tabs.
            tcMain.TabPages.Remove(tabHelp);
            tcMain.TabPages.Remove(tabLicense);

            // Set the GUI variables.
            PathRedumpSQLiteDB = Path.Combine(Application.StartupPath, "DB", "redump.ps3.sqlite.db");
            PathRedumpPS3IRDsDir = Path.Combine(Application.StartupPath, "IRDs");
            PathRedumpPS3ROMsDir = Path.Combine(Application.StartupPath, "ROMs");
            PathTempExtractionDir = Path.Combine(Application.StartupPath, "Tmp");
            InputName = "Title";
            OutputName = "MD5";

            // Set the title.
            UpdateTitle();

            // Print the version.
            PrintVersion();

            // Load the GUI RichTextBoxes from resources.
            rtbHelp.Text = Properties.Resources.AutomatedRedump2IRD_HELP;
            rtbLicense.Text = Properties.Resources.AutomatedRedump2IRD_LICENSE;
        }

        #endregion

        #region Members

        private readonly string AppName = "Automated Redump 2 IRD";
        private readonly string AppVersion = "0.0.1";
        private readonly string AppCopyright = "Copyright (c) 2016-2022 Automated Redump 2 IRD - All Rights Reserved";
        CancellationTokenSource cancellation_ = null;
        private static readonly byte[] D1_IV = { 105, 71, 71, 114, 175, 111, 218, 179, 66, 116, 58, 239, 170, 24, 98, 135 };
        private static readonly byte[] D1_KEY = { 56, 11, 207, 11, 83, 69, 91, 60, 120, 23, 171, 79, 163, 186, 144, 237 };

        #endregion

        #region Getters/Setters Public Accessors

        /// PathRedumpSQLiteDB
        public string PathRedumpSQLiteDB
        {
            get { return txtPathRedumpSQLiteDB.Text; }
            set { txtPathRedumpSQLiteDB.Text = value; }
        }
        /// PathRedumpPS3ROMsDir
        public string PathRedumpPS3ROMsDir
        {
            get { return txtPathRedumpPS3ROMsDir.Text; }
            set { txtPathRedumpPS3ROMsDir.Text = value; }
        }
        /// PathRedumpPS3IRDsDir
        public string PathRedumpPS3IRDsDir
        {
            get { return txtPathRedumpPS3IRDsDir.Text; }
            set { txtPathRedumpPS3IRDsDir.Text = value; }
        }
        /// PathTempExtractionDir
        public string PathTempExtractionDir
        {
            get { return txtPathTempExtractionDir.Text; }
            set { txtPathTempExtractionDir.Text = value; }
        }
        /// SkipExistingIRDs
        public bool SkipExistingIRDs
        {
            get { return chkSkipExistingIRDs.Checked; }
            set { chkSkipExistingIRDs.Checked = value; }
        }
        /// InputName
        public string InputName
        {
            get { return cbInputName.SelectedItem.ToString(); }
            set { cbInputName.SelectedItem = value; }
        }
        /// OutputName
        public string OutputName
        {
            get { return cbOutputName.SelectedItem.ToString(); }
            set { cbOutputName.SelectedItem = value; }
        }
        /// SendIRDsToTheUltimateIRDDatabase
        public bool SendIRDsToTheUltimateIRDDatabase
        {
            get { return chkSendIRDsToTheUltimateIRDDatabase.Checked; }
            set { chkSendIRDsToTheUltimateIRDDatabase.Checked = value; }
        }
        /// Username
        public string Username
        {
            get { return txtUsername.Text; }
            set { txtUsername.Text = value; }
        }
        /// Password
        public string Password
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }

        #endregion

        #region GUI Methods

        /// <summary>
        /// Sets the application title.
        /// </summary>
        /// <param name="strTitle"></param>
        public void UpdateTitle(string strTitle = "")
        {
            // Update the application title.
            this.Text = AppName + " v" + AppVersion + strTitle;
        }

        /// <summary>
        /// Updates the progress status message label.
        /// </summary>
        /// <param name="strMsg"></param>
        private void UpdateStatusMessageLabel(string strMsg)
        {
            // Update the progress status message label.
            tsslStatusMessage.Text = strMsg;
        }

        /// <summary>
        /// Resets the progress bars.
        /// </summary>
        private void ResetProgressBars()
        {
            tspbTaskProgress.ProgressBar.Value = 0;
            tspbOverallProgress.ProgressBar.Value = 0;
        }

        /// <summary>
        /// Change the state of the forum, basicially "this.Enable = enable;".
        /// </summary>
        /// <param name="boolIsEnabled"></param>
        public void ChangeState(bool boolIsEnabled)
        {
            txtPathRedumpSQLiteDB.Enabled = boolIsEnabled;
            txtPathRedumpPS3ROMsDir.Enabled = boolIsEnabled;
            txtPathRedumpPS3IRDsDir.Enabled = boolIsEnabled;
            txtPathTempExtractionDir.Enabled = boolIsEnabled;
            txtUsername.Enabled = boolIsEnabled;
            txtPassword.Enabled = boolIsEnabled;
            chkSkipExistingIRDs.Enabled = boolIsEnabled;
            chkSendIRDsToTheUltimateIRDDatabase.Enabled = boolIsEnabled;
            tsbBuildIRDs.Enabled = boolIsEnabled;
            tsbSaveLog.Enabled = boolIsEnabled;
            tsmiBuildIRDs.Enabled = boolIsEnabled;
            tsmiSaveLog.Enabled = boolIsEnabled;
            tsbCancel.Enabled = !boolIsEnabled;
        }

        /// <summary>
        /// Enables all buttons.
        /// </summary>
        private void EnableAllButtons()
        {
            txtPathRedumpSQLiteDB.Enabled = true;
            txtPathRedumpPS3ROMsDir.Enabled = true;
            txtPathRedumpPS3IRDsDir.Enabled = true;
            txtPathTempExtractionDir.Enabled = true;
            txtUsername.Enabled = true;
            txtPassword.Enabled = true;
            chkSkipExistingIRDs.Enabled = true;
            chkSendIRDsToTheUltimateIRDDatabase.Enabled = true;
            tsbBuildIRDs.Enabled = true;
            tsbSaveLog.Enabled = true;
            tsmiBuildIRDs.Enabled = true;
            tsmiSaveLog.Enabled = true;
        }

        /// <summary>
        /// Disables all buttons.
        /// </summary>
        private void DisableAllButtons()
        {
            txtPathRedumpSQLiteDB.Enabled = false;
            txtPathRedumpPS3ROMsDir.Enabled = false;
            txtPathRedumpPS3IRDsDir.Enabled = false;
            txtPathTempExtractionDir.Enabled = false;
            txtUsername.Enabled = false;
            txtPassword.Enabled = false;
            chkSkipExistingIRDs.Enabled = false;
            chkSendIRDsToTheUltimateIRDDatabase.Enabled = false;
            tsbBuildIRDs.Enabled = false;
            tsbSaveLog.Enabled = false;
            tsmiBuildIRDs.Enabled = false;
            tsmiSaveLog.Enabled = false;
        }

        /// <summary>
        /// Decrypts a Disc ID.
        /// </summary>
        /// <param name="strDiscIDEnc"></param>
        /// <returns></returns>
        private string DecryptDiscID(string strDiscIDEnc)
        {
            // Declarations
            string strDiscIDDec = String.Empty;
            string d2_enc_hexstring = strDiscIDEnc.Replace("-", "").Replace(" ", "").Replace(",", "");

            // Check the Disc ID.
            if (String.IsNullOrEmpty(d2_enc_hexstring) || d2_enc_hexstring.Length != 32 || !IsHex(d2_enc_hexstring))
            {
                strDiscIDDec = String.Empty;
                return strDiscIDDec;
            }

            // Convert the inputed D2 (encrypted) data to a byte[], and decrypt it.
            byte[] d2_enc = HexStringToByteArray(d2_enc_hexstring);
            if (d2_enc.Length > 0)
            {
                int? nullable = null;
                ODD.AESDecrypt(Utilities.D2_KEY, Utilities.D2_IV, d2_enc, 0, d2_enc.Length, d2_enc, 0, nullable);
                if (d2_enc.Length > 0)
                {
                    strDiscIDDec = ByteArrayToHexString(d2_enc);
                    return strDiscIDDec;
                }
            }

            return strDiscIDDec;
        }

        /// <summary>
        /// Encrypts a Disc ID.
        /// </summary>
        /// <param name="strDiscIDDec"></param>
        /// <returns></returns>
        private string EncryptDiscID(string strDiscIDDec)
        {
            // Declarations
            string strDiscIDEnc = String.Empty;
            // Note: D1 redump has some special logic, the XXXXXXXX gets converted to ?? 00000001 ??.
            string d2_dec_hexstring = strDiscIDDec.Replace("-", "").Replace(" ", "").Replace(",", "").Replace("XXXXXXXX", "00000001");

            // Check the Disc ID.
            if (String.IsNullOrEmpty(d2_dec_hexstring) || d2_dec_hexstring.Length != 32 || !IsHex(d2_dec_hexstring))
            {
                strDiscIDEnc = String.Empty;
                return strDiscIDEnc;
            }

            // Convert the inputed D2 (decrypted) data to a byte[], and encrypt it.
            byte[] d2_dec = HexStringToByteArray(d2_dec_hexstring);
            if (d2_dec.Length > 0)
            {
                int? nullable = null;
                ODD.AESEncrypt(Utilities.D2_KEY, Utilities.D2_IV, d2_dec, 0, d2_dec.Length, d2_dec, 0, nullable);
                if (d2_dec.Length > 0)
                {
                    strDiscIDEnc = ByteArrayToHexString(d2_dec);
                    return strDiscIDEnc;
                }
            }

            return strDiscIDEnc;
        }

        /// <summary>
        /// Decrypts a Disc Key.
        /// </summary>
        /// <param name="strDiscKeyEnc"></param>
        /// <returns></returns>
        private string DecryptDiscKey(string strDiscKeyEnc)
        {
            // Declarations
            string strDiscKeyDec = String.Empty;
            string d1_enc_hexstring = strDiscKeyEnc.Replace("-", "").Replace(" ", "").Replace(",", "");

            // Check the Disc ID.
            if (String.IsNullOrEmpty(d1_enc_hexstring) || d1_enc_hexstring.Length != 32 || !IsHex(d1_enc_hexstring))
            {
                strDiscKeyDec = String.Empty;
                return strDiscKeyDec;
            }

            // Convert the inputed D1 (encrypted) data to a byte[], and decrypt it.
            byte[] d1_enc = HexStringToByteArray(d1_enc_hexstring);
            if (d1_enc.Length > 0)
            {
                int? nullable = null;
                ODD.AESDecrypt(D1_KEY, D1_IV, d1_enc, 0, d1_enc.Length, d1_enc, 0, nullable);
                if (d1_enc.Length > 0)
                {
                    strDiscKeyDec = ByteArrayToHexString(d1_enc);
                    return strDiscKeyDec;
                }
            }

            return strDiscKeyDec;
        }

        /// <summary>
        /// Encrypts a Disc Key.
        /// </summary>
        /// <param name="strDiscKeyDec"></param>
        /// <returns></returns>
        private string EncryptDiscKey(string strDiscKeyDec)
        {
            // Declarations
            string strDiscKeyEnc = String.Empty;
            string d1_dec_hexstring = strDiscKeyDec.Replace("-", "").Replace(" ", "").Replace(",", "");

            // Check the DIsc Key.
            if (String.IsNullOrEmpty(d1_dec_hexstring) || d1_dec_hexstring.Length != 32 || !IsHex(d1_dec_hexstring))
            {
                strDiscKeyEnc = String.Empty;
                return strDiscKeyEnc;
            }

            // Convert the inputed D1 (decrypted) data to a byte[], and encrypt it.
            byte[] d1_dec = HexStringToByteArray(d1_dec_hexstring);
            if (d1_dec.Length > 0)
            {
                int? nullable = null;
                ODD.AESEncrypt(D1_KEY, D1_IV, d1_dec, 0, d1_dec.Length, d1_dec, 0, nullable);
                if (d1_dec.Length > 0)
                {
                    strDiscKeyEnc = ByteArrayToHexString(d1_dec);
                    return strDiscKeyEnc;
                }
            }

            return strDiscKeyEnc;
        }

        /// <summary>
        /// Converts valid byte array to valid hex.
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        private static string ByteArrayToHexString(byte[] bytes)
        {
            char[] c = new char[bytes.Length * 2];
            for (int i = 0, b; i < bytes.Length; i++)
            {
                b = bytes[i] >> 4;
                c[i * 2] = (char)(55 + b + (((b - 10) >> 31) & -7));
                b = bytes[i] & 0xF;
                c[i * 2 + 1] = (char)(55 + b + (((b - 10) >> 31) & -7));
            }
            return new string(c);
        }

        /// <summary>
        /// Converts valid hex to valid byte array.
        /// </summary>
        /// <param name="Hex"></param>
        /// <returns></returns>
        private static byte[] HexStringToByteArray(string Hex)
        {
            byte[] Bytes = new byte[Hex.Length / 2];
            int[] HexValue = new int[] { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05,
               0x06, 0x07, 0x08, 0x09, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
               0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F };

            for (int x = 0, i = 0; i < Hex.Length; i += 2, x += 1)
                Bytes[x] = (byte)(HexValue[Char.ToUpper(Hex[i + 0]) - '0'] << 4 | HexValue[Char.ToUpper(Hex[i + 1]) - '0']);
            return Bytes;
        }

        /// <summary>
        /// Checks to see if the input string is all valid hex.
        /// </summary>
        /// <param name="chars"></param>
        /// <returns></returns>
        private bool IsHex(IEnumerable<char> chars)
        {
            bool isHex;
            foreach (var c in chars)
            {
                isHex = ((c >= '0' && c <= '9') ||
                         (c >= 'a' && c <= 'f') ||
                         (c >= 'A' && c <= 'F'));
                if (!isHex)
                    return false;
            }
            return true;
        }

        #endregion

        #region Form Events

        /// <summary>
        /// Form Shown Event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Shown(object sender, EventArgs e)
        {
            // Perform the application startup tasks.
            bgwStartupTasks.RunWorkerAsync();
        }

        /// <summary>
        /// Form FormClosing Event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Check if the builder is running.
            if (bgwBuildIRDs.IsBusy && bgwBuildIRDs.WorkerSupportsCancellation)
            {
                // Display a messageBox.
                if (MessageBox.Show("The builder is currently running. Are you sure you want to exit now? Exiting now may cause corrupt or incomplete files!", "Confirm Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                {
                    e.Cancel = true;
                }
            }
        }

        #endregion

        #region GUI Click Events

        /// <summary>
        /// Saves the log to a text file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveLog_Click(object sender, EventArgs e)
        {
            try
            {
                // Disable all buttons.
                DisableAllButtons();

                // Create and initialize a SaveFileDialog for the log file.
                SaveFileDialog sfdLog = new SaveFileDialog
                {
                    DefaultExt = "*.txt",
                    Filter = "TXT Files|*.txt",
                    FileName = "AutomatedRedump2IRD-Log-" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt",
                    Title = "Please enter a path to the log file: ",
                    InitialDirectory = Path.Combine(Application.StartupPath, "Logs")
                };

                // Determine if the user selected a log filename.
                if (sfdLog.ShowDialog() == DialogResult.OK && sfdLog.FileName.Length > 0)
                {
                    // Get the log file info and directory name.
                    FileInfo fi = new FileInfo(sfdLog.FileName);

                    // Create log file directory if it doesn't exist.
                    if (Directory.Exists(fi.DirectoryName) == false) Directory.CreateDirectory(fi.DirectoryName);

                    // Save the contents of the log to a text file.
                    File.WriteAllLines(sfdLog.FileName, rtbLog.Lines);

                    // Print to screen
                    OutputLine("Info: Log file saved (" + sfdLog.FileName + ")");
                    OutputLine("Info: Ready");
                    OutputLine("");
                }

                // Dispose of the SaveFileDialog.
                sfdLog.Dispose();

                // Enable all buttons.
                EnableAllButtons();
            }
            catch (Exception ex)
            {
                // Print to screen
                OutputLine("Error: Saving log file failed");
                OutputLine("Error: " + ex.Message);
                OutputLine("Info: Ready");
                OutputLine("");
            }
        }

        private void PathRedumpSQLiteDB_Click(object sender, EventArgs e)
        {
            // Disable all buttons.
            DisableAllButtons();

            // Create and initialize a FolderBrowserDialog for the directory.
            FolderBrowserDialog fbdSelectDir = new FolderBrowserDialog
            {
                ShowNewFolderButton = true,
                Description = "Please enter a path to the Redump SQLite DB: ",
                SelectedPath = PathRedumpSQLiteDB
            };

            // Determine if the user selected OK from the FolderBrowserDialog.
            if (fbdSelectDir.ShowDialog() == DialogResult.OK)
            {
                // Set the variable.
                PathRedumpSQLiteDB = fbdSelectDir.SelectedPath;
            }

            // Dispose of the FolderBrowserDialog.
            fbdSelectDir.Dispose();

            // Enable all buttons.
            EnableAllButtons();
        }

        private void PathRedumpPS3ROMsDir_Click(object sender, EventArgs e)
        {
            // Disable all buttons.
            DisableAllButtons();

            // Create and initialize a FolderBrowserDialog for the directory.
            FolderBrowserDialog fbdSelectDir = new FolderBrowserDialog
            {
                ShowNewFolderButton = true,
                Description = "Please enter a path to the Redump PS3 ROMs directory: ",
                SelectedPath = PathRedumpPS3ROMsDir
            };

            // Determine if the user selected OK from the FolderBrowserDialog.
            if (fbdSelectDir.ShowDialog() == DialogResult.OK)
            {
                // Set the variable.
                PathRedumpPS3ROMsDir = fbdSelectDir.SelectedPath;
            }

            // Dispose of the FolderBrowserDialog.
            fbdSelectDir.Dispose();

            // Enable all buttons.
            EnableAllButtons();
        }

        private void PathRedumpPS3IRDsDir_Click(object sender, EventArgs e)
        {
            // Disable all buttons.
            DisableAllButtons();

            // Create and initialize a FolderBrowserDialog for the directory.
            FolderBrowserDialog fbdSelectDir = new FolderBrowserDialog
            {
                ShowNewFolderButton = true,
                Description = "Please enter a path to the Redump PS3 IRDs directory: ",
                SelectedPath = PathRedumpPS3IRDsDir
            };

            // Determine if the user selected OK from the FolderBrowserDialog.
            if (fbdSelectDir.ShowDialog() == DialogResult.OK)
            {
                // Set the variable.
                PathRedumpPS3IRDsDir = fbdSelectDir.SelectedPath;
            }

            // Dispose of the FolderBrowserDialog.
            fbdSelectDir.Dispose();

            // Enable all buttons.
            EnableAllButtons();
        }

        private void PathTempExtractionDir_Click(object sender, EventArgs e)
        {
            // Disable all buttons.
            DisableAllButtons();

            // Create and initialize a FolderBrowserDialog for the directory.
            FolderBrowserDialog fbdSelectDir = new FolderBrowserDialog
            {
                ShowNewFolderButton = true,
                Description = "Please enter a path to the temp extraction directory: ",
                SelectedPath = PathTempExtractionDir
            };

            // Determine if the user selected OK from the FolderBrowserDialog.
            if (fbdSelectDir.ShowDialog() == DialogResult.OK)
            {
                // Set the variable.
                PathTempExtractionDir = fbdSelectDir.SelectedPath;
            }

            // Dispose of the FolderBrowserDialog.
            fbdSelectDir.Dispose();

            // Enable all buttons.
            EnableAllButtons();
        }

        private void BuildIRDs_Click(object sender, EventArgs e)
        {
            // Select the Log tab.
            if (tcMain.TabPages.Contains(tabLog)) { tcMain.SelectTab(tabLog); }

            // Change the form's enabled state.
            ChangeState(false);

            // Print to screen
            OutputLine("");
            OutputLine("Info: Building IRDs started ...");

            // Update the status message label.
            UpdateStatusMessageLabel("Building IRDs ...");

            // Build IRDs.
            bgwBuildIRDs.RunWorkerAsync();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            // Disable the cancel button.
            tsbCancel.Enabled = false;

            // Print to screen
            OutputLine("Info: Cancellation pending after current operation ...");

            // Update the status message label.
            UpdateStatusMessageLabel("Cancellation Pending ...");

            // Cancel the tasks.
            cancellation_.Cancel();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            // Exit the application.
            Application.Exit();
        }

        #endregion

        #region View Click Events

        /// <summary>
        /// Toggles the visibility of the log.
        /// </summary>
        private void ViewLog_Click(object sender, EventArgs e)
        {
            if (tsmiViewLog.Checked)
            {
                tsmiViewLog.Checked = false;
                tsmiViewLog.CheckState = CheckState.Unchecked;
                tcMain.TabPages.Remove(tabLog);
            }
            else
            {
                tsmiViewLog.Checked = true;
                tsmiViewLog.CheckState = CheckState.Checked;
                tcMain.TabPages.Add(tabLog);
                tcMain.SelectTab(tabLog);
            }
        }

        /// <summary>
        /// Toggles the visibility of the options.
        /// </summary>
        private void ViewOptions_Click(object sender, EventArgs e)
        {
            if (tsmiViewOptions.Checked)
            {
                tsmiViewOptions.Checked = false;
                tsmiViewOptions.CheckState = CheckState.Unchecked;
                tcMain.TabPages.Remove(tabOptions);
            }
            else
            {
                tsmiViewOptions.Checked = true;
                tsmiViewOptions.CheckState = CheckState.Checked;
                tcMain.TabPages.Add(tabOptions);
                tcMain.SelectTab(tabOptions);
            }
        }

        /// <summary>
        /// Toggles the visibility of the help.
        /// </summary>
        private void ViewHelp_Click(object sender, EventArgs e)
        {
            if (tsmiViewHelp.Checked)
            {
                tsmiViewHelp.Checked = false;
                tsmiViewHelp.CheckState = CheckState.Unchecked;
                tcMain.TabPages.Remove(tabHelp);
            }
            else
            {
                tsmiViewHelp.Checked = true;
                tsmiViewHelp.CheckState = CheckState.Checked;
                tcMain.TabPages.Add(tabHelp);
                tcMain.SelectTab(tabHelp);
            }
        }

        /// <summary>
        /// Toggles the visibility of the license.
        /// </summary>
        private void ViewLicense_Click(object sender, EventArgs e)
        {
            if (tsmiViewLicense.Checked)
            {
                tsmiViewLicense.Checked = false;
                tsmiViewLicense.CheckState = CheckState.Unchecked;
                tcMain.TabPages.Remove(tabLicense);
            }
            else
            {
                tsmiViewLicense.Checked = true;
                tsmiViewLicense.CheckState = CheckState.Checked;
                tcMain.TabPages.Add(tabLicense);
                tcMain.SelectTab(tabLicense);
            }
        }

        /// <summary>
        /// Toggles the visibility of the toolbar.
        /// </summary>
        private void ViewToolbar_Click(object sender, EventArgs e)
        {
            if (tsMain.Visible)
            {
                tsMain.Visible = false;
                tsmiViewToolbar.Checked = false;
                tsmiViewToolbar.CheckState = CheckState.Unchecked;
            }
            else
            {
                tsMain.Visible = true;
                tsmiViewToolbar.Checked = true;
                tsmiViewToolbar.CheckState = CheckState.Checked;
            }
        }

        #endregion

        #region Zip Event Handlers

        private void UnzipFile_ExtractProgress(object sender, ExtractProgressEventArgs e)
        {
            if (e.TotalBytesToTransfer > 0)
            {
                tspbTaskProgress.ProgressBar.Invoke(new MethodInvoker(delegate {
                    tspbTaskProgress.ProgressBar.Maximum = 100;
                    tspbTaskProgress.ProgressBar.Value = Convert.ToInt32(100 * e.BytesTransferred / e.TotalBytesToTransfer);
                    tspbTaskProgress.ProgressBar.Update();
                }));
            }
        }

        #endregion

        #region Startup Tasks Background Worker

        /// <summary>
        /// StartupTasks DoWork
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartupTasks_DoWork(object sender, DoWorkEventArgs e)
        {
            // 
        }

        /// <summary>
        /// StartupTasks RunWorkerCompleted
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartupTasks_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                // Print to screen.
                OutputLine("Info: Startup tasks canceled");
            }
            else if (e.Error != null)
            {
                // Print to screen.
                OutputLine("Error: Startup tasks failed");
                OutputLine("Error: " + e.Error.Message);
            }
            else
            {
                // 
            }

            // Update the status message label.
            UpdateStatusMessageLabel("Ready");

            // Print to screen.
            OutputLine("Info: Ready");

            // Enable all buttons.
            EnableAllButtons();
        }

        #endregion

        #region Build IRDs Background Worker

        private void BuildIRDs_DoWork(object sender, DoWorkEventArgs e)
        {
            // Check the IRDs directory path.
            if (!Directory.Exists(PathRedumpPS3IRDsDir))
            {
                OutputLine("Info: Redump PS3 IRDs directory does not exist");
                e.Cancel = true;
                return;
            }

            // Get the DB ISOs array.
            if (!File.Exists(PathRedumpSQLiteDB))
            {
                OutputLine("Info: " + "Redump SQLite DB does not exist");
                e.Cancel = true;
                return;
            }
            Database database = new Database();
            database.ConnectionString = @"Data Source=" + PathRedumpSQLiteDB + "; Version=3";
            DataTable arrDBISOs = database.SelectIRDInfo();

            // Get the filesystem ISOs array and the filesystem zips array.
            if (!Directory.Exists(PathRedumpPS3ROMsDir))
            {
                OutputLine("Info: Redump PS3 ROMs directory does not exist");
                e.Cancel = true;
                return;
            }
            string[] arrFilesystemISOs = Directory.GetFiles(PathRedumpPS3ROMsDir, "*.iso", SearchOption.AllDirectories);
            string[] arrFilesystemZips = Directory.GetFiles(PathRedumpPS3ROMsDir, "*.zip", SearchOption.AllDirectories);
            List<string> arrListFilesystemROMs = new List<string>();
            arrListFilesystemROMs.AddRange(arrFilesystemISOs);
            arrListFilesystemROMs.AddRange(arrFilesystemZips);
            string[] arrFilesystemROMs = arrListFilesystemROMs.ToArray();

            // Print to screen
            OutputLine("Info: Redump DB ISOs: " + arrDBISOs.Rows.Count);
            OutputLine("Info: Filesystem ISOs: " + arrFilesystemISOs.Length);
            OutputLine("Info: Filesystem Zips: " + arrFilesystemZips.Length);

            // Declarations
            BackgroundWorker worker = sender as BackgroundWorker;

            // Cancellation declaration
            if (cancellation_ != null && !cancellation_.IsCancellationRequested)
                cancellation_.Cancel();
            if (cancellation_ != null)
                cancellation_.Dispose();
            cancellation_ = new CancellationTokenSource();

            // Loop through the filesystem ISOs.
            for (int i = 0; i < arrFilesystemROMs.Length; i++)
            {
                if (cancellation_.IsCancellationRequested)
                {
                    break;
                }

                // Declarations
                string strGameDKey = "";
                string strGameDID = "";
                string strGamePIC = "";
                string strPathIRDFileName = "";
                // string strPathIRDFileName = Path.Combine(PathRedumpPS3IRDsDir, Path.GetFileNameWithoutExtension(arrFilesystemROMs[i]) + ".ird");
                string strPathISOFileName = arrFilesystemROMs[i];

                // Print to screen
                OutputLine("Info: Building IRD for: " + Path.GetFileName(strPathISOFileName));

                // Get the Redump PS3 disc info.
                foreach (DataRow row in arrDBISOs.Rows)
                {
                    // Check if DB filename matches the filesystem filename.
                    if (row.Field<string>("TrackFilename") == Path.GetFileName(strPathISOFileName).Replace(".zip", ".iso"))
                    {
                        strGameDKey = row.Field<string>("GameDKey");
                        strGameDID = row.Field<string>("GameDID");
                        strGamePIC = row.Field<string>("GamePIC");
                        strPathIRDFileName = Path.Combine(PathRedumpPS3IRDsDir, Path.GetFileNameWithoutExtension(row.Field<string>("TrackMD5")) + ".ird");
                        // OutputLine("Info: Found: " + strPathISOGameName);
                        // OutputLine("Info: Row GameDKey: " + row["GameDKey"]);
                        // OutputLine("Info: Row GameDID: " + row["GameDID"]);
                        // OutputLine("Info: Row GamePIC: " + row["GamePIC"]);
                        // OutputLine("Info: Row TrackMD5: " + row["TrackMD5"]);
                        break;
                    }
                }

                // Check if the IRD already exists.
                if (!String.IsNullOrEmpty(strPathIRDFileName) && File.Exists(strPathIRDFileName) && SkipExistingIRDs)
                {
                    OutputLine("Info: IRD already exists (" + Path.GetFileName(strPathIRDFileName) + ") - Skipping");
                    worker.ReportProgress((int)(((decimal)(i + 1)) * 100) / arrFilesystemROMs.Length);
                    continue;
                }

                // Redump's Disc ID must be encrypted and Redump's Disc Key must be decrypted.
                string strGameDKeyDec = DecryptDiscKey(strGameDKey);
                string strGameDIDEnc = EncryptDiscID(strGameDID);

                // Prepare the DiscID/DiscKey/DiscPIC data in string form.
                string d1_dec_hexstring = strGameDKeyDec.Replace("-", "").Replace(" ", "").Replace(",", "");
                string d2_enc_hexstring = strGameDIDEnc.Replace("-", "").Replace(" ", "").Replace(",", "");
                string pic_hexstring = strGamePIC.Replace("-", "").Replace(" ", "").Replace(",", "").Replace("\r", "").Replace("\n", "").Replace("<br/>", "");

                // OutputLine("Info: ID: " + d1_dec_hexstring);
                // OutputLine("Info: DKey: " + d2_enc_hexstring);
                // OutputLine("Info: PIC: " + pic_hexstring);

                // Check the required data to build the IRD.
                if (String.IsNullOrEmpty(d1_dec_hexstring) || String.IsNullOrEmpty(d2_enc_hexstring) || String.IsNullOrEmpty(pic_hexstring))
                {
                    OutputLine("Info: The required DB data to build the IRD does not exist");
                    worker.ReportProgress((int)(((decimal)(i + 1)) * 100) / arrFilesystemROMs.Length);
                    continue;
                }

                // Check the required data to build the IRD.
                if (d1_dec_hexstring.Length != 16 * 2 || d2_enc_hexstring.Length != 16 * 2 || pic_hexstring.Length < 115 * 2)
                {
                    OutputLine("Info: The required DB data to build the IRD is corrupt");
                    worker.ReportProgress((int)(((decimal)(i + 1)) * 100) / arrFilesystemROMs.Length);
                    continue;
                }

                // Redump PIC is larger than 3k3y PIC, truncate if needed.
                pic_hexstring = pic_hexstring.Substring(0, 115 * 2);

                // Prepare the DiscID/DiscKey/DiscPIC data in byte array form.
                byte[] d1 = HexStringToByteArray(d1_dec_hexstring);
                byte[] d2 = HexStringToByteArray(d2_enc_hexstring);
                byte[] pic = HexStringToByteArray(pic_hexstring);

                // Check the required data to build the IRD.
                if (d1.Length != 16 || d2.Length != 16 || pic.Length != 115)
                {
                    OutputLine("Info: The required DB data to build the IRD cannot be converted");
                    worker.ReportProgress((int)(((decimal)(i + 1)) * 100) / arrFilesystemROMs.Length);
                    continue;
                }

                if (strPathISOFileName.EndsWith(".zip"))
                {
                    // Print to screen
                    // OutputLine("Info: ROM FileName: " + strPathISOFileName);
                    OutputLine("Info: Extracting zipped ROM ...");

                    // Unzip the file.
                    using (ZipFile zip = ZipFile.Read(strPathISOFileName))
                    {
                        zip.ExtractProgress += new EventHandler<ExtractProgressEventArgs>(UnzipFile_ExtractProgress);
                        zip.ExtractAll(PathTempExtractionDir);
                    }

                    // Report the overall progress.
                    worker.ReportProgress((int)(((decimal)(i + .5)) * 100) / arrFilesystemROMs.Length);

                    // Set the extracted ROM path.
                    strPathISOFileName = Path.Combine(PathTempExtractionDir, Path.GetFileNameWithoutExtension(strPathISOFileName) + ".iso");
                }

                try
                {
                    // Interaction.Instance
                    Interaction.SetInteraction(new RedumpInteraction(tspbTaskProgress.ProgressBar, rtbLog, strPathIRDFileName, strPathISOFileName));

                    // Build the IRD.
                    Task<bool> result = new IrdCreateRedumpFile(false, true, d1, d2, pic).CreateIRD(cancellation_.Token);
                    result.Wait();
                    if (result.IsCanceled || result.IsFaulted)
                    {
                        OutputLine("Info: IrdCreateRedumpFile failed or cancelled");
                    }
                }
                catch (Exception ex)
                {
                    // Print to screen
                    OutputLine("Error: " + ex.Message);
                    OutputLine("Error: " + ex.InnerException.Message);
                    OutputLine("Error: Building IRD failed");
                }

                // Delete any temp file.
                if (File.Exists(Path.Combine(PathTempExtractionDir, Path.GetFileNameWithoutExtension(strPathISOFileName) + ".iso")))
                {
                    File.Delete(Path.Combine(PathTempExtractionDir, Path.GetFileNameWithoutExtension(strPathISOFileName) + ".iso"));
                }

                // Report the overall progress.
                worker.ReportProgress((int)(((decimal)(i + 1)) * 100) / arrFilesystemROMs.Length);
            }

            // Send IRDs to The Ultimate IRD Database.
            if (SendIRDsToTheUltimateIRDDatabase)
            {
                OutputLine("Info: Sending IRDs to The Ultimate IRD database - Disabled");
            }
        }

        private void BuildIRDs_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Update the overall progressbar.
            tspbOverallProgress.ProgressBar.Value = e.ProgressPercentage;
        }

        private void BuildIRDs_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                // Print to screen
                OutputLine("Info: Building IRDs cancelled");
                OutputLine("Info: Ready");
            }
            else if (e.Error != null)
            {
                // Print to screen
                OutputLine("Error: Building IRDs failed");
                OutputLine("Error: " + e.Error.Message);
                OutputLine("Info: Ready");
            }
            else
            {
                // Print to screen
                OutputLine("Info: Building IRDs completed");
                OutputLine("Info: Ready");
            }

            // Reset the progress bars.
            ResetProgressBars();

            // Update the status message label.
            UpdateStatusMessageLabel("Ready");

            // Change the form's enabled state.
            ChangeState(true);
        }

        #endregion

        #region Printers

        /// <summary>
        /// Prints the version and copyright notice texts.
        /// </summary>
        public void PrintVersion()
        {
            // Print to screen
            OutputLine("------------------------------------------------------------------------------");
            OutputLine(AppName + " v" + AppVersion);
            OutputLine(AppCopyright);
            OutputLine("------------------------------------------------------------------------------");
        }

        /// <summary>
        /// Outputs a line of text.
        /// </summary>
        /// <param name="strMsg"></param>
        private void OutputLine(string strMsg)
        {
            if (this.InvokeRequired && !this.IsDisposed)
            {
                Invoke(new MethodInvoker(delegate ()
                {
                    // Add the line of text to the log.
                    this.rtbLog.AppendText(strMsg + Environment.NewLine);

                    // Scroll the log to the caret.
                    this.rtbLog.ScrollToCaret();
                }));
            }
            else if (!this.IsDisposed)
            {
                // Add the line of text to the log.
                this.rtbLog.AppendText(strMsg + Environment.NewLine);

                // Scroll the log to the caret.
                this.rtbLog.ScrollToCaret();
            }
        }

        #endregion
    }
}
