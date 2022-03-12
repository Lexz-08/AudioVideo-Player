using Microsoft.Win32;
using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AudioVideo_Player
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			Cursor hand = GetRegistryCursor("Hand");

			pnlClose.Cursor = hand;
			pnlMinimize.Cursor = hand;
			lblClose.Cursor = hand;
			lblMinimize.Cursor = hand;
			lstMediaFiles.Cursor = hand;
			lblMediaPlayerTab.Cursor = hand;
			lblFileSelection.Cursor = hand;
			lblLoadMedia.Cursor = hand;
			lblAddMedia.Cursor = hand;
			lblRemoveMedia.Cursor = hand;
			lblNewMedia.Cursor = hand;
		}

		[DllImport("user32.dll")]
		private static extern bool ReleaseCapture();

		[DllImport("user32.dll")]
		private static extern int SendMessage(IntPtr hwnd, int msg, int wp, int lp);

		[DllImport("user32.dll")]
		private static extern IntPtr LoadCursorFromFile(string CursorFile);

		private void DragForm(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, 161, 2, 0);
			}
		}

		private Cursor GetRegistryCursor(string Cursor)
		{
			Cursor cursor = null;

			try
			{
				RegistryKey cursorRegkey = Registry.CurrentUser.OpenSubKey("Control Panel").OpenSubKey("Cursors");
				string cursorPath = cursorRegkey.GetValue(Cursor).ToString();
				IntPtr cursorHandle = LoadCursorFromFile(cursorPath);
				cursor = new Cursor(cursorHandle);
			}
			catch
			{
				cursor = (Cursor)typeof(Cursors).GetProperty(Cursor).GetValue(cursor, null);
			}

			GC.Collect();

			return cursor;
		}

		private void Close(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void Minimize(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void SelectMediaPlayer(object sender, EventArgs e)
		{
			pnlMediaPlayerTab.BringToFront();
			pnlFileSelectionTab.SendToBack();

			lblMediaPlayerTab.BackColor = Color.FromArgb(50, 50, 50);
			lblFileSelection.BackColor = Color.FromArgb(25, 25, 25);
		}

		private void SelectFileSelection(object sender, EventArgs e)
		{
			pnlFileSelectionTab.BringToFront();
			pnlMediaPlayerTab.SendToBack();

			lblFileSelection.BackColor = Color.FromArgb(50, 50, 50);
			lblMediaPlayerTab.BackColor = Color.FromArgb(25, 25, 25);
		}

		private void LoadMedia(object sender, EventArgs e)
		{
			if (lstMediaFiles.Items.Count > 0)
			{
				mediaPlayer.URL = lstMediaFiles.SelectedItem.ToString();
			}
		}

		private void AddMedia(object sender, EventArgs e)
		{
			using (OpenFileDialog ofd = new OpenFileDialog()
			{
				Title = "Please select media to add...",
				Filter = "Video|*.mp4; *.mkv; *.mov; *.wmv|" +
						"Audio|*.mp3; *.wma;|" +
						"Supported Types|*.mp4; *.mkv; *.mov; *.wmv; *.mp3; *.wma",
				FilterIndex = 2,
				Multiselect = true,
			})
			{
				if (ofd.ShowDialog() == DialogResult.OK)
				{
					lstMediaFiles.Items.AddRange(ofd.FileNames);

					string[] items = new string[lstMediaFiles.Items.Count];

					for (int index = 0; index < items.Length; index++)
					{
						items[index] = lstMediaFiles.Items[index].ToString();
					}

					items = items.Distinct().ToArray();

					lstMediaFiles.Items.Clear();

					for (int index = 0; index < items.Length; index++)
					{
						lstMediaFiles.Items.Add(items[index]);
					}
				}
			}
		}

		private void RemoveMedia(object sender, EventArgs e)
		{
			lstMediaFiles.Items.Remove(lstMediaFiles.SelectedItem);
		}

		private void NewMedia(object sender, EventArgs e)
		{
			using (OpenFileDialog ofd = new OpenFileDialog()
			{
				Title = "Please select media to add...",
				Filter = "Video|*.mp4; *.mkv; *.mov; *.wmv|" +
						"Audio|*.mp3; *.wma;|" +
						"Supported Types|*.mp4; *.mkv; *.mov; *.wmv; *.mp3; *.wma",
				FilterIndex = 2,
				Multiselect = true,
			})
			{
				if (ofd.ShowDialog() == DialogResult.OK)
				{
					string[] items = new string[ofd.FileNames.Length];

					for (int index = 0; index < items.Length; index++)
					{
						items[index] = ofd.FileNames[index];
					}

					items = items.Distinct().ToArray();

					lstMediaFiles.Items.Clear();

					for (int index = 0; index < items.Length; index++)
					{
						lstMediaFiles.Items.Add(items[index]);
					}
				}
			}
		}

		private void Close_Enter(object sender, EventArgs e)
		{
			pnlClose.BackColor = Color.FromArgb(60, 60, 60);
			lblClose.BackColor = Color.FromArgb(60, 60, 60);

			lblToolTip.Text = "Close";
		}
		private void Close_Leave(object sender, EventArgs e)
		{
			pnlClose.BackColor = Color.FromArgb(40, 40, 40);
			lblClose.BackColor = Color.FromArgb(40, 40, 40);

			lblToolTip.Text = string.Empty;
		}

		private void Minimize_Enter(object sender, EventArgs e)
		{
			pnlMinimize.BackColor = Color.FromArgb(60, 60, 60);
			lblMinimize.BackColor = Color.FromArgb(60, 60, 60);

			lblToolTip.Text = "Minimize";
		}
		private void Minimize_Leave(object sender, EventArgs e)
		{
			pnlMinimize.BackColor = Color.FromArgb(40, 40, 40);
			lblMinimize.BackColor = Color.FromArgb(40, 40, 40);

			lblToolTip.Text = string.Empty;
		}

		private void MediaFiles_Enter(object sender, EventArgs e)
		{
			lblToolTip.Text = "Audio and Video file paths loaded into the program";
		}
		private void MediaFiles_Leave(object sender, EventArgs e)
		{
			lblToolTip.Text = string.Empty;
		}

		private void MediaPlayer_Enter(object sender, EventArgs e)
		{
			lblToolTip.Text = "Selects the 'Media Player' tab";
		}
		private void MediaPlayer_Leave(object sender, EventArgs e)
		{
			lblToolTip.Text = string.Empty;
		}

		private void FileSelection_Enter(object sender, EventArgs e)
		{
			lblToolTip.Text = "Selects the 'File Selection' tab";
		}
		private void FileSelection_Leave(object sender, EventArgs e)
		{
			lblToolTip.Text = string.Empty;
		}

		private void LoadMedia_Enter(object sender, EventArgs e)
		{
			lblLoadMedia.BackColor = Color.FromArgb(50, 50, 50);

			lblToolTip.Text = "Loads the selected media into the player";
		}
		private void LoadMedia_Leave(object sender, EventArgs e)
		{
			lblLoadMedia.BackColor = Color.FromArgb(25, 25, 25);

			lblToolTip.Text = string.Empty;
		}

		private void AddMedia_Enter(object sender, EventArgs e)
		{
			lblAddMedia.BackColor = Color.FromArgb(50, 50, 50);

			lblToolTip.Text = "Add new media to the file list";
		}
		private void AddMedia_Leave(object sender, EventArgs e)
		{
			lblAddMedia.BackColor = Color.FromArgb(25, 25, 25);

			lblToolTip.Text = string.Empty;
		}

		private void RemoveMedia_Enter(object sender, EventArgs e)
		{
			lblRemoveMedia.BackColor = Color.FromArgb(50, 50, 50);

			lblToolTip.Text = "Remove selected media from the file list";
		}
		private void RemoveMedia_Leave(object sender, EventArgs e)
		{
			lblRemoveMedia.BackColor = Color.FromArgb(25, 25, 25);

			lblToolTip.Text = string.Empty;
		}

		private void NewMedia_Enter(object sender, EventArgs e)
		{
			lblNewMedia.BackColor = Color.FromArgb(50, 50, 50);

			lblToolTip.Text = "Selects a new list of files, and clears the old list";
		}
		private void NewMedia_Leave(object sender, EventArgs e)
		{
			lblNewMedia.BackColor = Color.FromArgb(25, 25, 25);

			lblToolTip.Text = string.Empty;
		}
	}
}
