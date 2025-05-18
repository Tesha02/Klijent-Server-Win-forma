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
	public partial class RadSaStrucnomSpremom : Form
	{
		List<StrSprema> spreme = new List<StrSprema>();
		Kontroler k = new Kontroler();
		public RadSaStrucnomSpremom()
		{
			InitializeComponent();
			spreme = k.vratiStrucneSpreme();
			dgvStrSprema.DataSource = spreme;
			dgvStrSprema.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;
			dgvStrSprema.Columns[0].Visible=false;
		}

		private void tbPretraga_TextChanged(object sender, EventArgs e)
		{
			string filter = tbPretraga.Text.Trim();
			var filteredSpreme = spreme.Where(s => s.Naziv.Contains(filter) || s.Opis.Contains(filter)).ToList();

			dgvStrSprema.DataSource = new List<StrSprema>(filteredSpreme);
		}

		private void btnIzmeni_Click(object sender, EventArgs e)
		{
			if (dgvStrSprema.SelectedRows.Count == 1)
			{
				StrSprema sprema = dgvStrSprema.SelectedRows[0].DataBoundItem as StrSprema;
				StrucnaSpremaForma frm = new StrucnaSpremaForma(sprema);
				frm.ShowDialog();
			}
			else if (dgvStrSprema.SelectedRows.Count > 1)
			{
				MessageBox.Show("Izaberite maksimalno 1 red");
			}
			else
			{
				MessageBox.Show("Niste odabrali red");
			}
		}

		private void btnObrisi_Click(object sender, EventArgs e)
		{
			if (dgvStrSprema.SelectedRows.Count > 0)
			{
				foreach (DataGridViewRow selectedRow in dgvStrSprema.SelectedRows)
				{
					StrSprema sprema=selectedRow.DataBoundItem as StrSprema;
					k.obrisiStrucnuSpremu(sprema);
				}
				dgvStrSprema.DataSource = k.vratiStrucneSpreme();
				MessageBox.Show("Uspesno ste obrisali strucnu spremu!");
			}
			else
			{
				MessageBox.Show("Izaberite barem jedan red");
			}
		}
	}
}
