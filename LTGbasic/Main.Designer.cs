namespace LTG
{
	partial class FrmMain
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
			this.components = new System.ComponentModel.Container();
			this.lblDomain = new System.Windows.Forms.Label();
			this.cboDomain = new System.Windows.Forms.ComboBox();
			this.lblCode = new System.Windows.Forms.Label();
			this.cboCode = new System.Windows.Forms.ComboBox();
			this.lblBaseAddress = new System.Windows.Forms.Label();
			this.txtBaseAddress = new System.Windows.Forms.TextBox();
			this.gbPages = new System.Windows.Forms.GroupBox();
			this.lblPNotes = new System.Windows.Forms.Label();
			this.nudPTo = new System.Windows.Forms.NumericUpDown();
			this.lblPTo = new System.Windows.Forms.Label();
			this.nudPFrom = new System.Windows.Forms.NumericUpDown();
			this.lblPFrom = new System.Windows.Forms.Label();
			this.nudPTotal = new System.Windows.Forms.NumericUpDown();
			this.lblPTotal = new System.Windows.Forms.Label();
			this.gbControl = new System.Windows.Forms.GroupBox();
			this.nudRetries = new System.Windows.Forms.NumericUpDown();
			this.lblRetries = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnDestPath = new System.Windows.Forms.Button();
			this.txtDestPath = new System.Windows.Forms.TextBox();
			this.lvMain = new System.Windows.Forms.ListView();
			this.btnStart = new System.Windows.Forms.Button();
			this.fbdMain = new System.Windows.Forms.FolderBrowserDialog();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.gbPages.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudPTo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudPFrom)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudPTotal)).BeginInit();
			this.gbControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudRetries)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblDomain
			// 
			this.lblDomain.AutoSize = true;
			this.lblDomain.Location = new System.Drawing.Point(12, 15);
			this.lblDomain.Name = "lblDomain";
			this.lblDomain.Size = new System.Drawing.Size(46, 13);
			this.lblDomain.TabIndex = 0;
			this.lblDomain.Text = "Domain:";
			// 
			// cboDomain
			// 
			this.cboDomain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboDomain.FormattingEnabled = true;
			this.cboDomain.Location = new System.Drawing.Point(64, 12);
			this.cboDomain.Name = "cboDomain";
			this.cboDomain.Size = new System.Drawing.Size(75, 21);
			this.cboDomain.TabIndex = 1;
			this.cboDomain.SelectedIndexChanged += new System.EventHandler(this.CboDomain_SelectedIndexChanged);
			// 
			// lblCode
			// 
			this.lblCode.AutoSize = true;
			this.lblCode.Location = new System.Drawing.Point(145, 15);
			this.lblCode.Name = "lblCode";
			this.lblCode.Size = new System.Drawing.Size(35, 13);
			this.lblCode.TabIndex = 2;
			this.lblCode.Text = "Code:";
			// 
			// cboCode
			// 
			this.cboCode.FormattingEnabled = true;
			this.cboCode.Location = new System.Drawing.Point(186, 12);
			this.cboCode.Name = "cboCode";
			this.cboCode.Size = new System.Drawing.Size(100, 21);
			this.cboCode.TabIndex = 3;
			this.toolTip1.SetToolTip(this.cboCode, "Press ENTER to autocomplete base address and retrieve total page number.");
			this.cboCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CboCode_KeyDown);
			// 
			// lblBaseAddress
			// 
			this.lblBaseAddress.AutoSize = true;
			this.lblBaseAddress.Location = new System.Drawing.Point(12, 42);
			this.lblBaseAddress.Name = "lblBaseAddress";
			this.lblBaseAddress.Size = new System.Drawing.Size(75, 13);
			this.lblBaseAddress.TabIndex = 4;
			this.lblBaseAddress.Text = "Base Address:";
			// 
			// txtBaseAddress
			// 
			this.txtBaseAddress.Location = new System.Drawing.Point(93, 39);
			this.txtBaseAddress.Name = "txtBaseAddress";
			this.txtBaseAddress.Size = new System.Drawing.Size(250, 20);
			this.txtBaseAddress.TabIndex = 5;
			this.toolTip1.SetToolTip(this.txtBaseAddress, "Base address (remote folder) where image files are located.");
			// 
			// gbPages
			// 
			this.gbPages.Controls.Add(this.lblPNotes);
			this.gbPages.Controls.Add(this.nudPTo);
			this.gbPages.Controls.Add(this.lblPTo);
			this.gbPages.Controls.Add(this.nudPFrom);
			this.gbPages.Controls.Add(this.lblPFrom);
			this.gbPages.Controls.Add(this.nudPTotal);
			this.gbPages.Controls.Add(this.lblPTotal);
			this.gbPages.Location = new System.Drawing.Point(15, 65);
			this.gbPages.Name = "gbPages";
			this.gbPages.Size = new System.Drawing.Size(328, 80);
			this.gbPages.TabIndex = 6;
			this.gbPages.TabStop = false;
			this.gbPages.Text = "Pages to Download";
			// 
			// lblPNotes
			// 
			this.lblPNotes.AutoSize = true;
			this.lblPNotes.Location = new System.Drawing.Point(186, 47);
			this.lblPNotes.Name = "lblPNotes";
			this.lblPNotes.Size = new System.Drawing.Size(113, 13);
			this.lblPNotes.TabIndex = 6;
			this.lblPNotes.Text = "(From/To are 0-based)";
			// 
			// nudPTo
			// 
			this.nudPTo.Location = new System.Drawing.Point(130, 45);
			this.nudPTo.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.nudPTo.Name = "nudPTo";
			this.nudPTo.Size = new System.Drawing.Size(50, 20);
			this.nudPTo.TabIndex = 5;
			this.nudPTo.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
			// 
			// lblPTo
			// 
			this.lblPTo.AutoSize = true;
			this.lblPTo.Location = new System.Drawing.Point(101, 47);
			this.lblPTo.Name = "lblPTo";
			this.lblPTo.Size = new System.Drawing.Size(23, 13);
			this.lblPTo.TabIndex = 4;
			this.lblPTo.Text = "To:";
			// 
			// nudPFrom
			// 
			this.nudPFrom.Location = new System.Drawing.Point(45, 45);
			this.nudPFrom.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.nudPFrom.Name = "nudPFrom";
			this.nudPFrom.Size = new System.Drawing.Size(50, 20);
			this.nudPFrom.TabIndex = 3;
			this.nudPFrom.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
			// 
			// lblPFrom
			// 
			this.lblPFrom.AutoSize = true;
			this.lblPFrom.Location = new System.Drawing.Point(6, 47);
			this.lblPFrom.Name = "lblPFrom";
			this.lblPFrom.Size = new System.Drawing.Size(33, 13);
			this.lblPFrom.TabIndex = 2;
			this.lblPFrom.Text = "From:";
			// 
			// nudPTotal
			// 
			this.nudPTotal.Location = new System.Drawing.Point(74, 19);
			this.nudPTotal.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nudPTotal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudPTotal.Name = "nudPTotal";
			this.nudPTotal.Size = new System.Drawing.Size(50, 20);
			this.nudPTotal.TabIndex = 1;
			this.toolTip1.SetToolTip(this.nudPTotal, "Press ENTER to auto-fill From/To values.");
			this.nudPTotal.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nudPTotal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NudPTotal_KeyDown);
			// 
			// lblPTotal
			// 
			this.lblPTotal.AutoSize = true;
			this.lblPTotal.Location = new System.Drawing.Point(6, 21);
			this.lblPTotal.Name = "lblPTotal";
			this.lblPTotal.Size = new System.Drawing.Size(62, 13);
			this.lblPTotal.TabIndex = 0;
			this.lblPTotal.Text = "Book Total:";
			// 
			// gbControl
			// 
			this.gbControl.Controls.Add(this.nudRetries);
			this.gbControl.Controls.Add(this.lblRetries);
			this.gbControl.Location = new System.Drawing.Point(15, 151);
			this.gbControl.Name = "gbControl";
			this.gbControl.Size = new System.Drawing.Size(328, 52);
			this.gbControl.TabIndex = 7;
			this.gbControl.TabStop = false;
			this.gbControl.Text = "Download Control";
			// 
			// nudRetries
			// 
			this.nudRetries.Location = new System.Drawing.Point(55, 19);
			this.nudRetries.Name = "nudRetries";
			this.nudRetries.Size = new System.Drawing.Size(50, 20);
			this.nudRetries.TabIndex = 1;
			this.toolTip1.SetToolTip(this.nudRetries, "Number of times to retry file download.");
			this.nudRetries.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// lblRetries
			// 
			this.lblRetries.AutoSize = true;
			this.lblRetries.Location = new System.Drawing.Point(6, 21);
			this.lblRetries.Name = "lblRetries";
			this.lblRetries.Size = new System.Drawing.Size(43, 13);
			this.lblRetries.TabIndex = 0;
			this.lblRetries.Text = "Retries:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnDestPath);
			this.groupBox1.Controls.Add(this.txtDestPath);
			this.groupBox1.Location = new System.Drawing.Point(15, 209);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(328, 52);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "File Destination";
			// 
			// btnDestPath
			// 
			this.btnDestPath.Location = new System.Drawing.Point(222, 17);
			this.btnDestPath.Name = "btnDestPath";
			this.btnDestPath.Size = new System.Drawing.Size(100, 23);
			this.btnDestPath.TabIndex = 1;
			this.btnDestPath.Text = "Select Path...";
			this.btnDestPath.UseVisualStyleBackColor = true;
			this.btnDestPath.Click += new System.EventHandler(this.BtnDestPath_Click);
			// 
			// txtDestPath
			// 
			this.txtDestPath.Location = new System.Drawing.Point(6, 19);
			this.txtDestPath.Name = "txtDestPath";
			this.txtDestPath.Size = new System.Drawing.Size(210, 20);
			this.txtDestPath.TabIndex = 0;
			this.toolTip1.SetToolTip(this.txtDestPath, "Folder where downloaded files will be placed.");
			// 
			// lvMain
			// 
			this.lvMain.AutoArrange = false;
			this.lvMain.CheckBoxes = true;
			this.lvMain.FullRowSelect = true;
			this.lvMain.GridLines = true;
			this.lvMain.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvMain.Location = new System.Drawing.Point(349, 12);
			this.lvMain.Name = "lvMain";
			this.lvMain.ShowGroups = false;
			this.lvMain.Size = new System.Drawing.Size(423, 388);
			this.lvMain.TabIndex = 12;
			this.lvMain.UseCompatibleStateImageBehavior = false;
			this.lvMain.View = System.Windows.Forms.View.Details;
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(15, 267);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(150, 23);
			this.btnStart.TabIndex = 9;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 412);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.lvMain);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.gbControl);
			this.Controls.Add(this.gbPages);
			this.Controls.Add(this.txtBaseAddress);
			this.Controls.Add(this.lblBaseAddress);
			this.Controls.Add(this.cboCode);
			this.Controls.Add(this.lblCode);
			this.Controls.Add(this.cboDomain);
			this.Controls.Add(this.lblDomain);
			this.MaximizeBox = false;
			this.Name = "FrmMain";
			this.Text = "LTG Basic Retriever";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
			this.Load += new System.EventHandler(this.FrmMain_Load);
			this.Resize += new System.EventHandler(this.FrmMain_Resize);
			this.gbPages.ResumeLayout(false);
			this.gbPages.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudPTo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudPFrom)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudPTotal)).EndInit();
			this.gbControl.ResumeLayout(false);
			this.gbControl.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudRetries)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblDomain;
		private System.Windows.Forms.ComboBox cboDomain;
		private System.Windows.Forms.Label lblCode;
		private System.Windows.Forms.ComboBox cboCode;
		private System.Windows.Forms.Label lblBaseAddress;
		private System.Windows.Forms.TextBox txtBaseAddress;
		private System.Windows.Forms.GroupBox gbPages;
		private System.Windows.Forms.NumericUpDown nudPTotal;
		private System.Windows.Forms.Label lblPTotal;
		private System.Windows.Forms.Label lblPFrom;
		private System.Windows.Forms.NumericUpDown nudPFrom;
		private System.Windows.Forms.Label lblPNotes;
		private System.Windows.Forms.NumericUpDown nudPTo;
		private System.Windows.Forms.Label lblPTo;
		private System.Windows.Forms.GroupBox gbControl;
		private System.Windows.Forms.NumericUpDown nudRetries;
		private System.Windows.Forms.Label lblRetries;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnDestPath;
		private System.Windows.Forms.TextBox txtDestPath;
		private System.Windows.Forms.ListView lvMain;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.FolderBrowserDialog fbdMain;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}

