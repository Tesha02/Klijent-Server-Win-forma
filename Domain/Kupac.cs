using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
	public class Kupac
	{
		public long Id { get; set; }
		public string Ime { get; set; }
		public string Prezime { get; set; }
		public string Email { get; set; }
		public string KontaktTelefon { get; set; }
		public Mesto Mesto { get; set; }
		public bool Ulogovan { get; set; }
		public Kupac()
		{
		}

		public Kupac(string ime, string prezime, string email, string kontaktTelefon, Mesto mesto)
		{
			Ime = ime;
			Prezime = prezime;
			Email = email;
			KontaktTelefon = kontaktTelefon;
			Mesto = mesto;
		}

		public override string? ToString()
		{
			return Ime+" "+Prezime;
		}
	}
}
