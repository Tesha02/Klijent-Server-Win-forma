using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
	public class PrSS
	{
		public long RadnikId { get; set; }
		public long StrSpremaId { get; set; }
		public DateOnly DatumIzdavanja { get; set; }
		public Radnik Radnik { get; set; }
		public StrSprema StrSprema { get; set; }
		
	}
}
