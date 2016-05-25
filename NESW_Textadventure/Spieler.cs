using System;
using TextAdventure;
using System.Collections.Generic;	//um das Dictionary zu nutzen

namespace TextAdventure
{
	public class Spieler
	{
		Dictionary<string, Ding> inventar =
			new Dictionary<string, Ding> ();		//neues Dictionary für das Inventar
		public Spieler ()
		{
			// was hier passieren soll, sehen wir noch
		}
		public void PlaceInInventar(Ding in_neues_ding){		//Funktion, die dass neue Item ins Dictionary eingibt
			inventar.Add (in_neues_ding.name, in_neues_ding);
		}


		public void InventarAusgeben() {
			if (inventar.Count > 0) {
				foreach (var item in inventar) {
					String something = item.Key;
					Console.WriteLine ("You have " + something);
				}
			} else {
				Console.WriteLine ("You've got nothing in your pocket, sorry.");
			}
		}
	}
}
