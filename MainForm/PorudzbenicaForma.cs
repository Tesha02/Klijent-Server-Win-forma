using Domain;
using PoslovnaLogika;
using System;
using System.Collections;
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
	public partial class PorudzbenicaForma : Form
	{
		Kontroler k = new Kontroler();
		BindingList<StavkaPorudzbenice> stavke = new BindingList<StavkaPorudzbenice>();
		Radnik prosledjenRadnik;
		Porudzbenica prosledjenaPorudzbenica;

		public PorudzbenicaForma()
		{
			InitializeComponent();

		}

		public PorudzbenicaForma(Radnik r)
		{
			InitializeComponent();
			btnAzuriraj.Visible = false;
			stavke = k.vratiStavkeIzBaze();
			prosledjenRadnik = r;
			lblRadnik.Text = r.Ime + " " + r.Prezime;
			tbUkupnaCena.Enabled = false;
			tbIznosArtikla.Enabled = false;
			dtpDatumOd.Value = DateTime.Now;
			dtpDatumOd.Enabled = false;
			cmbKupac.DataSource = k.vratiKupce();
			cmbKupac.SelectedIndex = -1;
			cmbArtikal.DataSource = k.vratiArtikleIzBaze();
			cmbArtikal.SelectedIndex = -1;
			//dgvStavke.DataSource = stavke;
			dgvStavke.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			tbUkupnaVrednost.Enabled = false;
			cmbArtikal.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbKupac.DropDownStyle = ComboBoxStyle.DropDownList;

		}

		public PorudzbenicaForma(Radnik r, Porudzbenica p)
		{
			InitializeComponent();
			tbUkupnaVrednost.Text = p.UkupnaVr + "";
			prosledjenaPorudzbenica = p;
			btnSacuvaj.Visible = false;
			//stavke = k.vratiStavkeIzBaze();
			prosledjenRadnik = r;
			cmbKupac.Text=p.Kupac.ToString();
			cmbKupac.Enabled=false;
			dtpDatumDo.Value=p.DatumDo.ToDateTime(TimeOnly.MinValue);
			dtpDatumDo.Enabled=false;
			lblRadnik.Text = r.Ime + " " + r.Prezime;
			tbUkupnaCena.Enabled = false;
			tbIznosArtikla.Enabled = false;
			dtpDatumOd.Value = DateTime.Now;
			dtpDatumOd.Enabled = false;
			cmbKupac.DataSource = k.vratiKupce();
			cmbArtikal.DataSource = k.vratiArtikleIzBaze();
			//dgvStavke.DataSource = stavke;
			dgvStavke.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			tbUkupnaVrednost.Enabled = false;
			cmbArtikal.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbKupac.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbKupac.Text = p.Radnik.ToString();
			List<StavkaPorudzbenice> stavke = k.vratiStavkeZaPorudzbenicu(p);

			foreach (StavkaPorudzbenice sp in stavke)
			{
				dgvStavke.Rows.Add(sp.Artikal, sp.CenaStavke, sp.Kolicina, sp.UkupnaCena);
			}
		}

		private void btnSacuvaj_Click(object sender, EventArgs e)
		{
			if (!Validacija1())
			{
				MessageBox.Show("Nisi uneo sve podatke");
				return;
			}

			Kupac kupac = cmbKupac.SelectedItem as Kupac;
			DateOnly datumOd = DateOnly.FromDateTime(dtpDatumOd.Value.Date);
			DateOnly datumDo = DateOnly.FromDateTime(dtpDatumDo.Value);
			float ukupnaVr = float.Parse(tbUkupnaVrednost.Text);
			Porudzbenica p = new Porudzbenica(datumOd, datumDo, ukupnaVr, prosledjenRadnik, kupac);
			long porudzbenicaId = k.ubaciPorudzbenicu(p);

			if (porudzbenicaId > 0)
			{
				MessageBox.Show("Porudzbenica je uspesno sacuvana, njen id: " + porudzbenicaId);
			}

			p.Id = porudzbenicaId;
			Artikal artikal = new Artikal();
			float cenaArtikla, ukupnaCena = 0;
			long kolicina = 0;
			foreach (DataGridViewRow row in dgvStavke.Rows)
			{
				if (row.Cells["Artikal"].Value == null)
					break;
				artikal = row.Cells["Artikal"].Value as Artikal;
				cenaArtikla = Convert.ToSingle(row.Cells[1].Value);
				kolicina = Convert.ToInt64(row.Cells[2].Value);
				ukupnaCena = Convert.ToSingle(row.Cells[3].Value);

				StavkaPorudzbenice sp = new StavkaPorudzbenice(kolicina, cenaArtikla, ukupnaCena, artikal, p);
				p.StavkePorudzbenica.Add(sp);
				k.ubaciStavku(sp);

			}
			
			MessageBox.Show("Uspesno ste sacuvali porudzbenicu");
			dgvStavke.Rows.Clear();

		}

		private void cmbArtikal_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbArtikal.SelectedIndex < 0)
			{
				tbIznosArtikla.Text = 0 + "";
				return;
			}
			tbIznosArtikla.Text = ((Artikal)cmbArtikal.SelectedItem).Cena.ToString();
			tbKolicina.Clear();
			tbUkupnaCena.Clear();
		}

		private void btnDodajStavku_Click(object sender, EventArgs e)
		{
			if (!Validacija())
			{
				MessageBox.Show("Pogresno ste uneli nesto!");
				return;
			}

			Artikal a = (Artikal)cmbArtikal.SelectedItem;
			long kolicina = long.Parse(tbKolicina.Text);
			float cenaStavke = float.Parse(tbIznosArtikla.Text);
			float ukupnaCenaStavke = cenaStavke * kolicina;
			//StavkaPorudzbenice sp = new StavkaPorudzbenice(kolicina, cenaStavke, ukupnaCenaStavke, a);
			//k.ubaciStavku(sp);
			bool flag = true;
			foreach (DataGridViewRow row in dgvStavke.Rows)
			{
				if (row.Cells["Artikal"].Value != null && row.Cells["Artikal"].Value.ToString().Equals(a.ToString()))
				{
					flag = false;
					row.Cells["Kolicina"].Value = (long)row.Cells["Kolicina"].Value + kolicina;
					row.Cells["UkupnaCena"].Value = Convert.ToDouble(row.Cells["UkupnaCena"].Value) + kolicina * cenaStavke;
					break;
				}
			}
			if (flag)
			{
				dgvStavke.Rows.Add(a, cenaStavke, kolicina, ukupnaCenaStavke);
			}
			//dgvStavke.DataSource = k.vratiStavkeIzBaze();
			MessageBox.Show("Uspesno ste ubacili proizvod!");

			float ukupnaVr = 0;
			foreach (DataGridViewRow row in dgvStavke.Rows)
			{
				ukupnaVr += Convert.ToSingle(row.Cells["UkupnaCena"].Value);
			}
			tbUkupnaVrednost.Text = ukupnaVr + "";
		}

		private bool Validacija1()
		{
			bool isValid = true;
			if (string.IsNullOrEmpty(cmbKupac.Text))
			{
				cmbKupac.BackColor = Color.Salmon;
				return false;
			}

			if (dgvStavke.Rows.Count == 0)
			{
				dgvStavke.RowsDefaultCellStyle.BackColor = Color.Salmon;
				//dgvStavke.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
				return false;
			}

			int broj;
			if (!int.TryParse(tbUkupnaVrednost.Text, out broj))
			{
				tbUkupnaVrednost.BackColor = Color.Salmon;
				return false;
			}

			cmbKupac.BackColor = Color.White;
			dgvStavke.BackgroundColor = Color.White;

			return true;
		}
		private bool Validacija()
		{
			bool isValid = true;
			if (string.IsNullOrEmpty(tbIznosArtikla.Text))
			{
				tbIznosArtikla.BackColor = Color.Salmon;
				return false;
			}
			int broj;
			if (!int.TryParse(tbKolicina.Text, out broj))
			{
				tbKolicina.BackColor = Color.Salmon;
				return false;
			}
			if (string.IsNullOrEmpty(cmbArtikal.Text))
			{
				cmbArtikal.BackColor = Color.Salmon;
				return false;
			}

			tbKolicina.BackColor = Color.White;
			cmbArtikal.BackColor = Color.White;
			tbIznosArtikla.BackColor = Color.White;

			return true;
		}

		private void btnObrisiStavku_Click(object sender, EventArgs e)
		{
			if (dgvStavke.SelectedRows.Count > 0)
			{
				foreach (DataGridViewRow selectedRow in dgvStavke.SelectedRows)
				{
					dgvStavke.Rows.Remove(selectedRow);
				}

				float ukupnaVr = 0;
				foreach (DataGridViewRow row in dgvStavke.Rows)
				{
					ukupnaVr += Convert.ToSingle(row.Cells["UkupnaCena"].Value);
				}
				tbUkupnaVrednost.Text = ukupnaVr + "";
			}
			else
			{
				MessageBox.Show("Morate selektovati stavku!");
			}
		}

		private void tbUkupnaCena_TextChanged(object sender, EventArgs e)
		{

		}

		private void tbKolicina_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(tbKolicina.Text))
			{
				return;
			}
			long br = long.Parse(tbKolicina.Text) * long.Parse(tbIznosArtikla.Text);
			tbUkupnaCena.Text = br + "";
		}

		private void tbIznosArtikla_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(tbKolicina.Text))
			{
				return;
			}
			long br = long.Parse(tbKolicina.Text) * long.Parse(tbIznosArtikla.Text);
			tbUkupnaCena.Text = br + "";

		}

		private void dgvStavke_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btnAzuriraj_Click(object sender, EventArgs e)
		{
			k.izbrisiStavkeZaPorudzbenicu(prosledjenaPorudzbenica);
			Artikal artikal = new Artikal();
			float cenaArtikla, ukupnaCena = 0;
			long kolicina = 0;
			foreach (DataGridViewRow row in dgvStavke.Rows)
			{
				if (row.Cells["Artikal"].Value == null)
					break;
				artikal = row.Cells["Artikal"].Value as Artikal;
				cenaArtikla = Convert.ToSingle(row.Cells[1].Value);
				kolicina = Convert.ToInt64(row.Cells[2].Value);
				ukupnaCena = Convert.ToSingle(row.Cells[3].Value);

				StavkaPorudzbenice sp = new StavkaPorudzbenice(kolicina, cenaArtikla, ukupnaCena, artikal, prosledjenaPorudzbenica);
				k.ubaciStavku(sp);
			}
			
		}
	}
}
