using System;
namespace NarucivanjeModel
{
	public class StavkaNode : Gtk.TreeNode
	{
		public NarudzbaStavka original;

		[Gtk.TreeNodeValue(Column = 0)]
		public String redniBroj;

		[Gtk.TreeNodeValue(Column = 1)]
		public String naziv;

		[Gtk.TreeNodeValue(Column = 2)]
		public String cijena;

		[Gtk.TreeNodeValue(Column = 3)]
		public String kom;

		[Gtk.TreeNodeValue(Column = 4)]
		public String ukupno;

		public StavkaNode(int redni, NarudzbaStavka ns)
		{
			this.redniBroj = redni.ToString();

			this.naziv = ns.ArtiklStavke.Naziv;

			this.cijena = ns.ArtiklStavke.Cijena.ToString("0.00 kn");

			this.kom = ns.Kolicina.ToString() + " kom";

			this.ukupno = (ns.Kolicina * ns.ArtiklStavke.Cijena).ToString("0.00 kn");
		}
	}
}
