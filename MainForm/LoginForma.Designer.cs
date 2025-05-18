namespace View
{
	partial class LoginForma
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
			tbKorisnickoIme = new TextBox();
			tbLozinka = new TextBox();
			btnUloguj = new Button();
			pbShowPass = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pbShowPass).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(87, 94);
			label1.Name = "label1";
			label1.Size = new Size(109, 20);
			label1.TabIndex = 0;
			label1.Text = "Korisnicko ime:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(87, 164);
			label2.Name = "label2";
			label2.Size = new Size(62, 20);
			label2.TabIndex = 1;
			label2.Text = "Lozinka:";
			// 
			// tbKorisnickoIme
			// 
			tbKorisnickoIme.Location = new Point(201, 91);
			tbKorisnickoIme.Name = "tbKorisnickoIme";
			tbKorisnickoIme.Size = new Size(236, 27);
			tbKorisnickoIme.TabIndex = 2;
			// 
			// tbLozinka
			// 
			tbLozinka.Location = new Point(201, 161);
			tbLozinka.Name = "tbLozinka";
			tbLozinka.Size = new Size(236, 27);
			tbLozinka.TabIndex = 3;
			tbLozinka.UseSystemPasswordChar = true;
			// 
			// btnUloguj
			// 
			btnUloguj.Location = new Point(87, 275);
			btnUloguj.Name = "btnUloguj";
			btnUloguj.Size = new Size(94, 29);
			btnUloguj.TabIndex = 4;
			btnUloguj.Text = "Uloguj se";
			btnUloguj.UseVisualStyleBackColor = true;
			btnUloguj.Click += btnUloguj_Click;
			// 
			// pbShowPass
			// 
			pbShowPass.Image = Properties.Resources.icons8_closed_eye_50;
			pbShowPass.Location = new Point(443, 161);
			pbShowPass.Name = "pbShowPass";
			pbShowPass.Size = new Size(29, 27);
			pbShowPass.SizeMode = PictureBoxSizeMode.StretchImage;
			pbShowPass.TabIndex = 5;
			pbShowPass.TabStop = false;
			pbShowPass.Click += pbShowPass_Click;
			// 
			// LoginForma
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(608, 361);
			Controls.Add(pbShowPass);
			Controls.Add(btnUloguj);
			Controls.Add(tbLozinka);
			Controls.Add(tbKorisnickoIme);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "LoginForma";
			Text = "LoginForm";
			((System.ComponentModel.ISupportInitialize)pbShowPass).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox tbKorisnickoIme;
		private TextBox tbLozinka;
		private Button btnUloguj;
		private PictureBox pbShowPass;
	}
}