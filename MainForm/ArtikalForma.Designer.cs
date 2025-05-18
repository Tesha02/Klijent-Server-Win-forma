namespace View
{
	partial class ArtikalForma
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
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			tbNaziv = new TextBox();
			tbCena = new TextBox();
			cmbTip = new ComboBox();
			btnSacuvaj = new Button();
			btnAzuriraj = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(73, 9);
			label1.Name = "label1";
			label1.Size = new Size(46, 20);
			label1.TabIndex = 0;
			label1.Text = "Naziv";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(73, 102);
			label2.Name = "label2";
			label2.Size = new Size(42, 20);
			label2.TabIndex = 1;
			label2.Text = "Cena";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(73, 195);
			label3.Name = "label3";
			label3.Size = new Size(30, 20);
			label3.TabIndex = 2;
			label3.Text = "Tip";
			// 
			// tbNaziv
			// 
			tbNaziv.Location = new Point(73, 49);
			tbNaziv.Name = "tbNaziv";
			tbNaziv.Size = new Size(329, 27);
			tbNaziv.TabIndex = 3;
			// 
			// tbCena
			// 
			tbCena.Location = new Point(73, 145);
			tbCena.Name = "tbCena";
			tbCena.Size = new Size(329, 27);
			tbCena.TabIndex = 4;
			// 
			// cmbTip
			// 
			cmbTip.FormattingEnabled = true;
			cmbTip.Location = new Point(73, 237);
			cmbTip.Name = "cmbTip";
			cmbTip.Size = new Size(329, 28);
			cmbTip.TabIndex = 5;
			// 
			// btnSacuvaj
			// 
			btnSacuvaj.Location = new Point(29, 367);
			btnSacuvaj.Name = "btnSacuvaj";
			btnSacuvaj.Size = new Size(94, 29);
			btnSacuvaj.TabIndex = 6;
			btnSacuvaj.Text = "Sacuvaj";
			btnSacuvaj.UseVisualStyleBackColor = true;
			btnSacuvaj.Click += btnSacuvaj_Click;
			// 
			// btnAzuriraj
			// 
			btnAzuriraj.Location = new Point(438, 367);
			btnAzuriraj.Name = "btnAzuriraj";
			btnAzuriraj.Size = new Size(94, 29);
			btnAzuriraj.TabIndex = 7;
			btnAzuriraj.Text = "Azuriraj";
			btnAzuriraj.UseVisualStyleBackColor = true;
			btnAzuriraj.Click += btnAzuriraj_Click;
			// 
			// ArtikalForma
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(563, 426);
			Controls.Add(btnAzuriraj);
			Controls.Add(btnSacuvaj);
			Controls.Add(cmbTip);
			Controls.Add(tbCena);
			Controls.Add(tbNaziv);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "ArtikalForma";
			Text = "ArtikalForma";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private TextBox tbNaziv;
		private TextBox tbCena;
		private ComboBox cmbTip;
		private Button btnSacuvaj;
		private Button btnAzuriraj;
	}
}