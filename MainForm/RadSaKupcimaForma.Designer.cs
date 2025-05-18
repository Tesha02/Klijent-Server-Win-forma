namespace View
{
	partial class RadSaKupcimaForma
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
			dgvKorisnici = new DataGridView();
			label1 = new Label();
			tbPretraga = new TextBox();
			btnDetalji = new Button();
			((System.ComponentModel.ISupportInitialize)dgvKorisnici).BeginInit();
			SuspendLayout();
			// 
			// dgvKorisnici
			// 
			dgvKorisnici.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvKorisnici.Location = new Point(12, 229);
			dgvKorisnici.Name = "dgvKorisnici";
			dgvKorisnici.RowHeadersWidth = 51;
			dgvKorisnici.Size = new Size(860, 355);
			dgvKorisnici.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(41, 44);
			label1.Name = "label1";
			label1.Size = new Size(68, 20);
			label1.TabIndex = 1;
			label1.Text = "Pretraga:";
			// 
			// tbPretraga
			// 
			tbPretraga.Location = new Point(41, 88);
			tbPretraga.Name = "tbPretraga";
			tbPretraga.Size = new Size(377, 27);
			tbPretraga.TabIndex = 2;
			tbPretraga.TextChanged += tbPretraga_TextChanged;
			// 
			// btnDetalji
			// 
			btnDetalji.Location = new Point(778, 86);
			btnDetalji.Name = "btnDetalji";
			btnDetalji.Size = new Size(94, 29);
			btnDetalji.TabIndex = 5;
			btnDetalji.Text = "Detalji";
			btnDetalji.UseVisualStyleBackColor = true;
			btnDetalji.Click += btnDetalji_Click;
			// 
			// RadSaKupcimaForma
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(936, 715);
			Controls.Add(btnDetalji);
			Controls.Add(tbPretraga);
			Controls.Add(label1);
			Controls.Add(dgvKorisnici);
			Name = "RadSaKupcimaForma";
			Text = "RadSaKupcimaForma";
			Load += RadSaKupcimaForma_Load;
			((System.ComponentModel.ISupportInitialize)dgvKorisnici).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dgvKorisnici;
		private Label label1;
		private TextBox tbPretraga;
		private Button btnDetalji;
	}
}