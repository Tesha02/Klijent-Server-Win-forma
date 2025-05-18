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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace View
{
	public partial class ArtikalForma : Form
	{
		Kontroler kontroler = new Kontroler();
		Artikal artikalZaIzmenu;
		public ArtikalForma()
		{
			InitializeComponent();
			btnAzuriraj.Visible = false;
			cmbTip.DataSource = Enum.GetValues(typeof(Tip));
		}

		public ArtikalForma(Artikal a)
		{
			InitializeComponent();
			cmbTip.DataSource = Enum.GetValues(typeof(Tip));
			btnSacuvaj.Visible = false;
			artikalZaIzmenu = a;
			tbNaziv.Text = a.Naziv;
			tbCena.Text = a.Cena.ToString();
			cmbTip.Text = a.Tip.ToString();

		}

		private void btnSacuvaj_Click(object sender, EventArgs e)
		{
			try
			{
				if (!Validacija())
				{
					MessageBox.Show("Los unos podataka");
					return;
				}
				string naziv = tbNaziv.Text;
				long cena = long.Parse(tbCena.Text);
				Tip tip = (Tip)cmbTip.SelectedItem;
				Artikal a = new Artikal(naziv, cena, tip);
				if (kontroler.ubaciArtikal(a))
				{
					MessageBox.Show("Uspesno ste ubacili artikal!");
				}
				else
				{
					MessageBox.Show("Artikal vec postoji!");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Greska pri prijavljivanju: " + ex.Message);
			}
		}

		private bool Validacija()
		{
			bool isValid = true;
			if (string.IsNullOrEmpty(tbNaziv.Text))
			{
				tbNaziv.BackColor = Color.Salmon;
				isValid = false;
			}
			int broj;
			if (!int.TryParse(tbCena.Text, out broj))
			{
				tbCena.BackColor = Color.Salmon;
				isValid = false;
			}
			if (string.IsNullOrEmpty(cmbTip.Text))
			{
				cmbTip.BackColor = Color.Salmon;
				isValid = false;
			}

			return isValid;
		}

		private void btnAzuriraj_Click(object sender, EventArgs e)
		{
			if (!Validacija())
			{
				MessageBox.Show("Popunite sva polja!");
				return;
			}
			string naziv = tbNaziv.Text;
			long cena = long.Parse(tbCena.Text);
			Tip tip = (Tip)cmbTip.SelectedItem;

			DialogResult result = MessageBox.Show("Da li sigurno zelite da sacuvate izmene?", "Sacuvaj Izmene",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				artikalZaIzmenu.Naziv = naziv;
				artikalZaIzmenu.Cena = cena;
				artikalZaIzmenu.Tip = tip;
				kontroler.izmeniArtikal(artikalZaIzmenu);
			}
		}
	}
}
