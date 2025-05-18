namespace View
{
	partial class KupacForma
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
			tbIme = new TextBox();
			tbPrezime = new TextBox();
			label2 = new Label();
			tbEmail = new TextBox();
			label3 = new Label();
			tbKontaktTelefon = new TextBox();
			label4 = new Label();
			btnSacuvaj = new Button();
			btnAzuriraj = new Button();
			label5 = new Label();
			cmbMesto = new ComboBox();
			btnDodajMesto = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(70, 9);
			label1.Name = "label1";
			label1.Size = new Size(37, 20);
			label1.TabIndex = 0;
			label1.Text = "Ime:";
			// 
			// tbIme
			// 
			tbIme.Location = new Point(70, 47);
			tbIme.Name = "tbIme";
			tbIme.Size = new Size(193, 27);
			tbIme.TabIndex = 1;
			// 
			// tbPrezime
			// 
			tbPrezime.Location = new Point(375, 47);
			tbPrezime.Name = "tbPrezime";
			tbPrezime.Size = new Size(193, 27);
			tbPrezime.TabIndex = 3;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(375, 9);
			label2.Name = "label2";
			label2.Size = new Size(65, 20);
			label2.TabIndex = 2;
			label2.Text = "Prezime:";
			// 
			// tbEmail
			// 
			tbEmail.Location = new Point(70, 151);
			tbEmail.Name = "tbEmail";
			tbEmail.Size = new Size(193, 27);
			tbEmail.TabIndex = 5;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(70, 116);
			label3.Name = "label3";
			label3.Size = new Size(49, 20);
			label3.TabIndex = 4;
			label3.Text = "Email:";
			label3.Click += label3_Click;
			// 
			// tbKontaktTelefon
			// 
			tbKontaktTelefon.Location = new Point(375, 151);
			tbKontaktTelefon.Name = "tbKontaktTelefon";
			tbKontaktTelefon.Size = new Size(193, 27);
			tbKontaktTelefon.TabIndex = 7;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(375, 116);
			label4.Name = "label4";
			label4.Size = new Size(116, 20);
			label4.TabIndex = 6;
			label4.Text = "Kontakt Telefon:";
			// 
			// btnSacuvaj
			// 
			btnSacuvaj.Location = new Point(71, 451);
			btnSacuvaj.Name = "btnSacuvaj";
			btnSacuvaj.Size = new Size(94, 29);
			btnSacuvaj.TabIndex = 8;
			btnSacuvaj.Text = "Sacuvaj";
			btnSacuvaj.UseVisualStyleBackColor = true;
			btnSacuvaj.Click += btnSacuvaj_Click;
			// 
			// btnAzuriraj
			// 
			btnAzuriraj.Location = new Point(475, 451);
			btnAzuriraj.Name = "btnAzuriraj";
			btnAzuriraj.Size = new Size(94, 29);
			btnAzuriraj.TabIndex = 10;
			btnAzuriraj.Text = "Azuriraj";
			btnAzuriraj.UseVisualStyleBackColor = true;
			btnAzuriraj.Click += btnAzuriraj_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(70, 211);
			label5.Name = "label5";
			label5.Size = new Size(53, 20);
			label5.TabIndex = 11;
			label5.Text = "Mesto:";
			// 
			// cmbMesto
			// 
			cmbMesto.FormattingEnabled = true;
			cmbMesto.Location = new Point(70, 255);
			cmbMesto.Name = "cmbMesto";
			cmbMesto.Size = new Size(151, 28);
			cmbMesto.TabIndex = 12;
			// 
			// btnDodajMesto
			// 
			btnDodajMesto.Location = new Point(241, 254);
			btnDodajMesto.Name = "btnDodajMesto";
			btnDodajMesto.Size = new Size(38, 29);
			btnDodajMesto.TabIndex = 13;
			btnDodajMesto.Text = "+";
			btnDodajMesto.UseVisualStyleBackColor = true;
			btnDodajMesto.Click += btnDodajMesto_Click;
			// 
			// KupacForma
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(640, 523);
			Controls.Add(btnDodajMesto);
			Controls.Add(cmbMesto);
			Controls.Add(label5);
			Controls.Add(btnAzuriraj);
			Controls.Add(btnSacuvaj);
			Controls.Add(tbKontaktTelefon);
			Controls.Add(label4);
			Controls.Add(tbEmail);
			Controls.Add(label3);
			Controls.Add(tbPrezime);
			Controls.Add(label2);
			Controls.Add(tbIme);
			Controls.Add(label1);
			Name = "KupacForma";
			Text = "DodajKupcaForma";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox tbIme;
		private TextBox tbPrezime;
		private Label label2;
		private TextBox tbEmail;
		private Label label3;
		private TextBox tbKontaktTelefon;
		private Label label4;
		private Button btnSacuvaj;
		private Button btnAzuriraj;
		private Label label5;
		private ComboBox cmbMesto;
		private Button btnDodajMesto;
	}
}