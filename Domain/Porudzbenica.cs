using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
	public class Porudzbenica
	{
		public long Id { get; set; }
		public DateOnly DatumOd {  get; set; }
		public DateOnly DatumDo {  get; set; }
		public float UkupnaVr { get; set; }
		public Radnik Radnik { get; set; }
		public Kupac Kupac { get; set; }
		public List<StavkaPorudzbenice> StavkePorudzbenica { get; set; } = new List<StavkaPorudzbenice>();
		public Porudzbenica() { }

		public Porudzbenica(DateOnly datumOd, DateOnly datumDo, float ukupnaVr, Radnik radnik, Kupac kupac)
		{
			DatumOd = datumOd;
			DatumDo = datumDo;
			UkupnaVr = ukupnaVr;
			Radnik = radnik;
			Kupac = kupac;
		}
	}
}
