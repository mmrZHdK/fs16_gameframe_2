using System;
using TextAdventure;
using System.Collections.Generic;    //to use dictionary

namespace TextAdventure
{
	public class Spieler
	{
		Dictionary<string, Ding> inventar =
			new Dictionary<string, Ding>();     //I've made a new dictionary for inventory


		public Spieler ()
		{


			// was hier passieren soll, sehen wir noch
		}

		public void PlaceInInventar(Ding in_neues_ding){     //The function for placing the new item in the dictionary
			inventar.Add (in_neues_ding.name, in_neues_ding);
		}

		public Ding RemoveFromInventar(string thing){
			Ding ding = inventar [thing];
			inventar.Remove (thing);
			return ding;
		}

		public bool IsItInInventar(string whatToSearch){
			
			bool yes = false;
			foreach (var item in inventar) {
				String das = item.Key;
				if (das == whatToSearch) {
					yes = true;
				} else {
				}
			}
			return yes;
		
		}

		public void InventarAusgeben() {
			if (inventar.Count>0){
				foreach(var item in inventar){
					String something = item.Key;
					Console.WriteLine("You have " + something);	
				}
			}
			else{
				Console.WriteLine ("You've got nothing in your pocket, sorry.");
			}
		}
	}
}
