using System;
using Model;

namespace NoviProzor
{
	public partial class KorisnikWindow : Gtk.Window
	{
		public KorisnikPresenter Presenter = new KorisnikPresenter();

		public KorisnikWindow(Korisnik k) : base(Gtk.WindowType.Toplevel)
		{
			// postavi elemente sučelja
			this.Build();

			// pretplati se na promjene u Presenteru
			Presenter.Promjena += Prikazi;

			// postavi korisnika u Presenter
			Presenter.Korisnik = k;
		}

		// Metoda za prikaz sve informacije što prikazati dobiva iz Presentera
		public void Prikazi(object sender = null, EventArgs e = null)
		{
			// s lijeve strane element sučelja, dok je s desne strane podatak iz Presentera
			labelID.LabelProp = Presenter.ID;
			entryIme.Text = Presenter.Ime;
			entryPrezime.Text = Presenter.Prezime;
		}

		protected void IzmijeniPodatke(object sender, EventArgs e)
		{
			// promijeni unešene podatke nad Presenterom
			Presenter.Ime = entryIme.Text;
			Presenter.Prezime = entryPrezime.Text;

			// odrazi promjene i na model
			Presenter.Spremi();

			// zatvori i uništi prozor
			this.Destroy();
		}
	}
}