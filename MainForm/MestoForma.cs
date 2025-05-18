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
	public partial class MestoForma : Form
	{
		Kontroler k = new Kontroler();
		Mesto prosledjenoMesto;
		public MestoForma()
		{
			InitializeComponent();
			btnIzmeni.Visible=false;
		}

		public MestoForma(Mesto m)
		{
			InitializeComponent();
			prosledjenoMesto = m;
			tbNaziv.Text = m.Naziv;
			tbPtt.Text = m.PostanskiBroj;
			btnDodajMesto.Visible=false;
		}

		private void btnDodajMesto_Click(object sender, EventArgs e)
		{
			string naziv = tbNaziv.Text;
			string ptt = tbPtt.Text;
			Mesto mesto = new Mesto(ptt, naziv);
			k.ubaciMesto(mesto);
			MessageBox.Show("Uspesno ste ubacili mesto!");

		}

		private void btnIzmeni_Click(object sender, EventArgs e)
		{
			string naziv = tbNaziv.Text;
			string ptt = tbPtt.Text;
			Mesto mesto = new Mesto(ptt, naziv);
			k.izmeniMesto(mesto,prosledjenoMesto.PostanskiBroj);
			MessageBox.Show("Uspesno ste izmenili mesto!");
		}
	}
}
