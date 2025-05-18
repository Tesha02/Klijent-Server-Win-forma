using Domain;
using MainForm;
using PoslovnaLogika;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
	public partial class LoginForma : Form
	{
		private bool isPasswordVisible = false;
		public LoginForma()
		{
			InitializeComponent();
		}

		private void btnUloguj_Click(object sender, EventArgs e)
		{
			try
			{
				if (!Validacija()) return;
				string ks = tbKorisnickoIme.Text;
				string loz = tbLozinka.Text;

				Kontroler k = new Kontroler();
				Radnik r = k.Login(ks, loz);
				GlavnaForma frm = new GlavnaForma(r);
				this.Visible = false;
				frm.ShowDialog();
				this.Visible = true;
			}
			catch (Exception ex)
			{

				MessageBox.Show("Greska pri prijavljivanju: " + ex.Message);
			}

		}

		private bool Validacija()
		{
			bool isValid = true;
			if (string.IsNullOrEmpty(tbKorisnickoIme.Text))
			{
				tbKorisnickoIme.BackColor = Color.Salmon;
				isValid = false;
			}
			if (string.IsNullOrEmpty(tbLozinka.Text))
			{
				tbLozinka.BackColor = Color.Salmon;
				isValid = false;
			}
			return isValid;
		}

		private void pbShowPass_Click(object sender, EventArgs e)
		{
			if (isPasswordVisible)
			{
				tbLozinka.UseSystemPasswordChar = true;
				pbShowPass.Image = Properties.Resources.icons8_closed_eye_50;
				isPasswordVisible = false;
			}else
			{
				tbLozinka.UseSystemPasswordChar=false;
				pbShowPass.Image=Properties.Resources.icons8_eye_50;
				isPasswordVisible = true;
			}
		}
	}
}
