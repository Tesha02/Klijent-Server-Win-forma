namespace View
{
	partial class MestoForma
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
			tbPtt = new TextBox();
			tbNaziv = new TextBox();
			btnDodajMesto = new Button();
			btnIzmeni = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(75, 68);
			label1.Name = "label1";
			label1.Size = new Size(30, 20);
			label1.TabIndex = 0;
			label1.Text = "Ptt:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(75, 152);
			label2.Name = "label2";
			label2.Size = new Size(49, 20);
			label2.TabIndex = 1;
			label2.Text = "Naziv:";
			// 
			// tbPtt
			// 
			tbPtt.Location = new Point(148, 65);
			tbPtt.Name = "tbPtt";
			tbPtt.Size = new Size(175, 27);
			tbPtt.TabIndex = 2;
			// 
			// tbNaziv
			// 
			tbNaziv.Location = new Point(148, 149);
			tbNaziv.Name = "tbNaziv";
			tbNaziv.Size = new Size(175, 27);
			tbNaziv.TabIndex = 3;
			// 
			// btnDodajMesto
			// 
			btnDodajMesto.Location = new Point(161, 254);
			btnDodajMesto.Name = "btnDodajMesto";
			btnDodajMesto.Size = new Size(113, 29);
			btnDodajMesto.TabIndex = 4;
			btnDodajMesto.Text = "Dodaj mesto";
			btnDodajMesto.UseVisualStyleBackColor = true;
			btnDodajMesto.Click += btnDodajMesto_Click;
			// 
			// btnIzmeni
			// 
			btnIzmeni.Location = new Point(161, 254);
			btnIzmeni.Name = "btnIzmeni";
			btnIzmeni.Size = new Size(113, 29);
			btnIzmeni.TabIndex = 5;
			btnIzmeni.Text = "Izmeni mesto";
			btnIzmeni.UseVisualStyleBackColor = true;
			btnIzmeni.Click += btnIzmeni_Click;
			// 
			// MestoForma
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(418, 348);
			Controls.Add(btnIzmeni);
			Controls.Add(btnDodajMesto);
			Controls.Add(tbNaziv);
			Controls.Add(tbPtt);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "MestoForma";
			Text = "MestoForma";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox tbPtt;
		private TextBox tbNaziv;
		private Button btnDodajMesto;
		private Button btnIzmeni;
	}
}