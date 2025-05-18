namespace MainForm
{
	partial class GlavnaForma
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			menuStrip1 = new MenuStrip();
			kupacToolStripMenuItem = new ToolStripMenuItem();
			dodajKupcaToolStripMenuItem = new ToolStripMenuItem();
			radSaKupcimaToolStripMenuItem = new ToolStripMenuItem();
			artikaToolStripMenuItem = new ToolStripMenuItem();
			dodajArtikalToolStripMenuItem = new ToolStripMenuItem();
			radSaArtiklimaToolStripMenuItem = new ToolStripMenuItem();
			porudzbenicaToolStripMenuItem = new ToolStripMenuItem();
			dodajPorudzbenicuToolStripMenuItem = new ToolStripMenuItem();
			radSaPorudzbenicamaToolStripMenuItem = new ToolStripMenuItem();
			preporukaToolStripMenuItem = new ToolStripMenuItem();
			dodajMestoToolStripMenuItem = new ToolStripMenuItem();
			radSaMestimaToolStripMenuItem = new ToolStripMenuItem();
			pomocToolStripMenuItem = new ToolStripMenuItem();
			label1 = new Label();
			lblRadnik = new Label();
			dodajStrucnuSpremuToolStripMenuItem = new ToolStripMenuItem();
			radSaStrucnomSpremomToolStripMenuItem = new ToolStripMenuItem();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { kupacToolStripMenuItem, artikaToolStripMenuItem, porudzbenicaToolStripMenuItem, preporukaToolStripMenuItem, pomocToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(800, 28);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// kupacToolStripMenuItem
			// 
			kupacToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dodajKupcaToolStripMenuItem, radSaKupcimaToolStripMenuItem });
			kupacToolStripMenuItem.Name = "kupacToolStripMenuItem";
			kupacToolStripMenuItem.Size = new Size(64, 24);
			kupacToolStripMenuItem.Text = "Kupac";
			// 
			// dodajKupcaToolStripMenuItem
			// 
			dodajKupcaToolStripMenuItem.Name = "dodajKupcaToolStripMenuItem";
			dodajKupcaToolStripMenuItem.Size = new Size(196, 26);
			dodajKupcaToolStripMenuItem.Text = "Dodaj kupca";
			dodajKupcaToolStripMenuItem.Click += dodajKupcaToolStripMenuItem_Click;
			// 
			// radSaKupcimaToolStripMenuItem
			// 
			radSaKupcimaToolStripMenuItem.Name = "radSaKupcimaToolStripMenuItem";
			radSaKupcimaToolStripMenuItem.Size = new Size(196, 26);
			radSaKupcimaToolStripMenuItem.Text = "Rad sa kupcima";
			radSaKupcimaToolStripMenuItem.Click += radSaKupcimaToolStripMenuItem_Click;
			// 
			// artikaToolStripMenuItem
			// 
			artikaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dodajArtikalToolStripMenuItem, radSaArtiklimaToolStripMenuItem });
			artikaToolStripMenuItem.Name = "artikaToolStripMenuItem";
			artikaToolStripMenuItem.Size = new Size(66, 24);
			artikaToolStripMenuItem.Text = "Artikal";
			// 
			// dodajArtikalToolStripMenuItem
			// 
			dodajArtikalToolStripMenuItem.Name = "dodajArtikalToolStripMenuItem";
			dodajArtikalToolStripMenuItem.Size = new Size(198, 26);
			dodajArtikalToolStripMenuItem.Text = "Dodaj artikal";
			dodajArtikalToolStripMenuItem.Click += dodajArtikalToolStripMenuItem_Click;
			// 
			// radSaArtiklimaToolStripMenuItem
			// 
			radSaArtiklimaToolStripMenuItem.Name = "radSaArtiklimaToolStripMenuItem";
			radSaArtiklimaToolStripMenuItem.Size = new Size(198, 26);
			radSaArtiklimaToolStripMenuItem.Text = "Rad sa artiklima";
			radSaArtiklimaToolStripMenuItem.Click += radSaArtiklimaToolStripMenuItem_Click;
			// 
			// porudzbenicaToolStripMenuItem
			// 
			porudzbenicaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dodajPorudzbenicuToolStripMenuItem, radSaPorudzbenicamaToolStripMenuItem });
			porudzbenicaToolStripMenuItem.Name = "porudzbenicaToolStripMenuItem";
			porudzbenicaToolStripMenuItem.Size = new Size(112, 24);
			porudzbenicaToolStripMenuItem.Text = "Porudzbenica";
			// 
			// dodajPorudzbenicuToolStripMenuItem
			// 
			dodajPorudzbenicuToolStripMenuItem.Name = "dodajPorudzbenicuToolStripMenuItem";
			dodajPorudzbenicuToolStripMenuItem.Size = new Size(252, 26);
			dodajPorudzbenicuToolStripMenuItem.Text = "Dodaj porudzbenicu";
			dodajPorudzbenicuToolStripMenuItem.Click += dodajPorudzbenicuToolStripMenuItem_Click;
			// 
			// radSaPorudzbenicamaToolStripMenuItem
			// 
			radSaPorudzbenicamaToolStripMenuItem.Name = "radSaPorudzbenicamaToolStripMenuItem";
			radSaPorudzbenicamaToolStripMenuItem.Size = new Size(252, 26);
			radSaPorudzbenicamaToolStripMenuItem.Text = "Rad sa porudzbenicama";
			radSaPorudzbenicamaToolStripMenuItem.Click += radSaPorudzbenicamaToolStripMenuItem_Click;
			// 
			// preporukaToolStripMenuItem
			// 
			preporukaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dodajMestoToolStripMenuItem, radSaMestimaToolStripMenuItem });
			preporukaToolStripMenuItem.Name = "preporukaToolStripMenuItem";
			preporukaToolStripMenuItem.Size = new Size(64, 24);
			preporukaToolStripMenuItem.Text = "Mesto";
			preporukaToolStripMenuItem.Click += preporukaToolStripMenuItem_Click;
			// 
			// dodajMestoToolStripMenuItem
			// 
			dodajMestoToolStripMenuItem.Name = "dodajMestoToolStripMenuItem";
			dodajMestoToolStripMenuItem.Size = new Size(197, 26);
			dodajMestoToolStripMenuItem.Text = "Dodaj mesto";
			dodajMestoToolStripMenuItem.Click += dodajMestoToolStripMenuItem_Click;
			// 
			// radSaMestimaToolStripMenuItem
			// 
			radSaMestimaToolStripMenuItem.Name = "radSaMestimaToolStripMenuItem";
			radSaMestimaToolStripMenuItem.Size = new Size(197, 26);
			radSaMestimaToolStripMenuItem.Text = "Rad sa mestima";
			radSaMestimaToolStripMenuItem.Click += radSaMestimaToolStripMenuItem_Click;
			// 
			// pomocToolStripMenuItem
			// 
			pomocToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dodajStrucnuSpremuToolStripMenuItem, radSaStrucnomSpremomToolStripMenuItem });
			pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
			pomocToolStripMenuItem.Size = new Size(127, 24);
			pomocToolStripMenuItem.Text = "Strucna Sprema";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(37, 405);
			label1.Name = "label1";
			label1.Size = new Size(57, 20);
			label1.TabIndex = 1;
			label1.Text = "Radnik:";
			// 
			// lblRadnik
			// 
			lblRadnik.AutoSize = true;
			lblRadnik.Location = new Point(115, 405);
			lblRadnik.Name = "lblRadnik";
			lblRadnik.Size = new Size(0, 20);
			lblRadnik.TabIndex = 2;
			// 
			// dodajStrucnuSpremuToolStripMenuItem
			// 
			dodajStrucnuSpremuToolStripMenuItem.Name = "dodajStrucnuSpremuToolStripMenuItem";
			dodajStrucnuSpremuToolStripMenuItem.Size = new Size(268, 26);
			dodajStrucnuSpremuToolStripMenuItem.Text = "Dodaj strucnu spremu";
			dodajStrucnuSpremuToolStripMenuItem.Click += dodajStrucnuSpremuToolStripMenuItem_Click;
			// 
			// radSaStrucnomSpremomToolStripMenuItem
			// 
			radSaStrucnomSpremomToolStripMenuItem.Name = "radSaStrucnomSpremomToolStripMenuItem";
			radSaStrucnomSpremomToolStripMenuItem.Size = new Size(268, 26);
			radSaStrucnomSpremomToolStripMenuItem.Text = "Rad sa strucnom spremom";
			radSaStrucnomSpremomToolStripMenuItem.Click += radSaStrucnomSpremomToolStripMenuItem_Click;
			// 
			// GlavnaForma
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(lblRadnik);
			Controls.Add(label1);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Name = "GlavnaForma";
			Text = "Form1";
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem kupacToolStripMenuItem;
		private ToolStripMenuItem artikaToolStripMenuItem;
		private ToolStripMenuItem porudzbenicaToolStripMenuItem;
		private ToolStripMenuItem preporukaToolStripMenuItem;
		private ToolStripMenuItem pomocToolStripMenuItem;
		private Label label1;
		private Label lblRadnik;
		private ToolStripMenuItem dodajKupcaToolStripMenuItem;
		private ToolStripMenuItem radSaKupcimaToolStripMenuItem;
		private ToolStripMenuItem dodajArtikalToolStripMenuItem;
		private ToolStripMenuItem radSaArtiklimaToolStripMenuItem;
		private ToolStripMenuItem dodajPorudzbenicuToolStripMenuItem;
		private ToolStripMenuItem radSaPorudzbenicamaToolStripMenuItem;
		private ToolStripMenuItem dodajMestoToolStripMenuItem;
		private ToolStripMenuItem radSaMestimaToolStripMenuItem;
		private ToolStripMenuItem dodajStrucnuSpremuToolStripMenuItem;
		private ToolStripMenuItem radSaStrucnomSpremomToolStripMenuItem;
	}
}
