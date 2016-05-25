using System;
using TextAdventure;

namespace TextAdventure
{
	public class SelinasOrt: Ort
	{
		public SelinasOrt ()
		{
			name = "pantry";
			beschrieb = "It's quiet dark in here. ";
			beschrieb += "Only a small electric bulb ";
			beschrieb += "is bringing some faint light in the small chamber. ";
			beschrieb += "In the south is the door to the kitchen. ";
			beschrieb += "All other walls are covered with shelves which are packed with canned food. ";
			beschrieb += "You see a rat sneaking around the shelves. ";


			//Dinge in meinem Raum
			Ding ravioli = new Ding ("canned ravioli");
			this.VerknuepfeDing(ravioli);
			Ding gab = new Ding ("crack in the wall");
			this.VerknuepfeDing(gab);

			//Spezial Dinge
			SelinaDing ratte = new SelinaDing(name);
			this.VerknuepfeDing (ratte);
		}

		//Befehle, die nur in meinem Raum möglich sind
		public override bool IstCustomCommand(string in_kommando){

			return ((in_kommando == "look") || (in_kommando == "squeeze thorugh") || (in_kommando == "catch rat") || (in_kommando == "cook ravioli")) ;

		}

		public override void BehandleCustomCommand(string in_kommando){
			if (in_kommando == "look") {
				string antwort = "You take a closer look at the walls and find a crack in the east wall! It's big enough for a human to squeeze through. ";
				Console.WriteLine (antwort);

			} else if (in_kommando == "cook ravioli") {
				string antwort = "It's a good idea to warm them up but you don't have any cooking facilities in here. ";
				Console.WriteLine (antwort);

			} else if (in_kommando == "catch rat") {
				string antwort = "The rat is to swift. You can't catch it. ";
				Console.WriteLine (antwort);

			} else if (in_kommando == "squeeze through") {
				string antwort = "You managed to squeeze through the crack. ";
				Console.WriteLine (antwort);
				// Marcels Raum aufrufen
				// MarcellosOrt.LosGehts ();


			}
		}
	}
}
