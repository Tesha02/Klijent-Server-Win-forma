namespace View
{
	partial class RadSaStrucnomSpremom
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
			dgvStrSprema = new DataGridView();
			tbPretraga = new TextBox();
			label1 = new Label();
			btnIzmeni = new Button();
			btnObrisi = new Button();
			((System.ComponentModel.ISupportInitialize)dgvStrSprema).BeginInit();
			SuspendLayout();
			// 
			// dgvStrSprema
			// 
			dgvStrSprema.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvStrSprema.Location = new Point(12, 212);
			dgvStrSprema.Name = "dgvStrSprema";
			dgvStrSprema.RowHeadersWidth = 51;
			dgvStrSprema.Size = new Size(431, 226);
			dgvStrSprema.TabIndex = 0;
			// 
			// tbPretraga
			// 
			tbPretraga.Location = new Point(12, 75);
			tbPretraga.Name = "tbPretraga";
			tbPretraga.Size = new Size(190, 27);
			tbPretraga.TabIndex = 1;
			tbPretraga.TextChanged += tbPretraga_TextChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 38);
			label1.Name = "label1";
			label1.Size = new Size(62, 20);
			label1.TabIndex = 2;
			label1.Text = "Pretrazi:";
			// 
			// btnIzmeni
			// 
			btnIzmeni.Location = new Point(449, 212);
			btnIzmeni.Name = "btnIzmeni";
			btnIzmeni.Size = new Size(94, 29);
			btnIzmeni.TabIndex = 3;
			btnIzmeni.Text = "Izmeni";
			btnIzmeni.UseVisualStyleBackColor = true;
			btnIzmeni.Click += btnIzmeni_Click;
			// 
			// btnObrisi
			// 
			btnObrisi.Location = new Point(449, 271);
			btnObrisi.Name = "btnObrisi";
			btnObrisi.Size = new Size(94, 29);
			btnObrisi.TabIndex = 4;
			btnObrisi.Text = "Obrisi";
			btnObrisi.UseVisualStyleBackColor = true;
			btnObrisi.Click += btnObrisi_Click;
			// 
			// RadSaStrucnomSpremom
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(555, 450);
			Controls.Add(btnObrisi);
			Controls.Add(btnIzmeni);
			Controls.Add(label1);
			Controls.Add(tbPretraga);
			Controls.Add(dgvStrSprema);
			Name = "RadSaStrucnomSpremom";
			Text = "RadSaStrucnomSpremom";
			((System.ComponentModel.ISupportInitialize)dgvStrSprema).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dgvStrSprema;
		private TextBox tbPretraga;
		private Label label1;
		private Button btnIzmeni;
		private Button btnObrisi;
	}
}