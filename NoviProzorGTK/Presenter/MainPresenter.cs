using System;
using Gtk;
using Model;

public class MainPresenter : Presenter
{
	private Korisnik korisnik;
	public Korisnik Korisnik
	{
		set
		{
			this.korisnik = value;
			signalizirajPromjenu();
		}
		get
		{
			return this.korisnik;
		}
	}

	public String PrijavljeniKorisnik
	{
		get
		{
			return "(ID=" + korisnik.ID + ") " + korisnik.Ime + " " + korisnik.Prezime;
		}
	}
}