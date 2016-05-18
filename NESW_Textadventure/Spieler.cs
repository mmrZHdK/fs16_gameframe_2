using System;
using System.Collections.Generic;
using TextAdventure;

namespace TextAdventure
{
	public class Spieler
	{
		// Inventar erstellen, vom abstrakten Datentyp 'List'
		List<Ding> inventar = new List<Ding>();

		public Spieler ()
		{
			// was hier passieren soll, sehen wir noch
		}

		public void InventarAusgeben() {

			// Wenn nichts im Inventar
			if(inventar.Count == 0)
			{
				// Ausgabe
				Console.WriteLine ("You've got nothing in your pocket, sorry.");
			}
			else
			{
				// Ansonsten Inventar auflisten
				Console.WriteLine("Inventory content:");

				// Schleife durchs Inventar
				foreach(Ding ding in inventar)
				{
					// Der Name jedes Dings ausgeben
					Console.WriteLine("-- " + ding.name);
				}
			}
		}

		// Schmeiss Dinge in Inventar
		public void ZuInventar(Ding ding) {
			inventar.Add(ding);
		}

		// Ist im Inventar vorhanden?
		public bool IstImInventar(Ding ding) {
			return inventar.Contains(ding);
		}

		// Aus Inventar entfernen
		public bool AusInventar(Ding ding) {
			return inventar.Remove(ding);
		}
	}
}
