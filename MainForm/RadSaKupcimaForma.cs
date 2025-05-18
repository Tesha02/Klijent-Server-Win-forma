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

namespace View
{
	public partial class RadSaKupcimaForma : Form
	{
		Kontroler k = new Kontroler();
		BindingList<Kupac> kupci = new BindingList<Kupac>();

		public RadSaKupcimaForma()
		{
			InitializeComponent();
			kupci = k.vratiKupce();
			dgvKorisnici.DataSource = kupci;
			dgvKorisnici.Columns[0].Visible = false;
			tbPretraga.TextChanged += tbPretraga_TextChanged;
			dgvKorisnici.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;

		}



		private void tbPretraga_TextChanged(object sender, EventArgs e)
		{
			string filter = tbPretraga.Text.Trim();
			var filteredKupci = kupci.Where(k => k.Ime.Contains(filter) || k.Prezime.Contains(filter)).ToList();

			dgvKorisnici.DataSource = new BindingList<Kupac>(filteredKupci);
		}

		private void RadSaKupcimaForma_Load(object sender, EventArgs e)
		{

		}

		private void btnDetalji_Click(object sender, EventArgs e)
		{
			if (dgvKorisnici.SelectedRows.Count > 0)
			{
				Kupac k = dgvKorisnici.SelectedRows[0].DataBoundItem as Kupac;
				KupacForma frm=new KupacForma(k);
				frm.ShowDialog();
			}
			else
			{
				MessageBox.Show("Niste odabrali red");
			}
		}
	}
}
