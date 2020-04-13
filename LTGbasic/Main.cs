using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTG
{
	public partial class FrmMain : Form
	{
		
		// ##### Data Structures #####

		public struct CurrentDownloadStruct
		{
			public string sBaseAddress;
			public string sDestPath;
			public int iPFrom;
			public int iPTo;
			public Uri uriCurrentURI;
			public int iCurrentFile;
			public int iRetry;
			public int iFailed;
		}

		public struct DLItemStatus
		{
			public int iFile;
			public int iStatus;
		}


		// ##### Fields #####

		private CurrentDownloadStruct CDL;
		

		// ##### Constructor #####

		public FrmMain()
		{
			InitializeComponent();
		}


		// ##### Form's Controls Event Handlers #####

		private void FrmMain_Load(object sender, EventArgs e)
		{
			Initialize_Controls_Values();
		}

		private void FrmMain_Resize(object sender, EventArgs e)
		{
			// ListView location: 349, 12 (X,Y)
			// ListView minimum size: 423,388 (W,H)
			// Margins: 12
			System.Drawing.Size szNew = new System.Drawing.Size(423,388);
			if (this.ClientSize.Width > 784) {  //lv left + lv width + marg
				szNew.Width = this.ClientSize.Width - 361;  // lv left + marg
			}
			if (this.ClientSize.Height > 412) {  // lv height + 2*marg
				szNew.Height = this.ClientSize.Height - 24;  // 2*marg
			}
			lvMain.Size = szNew;
		}

		private void FrmMain_FormClosing(object sender, FormClosingEventArgs e) {
			Save_Properties();
		}


		private void CboDomain_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cboDomain.SelectedIndex == 0) {
				txtBaseAddress.Text = "https://historico.conaliteg.gob.mx/c/";
			} else {
				txtBaseAddress.Text = "https://libros.conaliteg.gob.mx/c/";
			}
		}

		private void CboCode_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter) {
				if (cboDomain.SelectedIndex == 0) {
					txtBaseAddress.Text = "https://historico.conaliteg.gob.mx/c/";
				} else {
					txtBaseAddress.Text = "https://libros.conaliteg.gob.mx/c/";
				}
				txtBaseAddress.AppendText(cboCode.Text + "/");
				TryGetPageNumber();
			}
		}

		private void NudPTotal_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter && nudPTotal.Value != 0) {
				nudPFrom.Value = 0;
				nudPTo.Value = nudPTotal.Value - 1;
			}
		}

		private void BtnDestPath_Click(object sender, EventArgs e)
		{
			if (fbdMain.ShowDialog() == DialogResult.OK) {
				txtDestPath.Text = fbdMain.SelectedPath;
			}
		}

		private void BtnStart_Click(object sender, EventArgs e)
		{

			btnStart.Enabled = false;

			if (Validate_Controls_Values() != true) {
				btnStart.Enabled = true;
				return;
			}

			// Initialize Download Parameters
			CDL.sBaseAddress = txtBaseAddress.Text;
			CDL.sDestPath = txtDestPath.Text;
			CDL.iPFrom = Convert.ToInt32(nudPFrom.Value);
			CDL.iPTo = Convert.ToInt32(nudPTo.Value);
			CDL.iFailed = 0;

			// Populate ListView
			lvMain.Items.Clear();
			for (int i = CDL.iPFrom; i <= CDL.iPTo; i++) {
				ListViewItem lviNew = new ListViewItem();
				DLItemStatus DLIS = new DLItemStatus();
				DLIS.iFile = i;
				DLIS.iStatus = 0;
				lviNew.Tag = DLIS;
				lviNew.Text = CDL.sBaseAddress + i.ToString("D3") + ".jpg";
				lviNew.SubItems.Add("Queued");
				lviNew.Checked = true;

				lvMain.Items.Add(lviNew);
			}
			lvMain.Refresh();

			// Prepare Next File Download
			CDL.iCurrentFile = CDL.iPFrom;
			CDL.uriCurrentURI = new Uri(CDL.sBaseAddress + CDL.iPFrom.ToString("D3") + ".jpg");
			//System.Diagnostics.Debug.WriteLine(CDL.uriCurrentURI.ToString());
			CDL.iRetry = 0;

			Download_File();
		}


		// ##### Private Functions #####

		private void Download_File()
		{
			// Create WebClient
			WebClient wc = new WebClient();
			// Assign Event Handlers
			wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(Wc_DPC);
			wc.DownloadFileCompleted += new AsyncCompletedEventHandler(Wc_DFC);
			// Download Async
			string sLoc = Path.Combine(CDL.sDestPath, CDL.iCurrentFile.ToString("D3") + ".jpg");
			wc.DownloadFileAsync(CDL.uriCurrentURI, sLoc);

		}

		private void Wc_DPC(object sender, DownloadProgressChangedEventArgs e)
		{
			string sInfo;
			if (CDL.iRetry == 0)
				sInfo = "Downloading";
			else
				sInfo = "Retrying (" + CDL.iRetry.ToString() + ")";

			lvMain.Items[CDL.iCurrentFile - CDL.iPFrom].SubItems[1].Text = sInfo + " - " + e.ProgressPercentage.ToString() + "%";
		}

		private void Wc_DFC(object sender, AsyncCompletedEventArgs e)
		{
			if (e.Error != null) {
				if (nudRetries.Value != 0 && CDL.iRetry < nudRetries.Value) {
					CDL.iRetry++;
					Download_File();
					return;
				} else {
					int iCLVII = CDL.iCurrentFile - CDL.iPFrom;
					lvMain.Items[iCLVII].SubItems[1].Text = "Failed";
					DLItemStatus DLIS1 = (DLItemStatus)lvMain.Items[iCLVII].Tag;
					DLIS1.iStatus = -1;
					lvMain.Items[iCLVII].Tag = DLIS1;
					lvMain.Items[iCLVII].Checked = true;
					CDL.iFailed++;

					// TODO: Delete failed file (it's created, but 0 size)
					string sLoc = Path.Combine(CDL.sDestPath, CDL.iCurrentFile.ToString("D3") + ".jpg");
					if (File.Exists(sLoc)) {
						File.Delete(sLoc);
					}
					
				}
			} else {
				int iCLVII = CDL.iCurrentFile - CDL.iPFrom;
				lvMain.Items[iCLVII].SubItems[1].Text = "Completed";
				DLItemStatus DLIS = (DLItemStatus)lvMain.Items[iCLVII].Tag;
				DLIS.iStatus = 1;
				lvMain.Items[iCLVII].Tag = DLIS;
				lvMain.Items[iCLVII].Checked = false;
			}

			if (CDL.iCurrentFile == CDL.iPTo) {
				string sMsg;
				if (CDL.iFailed != 0)
					sMsg = "Process completed. " + CDL.iFailed.ToString() + " failed.";
				else
					sMsg = "Download completed.";
				MessageBox.Show(sMsg, "LTG");
				btnStart.Enabled = true;
			} else {
				CDL.iCurrentFile++;
				CDL.uriCurrentURI = new Uri(CDL.sBaseAddress + CDL.iCurrentFile.ToString("D3") + ".jpg");
				CDL.iRetry = 0;
				Download_File();

				// Scroll to current
				int iCLVII = CDL.iCurrentFile - CDL.iPFrom;
				lvMain.EnsureVisible(iCLVII);
			}
		}

		private void Initialize_Controls_Values()
		{
			// Add domain options to combo box
			cboDomain.Items.Add("Histórico");
			cboDomain.Items.Add("Actual");
			cboDomain.SelectedIndex = 1;

			// ListView Columns
			lvMain.Columns.Add("File", 300);
			lvMain.Columns.Add("Status", 150);

			nudPTotal.Value = 100;
			nudPFrom.Value = 0;
			nudPTo.Value = 99;

			// Check saved settings availability
			//sProperty = Properties.Settings.Default.sSetting;
			nudRetries.Value = Properties.Settings.Default.iMaxRetries;
			if (Properties.Settings.Default.sSavedPath.Length == 0)
				txtDestPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			else
				txtDestPath.Text = Properties.Settings.Default.sSavedPath;
			

		}

		private void Save_Properties()
		{
			//Properties.Settings.Default.sSetting = sProperty;
			Properties.Settings.Default.iMaxRetries = Convert.ToInt32(nudRetries.Value);
			Properties.Settings.Default.sSavedPath = txtDestPath.Text;
			Properties.Settings.Default.Save();
		}

		private bool Validate_Controls_Values()
		{
			// Validate Base Address URI

			if (txtBaseAddress.TextLength == 0) {
				MessageBox.Show("You must supply a base address.", "LTG");
				txtBaseAddress.Focus();
				return false;
			}
			if (txtBaseAddress.Text.Last() != '/')
				txtBaseAddress.AppendText("/");
			if (!Is_Valid_URI(txtBaseAddress.Text)) {
				MessageBox.Show("The base address:\n" +	txtBaseAddress.Text +
					"\nis not valid.", "LTG");
				txtBaseAddress.SelectAll();
				txtBaseAddress.Focus();
				return false;
			}

			// Validate From/To Pages Values
			if (nudPTo.Value < nudPFrom.Value){
				MessageBox.Show("Page \"To\" cannot be lower than \"From\".\nValues will be swapped.", "LTG");
				decimal dTmp = nudPFrom.Value;
				nudPFrom.Value = nudPTo.Value;
				nudPTo.Value = dTmp;
				nudPFrom.Focus();
				return false;
			}

			// Validate Save Path
			if (txtDestPath.TextLength == 0){
				MessageBox.Show("You must supply a destination folder.", "LTG");
				txtDestPath.Focus();
				return false;
			}
			DirectoryInfo di = new DirectoryInfo(txtDestPath.Text);
			if (!di.Exists) {
				MessageBox.Show("Selected destination folder:\n" + txtDestPath.Text + "\ndoes not exist.", "LTG");
				txtDestPath.SelectAll();
				txtDestPath.Focus();
				return false;
			}

			return true;
		}

		private bool Is_Valid_URI(string sUri)
		{
			Uri uriResult;
			return Uri.TryCreate(txtBaseAddress.Text, UriKind.Absolute, out uriResult)
				&& (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
		}

		private void TryGetPageNumber() {
			string sURI;
			if (cboDomain.SelectedIndex == 0) {
				sURI = @"https://historico.conaliteg.gob.mx/" + cboCode.Text + ".htm";
			} else {
				sURI = @"https://libros.conaliteg.gob.mx/" + cboCode.Text + ".htm";
			}
			WebClient wc = new WebClient();
			byte[] byData = wc.DownloadData(sURI);
			string sData = Encoding.ASCII.GetString(byData);
			int iStart = sData.IndexOf("ag_pages");
			int iE = sData.IndexOf("=", iStart);
			int iC = sData.IndexOf(";", iStart);
			nudPTotal.Value = Convert.ToInt32(sData.Substring(iE + 2, iC - iE - 2));
			// TODO: Manage exceptions (not found file, strings, etc.)
		}

	}
}