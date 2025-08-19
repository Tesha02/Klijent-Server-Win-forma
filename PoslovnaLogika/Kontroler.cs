using BrokerBazePodataka;
using Domain;
using System.ComponentModel;

namespace PoslovnaLogika
{
	public class Kontroler
	{
		private Broker broker = new Broker();

		#region singlton
		private static Kontroler instance;
		private static object _lock = new object();
		private Kontroler()
		{
			repository = new GenericRepository();
		}
		public static Controller Instance
		{
			get
			{
				if (instance == null)
				{
					lock (_lock)
					{
						if (instance == null)
						{
							instance = new Controller();
						}
					}
				}
				return instance;
			}
		}
		#endregion

		public void izbaciStavku(StavkaPorudzbenice sp)
		{
			broker.Connect();
			try
			{
				broker.izbaciStavku(sp);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				throw;
			}
			finally
			{
				broker.Disconnect();
			}
		}

		public void izbrisiStavkeZaPorudzbenicu(Porudzbenica prosledjenaPorudzbenica)
		{
			broker.Connect();
			try
			{
				broker.izbrisiStavkeZaPorudzbenicu(prosledjenaPorudzbenica);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				throw;
			}
			finally
			{
				broker.Disconnect();
			}
		}

		public void izmeniArtikal(Artikal a)
		{
			broker.Connect();
			try
			{
				broker.izmeniArtikal(a);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				throw;
			}
			finally
			{
				broker.Disconnect();
			}
		}

		public void izmeniKupca(Kupac izmenjenKupac)
		{
			broker.Connect();
			try
			{
				broker.izmeniKupca(izmenjenKupac);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				throw;
			}
			finally
			{
				broker.Disconnect();
			}
		}

		public void izmeniMesto(Mesto mesto,string ptt)
		{
			broker.Connect();
			try
			{
				broker.izmeniMesto(mesto,ptt);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				throw;
			}
			finally
			{
				broker.Disconnect();
			}
		}

		public void izmeniStrucnuSpremu(StrSprema prosledjenaSprema)
		{
			broker.Connect();
			try
			{
				broker.izmeniStrucnuSpremu(prosledjenaSprema);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				throw;
			}
			finally
			{
				broker.Disconnect();
			}
		}

		public Radnik Login(string ks, string loz)
		{
			broker.Connect();
			try
			{
				Radnik r = broker.getRadnikByUserPass(ks,loz);
				return r;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				throw;
			}
			finally
			{
				broker.Disconnect();
			}

		}

		public void obrisiMesto(Mesto? m)
		{
			broker.Connect();
			try
			{
				broker.obrisiMesto(m);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				throw;
			}
			finally
			{
				broker.Disconnect();
			}
		}

		public void obrisiStrucnuSpremu(StrSprema? sprema)
		{
			broker.Connect();
			try
			{
				broker.obrisiStrucnuSpremu(sprema);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				throw;
			}
			finally
			{
				broker.Disconnect();
			}
		}

		public Boolean ubaciArtikal(Artikal a)
		{
			broker.Connect();
			try
			{
				return broker.ubaciArtikal(a);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				throw;
			}
			finally
			{
				broker.Disconnect();
			}
			
		}
	

		public void ubaciKupca(Kupac k)
		{
			broker.Connect();
			try
			{
				broker.ubaciKupca(k);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				throw;
			}
			finally
			{
				broker.Disconnect();
			}
		}

		public void ubaciMesto(Mesto mesto)
		{
			broker.Connect();
			try
			{
				broker.ubaciMesto(mesto);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				throw;
			}
			finally
			{
				broker.Disconnect();
			}
		}

		public long ubaciPorudzbenicu(Porudzbenica p)
		{
			broker.Connect();
			try
			{
				return broker.ubaciPorudzbenicu(p);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				throw;
			}
			finally
			{
				broker.Disconnect();
			}
		}

		public void ubaciStavku(StavkaPorudzbenice sp)
		{
			broker.Connect();
			try
			{
				broker.ubaciStavku(sp);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				throw;
			}
			finally
			{
				broker.Disconnect();
			}
		}

		public void ubaciStrucnuSpremu(StrSprema strSprema)
		{
			broker.Connect();
			try
			{
				broker.ubaciStrucnuSpremu(strSprema);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				throw;
			}
			finally
			{
				broker.Disconnect();
			}
		}

		public BindingList<Artikal> vratiArtikleIzBaze()
		{
			broker.Connect();
			try
			{
				return broker.vratiArtikle();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				throw;
			}
			finally
			{
				broker.Disconnect();
			}
		}

		public BindingList<Artikal> vratiArtiklePoTipu(Tip t)
		{
			broker.Connect();
			try
			{
				return broker.vratiArtiklePoTipu(t);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				throw;
			}
			finally
			{
				broker.Disconnect();
			}
		}

		public BindingList<Kupac> vratiKupce()
		{
			broker.Connect();
			try
			{
				return broker.vratiKupce();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				throw;
			}
			finally
			{
				broker.Disconnect();
			}

		}

		public List<Mesto> vratiMestaIzBaze()
		{
			broker.Connect();
			try
			{
				return broker.vratiMestaIzBaze();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				throw;
			}
			finally
			{
				broker.Disconnect();
			}
		}

		public BindingList<Porudzbenica> vratiPorudzbeniceZaKupca(Radnik r, Kupac k)
		{
			broker.Connect();
			try
			{
				return broker.vratiPorudzbeniceZaKupca(r,k);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				throw;
			}
			finally
			{
				broker.Disconnect();
			}
		}

		public BindingList<Porudzbenica> vratiPorudzbeniceZaRadnika(Radnik r)
		{
			broker.Connect();
			try
			{
				return broker.vratiPorudzbeniceZaRadnika(r);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				throw;
			}
			finally
			{
				broker.Disconnect();
			}
		}

		public BindingList<StavkaPorudzbenice> vratiStavkeIzBaze()
		{
			broker.Connect();
			try
			{
				return broker.vratiStavke();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				throw;
			}
			finally
			{
				broker.Disconnect();
			}
		}

		public List<StavkaPorudzbenice> vratiStavkeZaPorudzbenicu(Porudzbenica p)
		{
			broker.Connect();
			try
			{
				return broker.vratiStavkeZaPorudzbenicu(p);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				throw;
			}
			finally
			{
				broker.Disconnect();
			}
		}

		public List<StrSprema> vratiStrucneSpreme()
		{
			broker.Connect();
			try
			{
				return broker.vratiStrucneSpreme();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				throw;
			}
			finally
			{
				broker.Disconnect();
			}
		}
	}
}
