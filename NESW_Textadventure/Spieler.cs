using System;
using TextAdventure;
using System.Collections.Generic; //um Dictionary zu benutzen

namespace TextAdventure
{
	public class Spieler
	{
		//Dictionary für das Inventar
		Dictionary<string, Ding> inventar =
			new Dictionary<string, Ding> ();
		
		public Spieler ()
		{
			
			
			// was hier passieren soll, sehen wir noch
		}

		//Methode, die das Ding ins Inventar tut
		public void PlaceInInventar(Ding in_neues_ding){
			inventar.Add (in_neues_ding.name, in_neues_ding);
		}


		public void InventarAusgeben() {
			//prüfen, ob etwas im Inventar ist
			if (inventar.Count > 0) {
				foreach (var item in inventar) {
					string something = item.Key;
					//falls etwas im Dictionary des Inventars ist, gibt dies die Konsole aus
					Console.WriteLine ("You've got " + something + " in your inventrory.");
				}
			} else {
				Console.WriteLine ("You've got nothing in your pocket, sorry.");
			}
		}
	}
}
