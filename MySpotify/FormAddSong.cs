using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace MySpotify {
	public partial class FormAddSong : Form {
		public FormAddSong() {
			InitializeComponent();
		}

		private void buttonMySongs_Click(object sender, EventArgs e) {
			Close();

		}

		private void label1_Click(object sender, EventArgs e) {
			openFileDialog1 = new OpenFileDialog();
			openFileDialog1.Filter = "Music files (*.mp3)|*.mp3";
			openFileDialog1.ShowDialog();
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
				File.Copy(openFileDialog1.FileName, @"Songs\" + openFileDialog1.SafeFileName);
		}

		private void FormAddSong_DragDrop(object sender, DragEventArgs e) {
			List<string> paths = new List<string>();
			foreach (string obj in (string[])e.Data.GetData(DataFormats.FileDrop))
				if (Directory.Exists(obj))
					paths.AddRange(Directory.GetFiles(obj, "*.mp3", SearchOption.AllDirectories));
				else {
					string tmp = @"Songs\" + obj.Substring(obj.LastIndexOf('\\') + 1);
					string newline = "";
					foreach (char symbol in tmp) {
						if (symbol == ' ')
							newline += '_';
						else
							newline += symbol;
					}
					File.Copy(obj, newline);
				}
		}

		private void FormAddSong_DragEnter(object sender, DragEventArgs e) {
			if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
				label1.Text = "Put it";
				e.Effect = DragDropEffects.Copy;
			}
		}

		private void FormAddSong_DragLeave(object sender, EventArgs e) {
			label1.Text = "Drop file\r\nor click here\r\n";
		}
	}
}
