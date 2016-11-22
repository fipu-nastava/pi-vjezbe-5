using System;
using System.Collections.Generic;

namespace Narucivanje
{
	public class NarudzbaNodeStore : Gtk.NodeStore
	{
		public NarudzbaNodeStore() : base(typeof(NarudzbaNode))
		{
		}

		internal void Dodaj(List<Narudzba> narudzbe)
		{
			foreach (var n in narudzbe)
			{
				this.AddNode(new NarudzbaNode(n));
			}
		}
	}
}
