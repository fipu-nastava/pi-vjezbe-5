using System;
using Gtk;

namespace Artikli
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Application.Init();
			ArtiklWindow win = new ArtiklWindow();
			win.Show();
			Application.Run();
		}
	}
}