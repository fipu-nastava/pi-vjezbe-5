using System;
using Gtk;
using Model;

namespace NoviProzor
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Application.Init();

			// postavi trenutnog korisnika aplikacije
			Korisnik k = new Korisnik(101, "Hrvoje", "Horvat");

			// instanciraj glavni prozor i predaj korisnika kao parametar
			MainWindow win = new MainWindow();
			win.Presenter.Korisnik = k;
				
			// prikaži glavni prozor
			win.Show();

			Application.Run();
		}
	}
}
