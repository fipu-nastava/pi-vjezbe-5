using System;
using Gtk;
using Narudzba;
using System.Collections.Generic;

namespace Artikli
{
	public partial class ArtiklWindow : Gtk.Window
	{
		public List<Artikl> artikli = new List<Artikl>();

		// presenter koji je povezan na ovaj view
		ArtiklNodeStore artikliPresenter;

		public ArtiklWindow() : base(Gtk.WindowType.Toplevel)
		{
			Build();

			artikli.Add(new Artikl("Mlijeko 2.5%", 4.49));
			artikli.Add(new Artikl("Kruh 500g", 5.49));
			artikli.Add(new Artikl("Čipi cips 200g", 15.23));
			artikli.Add(new Artikl("Mlijeko 3.2%", 5.23));

			artikliPresenter = new ArtiklNodeStore();
			artikliPresenter.Dodaj(artikli);

			popisArtikala.NodeStore = artikliPresenter;
			popisArtikala.AppendColumn("Naziv", new Gtk.CellRendererText(), "text", 0);
			popisArtikala.AppendColumn("Cijena", new Gtk.CellRendererText(), "text", 1);

			popisArtikala.NodeSelection.Changed += this.RowSelected;
		}

		protected void OnDeleteEvent(object sender, DeleteEventArgs a)
		{
			Application.Quit();
			a.RetVal = true;
		}

		protected void RowSelected(object o, EventArgs args)
		{
			var selectedArtikl = (ArtiklNode) popisArtikala.NodeSelection.SelectedNode;

			labelRedak.LabelProp = selectedArtikl.naziv;

			//artikliPresenter.Add(new Artikl("Mlijeko 2.5%", 4.49));
		}
	}
}