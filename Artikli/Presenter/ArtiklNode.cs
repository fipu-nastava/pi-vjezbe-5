using System;
namespace Artikli
{
	public class ArtiklNode : Gtk.TreeNode
	{
		[Gtk.TreeNodeValue(Column = 0)]
		public String naziv;

		[Gtk.TreeNodeValue(Column = 1)]
		public String cijena;

		public ArtiklNode(Narudzba.Artikl a)
		{
			this.naziv = a.Naziv;
			this.cijena = a.Cijena.ToString("0.00 kn");
		}
	}
}
