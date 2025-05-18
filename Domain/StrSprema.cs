using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
	public class StrSprema
	{
		public long Id { get; set; }
		public string Naziv { get; set; }
		public string Opis { get; set; }
		public List<PrSS> PrSSi { get; set; }

		public StrSprema() { }
		public StrSprema(string naziv, string opis)
		{
			Naziv = naziv;
			Opis = opis;
		}
	}
}
