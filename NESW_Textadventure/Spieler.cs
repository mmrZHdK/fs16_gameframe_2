using System;
using TextAdventure;
using System.Collections.Generic; //to use dictionary

namespace TextAdventure
{
	public class Spieler
	{

		Dictionary<string, Ding> inventar =
			new Dictionary<string, Ding>(); 	//I've made a new dictionary for inventory

		public Spieler ()
		{

			// was hier passieren soll, sehen wir noch
		}

		public bool IstEsDrinn (string superCrowbar) {
			if (inventar.ContainsKey (superCrowbar)) {
				return true;
				
			} else {
				return false;
			}
		}







		public void PlaceInInventory(Ding in_neues_ding){			//Placing the new item in the dictionary
			inventar.Add (in_neues_ding.name, in_neues_ding);
		}

		public void InventarAusgeben() {
			if (inventar.Count > 0) {
				foreach (var item in inventar) {
					String something = item.Key;
					Console.WriteLine ("You have a(n) " + something);
				}
			} else {

				Console.WriteLine ("You've got nothing in your pocket, sorry.");
			}
		}
	}
}
