namespace MySpotify {
	partial class Form1 {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.buttonAddSong = new System.Windows.Forms.Button();
			this.buttonMySongs = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonAddSong
			// 
			this.buttonAddSong.BackColor = System.Drawing.Color.Black;
			this.buttonAddSong.FlatAppearance.BorderSize = 0;
			this.buttonAddSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAddSong.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.buttonAddSong.ForeColor = System.Drawing.Color.White;
			this.buttonAddSong.Location = new System.Drawing.Point(32, 96);
			this.buttonAddSong.Name = "buttonAddSong";
			this.buttonAddSong.Size = new System.Drawing.Size(112, 48);
			this.buttonAddSong.TabIndex = 3;
			this.buttonAddSong.Text = "Add song";
			this.buttonAddSong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonAddSong.UseVisualStyleBackColor = false;
			this.buttonAddSong.Click += new System.EventHandler(this.buttonAddSong_Click);
			// 
			// buttonMySongs
			// 
			this.buttonMySongs.BackColor = System.Drawing.Color.Black;
			this.buttonMySongs.FlatAppearance.BorderSize = 0;
			this.buttonMySongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonMySongs.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.buttonMySongs.ForeColor = System.Drawing.Color.White;
			this.buttonMySongs.Location = new System.Drawing.Point(64, 48);
			this.buttonMySongs.Name = "buttonMySongs";
			this.buttonMySongs.Size = new System.Drawing.Size(112, 48);
			this.buttonMySongs.TabIndex = 1;
			this.buttonMySongs.Text = "My Songs";
			this.buttonMySongs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonMySongs.UseVisualStyleBackColor = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1407, 744);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1407, 744);
			this.Controls.Add(this.buttonAddSong);
			this.Controls.Add(this.buttonMySongs);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Spotify";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Button buttonAddSong;
		private Button buttonMySongs;
		private PictureBox pictureBox1;
		private OpenFileDialog openFileDialog1;
	}
}