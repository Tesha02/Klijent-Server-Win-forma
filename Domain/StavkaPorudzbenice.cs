using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
	public class StavkaPorudzbenice
	{
		public long Id { get; set; }
		public long Kolicina {  get; set; }
		public double CenaStavke { get; set; }
		public double UkupnaCena { get; set; }
		public Artikal Artikal { get; set; }
		public Porudzbenica Porudzbenica { get; set; }
		public StavkaPorudzbenice() { }

		public StavkaPorudzbenice(long kolicina, double cenaStavke, double ukupnaCena, Artikal artikal, Porudzbenica porudzbenica)
		{
			Kolicina = kolicina;
			CenaStavke = cenaStavke;
			UkupnaCena = ukupnaCena;
			Artikal = artikal;
			Porudzbenica = porudzbenica;
		}
	}
}
