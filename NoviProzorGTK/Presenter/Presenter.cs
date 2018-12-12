using System;
public class Presenter
{
	public event EventHandler Promjena;

	protected void signalizirajPromjenu()
	{
		EventHandler h = Promjena;
		if (h != null)
		{
			h(this, new EventArgs());
		}
	}
}