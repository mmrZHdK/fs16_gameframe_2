using System;
using TextAdventure;

namespace TextAdventure
{
	public class NicolesOrt : Ort
	{
		bool shardsFound = false;

		public NicolesOrt ()
		{
			name = "dining room";
			beschrieb = "An old chandelier coveres the dining room in dull candlelight. ";
			beschrieb += "The huge table is laid for twelve people, but the plates are empty. ";
			beschrieb += "You can feel a cold draught coming from the end of the room, where claret ";
			beschrieb += "draperies hide a series of tinted windows. ";
			beschrieb += "On the right side of the room you see a long case clock. It's pendulum ";
			beschrieb += "is standing still. ";
			//beschrieb += "West to you a small door leads to the kitchen. South to you lies the lobby. ";

			//Dinge im Raum
			Ding pendulum = new Ding ("long case clock with a pendulum"); 
			this.VerknuepfeDing (pendulum);
<<<<<<< HEAD
			Ding table = new Ding ("laid table with chairs"); 
			this.VerknuepfeDing (table);
			Ding vorhang = new Ding ("claret draperies"); 
			this.VerknuepfeDing (vorhang);
			Ding gabel = new Ding ("fork");
=======
			Ding table = new Ding ("laid table"); 
			this.VerknuepfeDing (table);
			Ding scherbe = new Ding ("shard");
			this.VerknuepfeDing (scherbe);
			Ding gabel = new Ding ("fork"); 
>>>>>>> master
			this.VerknuepfeDing (gabel);
		}


		// mögliche Befehle spezifisch im Raum

		public override bool IstCustomCommand(string in_kommando){

<<<<<<< HEAD
			return ((in_kommando == "open window") || (in_kommando == "eat") || (in_kommando == "move pendulum") || (in_kommando == "sit down") ||
=======
			return ((in_kommando == "open window") || (in_kommando == "eat") || (in_kommando == "swing pendulum") || (in_kommando == "sit down") ||
>>>>>>> master
					(in_kommando == "move draperies") ||(in_kommando == "take shard") || (in_kommando == "take fork"));
		}

		// Reaktionen auf mögliche Befehle

		public override void BehandleCustomCommand(string in_kommando){
			if (in_kommando == "open window") {
				string antwort = "There is no way to open the windows. ";
<<<<<<< HEAD
=======
				Console.WriteLine (antwort);
			} else if (in_kommando == "move draperies") {
				string antwort = "Behind the draperies you find a shattered pane. Shards laying around. ";
>>>>>>> master
				Console.WriteLine (antwort);
			} else if (in_kommando == "move draperies") {
				string antwort = "Behind the draperies you find a shattered pane. Shards laying around. ";
				Console.WriteLine (antwort);
				shardsFound = true;
			} else if (in_kommando == "move pendulum") {
				string antwort = "As soon as you bring the pendulum into movement, the clock starts ticking. The hands reach twelve o'clock and a bell rings somewhere far in the mansion. ";
				Console.WriteLine (antwort);
			} else if (in_kommando == "sit down") {
				string antwort = "You sit down at the table. Nothing happens at all. ";
				Console.WriteLine (antwort);
			}	else if (in_kommando == "take shard" && shardsFound == false) {
				string antwort = "Hmmm... that seems to be impossible around here. ";
				Console.WriteLine (antwort);
			}	else if (in_kommando == "take shard" && shardsFound == true) {
				string antwort = "You take up a glass shard. Be carefull- Oh well. A fine cut find its way to your finger. See? Sharp!";
				Console.WriteLine (antwort);
			} else if (in_kommando == "take fork") {
				string antwort = "You take one of the silver forks. It's a really nice fork, polished and pointy. ";
				Console.WriteLine (antwort);
			} else if (in_kommando == "eat") {
				string antwort = "You can't eat anything. The plates are empty and there's nobody in the kitchen to serve you some food. ";
				Console.WriteLine (antwort);
			}
		}
	}
}


