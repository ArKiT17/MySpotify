namespace MySpotify {
	partial class FormAddSong {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddSong));
			this.buttonAddSong = new System.Windows.Forms.Button();
			this.buttonMySongs = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonAddSong
			// 
			this.buttonAddSong.BackColor = System.Drawing.Color.Black;
			this.buttonAddSong.FlatAppearance.BorderSize = 0;
			this.buttonAddSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAddSong.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.buttonAddSong.ForeColor = System.Drawing.Color.White;
			this.buttonAddSong.Location = new System.Drawing.Point(64, 96);
			this.buttonAddSong.Name = "buttonAddSong";
			this.buttonAddSong.Size = new System.Drawing.Size(112, 48);
			this.buttonAddSong.TabIndex = 11;
			this.buttonAddSong.Text = "Add song";
			this.buttonAddSong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonAddSong.UseVisualStyleBackColor = false;
			// 
			// buttonMySongs
			// 
			this.buttonMySongs.BackColor = System.Drawing.Color.Black;
			this.buttonMySongs.FlatAppearance.BorderSize = 0;
			this.buttonMySongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonMySongs.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.buttonMySongs.ForeColor = System.Drawing.Color.White;
			this.buttonMySongs.Location = new System.Drawing.Point(32, 48);
			this.buttonMySongs.Name = "buttonMySongs";
			this.buttonMySongs.Size = new System.Drawing.Size(112, 48);
			this.buttonMySongs.TabIndex = 10;
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
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
			this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(216, 240);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(201, 72);
			this.label1.TabIndex = 13;
			this.label1.Text = "Drop file\r\nor click here\r\n";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(0, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(632, 576);
			this.pictureBox2.TabIndex = 12;
			this.pictureBox2.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.AllowDrop = true;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Location = new System.Drawing.Point(416, 40);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(632, 576);
			this.panel1.TabIndex = 14;
			this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormAddSong_DragDrop);
			this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormAddSong_DragEnter);
			this.panel1.DragLeave += new System.EventHandler(this.FormAddSong_DragLeave);
			// 
			// FormAddSong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1407, 744);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.buttonAddSong);
			this.Controls.Add(this.buttonMySongs);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormAddSong";
			this.Text = "Spotify";
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormAddSong_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormAddSong_DragEnter);
			this.DragLeave += new System.EventHandler(this.FormAddSong_DragLeave);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Button buttonAddSong;
		private Button buttonMySongs;
		private PictureBox pictureBox1;
		private OpenFileDialog openFileDialog1;
		private Label label1;
		private PictureBox pictureBox2;
		private Panel panel1;
	}
}