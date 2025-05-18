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
	public partial class StrucnaSpremaForma : Form
	{
		Kontroler k = new Kontroler();
		StrSprema prosledjenaSprema;
		public StrucnaSpremaForma()
		{
			InitializeComponent();
			btnIzmeni.Visible = false;
		}

		public StrucnaSpremaForma(StrSprema sprema)
		{
			InitializeComponent();
			prosledjenaSprema = sprema;
			btnDodaj.Visible = false;
			tbNaziv.Text = sprema.Naziv;
			tbOpis.Text = sprema.Opis;
		}

		private void btnDodaj_Click(object sender, EventArgs e)
		{
			string naziv = tbNaziv.Text;
			string opis = tbOpis.Text;
			StrSprema strSprema = new StrSprema(naziv, opis);
			k.ubaciStrucnuSpremu(strSprema);
			MessageBox.Show("Uspesno ste dodali strucnu spremu");
		}

		private void btnIzmeni_Click(object sender, EventArgs e)
		{
			prosledjenaSprema.Naziv= tbNaziv.Text;
			prosledjenaSprema.Opis=tbOpis.Text;
			k.izmeniStrucnuSpremu(prosledjenaSprema);
			MessageBox.Show("Uspesno izmenjena strucna sprema");
		}
	}
}
