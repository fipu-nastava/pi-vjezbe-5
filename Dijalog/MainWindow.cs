using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
	public MainWindow() : base(Gtk.WindowType.Toplevel)
	{
		Build();
	}

	protected void OnDeleteEvent(object sender, DeleteEventArgs a)
	{
		Application.Quit();
		a.RetVal = true;
	}

	protected void showCustomQuestion(object sender, EventArgs e)
	{
		// instanciranje dijaloga sa posebno definiranim gumbima
		// ButtonsType.None označuje da ne želimo koristiti preddefinirane gumbe
		Dialog d = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Question, ButtonsType.None, "Odgovorite na pitanje");

		// Dodaj button "da" i poveži ga na pozitivan odgovor
		d.AddButton("Da", Gtk.ResponseType.Yes);

		// Dodaj button "ne" i poveži ga s negatvnim odgovorom
		d.AddButton("Ne", Gtk.ResponseType.No);

		// Još button za odustajanje
		d.AddButton("Odustani", Gtk.ResponseType.Cancel);

		// metoda koja prikazuje dijalog i čeka povratni odgovor korisnika
		// Tip koji metoda Run vraća je int te ga pretvaramo u Gtk.ResponseType enumeraciju da ga možemo isčitati
		var odgovor = (Gtk.ResponseType) d.Run();

		if (odgovor == Gtk.ResponseType.Yes)
		{
			lOdgovor2.Text = "Da";
		}
		else if (odgovor == Gtk.ResponseType.No)
		{
			lOdgovor2.Text = "Ne";
		}
		else if (odgovor == Gtk.ResponseType.Cancel)
		{
			lOdgovor2.Text = "Korisnik je odustao";
		}
		else
		{
			lOdgovor2.Text = "Korisnik je zatvorio dijalog";
		}

		// nakon što korisnik odgovori, sakrij dijalog
		d.Destroy();
	}

	protected void showError(object sender, EventArgs e)
	{
		// instanciranje dijaloga
		// ButtonsType.Ok označuje da će dijalog imati "OK" button
		Dialog d = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, "Prikaz informacije o grešci");

		// metoda koja prikazuje dijalog i čeka povratni odgovor korisnika
		d.Run();

		// nakon što korisnik odgovori, sakrij dijalog
		d.Destroy();
	}

	protected void showQuestion(object sender, EventArgs e)
	{
		// instanciranje dijaloga s pitanjem
		// ButtonsType.YesNo označuje da će dijalog prikazati DA/NE buttone
		Dialog d = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Question, ButtonsType.YesNo, "Prikaz pitanja");

		// metoda koja prikazuje dijalog i čeka povratni odgovor korisnika
		// Tip koji metoda Run vraća je int te ga pretvaramo u Gtk.ResponseType enumeraciju da ga možemo isčitati
		var odgovor = (Gtk.ResponseType) d.Run();

		if (odgovor == Gtk.ResponseType.Yes)
		{
			lOdgovor1.Text = "DA";
		}
		else if (odgovor == Gtk.ResponseType.No)
		{
			lOdgovor1.Text = "NE";
		}

		// nakon što korisnik odgovori, sakrij dijalog
		d.Destroy();
	}

	protected void showWarning(object sender, EventArgs e)
	{
		// instanciranje dijaloga
		// ButtonsType.Ok označuje da će dijalog imati "OK" button
		Dialog d = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, "Prikaz upozorenja!");

		// metoda koja prikazuje dijalog i čeka povratni odgovor korisnika
		d.Run();

		// nakon što korisnik odgovori, sakrij dijalog
		d.Destroy();
	}

	protected void showInfo(object sender, EventArgs e)
	{
		// instanciranje dijaloga
		// ButtonsType.Ok označuje da će dijalog imati "OK" button
		Dialog d = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "Prikaz informacije");

		// metoda koja prikazuje dijalog i čeka povratni odgovor korisnika
		d.Run();

		// nakon što korisnik odgovori, sakrij dijalog
		d.Destroy();
	}
}