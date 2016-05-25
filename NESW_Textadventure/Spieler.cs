using System;
using System.Collections.Generic;
//Mach Listen-Benutzung möglich!
using TextAdventure;

namespace TextAdventure
{
	public class Spieler
	{

		public List<Ding> Inventar = new List<Ding>();

		public Spieler ()
		{
			

			// was hier passieren soll, sehen wir noch
		}

		public void InventarAusgeben() {
			Console.WriteLine ("You've got nothing in your pocket, sorry.");
		}

	}
}
