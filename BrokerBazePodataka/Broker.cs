using Domain;
using Microsoft.Data.SqlClient;
using System.ComponentModel;
using System.Reflection.PortableExecutable;

namespace BrokerBazePodataka
{
	public class Broker
	{
		private SqlConnection conn;

		public void Connect()
		{
			try
			{
				conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=projekat;Integrated Security = True;");
				conn.Open();
			}
			catch (Exception)
			{
				Console.WriteLine("Nije uspesno uspostavljena veza sa bazom podataka!");
				throw;
			}
		}
		public void Disconnect()
		{
			conn?.Close();

		}

		public Radnik getRadnikByUserPass(string korisnickoIme, string lozinka)
		{
			try
			{
				string upit = @"
				SELECT * FROM Radnik 
				WHERE korisnickoime COLLATE SQL_Latin1_General_CP1_CS_AS = @ks 
				AND lozinka COLLATE SQL_Latin1_General_CP1_CS_AS = @loz";

				SqlCommand cmd = new SqlCommand(upit, conn);
				cmd.Parameters.AddWithValue("ks", korisnickoIme);
				cmd.Parameters.AddWithValue("loz", lozinka);
				SqlDataReader reader = cmd.ExecuteReader();
				Radnik r = new Radnik();
				if (reader.Read())
				{
					r.Id = reader.GetInt64(0);
					r.Ime = reader.GetString(1);
					r.Prezime = reader.GetString(2);
					r.Email = reader.GetString(3);
					r.Kontakt = reader.GetString(4);
					r.KorisnickoIme = korisnickoIme;
					r.Lozinka = lozinka;
					return r;
				}
				else
				{
					throw new Exception("Ne postoji korisnik sa zadatim podacima!");
				}
			}
			catch (SqlException ex)
			{
				Console.WriteLine("Greska pri radu sa bazom!");
				Console.WriteLine(ex.Message);
				throw;
			}

		}

		public List<Mesto> vratiMestaIzBaze()
		{
			try
			{
				List<Mesto> mesta = new List<Mesto>();
				string upit = $"select * from mesto";
				SqlCommand cmd = new SqlCommand(upit, conn);
				SqlDataReader reader = cmd.ExecuteReader();

				while (reader.Read())
				{
					Mesto m = new Mesto();
					m.PostanskiBroj = reader.GetString(0);
					m.Naziv = reader.GetString(1);
					mesta.Add(m);
				}
				return mesta;
			}
			catch (SqlException ex)
			{
				Console.WriteLine("Greska pri radu sa bazom!");
				Console.WriteLine(ex.Message);
				throw;
			}
		}

		public void ubaciKupca(Kupac k)
		{
			try
			{
				string upit = $"insert into kupac values ('{k.Ime}','{k.Prezime}','{k.Email}','{k.KontaktTelefon}','{k.Mesto.PostanskiBroj}')";
				SqlCommand cmd = new SqlCommand(upit, conn);
				//cmd.Parameters.AddWithValue("@ime", k.Ime);
				//cmd.Parameters.AddWithValue("@prezime", k.Prezime);
				//cmd.Parameters.AddWithValue("@email", k.Email);
				//cmd.Parameters.AddWithValue("@telefon", k.KontaktTelefon);
				//cmd.Parameters.AddWithValue("@ptt", k.Mesto.PostanskiBroj);

				int affectedRows = cmd.ExecuteNonQuery();
				if (affectedRows > 0)
				{
					Console.WriteLine("Osoba je uspesno sacuvana!");
				}
			}
			catch (SqlException ex)
			{
				Console.WriteLine("Greska: " + ex.Message);
			}
		}

		public BindingList<Kupac> vratiKupce()
		{
			BindingList<Kupac> kupci=new BindingList<Kupac>();
			string upit = $"select * from kupac join mesto on postanskibrojmesta=postanskibroj";
			SqlCommand cmd = new SqlCommand(upit, conn);
			SqlDataReader r = cmd.ExecuteReader();

			while (r.Read())
			{
				Kupac k = new Kupac();
				k.Id= r.GetInt64(0);
				k.Ime = r.GetString(1);
				k.Prezime = r.GetString(2);
				k.Email = r.GetString(3);
				k.KontaktTelefon = r.GetString(4);
				Mesto m=new Mesto();
				m.PostanskiBroj = r.GetString(5);
				m.Naziv= r.GetString(7);
				k.Mesto = m;
				kupci.Add(k);
			}
			return kupci;
		}

		public Mesto vratiMestaIzBazeByPtt(String ptt)
		{
			try
			{
				string upit = $"select * from mesto where postanskibroj='{ptt}'";
				SqlCommand cmd = new SqlCommand(upit, conn);
				SqlDataReader reader = cmd.ExecuteReader();
				Mesto m = new Mesto();
				if (reader.Read())
				{
					m.PostanskiBroj = reader.GetString(0);
					m.Naziv = reader.GetString(1);
				}
				return m;
				
			}
			catch (SqlException ex)
			{
				Console.WriteLine("Greska pri radu sa bazom!");
				Console.WriteLine(ex.Message);
				throw;
			}
		}

		public void izmeniKupca(Kupac k)
		{
			string upit = $"update kupac set ime='{k.Ime}',prezime='{k.Prezime}',email='{k.Email}',kontakttelefon='{k.KontaktTelefon}',postanskibrojmesta='{k.Mesto.PostanskiBroj}' where id='{k.Id}'";
			SqlCommand cmd =new SqlCommand(upit, conn);
			cmd.ExecuteNonQuery();
		}

		public Boolean ubaciArtikal(Artikal a)
		{
			string upit = $"select count(*) from artikal where naziv='{a.Naziv}'";
			SqlCommand cmd=new SqlCommand(upit, conn);
			int brojPostojecih=(int)cmd.ExecuteScalar();
			if (brojPostojecih > 0)
			{
				return false;
			}
			string upit1 = $"insert into artikal values ('{a.Naziv}','{a.Cena}','{a.Tip.ToString()}')";
			cmd.CommandText = upit1;
			cmd.ExecuteNonQuery();
			return true;
		}

		public BindingList<Artikal> vratiArtikle()
		{
			try
			{
				BindingList<Artikal> artikli = new BindingList<Artikal>();
				string upit = $"select * from artikal";
				SqlCommand cmd = new SqlCommand(upit, conn);
				SqlDataReader reader = cmd.ExecuteReader();

				while (reader.Read())
				{
					Artikal a = new Artikal();
					a.Id = reader.GetInt64(0);
					a.Naziv = reader.GetString(1);
					a.Cena=reader.GetDouble(2);
					a.Tip = Enum.Parse<Tip>(reader[3].ToString());
					artikli.Add(a);
				}
				return artikli;
			}
			catch (SqlException ex)
			{
				Console.WriteLine("Greska pri radu sa bazom!");
				Console.WriteLine(ex.Message);
				throw;
			}
		}

		public BindingList<Artikal> vratiArtiklePoTipu(Tip t)
		{
			try
			{
				BindingList<Artikal> artikli = new BindingList<Artikal>();
				string upit = $"select * from artikal where Tip='{t.ToString()}'";
				SqlCommand cmd = new SqlCommand(upit, conn);
				SqlDataReader reader = cmd.ExecuteReader();

				while (reader.Read())
				{
					Artikal a = new Artikal();
					a.Id = reader.GetInt64(0);
					a.Naziv = reader.GetString(1);
					a.Cena = reader.GetDouble(2);
					a.Tip = Enum.Parse<Tip>(reader[3].ToString());
					artikli.Add(a);
				}
				return artikli;
			}
			catch (SqlException ex)
			{
				Console.WriteLine("Greska pri radu sa bazom!");
				Console.WriteLine(ex.Message);
				throw;
			}
		}

		public void izmeniArtikal(Artikal a)
		{
			string upit = $"update artikal set naziv='{a.Naziv}',cena='{a.Cena}',tip='{a.Tip.ToString()}' where id='{a.Id}'";
			SqlCommand cmd = new SqlCommand(upit,conn);
			cmd.ExecuteNonQuery();
		}

		public BindingList<StavkaPorudzbenice> vratiStavke()
		{
			try
			{
				BindingList<StavkaPorudzbenice> stavke = new BindingList<StavkaPorudzbenice>();
				string upit = $"select * from stavkaporudzbenice sp join artikal a on sp.artikalid=a.id";
				SqlCommand cmd = new SqlCommand(upit, conn);
				SqlDataReader reader = cmd.ExecuteReader();

				while (reader.Read())
				{
					StavkaPorudzbenice sp = new StavkaPorudzbenice();
					sp.Id = reader.GetInt64(0);
					sp.Kolicina = reader.GetInt64(1);
					sp.CenaStavke = reader.GetDouble(2);
					sp.UkupnaCena = reader.GetDouble(3);
					Artikal a = new Artikal();
					a.Id = reader.GetInt64(5);
					a.Naziv = reader.GetString(7);
					a.Cena= reader.GetDouble(8);
					a.Tip = Enum.Parse<Tip>(reader.GetString(9));
					sp.Artikal = a;
					stavke.Add(sp);
				}
				return stavke;
			}
			catch (SqlException ex)
			{
				Console.WriteLine("Greska pri radu sa bazom!");
				Console.WriteLine(ex.Message);
				throw;
			}
		}

		public void ubaciStavku(StavkaPorudzbenice sp)
		{
			string upit = $"insert into stavkaporudzbenice values ('{sp.Kolicina}','{sp.CenaStavke}','{sp.UkupnaCena}','{sp.Porudzbenica.Id}','{sp.Artikal.Id}')";
			SqlCommand cmd = new SqlCommand(upit, conn);
			cmd.CommandText = upit;
			cmd.ExecuteNonQuery();
		}

		public void izbaciStavku(StavkaPorudzbenice sp)
		{
			string upit = $"delete stavkaporudzbenice where id='{sp.Id}'";
			SqlCommand cmd = new SqlCommand(upit,conn);
			cmd.ExecuteNonQuery();
		}

		public long ubaciPorudzbenicu(Porudzbenica p)
		{
			string upit = $"insert into porudzbenica output inserted.id values('{p.DatumOd}','{p.DatumDo}','{p.UkupnaVr}','{p.Radnik.Id}','{p.Kupac.Id}')";
			SqlCommand cmd = new SqlCommand(upit, conn);
			long porudzbenicaId=(long)cmd.ExecuteScalar();

			return porudzbenicaId;
		}

		public BindingList<Porudzbenica> vratiPorudzbeniceZaRadnika(Radnik r)
		{
			try
			{
				BindingList<Porudzbenica> porudzbenice = new BindingList<Porudzbenica>();
				string upit = $"select * from porudzbenica p join kupac k on p.kupacid=k.id join mesto on postanskibrojmesta=postanskibroj where p.radnikid='{r.Id}'";
				SqlCommand cmd = new SqlCommand(upit, conn);
				SqlDataReader reader = cmd.ExecuteReader();

				while (reader.Read())
				{
					Porudzbenica p = new Porudzbenica();
					p.Id = reader.GetInt64(0);
					p.DatumOd = DateOnly.FromDateTime(reader.GetDateTime(1));
					p.DatumDo = DateOnly.FromDateTime(reader.GetDateTime(2));
					p.UkupnaVr=(float)reader.GetDouble(3);
					p.Radnik = r;
					Kupac k = new Kupac();
					k.Id= reader.GetInt64(6);
					k.Ime=reader.GetString(7);
					k.Prezime=reader.GetString(8);
					k.Email=reader.GetString(9);
					k.KontaktTelefon=reader.GetString(10);
					Mesto m = new Mesto();
					m.PostanskiBroj = reader.GetString(12);
					m.Naziv = reader.GetString(13);
					k.Mesto = m;
					p.Kupac = k;
					porudzbenice.Add(p);
				}
				return porudzbenice;
			}
			catch (SqlException ex)
			{
				Console.WriteLine("Greska pri radu sa bazom!");
				Console.WriteLine(ex.Message);
				throw;
			}
		}

		public BindingList<Porudzbenica> vratiPorudzbeniceZaKupca(Radnik r, Kupac k)
		{
			try
			{
				BindingList<Porudzbenica> porudzbenice = new BindingList<Porudzbenica>();
				string upit = $"select * from porudzbenica p join kupac k on p.kupacid=k.id join mesto on postanskibrojmesta=postanskibroj where p.radnikid='{r.Id}' and p.kupacid='{k.Id}'";
				SqlCommand cmd = new SqlCommand(upit, conn);
				SqlDataReader reader = cmd.ExecuteReader();

				while (reader.Read())
				{
					Porudzbenica p = new Porudzbenica();
					p.Id = reader.GetInt64(0);
					p.DatumOd = DateOnly.FromDateTime(reader.GetDateTime(1));
					p.DatumDo = DateOnly.FromDateTime(reader.GetDateTime(2));
					p.UkupnaVr = (float)reader.GetDouble(3);
					p.Radnik = r;
					p.Kupac = k;
					porudzbenice.Add(p);
				}
				return porudzbenice;
			}
			catch (SqlException ex)
			{
				Console.WriteLine("Greska pri radu sa bazom!");
				Console.WriteLine(ex.Message);
				throw;
			}
		}

		public List<StavkaPorudzbenice> vratiStavkeZaPorudzbenicu(Porudzbenica p)
		{
			try
			{
				List<StavkaPorudzbenice> stavke = new List<StavkaPorudzbenice>();
				string upit = $"select * from stavkaporudzbenice sp join artikal a on sp.ArtikalId=a.id where sp.porudzbenicaid='{p.Id}'";
				SqlCommand cmd = new SqlCommand(upit, conn);
				SqlDataReader reader = cmd.ExecuteReader();

				while (reader.Read())
				{
					StavkaPorudzbenice sp = new StavkaPorudzbenice();
					sp.Id=reader.GetInt64(0);
					sp.Kolicina=reader.GetInt64(1);
					sp.CenaStavke=reader.GetDouble(2);
					sp.UkupnaCena=reader.GetDouble(3);
					sp.Porudzbenica = p;
					Artikal a=new Artikal();
					a.Id=reader.GetInt64(6);
					a.Naziv=reader.GetString(7);
					a.Cena = reader.GetDouble(8);
					a.Tip=Enum.Parse<Tip>(reader.GetString(9));
					sp.Artikal = a;
					stavke.Add(sp);
				}
				return stavke;
			}
			catch (SqlException ex)
			{
				Console.WriteLine("Greska pri radu sa bazom!");
				Console.WriteLine(ex.Message);
				throw;
			}
		}

		public void izbrisiStavkeZaPorudzbenicu(Porudzbenica p)
		{
			string upit = $"delete stavkaporudzbenice where porudzbenicaid='{p.Id}'";
			SqlCommand cmd = new SqlCommand(upit, conn);
			cmd.ExecuteNonQuery();
		}

		public void ubaciMesto(Mesto mesto)
		{
			string upit = $"insert into mesto values('{mesto.PostanskiBroj}','{mesto.Naziv}')";
			SqlCommand cmd = new SqlCommand(upit,conn);	
			cmd.ExecuteNonQuery();
		}

		public void obrisiMesto(Mesto m)
		{
			string upit = $"delete mesto where postanskibroj='{m.PostanskiBroj}'";
			SqlCommand cmd = new SqlCommand(upit,conn);
			cmd.ExecuteNonQuery();
		}

		public void izmeniMesto(Mesto m,string ptt)
		{
			string upit = $"update mesto set naziv='{m.Naziv}', postanskibroj='{m.PostanskiBroj}' where postanskibroj='{ptt}'";
			SqlCommand cmd = new SqlCommand(upit, conn);
			cmd.ExecuteNonQuery();
		}

		public void ubaciStrucnuSpremu(StrSprema strSprema)
		{
			string upit = $"insert into StrSprema values('{strSprema.Naziv}','{strSprema.Opis}')";
			SqlCommand cmd = new SqlCommand(upit, conn);
			cmd.ExecuteNonQuery();
		}

		public void obrisiStrucnuSpremu(StrSprema sprema)
		{
			string upit = $"delete strsprema where id='{sprema.Id}'";
			SqlCommand cmd = new SqlCommand(upit, conn);
			cmd.ExecuteNonQuery();
		}

		public void izmeniStrucnuSpremu(StrSprema sprema)
		{
			string upit = $"update strsprema set naziv='{sprema.Naziv}',opis='{sprema.Opis}' where id='{sprema.Id}'";
			SqlCommand cmd = new SqlCommand(upit, conn);
			cmd.ExecuteNonQuery();
		}

		public List<StrSprema> vratiStrucneSpreme()
		{
			List<StrSprema> spreme=new List<StrSprema> ();
			string upit = $"select * from strsprema";
			SqlCommand cmd=new SqlCommand(upit, conn);
			SqlDataReader r = cmd.ExecuteReader();

			while (r.Read())
			{
				StrSprema s = new StrSprema();
				s.Id = r.GetInt64(0);
				s.Naziv = r.GetString(1);
				s.Opis= r.GetString(2);

				spreme.Add(s);
			}

			return spreme;
		}
	}
}
