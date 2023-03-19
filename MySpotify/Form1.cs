using MySpotify;
using System.IO;
using System.Windows.Forms;

namespace MySpotify {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void buttonAddSong_Click(object sender, EventArgs e) {
			FormAddSong formAdd = new FormAddSong();
			formAdd.Show();
			Visible = false;
			ShowInTaskbar = false;
		}
	}
}