using System;
namespace Narucivanje
{
	public class NarudzbaNode : Gtk.TreeNode
	{
		public Narudzba original;

		[Gtk.TreeNodeValue(Column = 0)]
		public String broj;

		[Gtk.TreeNodeValue(Column = 1)]
		public String datum;

		[Gtk.TreeNodeValue(Column = 2)]
		public String datumDostave;

		[Gtk.TreeNodeValue(Column = 3)]
		public String brojStavaka;

		public NarudzbaNode(Narudzba n)
		{
			this.original = n;
			this.broj = n.Datum.ToString("yyyy") + "-" + n.BrojDokumenta.ToString().PadLeft(10, '0');
			this.datum = n.Datum.ToString("dd.MM.yyyy hh:mm:ss");
			this.datumDostave = n.DatumDostave.ToString("dd.MM.yyyy hh:mm:ss");
			this.brojStavaka = n.Stavke.Count.ToString();
		}
	}
}