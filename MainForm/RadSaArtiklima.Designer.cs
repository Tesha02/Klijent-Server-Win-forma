namespace View
{
	partial class RadSaArtiklima
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
			tbPretraga = new TextBox();
			cmbPretragaPoTipu = new ComboBox();
			dgvArtikli = new DataGridView();
			btnDetalji = new Button();
			((System.ComponentModel.ISupportInitialize)dgvArtikli).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(55, 30);
			label1.Name = "label1";
			label1.Size = new Size(65, 20);
			label1.TabIndex = 0;
			label1.Text = "Pretraga";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(55, 117);
			label2.Name = "label2";
			label2.Size = new Size(120, 20);
			label2.TabIndex = 1;
			label2.Text = "Pretraga po tipu:";
			// 
			// tbPretraga
			// 
			tbPretraga.Location = new Point(55, 62);
			tbPretraga.Name = "tbPretraga";
			tbPretraga.Size = new Size(266, 27);
			tbPretraga.TabIndex = 2;
			tbPretraga.TextChanged += tbPretraga_TextChanged;
			// 
			// cmbPretragaPoTipu
			// 
			cmbPretragaPoTipu.FormattingEnabled = true;
			cmbPretragaPoTipu.Location = new Point(55, 159);
			cmbPretragaPoTipu.Name = "cmbPretragaPoTipu";
			cmbPretragaPoTipu.Size = new Size(151, 28);
			cmbPretragaPoTipu.TabIndex = 3;
			cmbPretragaPoTipu.SelectedIndexChanged += cmbPretragaPoTipu_SelectedIndexChanged;
			// 
			// dgvArtikli
			// 
			dgvArtikli.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvArtikli.Location = new Point(55, 234);
			dgvArtikli.Name = "dgvArtikli";
			dgvArtikli.RowHeadersWidth = 51;
			dgvArtikli.Size = new Size(672, 285);
			dgvArtikli.TabIndex = 4;
			// 
			// btnDetalji
			// 
			btnDetalji.Location = new Point(619, 61);
			btnDetalji.Name = "btnDetalji";
			btnDetalji.Size = new Size(94, 29);
			btnDetalji.TabIndex = 5;
			btnDetalji.Text = "Detalji";
			btnDetalji.UseVisualStyleBackColor = true;
			btnDetalji.Click += btnDetalji_Click;
			// 
			// RadSaArtiklima
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 531);
			Controls.Add(btnDetalji);
			Controls.Add(dgvArtikli);
			Controls.Add(cmbPretragaPoTipu);
			Controls.Add(tbPretraga);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "RadSaArtiklima";
			Text = "RadSaArtiklima";
			((System.ComponentModel.ISupportInitialize)dgvArtikli).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox tbPretraga;
		private ComboBox cmbPretragaPoTipu;
		private DataGridView dgvArtikli;
		private Button btnDetalji;
	}
}