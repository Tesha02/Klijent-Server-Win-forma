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
	public partial class RadSaArtiklima : Form
	{
		Kontroler k = new Kontroler();
		BindingList<Artikal> artikli = new BindingList<Artikal>();
		public RadSaArtiklima()
		{
			InitializeComponent();
			artikli = k.vratiArtikleIzBaze();
			dgvArtikli.DataSource = artikli;
			dgvArtikli.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			cmbPretragaPoTipu.DataSource = Enum.GetValues(typeof(Tip));
			cmbPretragaPoTipu.SelectedIndex = -1;

		}

		private void tbPretraga_TextChanged(object sender, EventArgs e)
		{
			string filter = tbPretraga.Text.Trim();
			var filteredArtikli = artikli.Where(a => a.Naziv.Contains(filter) || a.Naziv.Contains(filter)).ToList();

			dgvArtikli.DataSource = new BindingList<Artikal>(filteredArtikli);
		}

		private void cmbPretragaPoTipu_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbPretragaPoTipu.SelectedIndex < 0)
			{
				dgvArtikli.DataSource = artikli;
				return;
			}
			Tip tip = (Tip)cmbPretragaPoTipu.SelectedItem;
			dgvArtikli.DataSource = k.vratiArtiklePoTipu(tip);
		}

		private void btnDetalji_Click(object sender, EventArgs e)
		{
			if (dgvArtikli.SelectedRows.Count > 0)
			{
				Artikal a = dgvArtikli.SelectedRows[0].DataBoundItem as Artikal;
				ArtikalForma frm = new ArtikalForma(a);
				frm.ShowDialog();
			}
			else
			{
				MessageBox.Show("Niste odabrali red");
			}
		}







		//private void FiltrirajProizvode()
		//{
		//	string selektovaniTip = cmbPretragaPoTipu.SelectedItem.ToString();
		//	string tekstZaPretragu = tbPretraga.Text.ToLower();

		//	// Filtriranje iz originalne liste
		//	var filtriraniProizvodi = originalnaLista
		//		.Where(p =>
		//			(selektovaniTip == "Svi tipovi" || p.Tip.ToString() == selektovaniTip) && // Provera tipa
		//			(string.IsNullOrEmpty(tekstZaPretragu) || p.Naziv.ToLower().Contains(tekstZaPretragu)) // Provera naziva
		//		)
		//		.ToList();

		//	// Ažuriranje BindingList
		//	bindingListArtikli.Clear();
		//	foreach (var proizvod in filtriraniProizvodi)
		//	{
		//		bindingListArtikli.Add(proizvod);
		//	}
		//}
	}
}
