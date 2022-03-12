
namespace AudioVideo_Player
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.pnlCaptionBar = new System.Windows.Forms.Panel();
			this.lblToolTip = new System.Windows.Forms.Label();
			this.pnlMinimize = new System.Windows.Forms.Panel();
			this.lblMinimize = new System.Windows.Forms.Label();
			this.pnlClose = new System.Windows.Forms.Panel();
			this.lblClose = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this.lstMediaFiles = new System.Windows.Forms.ListBox();
			this.pnlTabs = new System.Windows.Forms.TableLayoutPanel();
			this.lblFileSelection = new System.Windows.Forms.Label();
			this.lblMediaPlayerTab = new System.Windows.Forms.Label();
			this.pnlMediaPlayerTab = new System.Windows.Forms.Panel();
			this.lblLoadMedia = new System.Windows.Forms.Label();
			this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
			this.pnlFileSelectionTab = new System.Windows.Forms.Panel();
			this.lblNewMedia = new System.Windows.Forms.Label();
			this.lblRemoveMedia = new System.Windows.Forms.Label();
			this.lblAddMedia = new System.Windows.Forms.Label();
			this.pnlCaptionBar.SuspendLayout();
			this.pnlMinimize.SuspendLayout();
			this.pnlClose.SuspendLayout();
			this.pnlTabs.SuspendLayout();
			this.pnlMediaPlayerTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
			this.pnlFileSelectionTab.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlCaptionBar
			// 
			this.pnlCaptionBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.pnlCaptionBar.Controls.Add(this.lblToolTip);
			this.pnlCaptionBar.Controls.Add(this.pnlMinimize);
			this.pnlCaptionBar.Controls.Add(this.pnlClose);
			this.pnlCaptionBar.Controls.Add(this.lblTitle);
			this.pnlCaptionBar.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.pnlCaptionBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlCaptionBar.Location = new System.Drawing.Point(0, 0);
			this.pnlCaptionBar.Name = "pnlCaptionBar";
			this.pnlCaptionBar.Size = new System.Drawing.Size(958, 32);
			this.pnlCaptionBar.TabIndex = 0;
			this.pnlCaptionBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm);
			// 
			// lblToolTip
			// 
			this.lblToolTip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblToolTip.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblToolTip.Location = new System.Drawing.Point(139, 6);
			this.lblToolTip.Name = "lblToolTip";
			this.lblToolTip.Size = new System.Drawing.Size(749, 19);
			this.lblToolTip.TabIndex = 3;
			this.lblToolTip.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.lblToolTip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm);
			// 
			// pnlMinimize
			// 
			this.pnlMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlMinimize.Controls.Add(this.lblMinimize);
			this.pnlMinimize.Location = new System.Drawing.Point(894, 0);
			this.pnlMinimize.Name = "pnlMinimize";
			this.pnlMinimize.Size = new System.Drawing.Size(32, 32);
			this.pnlMinimize.TabIndex = 2;
			this.pnlMinimize.Click += new System.EventHandler(this.Minimize);
			this.pnlMinimize.MouseEnter += new System.EventHandler(this.Minimize_Enter);
			this.pnlMinimize.MouseLeave += new System.EventHandler(this.Minimize_Leave);
			// 
			// lblMinimize
			// 
			this.lblMinimize.AutoSize = true;
			this.lblMinimize.Font = new System.Drawing.Font("Webdings", 10F);
			this.lblMinimize.Location = new System.Drawing.Point(5, 2);
			this.lblMinimize.Name = "lblMinimize";
			this.lblMinimize.Size = new System.Drawing.Size(23, 20);
			this.lblMinimize.TabIndex = 1;
			this.lblMinimize.Text = "0";
			this.lblMinimize.Click += new System.EventHandler(this.Minimize);
			this.lblMinimize.MouseEnter += new System.EventHandler(this.Minimize_Enter);
			this.lblMinimize.MouseLeave += new System.EventHandler(this.Minimize_Leave);
			// 
			// pnlClose
			// 
			this.pnlClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlClose.Controls.Add(this.lblClose);
			this.pnlClose.Location = new System.Drawing.Point(926, 0);
			this.pnlClose.Name = "pnlClose";
			this.pnlClose.Size = new System.Drawing.Size(32, 32);
			this.pnlClose.TabIndex = 1;
			this.pnlClose.Click += new System.EventHandler(this.Close);
			this.pnlClose.MouseEnter += new System.EventHandler(this.Close_Enter);
			this.pnlClose.MouseLeave += new System.EventHandler(this.Close_Leave);
			// 
			// lblClose
			// 
			this.lblClose.AutoSize = true;
			this.lblClose.Font = new System.Drawing.Font("Webdings", 10F);
			this.lblClose.Location = new System.Drawing.Point(5, 5);
			this.lblClose.Name = "lblClose";
			this.lblClose.Size = new System.Drawing.Size(23, 20);
			this.lblClose.TabIndex = 0;
			this.lblClose.Text = "r";
			this.lblClose.Click += new System.EventHandler(this.Close);
			this.lblClose.MouseEnter += new System.EventHandler(this.Close_Enter);
			this.lblClose.MouseLeave += new System.EventHandler(this.Close_Leave);
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblTitle.Location = new System.Drawing.Point(6, 6);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(127, 19);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Audio-Video Player";
			this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm);
			// 
			// lstMediaFiles
			// 
			this.lstMediaFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstMediaFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.lstMediaFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lstMediaFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
			this.lstMediaFiles.FormattingEnabled = true;
			this.lstMediaFiles.ItemHeight = 15;
			this.lstMediaFiles.Location = new System.Drawing.Point(635, 34);
			this.lstMediaFiles.Name = "lstMediaFiles";
			this.lstMediaFiles.Size = new System.Drawing.Size(323, 572);
			this.lstMediaFiles.TabIndex = 1;
			this.lstMediaFiles.MouseEnter += new System.EventHandler(this.MediaFiles_Enter);
			this.lstMediaFiles.MouseLeave += new System.EventHandler(this.MediaFiles_Leave);
			// 
			// pnlTabs
			// 
			this.pnlTabs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlTabs.ColumnCount = 2;
			this.pnlTabs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.pnlTabs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.pnlTabs.Controls.Add(this.lblFileSelection, 1, 0);
			this.pnlTabs.Controls.Add(this.lblMediaPlayerTab, 0, 0);
			this.pnlTabs.Location = new System.Drawing.Point(-1, 34);
			this.pnlTabs.Name = "pnlTabs";
			this.pnlTabs.RowCount = 1;
			this.pnlTabs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.pnlTabs.Size = new System.Drawing.Size(630, 43);
			this.pnlTabs.TabIndex = 2;
			// 
			// lblFileSelection
			// 
			this.lblFileSelection.AutoSize = true;
			this.lblFileSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.lblFileSelection.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblFileSelection.Location = new System.Drawing.Point(318, 0);
			this.lblFileSelection.Name = "lblFileSelection";
			this.lblFileSelection.Size = new System.Drawing.Size(309, 43);
			this.lblFileSelection.TabIndex = 1;
			this.lblFileSelection.Text = "File Selection";
			this.lblFileSelection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblFileSelection.Click += new System.EventHandler(this.SelectFileSelection);
			this.lblFileSelection.MouseEnter += new System.EventHandler(this.FileSelection_Enter);
			this.lblFileSelection.MouseLeave += new System.EventHandler(this.FileSelection_Leave);
			// 
			// lblMediaPlayerTab
			// 
			this.lblMediaPlayerTab.AutoSize = true;
			this.lblMediaPlayerTab.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblMediaPlayerTab.Location = new System.Drawing.Point(3, 0);
			this.lblMediaPlayerTab.Name = "lblMediaPlayerTab";
			this.lblMediaPlayerTab.Size = new System.Drawing.Size(309, 43);
			this.lblMediaPlayerTab.TabIndex = 0;
			this.lblMediaPlayerTab.Text = "Media Player";
			this.lblMediaPlayerTab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblMediaPlayerTab.Click += new System.EventHandler(this.SelectMediaPlayer);
			this.lblMediaPlayerTab.MouseEnter += new System.EventHandler(this.MediaPlayer_Enter);
			this.lblMediaPlayerTab.MouseLeave += new System.EventHandler(this.MediaPlayer_Leave);
			// 
			// pnlMediaPlayerTab
			// 
			this.pnlMediaPlayerTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlMediaPlayerTab.Controls.Add(this.lblLoadMedia);
			this.pnlMediaPlayerTab.Controls.Add(this.mediaPlayer);
			this.pnlMediaPlayerTab.Location = new System.Drawing.Point(1, 83);
			this.pnlMediaPlayerTab.Name = "pnlMediaPlayerTab";
			this.pnlMediaPlayerTab.Size = new System.Drawing.Size(628, 523);
			this.pnlMediaPlayerTab.TabIndex = 3;
			// 
			// lblLoadMedia
			// 
			this.lblLoadMedia.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblLoadMedia.Location = new System.Drawing.Point(0, 477);
			this.lblLoadMedia.Name = "lblLoadMedia";
			this.lblLoadMedia.Size = new System.Drawing.Size(750, 46);
			this.lblLoadMedia.TabIndex = 1;
			this.lblLoadMedia.Text = "Load";
			this.lblLoadMedia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblLoadMedia.Click += new System.EventHandler(this.LoadMedia);
			this.lblLoadMedia.MouseEnter += new System.EventHandler(this.LoadMedia_Enter);
			this.lblLoadMedia.MouseLeave += new System.EventHandler(this.LoadMedia_Leave);
			// 
			// mediaPlayer
			// 
			this.mediaPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mediaPlayer.Enabled = true;
			this.mediaPlayer.Location = new System.Drawing.Point(0, 0);
			this.mediaPlayer.Name = "mediaPlayer";
			this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
			this.mediaPlayer.Size = new System.Drawing.Size(628, 477);
			this.mediaPlayer.TabIndex = 0;
			// 
			// pnlFileSelectionTab
			// 
			this.pnlFileSelectionTab.Controls.Add(this.lblNewMedia);
			this.pnlFileSelectionTab.Controls.Add(this.lblRemoveMedia);
			this.pnlFileSelectionTab.Controls.Add(this.lblAddMedia);
			this.pnlFileSelectionTab.Location = new System.Drawing.Point(1, 83);
			this.pnlFileSelectionTab.Name = "pnlFileSelectionTab";
			this.pnlFileSelectionTab.Size = new System.Drawing.Size(628, 523);
			this.pnlFileSelectionTab.TabIndex = 4;
			// 
			// lblNewMedia
			// 
			this.lblNewMedia.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.lblNewMedia.Location = new System.Drawing.Point(390, 229);
			this.lblNewMedia.Name = "lblNewMedia";
			this.lblNewMedia.Size = new System.Drawing.Size(139, 53);
			this.lblNewMedia.TabIndex = 2;
			this.lblNewMedia.Text = "New Media";
			this.lblNewMedia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblNewMedia.Click += new System.EventHandler(this.NewMedia);
			this.lblNewMedia.MouseEnter += new System.EventHandler(this.NewMedia_Enter);
			this.lblNewMedia.MouseLeave += new System.EventHandler(this.NewMedia_Leave);
			// 
			// lblRemoveMedia
			// 
			this.lblRemoveMedia.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.lblRemoveMedia.Location = new System.Drawing.Point(244, 229);
			this.lblRemoveMedia.Name = "lblRemoveMedia";
			this.lblRemoveMedia.Size = new System.Drawing.Size(140, 53);
			this.lblRemoveMedia.TabIndex = 1;
			this.lblRemoveMedia.Text = "Remove Media";
			this.lblRemoveMedia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblRemoveMedia.Click += new System.EventHandler(this.RemoveMedia);
			this.lblRemoveMedia.MouseEnter += new System.EventHandler(this.RemoveMedia_Enter);
			this.lblRemoveMedia.MouseLeave += new System.EventHandler(this.RemoveMedia_Leave);
			// 
			// lblAddMedia
			// 
			this.lblAddMedia.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.lblAddMedia.Location = new System.Drawing.Point(99, 229);
			this.lblAddMedia.Name = "lblAddMedia";
			this.lblAddMedia.Size = new System.Drawing.Size(139, 53);
			this.lblAddMedia.TabIndex = 0;
			this.lblAddMedia.Text = "Add Media";
			this.lblAddMedia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblAddMedia.Click += new System.EventHandler(this.AddMedia);
			this.lblAddMedia.MouseEnter += new System.EventHandler(this.AddMedia_Enter);
			this.lblAddMedia.MouseLeave += new System.EventHandler(this.AddMedia_Leave);
			// 
			// Form1
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.ClientSize = new System.Drawing.Size(958, 607);
			this.Controls.Add(this.pnlFileSelectionTab);
			this.Controls.Add(this.pnlMediaPlayerTab);
			this.Controls.Add(this.pnlTabs);
			this.Controls.Add(this.lstMediaFiles);
			this.Controls.Add(this.pnlCaptionBar);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Audio-Video Player";
			this.pnlCaptionBar.ResumeLayout(false);
			this.pnlCaptionBar.PerformLayout();
			this.pnlMinimize.ResumeLayout(false);
			this.pnlMinimize.PerformLayout();
			this.pnlClose.ResumeLayout(false);
			this.pnlClose.PerformLayout();
			this.pnlTabs.ResumeLayout(false);
			this.pnlTabs.PerformLayout();
			this.pnlMediaPlayerTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
			this.pnlFileSelectionTab.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlCaptionBar;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Panel pnlMinimize;
		private System.Windows.Forms.Panel pnlClose;
		private System.Windows.Forms.Label lblMinimize;
		private System.Windows.Forms.Label lblClose;
		private System.Windows.Forms.Label lblToolTip;
		private System.Windows.Forms.ListBox lstMediaFiles;
		private System.Windows.Forms.TableLayoutPanel pnlTabs;
		private System.Windows.Forms.Label lblFileSelection;
		private System.Windows.Forms.Label lblMediaPlayerTab;
		private System.Windows.Forms.Panel pnlMediaPlayerTab;
		private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
		private System.Windows.Forms.Label lblLoadMedia;
		private System.Windows.Forms.Panel pnlFileSelectionTab;
		private System.Windows.Forms.Label lblNewMedia;
		private System.Windows.Forms.Label lblRemoveMedia;
		private System.Windows.Forms.Label lblAddMedia;
	}
}

