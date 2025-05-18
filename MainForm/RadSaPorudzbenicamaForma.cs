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
	public partial class RadSaPorudzbenicamaForma : Form
	{
		Kontroler k = new Kontroler();
		Radnik prijavljeniRadnik;
		public RadSaPorudzbenicamaForma()
		{
			InitializeComponent();
			cmbKupac.DataSource = k.vratiKupce();

		}

		public RadSaPorudzbenicamaForma(Radnik r)
		{
			InitializeComponent();
			prijavljeniRadnik = r;
			cmbKupac.DataSource = k.vratiKupce();
			cmbKupac.SelectedIndex = -1;
			dgvPorudzbenice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}

		private void cmbKupac_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbKupac.SelectedIndex < 0)
			{
				dgvPorudzbenice.DataSource = k.vratiPorudzbeniceZaRadnika(prijavljeniRadnik);
				return;
			}
			Kupac kupac = (Kupac)cmbKupac.SelectedItem;
			dgvPorudzbenice.DataSource = k.vratiPorudzbeniceZaKupca(prijavljeniRadnik, kupac);
		}

		private void btnPrikaziSve_Click(object sender, EventArgs e)
		{
			dgvPorudzbenice.DataSource = k.vratiPorudzbeniceZaRadnika(prijavljeniRadnik);
			cmbKupac.SelectedIndex = -1;
		}

		private void btnDetalji_Click(object sender, EventArgs e)
		{
			if (dgvPorudzbenice.SelectedRows.Count == 1)
			{
				Porudzbenica p = dgvPorudzbenice.SelectedRows[0].DataBoundItem as Porudzbenica;
				PorudzbenicaForma frm = new PorudzbenicaForma(prijavljeniRadnik, p);
				frm.ShowDialog();
			}
			else if (dgvPorudzbenice.SelectedRows.Count > 1)
			{
				MessageBox.Show("Izaberite maksimalno 1 red");
			}
			else
			{
				MessageBox.Show("Niste odabrali red");
			}
		}

		private void btnIzbrisi_Click(object sender, EventArgs e)
		{

		}
	}
}
