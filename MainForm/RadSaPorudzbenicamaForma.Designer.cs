namespace View
{
	partial class RadSaPorudzbenicamaForma
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
			cmbKupac = new ComboBox();
			dgvPorudzbenice = new DataGridView();
			btnDetalji = new Button();
			btnIzbrisi = new Button();
			btnPrikaziSve = new Button();
			((System.ComponentModel.ISupportInitialize)dgvPorudzbenice).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 48);
			label1.Name = "label1";
			label1.Size = new Size(50, 20);
			label1.TabIndex = 0;
			label1.Text = "Kupac";
			// 
			// cmbKupac
			// 
			cmbKupac.FormattingEnabled = true;
			cmbKupac.Location = new Point(68, 45);
			cmbKupac.Name = "cmbKupac";
			cmbKupac.Size = new Size(330, 28);
			cmbKupac.TabIndex = 1;
			cmbKupac.SelectedIndexChanged += cmbKupac_SelectedIndexChanged;
			// 
			// dgvPorudzbenice
			// 
			dgvPorudzbenice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvPorudzbenice.Location = new Point(12, 134);
			dgvPorudzbenice.Name = "dgvPorudzbenice";
			dgvPorudzbenice.RowHeadersWidth = 51;
			dgvPorudzbenice.Size = new Size(839, 352);
			dgvPorudzbenice.TabIndex = 2;
			// 
			// btnDetalji
			// 
			btnDetalji.Location = new Point(857, 413);
			btnDetalji.Name = "btnDetalji";
			btnDetalji.Size = new Size(94, 29);
			btnDetalji.TabIndex = 3;
			btnDetalji.Text = "Detalji";
			btnDetalji.UseVisualStyleBackColor = true;
			btnDetalji.Click += btnDetalji_Click;
			// 
			// btnIzbrisi
			// 
			btnIzbrisi.Location = new Point(857, 457);
			btnIzbrisi.Name = "btnIzbrisi";
			btnIzbrisi.Size = new Size(94, 29);
			btnIzbrisi.TabIndex = 4;
			btnIzbrisi.Text = "Izbrisi";
			btnIzbrisi.UseVisualStyleBackColor = true;
			btnIzbrisi.Click += btnIzbrisi_Click;
			// 
			// btnPrikaziSve
			// 
			btnPrikaziSve.Location = new Point(765, 39);
			btnPrikaziSve.Name = "btnPrikaziSve";
			btnPrikaziSve.Size = new Size(186, 29);
			btnPrikaziSve.TabIndex = 5;
			btnPrikaziSve.Text = "Prikazi sve porudzbenice";
			btnPrikaziSve.UseVisualStyleBackColor = true;
			btnPrikaziSve.Click += btnPrikaziSve_Click;
			// 
			// RadSaPorudzbenicamaForma
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(963, 512);
			Controls.Add(btnPrikaziSve);
			Controls.Add(btnIzbrisi);
			Controls.Add(btnDetalji);
			Controls.Add(dgvPorudzbenice);
			Controls.Add(cmbKupac);
			Controls.Add(label1);
			Name = "RadSaPorudzbenicamaForma";
			Text = "RadSaPorudzbenicamaForma";
			((System.ComponentModel.ISupportInitialize)dgvPorudzbenice).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private ComboBox cmbKupac;
		private DataGridView dgvPorudzbenice;
		private Button btnDetalji;
		private Button btnIzbrisi;
		private Button btnPrikaziSve;
	}
}