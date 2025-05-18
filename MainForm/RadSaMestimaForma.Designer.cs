namespace View
{
	partial class RadSaMestimaForma
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
			dgvMesta = new DataGridView();
			btnIzmeni = new Button();
			btnObrisi = new Button();
			tbPretrazi = new TextBox();
			label1 = new Label();
			((System.ComponentModel.ISupportInitialize)dgvMesta).BeginInit();
			SuspendLayout();
			// 
			// dgvMesta
			// 
			dgvMesta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvMesta.Location = new Point(12, 230);
			dgvMesta.Name = "dgvMesta";
			dgvMesta.RowHeadersWidth = 51;
			dgvMesta.Size = new Size(406, 315);
			dgvMesta.TabIndex = 0;
			dgvMesta.CellContentClick += dgvMesta_CellContentClick;
			// 
			// btnIzmeni
			// 
			btnIzmeni.Location = new Point(461, 230);
			btnIzmeni.Name = "btnIzmeni";
			btnIzmeni.Size = new Size(94, 29);
			btnIzmeni.TabIndex = 1;
			btnIzmeni.Text = "Izmeni";
			btnIzmeni.UseVisualStyleBackColor = true;
			btnIzmeni.Click += btnIzmeni_Click;
			// 
			// btnObrisi
			// 
			btnObrisi.Location = new Point(461, 277);
			btnObrisi.Name = "btnObrisi";
			btnObrisi.Size = new Size(94, 29);
			btnObrisi.TabIndex = 2;
			btnObrisi.Text = "Obrisi";
			btnObrisi.UseVisualStyleBackColor = true;
			btnObrisi.Click += btnObrisi_Click;
			// 
			// tbPretrazi
			// 
			tbPretrazi.Location = new Point(12, 93);
			tbPretrazi.Name = "tbPretrazi";
			tbPretrazi.Size = new Size(240, 27);
			tbPretrazi.TabIndex = 4;
			tbPretrazi.TextChanged += textBox1_TextChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 44);
			label1.Name = "label1";
			label1.Size = new Size(59, 20);
			label1.TabIndex = 5;
			label1.Text = "Pretrazi";
			// 
			// RadSaMestimaForma
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(575, 568);
			Controls.Add(label1);
			Controls.Add(tbPretrazi);
			Controls.Add(btnObrisi);
			Controls.Add(btnIzmeni);
			Controls.Add(dgvMesta);
			Name = "RadSaMestimaForma";
			Text = "RadSaMestimaForma";
			((System.ComponentModel.ISupportInitialize)dgvMesta).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dgvMesta;
		private Button btnIzmeni;
		private Button btnObrisi;
		private TextBox tbPretrazi;
		private Label label1;
	}
}