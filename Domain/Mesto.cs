using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
	public class Mesto
	{
		public string PostanskiBroj {  get; set; }
		public string Naziv {  get; set; }
		public List<Kupac> Kupci {  get; set; }

		public override string? ToString()
		{
			return Naziv;
		}
		public Mesto() { }

		public Mesto(string postanskiBroj, string naziv)
		{
			PostanskiBroj = postanskiBroj;
			Naziv = naziv;
		}
	}
}
