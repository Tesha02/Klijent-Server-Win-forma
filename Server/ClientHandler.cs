using Azure.Core;
using Azure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Zajednicki;
using Domain;
using System.Text.Json;

namespace Server
{
	public class ClientHandler
	{
		private Socket klijentskiSoket;
		private readonly BindingList<Radnik> radnici;
		private Radnik ulogovaniRadnik;

		public ClientHandler(Socket klijentskiSoket, BindingList<Radnik> radnici)
		{
			this.klijentskiSoket = klijentskiSoket;
			this.radnici = radnici;
		}

		public void StartHandler()
		{
			try
			{
				NetworkStream stream = new NetworkStream(klijentskiSoket);
				while (true)
				{
					Zahtev request = JsonSerializer.Deserialize<Zahtev>(stream);
					Odgovor response;
					try
					{
						response = ProcessRequest(request);
					}
					catch (Exception ex)
					{
						Debug.WriteLine(">>>" + ex.Message);
						response = new Odgovor();
						response.IsSuccessful = false;
						response.Error = ex.Message;
					}
					JsonSerializer.Serialize(stream, response);
				}
			}
			catch (IOException)
			{
				Console.WriteLine("Doslo je do prekida veze");
				radnici.Remove(ulogovaniRadnik);
			}
			catch (SerializationException)
			{
				Console.WriteLine("Doslo je do prekida veze");
				radnici.Remove(ulogovaniRadnik);

			}
		}

		private Odgovor ProcessRequest(Zahtev request)
		{
			Odgovor response = new Odgovor();
			response.IsSuccessful = true;
			switch (request.Operation)
			{
				//case Operation.ObrisiKorisnika:
				//	Controller.Instance.ObrisiKorisnika((Korisnik)request.RequestObject);
				//	break;
				//case Operation.ObrisiRezervaciju:
				//	Controller.Instance.ObrisiRezervaciju((Rezervacija)request.RequestObject);
				//	break;
				//case Operation.ObrisiTermin:
				//	Controller.Instance.ObrisiTermin((Termin)request.RequestObject);
				//	break;
				//case Operation.ObrisiUslugu:
				//	Controller.Instance.ObrisiUslugu((Usluga)request.RequestObject);
				//	break;
				//case Operation.PretraziKorisnike:
				//	response.Result = Controller.Instance.PretraziKorisnike((Korisnik)request.RequestObject);
				//	break;
				//case Operation.UcitajKorisnika:
				//	response.Result = Controller.Instance.UcitajKorisnika((Korisnik)request.RequestObject);
				//	break;
				//case Operation.UnesiKorisnika:
				//	Controller.Instance.UnesiKorisnika((Korisnik)request.RequestObject);
				//	break;
				//case Operation.UnesiRezervacije:
				//	Controller.Instance.UnesiRezervacije((List<Rezervacija>)request.RequestObject);
				//	break;
				//case Operation.UnesiTermine:
				//	Controller.Instance.UnesiTermine((List<Termin>)request.RequestObject);
				//	break;
				//case Operation.UnesiUslugu:
				//	Controller.Instance.UnesiUslugu((Usluga)request.RequestObject);
				//	break;
				//case Operation.UcitajKorisnike:
				//	response.Result = Controller.Instance.UcitajKorisnike();
				//	break;
				//case Operation.UcitajRezervacije:
				//	response.Result = Controller.Instance.UcitajRezervacije();
				//	break;
				//case Operation.UcitajSale:
				//	response.Result = Controller.Instance.UcitajSale();
				//	break;
				//case Operation.UcitajTermine:
				//	response.Result = Controller.Instance.UcitajTermine();
				//	break;
				//case Operation.UcitajTrenere:
				//	response.Result = Controller.Instance.UcitajTrenere();
				//	break;
				//case Operation.UcitajUsluge:
				//	response.Result = Controller.Instance.UcitajUsluge();
				//	break;
				case Operacija.Login:
					Radnik r = Controller.Instance.Login((Radnik)request.RequestObject);
					if (r != null)
					{
						r.Ulogovan = radnici.Any(rad => rad.KorisnickoIme == r.KorisnickoIme);
						if (!r.Ulogovan)
						{
							ulogovaniRadnik = r;
							radnici.Add(ulogovaniRadnik);
							response.Result = r;
						}
					}
					break;
			}
			return response;
		}

		internal void Stop()
		{
			klijentskiSoket.Close();
		}
	}
}
