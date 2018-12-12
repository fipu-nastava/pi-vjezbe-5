using System;
using Gtk;
using NoviProzor;

public partial class MainWindow : Gtk.Window
{
	public MainPresenter Presenter = new MainPresenter();

	public MainWindow() : base(Gtk.WindowType.Toplevel)
	{
		// postavi elemente sučelja
		Build();

		// pretplati se na promjene u Presenteru da bi se odrazile na sučelje
		Presenter.Promjena += Prikazi;
	}

	// prikaži promjene na sučelju iz prezentera
	public void Prikazi(object sender = null, EventArgs e = null)
	{
		labelKorisnik.Text = Presenter.PrijavljeniKorisnik;
	}

	// otvori prozor za uređivanje podataka korisnika
	protected void UrediPodatke(object sender, EventArgs e)
	{
		// instanciraj prozor
		var korisnikWin = new KorisnikWindow();

		// uredi presenter novog prozora (što treba prikazivati)
		korisnikWin.Presenter.Korisnik = Presenter.Korisnik;

		// pretplati se na promjene koje se dogode u novom prozoru (njegovom prezenteru)
		korisnikWin.Presenter.Promjena += Prikazi;
	}

	protected void OnDeleteEvent(object sender, DeleteEventArgs a)
	{
		Application.Quit();
		a.RetVal = true;
	}
}
