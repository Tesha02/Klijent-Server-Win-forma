using Domain;
using View;

namespace MainForm
{
	public partial class GlavnaForma : Form
	{
		Radnik prijavljeniRadnik;
		public GlavnaForma()
		{
			InitializeComponent();
		}

		public GlavnaForma(Radnik r)
		{
			InitializeComponent();
			prijavljeniRadnik = r;
			lblRadnik.Text = r.Ime + " " + r.Prezime;
		}

		private void dodajKupcaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			KupacForma frm = new KupacForma();
			frm.ShowDialog();
		}

		private void radSaKupcimaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			RadSaKupcimaForma frm = new RadSaKupcimaForma();
			frm.ShowDialog();
		}

		private void dodajArtikalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ArtikalForma frm = new ArtikalForma();
			frm.ShowDialog();
		}

		private void radSaArtiklimaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			RadSaArtiklima frm = new RadSaArtiklima();
			frm.ShowDialog();
		}

		private void dodajPorudzbenicuToolStripMenuItem_Click(object sender, EventArgs e)
		{
			PorudzbenicaForma frm = new PorudzbenicaForma(prijavljeniRadnik);
			frm.ShowDialog();
		}

		private void radSaPorudzbenicamaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			RadSaPorudzbenicamaForma frm = new RadSaPorudzbenicamaForma(prijavljeniRadnik);
			frm.ShowDialog();
		}

		private void preporukaToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void dodajMestoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MestoForma frm = new MestoForma();
			frm.ShowDialog();
		}

		private void radSaMestimaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			RadSaMestimaForma frm = new RadSaMestimaForma();
			frm.ShowDialog();
		}

		private void dodajStrucnuSpremuToolStripMenuItem_Click(object sender, EventArgs e)
		{
			StrucnaSpremaForma frm=new StrucnaSpremaForma();
			frm.ShowDialog();
		}

		private void radSaStrucnomSpremomToolStripMenuItem_Click(object sender, EventArgs e)
		{
			RadSaStrucnomSpremom frm=new RadSaStrucnomSpremom();
			frm.ShowDialog();
		}
	}
}
