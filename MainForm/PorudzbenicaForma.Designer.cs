namespace View
{
	partial class PorudzbenicaForma
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
			lblRadnik = new Label();
			label4 = new Label();
			cmbKupac = new ComboBox();
			btnObrisiStavku = new Button();
			label5 = new Label();
			label6 = new Label();
			dtpDatumOd = new DateTimePicker();
			dtpDatumDo = new DateTimePicker();
			panel1 = new Panel();
			btnDodajStavku = new Button();
			tbIznosArtikla = new TextBox();
			tbUkupnaCena = new TextBox();
			tbKolicina = new TextBox();
			cmbArtikal = new ComboBox();
			label10 = new Label();
			label9 = new Label();
			label8 = new Label();
			label7 = new Label();
			dgvStavke = new DataGridView();
			btnSacuvaj = new Button();
			label3 = new Label();
			tbUkupnaVrednost = new TextBox();
			btnAzuriraj = new Button();
			Artikal = new DataGridViewTextBoxColumn();
			CenaArtikla = new DataGridViewTextBoxColumn();
			Kolicina = new DataGridViewTextBoxColumn();
			UkupnaCena = new DataGridViewTextBoxColumn();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvStavke).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(41, 28);
			label1.Name = "label1";
			label1.Size = new Size(53, 20);
			label1.TabIndex = 0;
			label1.Text = "Kupac:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(41, 124);
			label2.Name = "label2";
			label2.Size = new Size(57, 20);
			label2.TabIndex = 1;
			label2.Text = "Radnik:";
			// 
			// lblRadnik
			// 
			lblRadnik.AutoSize = true;
			lblRadnik.Location = new Point(41, 170);
			lblRadnik.Name = "lblRadnik";
			lblRadnik.Size = new Size(50, 20);
			lblRadnik.TabIndex = 2;
			lblRadnik.Text = "label3";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(38, 160);
			label4.Name = "label4";
			label4.Size = new Size(97, 20);
			label4.TabIndex = 3;
			label4.Text = "Ukupna cena:";
			// 
			// cmbKupac
			// 
			cmbKupac.FormattingEnabled = true;
			cmbKupac.Location = new Point(41, 72);
			cmbKupac.Name = "cmbKupac";
			cmbKupac.Size = new Size(151, 28);
			cmbKupac.TabIndex = 4;
			// 
			// btnObrisiStavku
			// 
			btnObrisiStavku.Location = new Point(41, 286);
			btnObrisiStavku.Name = "btnObrisiStavku";
			btnObrisiStavku.Size = new Size(121, 29);
			btnObrisiStavku.TabIndex = 5;
			btnObrisiStavku.Text = "Obrisi stavku";
			btnObrisiStavku.UseVisualStyleBackColor = true;
			btnObrisiStavku.Click += btnObrisiStavku_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(269, 28);
			label5.Name = "label5";
			label5.Size = new Size(79, 20);
			label5.TabIndex = 6;
			label5.Text = "Datum od:";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(269, 124);
			label6.Name = "label6";
			label6.Size = new Size(79, 20);
			label6.TabIndex = 7;
			label6.Text = "Datum do:";
			// 
			// dtpDatumOd
			// 
			dtpDatumOd.Location = new Point(269, 70);
			dtpDatumOd.Name = "dtpDatumOd";
			dtpDatumOd.Size = new Size(250, 27);
			dtpDatumOd.TabIndex = 8;
			// 
			// dtpDatumDo
			// 
			dtpDatumDo.Location = new Point(269, 163);
			dtpDatumDo.Name = "dtpDatumDo";
			dtpDatumDo.Size = new Size(250, 27);
			dtpDatumDo.TabIndex = 9;
			// 
			// panel1
			// 
			panel1.Controls.Add(btnDodajStavku);
			panel1.Controls.Add(tbIznosArtikla);
			panel1.Controls.Add(tbUkupnaCena);
			panel1.Controls.Add(tbKolicina);
			panel1.Controls.Add(cmbArtikal);
			panel1.Controls.Add(label10);
			panel1.Controls.Add(label9);
			panel1.Controls.Add(label8);
			panel1.Controls.Add(label4);
			panel1.Location = new Point(574, 61);
			panel1.Name = "panel1";
			panel1.Size = new Size(438, 254);
			panel1.TabIndex = 10;
			// 
			// btnDodajStavku
			// 
			btnDodajStavku.Location = new Point(308, 225);
			btnDodajStavku.Name = "btnDodajStavku";
			btnDodajStavku.Size = new Size(111, 29);
			btnDodajStavku.TabIndex = 7;
			btnDodajStavku.Text = "Dodaj stavku";
			btnDodajStavku.UseVisualStyleBackColor = true;
			btnDodajStavku.Click += btnDodajStavku_Click;
			// 
			// tbIznosArtikla
			// 
			tbIznosArtikla.Location = new Point(141, 115);
			tbIznosArtikla.Name = "tbIznosArtikla";
			tbIznosArtikla.Size = new Size(209, 27);
			tbIznosArtikla.TabIndex = 6;
			tbIznosArtikla.TextChanged += tbIznosArtikla_TextChanged;
			// 
			// tbUkupnaCena
			// 
			tbUkupnaCena.Location = new Point(141, 157);
			tbUkupnaCena.Name = "tbUkupnaCena";
			tbUkupnaCena.Size = new Size(209, 27);
			tbUkupnaCena.TabIndex = 12;
			tbUkupnaCena.TextChanged += tbUkupnaCena_TextChanged;
			// 
			// tbKolicina
			// 
			tbKolicina.Location = new Point(141, 72);
			tbKolicina.Name = "tbKolicina";
			tbKolicina.Size = new Size(209, 27);
			tbKolicina.TabIndex = 5;
			tbKolicina.TextChanged += tbKolicina_TextChanged;
			// 
			// cmbArtikal
			// 
			cmbArtikal.FormattingEnabled = true;
			cmbArtikal.Location = new Point(141, 31);
			cmbArtikal.Name = "cmbArtikal";
			cmbArtikal.Size = new Size(284, 28);
			cmbArtikal.TabIndex = 4;
			cmbArtikal.SelectedIndexChanged += cmbArtikal_SelectedIndexChanged;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(38, 118);
			label10.Name = "label10";
			label10.Size = new Size(90, 20);
			label10.TabIndex = 2;
			label10.Text = "Cena artikla:";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(38, 75);
			label9.Name = "label9";
			label9.Size = new Size(65, 20);
			label9.TabIndex = 1;
			label9.Text = "Kolicina:";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(38, 31);
			label8.Name = "label8";
			label8.Size = new Size(55, 20);
			label8.TabIndex = 0;
			label8.Text = "Artikal:";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(585, 49);
			label7.Name = "label7";
			label7.Size = new Size(52, 20);
			label7.TabIndex = 11;
			label7.Text = "Stavka";
			// 
			// dgvStavke
			// 
			dgvStavke.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvStavke.Columns.AddRange(new DataGridViewColumn[] { Artikal, CenaArtikla, Kolicina, UkupnaCena });
			dgvStavke.Location = new Point(19, 352);
			dgvStavke.Name = "dgvStavke";
			dgvStavke.ReadOnly = true;
			dgvStavke.RowHeadersWidth = 51;
			dgvStavke.Size = new Size(993, 340);
			dgvStavke.TabIndex = 13;
			dgvStavke.CellContentClick += dgvStavke_CellContentClick;
			// 
			// btnSacuvaj
			// 
			btnSacuvaj.Location = new Point(1029, 663);
			btnSacuvaj.Name = "btnSacuvaj";
			btnSacuvaj.Size = new Size(94, 29);
			btnSacuvaj.TabIndex = 14;
			btnSacuvaj.Text = "Sacuvaj";
			btnSacuvaj.UseVisualStyleBackColor = true;
			btnSacuvaj.Click += btnSacuvaj_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(41, 238);
			label3.Name = "label3";
			label3.Size = new Size(123, 20);
			label3.TabIndex = 13;
			label3.Text = "Ukupna vrednost:";
			// 
			// tbUkupnaVrednost
			// 
			tbUkupnaVrednost.Location = new Point(170, 235);
			tbUkupnaVrednost.Name = "tbUkupnaVrednost";
			tbUkupnaVrednost.Size = new Size(209, 27);
			tbUkupnaVrednost.TabIndex = 13;
			// 
			// btnAzuriraj
			// 
			btnAzuriraj.Location = new Point(1029, 663);
			btnAzuriraj.Name = "btnAzuriraj";
			btnAzuriraj.Size = new Size(94, 29);
			btnAzuriraj.TabIndex = 15;
			btnAzuriraj.Text = "Azuriraj";
			btnAzuriraj.UseVisualStyleBackColor = true;
			btnAzuriraj.Click += btnAzuriraj_Click;
			// 
			// Artikal
			// 
			Artikal.HeaderText = "Artikal";
			Artikal.MinimumWidth = 6;
			Artikal.Name = "Artikal";
			Artikal.ReadOnly = true;
			Artikal.Width = 125;
			// 
			// CenaArtikla
			// 
			CenaArtikla.HeaderText = "Cena artikla";
			CenaArtikla.MinimumWidth = 6;
			CenaArtikla.Name = "CenaArtikla";
			CenaArtikla.ReadOnly = true;
			CenaArtikla.Width = 125;
			// 
			// Kolicina
			// 
			Kolicina.HeaderText = "Kolicina";
			Kolicina.MinimumWidth = 6;
			Kolicina.Name = "Kolicina";
			Kolicina.ReadOnly = true;
			Kolicina.Width = 125;
			// 
			// UkupnaCena
			// 
			UkupnaCena.HeaderText = "Ukupna cena";
			UkupnaCena.MinimumWidth = 6;
			UkupnaCena.Name = "UkupnaCena";
			UkupnaCena.ReadOnly = true;
			UkupnaCena.Width = 125;
			// 
			// PorudzbenicaForma
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1135, 731);
			Controls.Add(btnAzuriraj);
			Controls.Add(tbUkupnaVrednost);
			Controls.Add(label3);
			Controls.Add(btnSacuvaj);
			Controls.Add(dgvStavke);
			Controls.Add(label7);
			Controls.Add(panel1);
			Controls.Add(dtpDatumDo);
			Controls.Add(dtpDatumOd);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(btnObrisiStavku);
			Controls.Add(cmbKupac);
			Controls.Add(lblRadnik);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "PorudzbenicaForma";
			Text = "PorudzbenicaForma";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgvStavke).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label lblRadnik;
		private Label label4;
		private ComboBox cmbKupac;
		private Button btnObrisiStavku;
		private Label label5;
		private Label label6;
		private DateTimePicker dtpDatumOd;
		private DateTimePicker dtpDatumDo;
		private Panel panel1;
		private ComboBox cmbArtikal;
		private Label label10;
		private Label label9;
		private Label label8;
		private Label label7;
		private Button btnDodajStavku;
		private TextBox tbIznosArtikla;
		private TextBox tbKolicina;
		private TextBox tbUkupnaCena;
		private DataGridView dgvStavke;
		private Button btnSacuvaj;
		private Label label3;
		private TextBox tbUkupnaVrednost;
		private Button btnAzuriraj;
		private DataGridViewTextBoxColumn Artikal;
		private DataGridViewTextBoxColumn CenaArtikla;
		private DataGridViewTextBoxColumn Kolicina;
		private DataGridViewTextBoxColumn UkupnaCena;
	}
}