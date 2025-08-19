using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Server
{
	public class Server
	{
		private Socket osluskujuciSoket;
		private List<ClientHandler> klijenti = new List<ClientHandler>();
		private BindingList<Radnik> radnici = new BindingList<Radnik>();

		public BindingList<Radnik> Administartori { get { return radnici; } }

		public Server()
		{
			osluskujuciSoket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
		}

		public void Start()
		{
			osluskujuciSoket.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), int.Parse(ConfigurationManager.AppSettings["port"])));
		}

		public void Listen()
		{
			osluskujuciSoket.Listen(5);
			bool kraj = false;
			while (!kraj)
			{
				try
				{
					Socket klijentskiSoket = osluskujuciSoket.Accept();
					ClientHandler handler = new ClientHandler(klijentskiSoket, administratori);
					klijenti.Add(handler);
					Thread klijentskaNit = new Thread(handler.StartHandler);
					klijentskaNit.IsBackground = true;
					klijentskaNit.Start();
				}
				catch (SocketException)
				{
					Console.WriteLine("Kraj rada");
					kraj = true;
				}
			}
		}

		public void Stop()
		{
			osluskujuciSoket.Close();
			foreach (ClientHandler c in klijenti)
			{
				c.Stop();
			}
			klijenti.Clear();
		}

	}
}
