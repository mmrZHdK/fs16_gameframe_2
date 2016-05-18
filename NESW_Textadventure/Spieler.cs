using System;
using System.Collections.Generic;
using TextAdventure;

namespace TextAdventure
{
	public class Spieler
	{

		public List Inventar = new List<Ding>();

		public Spieler ()
		{
			

			// was hier passieren soll, sehen wir noch
		}

		public void InventarAusgeben() {
			Console.WriteLine ("You've got nothing in your pocket, sorry.");
		}
	}
}
