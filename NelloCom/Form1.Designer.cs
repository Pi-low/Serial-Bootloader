namespace NelloCom
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.cmbListSerial = new System.Windows.Forms.ComboBox();
			this.BtOuvrir = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// cmbListSerial
			// 
			this.cmbListSerial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbListSerial.FormattingEnabled = true;
			this.cmbListSerial.Location = new System.Drawing.Point(39, 25);
			this.cmbListSerial.Name = "cmbListSerial";
			this.cmbListSerial.Size = new System.Drawing.Size(121, 23);
			this.cmbListSerial.TabIndex = 0;
			// 
			// BtOuvrir
			// 
			this.BtOuvrir.Location = new System.Drawing.Point(209, 25);
			this.BtOuvrir.Name = "BtOuvrir";
			this.BtOuvrir.Size = new System.Drawing.Size(75, 23);
			this.BtOuvrir.TabIndex = 1;
			this.BtOuvrir.Text = "Ouvrir";
			this.BtOuvrir.UseVisualStyleBackColor = true;
			this.BtOuvrir.Click += new System.EventHandler(this.BtOuvrir_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.BtOuvrir);
			this.Controls.Add(this.cmbListSerial);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private ComboBox cmbListSerial;
		private Button BtOuvrir;
		private OpenFileDialog openFileDialog1;
	}
}