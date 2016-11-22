using System;
using Gtk;
using NoviProzor;
using Model;

public partial class MainWindow : Gtk.Window
{
	public MainPresenter Presenter = new MainPresenter();

	public MainWindow(Korisnik k) : base(Gtk.WindowType.Toplevel)
	{
		// postavi elemente sučelja
		Build();

		// pretplati se na promjene u Presenteru da bi se odrazile na sučelje
		Presenter.Promjena += Prikazi;

		// postavi korisnika u Presenteru
		Presenter.Korisnik = k;
	}

	// iscrtaj promjene na sučelju
	public void Prikazi(object sender = null, EventArgs e = null)
	{
		labelKorisnik.Text = Presenter.PrijavljeniKorisnik;
	}

	// otvori prozor za uređivanje podataka korisnika
	protected void UrediPodatke(object sender, EventArgs e)
	{
		// instanciraj prozor i predaj korisnika kao parametar
		var korisnikWin = new KorisnikWindow(Presenter.Korisnik);

		// pretplati se na promjene u novom prozoru
		korisnikWin.Presenter.Promjena += Prikazi;
	}

	protected void OnDeleteEvent(object sender, DeleteEventArgs a)
	{
		Application.Quit();
		a.RetVal = true;
	}
}
