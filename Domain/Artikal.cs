namespace Domain
{
	public class Artikal
	{
		public long Id { get; set; }
		public string Naziv { get; set; }
		public double Cena { get; set; }
		public Tip Tip { get; set; }
		public List<StavkaPorudzbenice> stavkePorudzbenica { get; set; }

		public Artikal() { }

		public Artikal(string naziv, long cena, Tip tip)
		{
			Naziv = naziv;
			Cena = cena;
			Tip = tip;
		}

		public override string? ToString()
		{
			return Naziv;
		}
	}
}
