using System;
using Gtk;
using Model;

public class KorisnikPresenter : Presenter
{
	private Korisnik korisnik;
	public Korisnik Korisnik
	{
		set
		{
			this.korisnik = value;

			// popuni vrijednosti Presentera
			this.Ime = korisnik.Ime;
			this.Prezime = korisnik.Prezime;

			signalizirajPromjenu();
		}
		get
		{
			return korisnik;
		}
	}

	public void Spremi()
	{
		// odrazi promjene na model

		this.korisnik.Ime = Ime;
		this.korisnik.Prezime = Prezime;

		signalizirajPromjenu ();
	}

	public String ID 
	{
		get
		{
			return this.korisnik.ID.ToString();
		}	
	}

	public String Ime { get; set; }

	public String Prezime { get; set; }
}