using Domain;
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
	public partial class KupacForma : Form
	{
		Kontroler kontroler = new Kontroler();
		Kupac IzmenjenKupac;
		public KupacForma()
		{
			InitializeComponent();
			btnAzuriraj.Visible = false;
			cmbMesto.DataSource = kontroler.vratiMestaIzBaze();
			cmbMesto.DisplayMember = "Naziv";
		}

		public KupacForma(Kupac k)
		{
			InitializeComponent();
			cmbMesto.DataSource = kontroler.vratiMestaIzBaze();
			cmbMesto.DisplayMember = "Naziv";
			IzmenjenKupac = k;
			btnSacuvaj.Visible = false;
			tbIme.Text = k.Ime;
			tbPrezime.Text = k.Prezime;
			tbEmail.Text = k.Email;	
			tbKontaktTelefon.Text = k.KontaktTelefon;
			cmbMesto.Text=k.Mesto.ToString();
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void btnSacuvaj_Click(object sender, EventArgs e)
		{
			try
			{
				if (!Validacija())
				{
					MessageBox.Show("Popunite sva polja!");
					return;
				}

				string ime = tbIme.Text;
				string prezime = tbPrezime.Text;
				string email = tbEmail.Text;
				string telefon = tbKontaktTelefon.Text;
				Mesto m = (Mesto)cmbMesto.SelectedItem;

				Kupac k = new Kupac(ime, prezime, email, telefon, m);
				kontroler.ubaciKupca(k);
				MessageBox.Show("Uspesno ste ubacili kupca!");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Greska pri prijavljivanju: " + ex.Message);
			}

		}

		private bool Validacija()
		{
			bool isValid = true;
			if (string.IsNullOrEmpty(tbIme.Text))
			{
				tbIme.BackColor = Color.Salmon;
				isValid = false;
			}
			if (string.IsNullOrEmpty(tbPrezime.Text))
			{
				tbPrezime.BackColor = Color.Salmon;
				isValid = false;
			}
			if (string.IsNullOrEmpty(tbEmail.Text))
			{
				tbEmail.BackColor = Color.Salmon;
				isValid = false;
			}
			if (string.IsNullOrEmpty(tbKontaktTelefon.Text))
			{
				tbKontaktTelefon.BackColor = Color.Salmon;
				isValid = false;
			}
			return isValid;
		}

		private void btnDodajMesto_Click(object sender, EventArgs e)
		{
			MestoForma frm = new MestoForma();
			frm.ShowDialog();
			cmbMesto.DataSource = kontroler.vratiMestaIzBaze();
		}

		private void btnAzuriraj_Click(object sender, EventArgs e)
		{
			if (!Validacija())
			{
				MessageBox.Show("Popunite sva polja!");
				return;
			}
			string ime = tbIme.Text;
			string prezime = tbPrezime.Text;
			string email = tbEmail.Text;
			string telefon = tbKontaktTelefon.Text;
			Mesto m = (Mesto)cmbMesto.SelectedItem;

			DialogResult result = MessageBox.Show("Da li sigurno zelite da sacuvate izmene?", "Sacuvaj Izmene",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				IzmenjenKupac.Ime = ime;
				IzmenjenKupac.Prezime=prezime;
				IzmenjenKupac.Email=email;
				IzmenjenKupac.KontaktTelefon=telefon;
				IzmenjenKupac.Mesto = m;
				kontroler.izmeniKupca(IzmenjenKupac);

			}
		}
	}
}
