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
	public partial class RadSaMestimaForma : Form
	{
		Kontroler k = new Kontroler();
		List<Mesto> mesta = new List<Mesto>();
		public RadSaMestimaForma()
		{
			InitializeComponent();
			mesta = k.vratiMestaIzBaze();
			dgvMesta.DataSource = mesta;
			dgvMesta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}


		private void dgvMesta_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			string filter = tbPretrazi.Text.Trim();
			var filteredMesta = mesta.Where(m => m.Naziv.Contains(filter) || m.PostanskiBroj.Contains(filter)).ToList();

			dgvMesta.DataSource = new BindingList<Mesto>(filteredMesta);
		}

		private void btnObrisi_Click(object sender, EventArgs e)
		{
			if (dgvMesta.SelectedRows.Count > 0)
			{
				foreach (DataGridViewRow selectedRow in dgvMesta.SelectedRows)
				{
					Mesto m = dgvMesta.SelectedRows[0].DataBoundItem as Mesto;
					k.obrisiMesto(m);
				}
			}
			else
			{
				MessageBox.Show("Niste selektovali nijedno mesto");
			}
			dgvMesta.DataSource = k.vratiMestaIzBaze();
			MessageBox.Show("Obrisali ste mesto");
		}

		private void btnIzmeni_Click(object sender, EventArgs e)
		{
			if (dgvMesta.SelectedRows.Count == 1)
			{
				Mesto m = dgvMesta.SelectedRows[0].DataBoundItem as Mesto;
				MestoForma frm =new MestoForma(m);
				frm.ShowDialog();
			}
			else if(dgvMesta.SelectedRows.Count>1)
			{
				MessageBox.Show("Izaberite samo jedno mesto!");
			}
			else
			{
				MessageBox.Show("Niste selektovali nijedno mesto");
			}
			dgvMesta.DataSource = k.vratiMestaIzBaze();
		}
	}
}
