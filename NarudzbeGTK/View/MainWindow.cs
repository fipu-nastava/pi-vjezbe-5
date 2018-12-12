using System;
using Gtk;
using NarucivanjeModel;
using System.Collections.Generic;

public partial class MainWindow : Gtk.Window
{
	private StavkaNodeStore stavkePresenter;

	public MainWindow() : base(Gtk.WindowType.Toplevel)
	{
		Build();

		Artikl a1 = new Artikl("Mlijeko 2.5%mm", 2.32);
		Artikl a2 = new Artikl("Kruh Brionka bijeli", 5.44);
		Artikl a3 = new Artikl("Maslac 500g", 10.44);

		// instanciraj nekoliko narudžbi
		var n1 = new Narudzba(1, DateTime.Now.AddDays(-4), DateTime.Now.AddDays(1));
		n1.DodajStavku(a1, 13);
		var n2 = new Narudzba(2, DateTime.Now.AddDays(-3), DateTime.Now.AddDays(4));
		n2.DodajStavku(a1, 31);
		n2.DodajStavku(a2, 4);
		var n3 = new Narudzba(3, DateTime.Now.AddDays(-2), DateTime.Now.AddDays(5));
		n3.DodajStavku(a1, 3);
		n3.DodajStavku(a2, 4);
		n3.DodajStavku(a3, 3);
		var n4 = new Narudzba(4, DateTime.Now.AddDays(-1));
		n4.DodajStavku(a1, 2);
		n4.DodajStavku(a3, 12);

		// dodaj ih u kolekciju narudžbi
		var narudzbe = new List<Narudzba> { n1, n2, n3, n4 };

		// instanciraj Presentera narudžbi
		var narudzbaPresenter = new NarudzbaNodeStore();
		// dodaj unutra narudžbe
		narudzbaPresenter.Dodaj(narudzbe);

		// poveži Presenter sa View za narudžbu
		nvNarudzbe.NodeStore = narudzbaPresenter;
		// dodaj potrebne kolone za prikaz narudžbe
		nvNarudzbe.AppendColumn("Broj narudžbe", new Gtk.CellRendererText(), "text", 0);
		nvNarudzbe.AppendColumn("Datum narudžbe", new Gtk.CellRendererText(), "text", 1);
		nvNarudzbe.AppendColumn("Datum dostave", new Gtk.CellRendererText(), "text", 2);

		// instanciraj Presenter za stavke
		stavkePresenter = new StavkaNodeStore();

		// poveži Presenter sa Viewom za stavku
		nvStavke.NodeStore = stavkePresenter;
		// dodaj potrebne kolone za prikaz stavke
		nvStavke.AppendColumn("RBR", new Gtk.CellRendererText(), "text", 0);
		nvStavke.AppendColumn("Artikl", new Gtk.CellRendererText { Width = 300 }, "text", 1);
		nvStavke.AppendColumn("Cijena", new Gtk.CellRendererText { Xalign = 1, Width = 100 }, "text", 2);
		nvStavke.AppendColumn("Količina", new Gtk.CellRendererText { Xalign = 1, Width = 50 }, "text", 3);
		nvStavke.AppendColumn("Ukupno", new Gtk.CellRendererText { Xalign = 1, Width = 100 }, "text", 4);

		// pretplata na događaj promjene selektirane stavke
		nvNarudzbe.NodeSelection.Changed += this.RowSelected;
	}

	void RowSelected(object sender, EventArgs e)
	{
		// dohvat selektirane stavke
		NodeSelection selected = (NodeSelection) sender;
		// znamo da je selektirana stavka tipa NarudzbaNode pa možemo napraviti cast
		var selectedNarudzba = (NarudzbaNode) selected.SelectedNode;

		// Promjeni ispis labeli na selektiranu stavku
		lBrojDokumenta.LabelProp = selectedNarudzba.datum;
		lDatum.LabelProp = selectedNarudzba.datumDostave;
		lBrojStavaka.LabelProp = selectedNarudzba.brojStavaka;

		// promjena prikazanih stavki

		// obriši trenutne stavke u view-modelu
		nvStavke.NodeStore.Clear();

		// dodaj nove
		stavkePresenter.Dodaj(selectedNarudzba.original.Stavke);
	}

	protected void OnDeleteEvent(object sender, DeleteEventArgs a)
	{
		Application.Quit();
		a.RetVal = true;
	}
}
