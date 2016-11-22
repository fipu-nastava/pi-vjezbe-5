using System;
using System.Collections.Generic;

namespace Narucivanje
{
	public class StavkaNodeStore : Gtk.NodeStore
	{
		public StavkaNodeStore() : base(typeof(StavkaNode))
		{
		}

		public void Dodaj(List<NarudzbaStavka> stavke)
		{
			for (int i = 0; i < stavke.Count; i++)
			{
				this.AddNode(new StavkaNode(i+1, stavke[i]));
			}
		}
	}
}
