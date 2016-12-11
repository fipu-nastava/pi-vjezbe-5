using System;
namespace Narucivanje
{
	public class Dokument
	{

		public Dokument(long brojDokumenta, DateTime datum)
		{
			this.BrojDokumenta = brojDokumenta;
			this.Datum = datum;
		}

		public long BrojDokumenta { get; set; }

		public DateTime Datum { get; set; }

		public bool Zakljucen { get; set; }

		public void Zakljuci()
		{
			this.Zakljucen = true;
		}
	}
}