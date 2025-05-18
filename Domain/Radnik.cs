using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
	public class Radnik
	{
		public long Id {  get; set; }
		public string Ime { get; set; }
		public string Prezime { get; set; }
		public string Email { get; set; }
		public string Kontakt { get; set; }
		public string KorisnickoIme { get; set; }
		public string Lozinka { get; set; }
		public List<PrSS> PrSSi { get; set; }

		public override string? ToString()
		{
			return Ime+" "+Prezime;
		}
	}
}
