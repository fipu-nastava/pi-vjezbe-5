using System;

namespace Model
{
	public class Korisnik
	{
		public long ID { get; }
		public String Ime { get; set; }
		public String Prezime { get; set; }

		public Korisnik(long ID, String ime, String prezime)
		{
			this.ID = ID;
			this.Ime = ime;
			this.Prezime = prezime;
		}
	}
}
