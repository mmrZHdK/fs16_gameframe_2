using System;
using TextAdventure;

namespace TextAdventure
{
	    class MartinasOrt : Ort
	    {
		        public MartinasOrt ()
		{
			name = "crooked shed";

			beschrieb += "A dim light falls through the small window to your right.";
			beschrieb += "\nUnder the window, you can see different garden tools, covered in cobwebs.";
			beschrieb += "\nOn your left, there are a few wooden boards, leaned against the wall";
			beschrieb += "\nA piece of rope lies on the dusty floor\n";
			        
		

			// Dinge in meinem Raum
			Ding Seil = new Ding ("rope");
			this.VerknuepfeDing (Seil);

			//Spezielles Ding
			MartinasDing Brecheisen = new MartinasDing(name);
			this.VerknuepfeDing (Brecheisen);

		}
			
		bool trapDoorOpen = false; // "Go downstairs" soll nur funktionieren, wenn die Falltüre offen ist

		//Befehle, die nur in meinem Raum möglich sind
		public override bool IstCustomCommand( string in_kommando )
		{
			return ((in_kommando == "take tool") || (in_kommando == "take broom") || 
			(in_kommando == "take hose") || (in_kommando == "take board") || (in_kommando == "take crowbar") ||
			(in_kommando == "take rope") || (in_kommando == "open trap door") || (in_kommando == "go downstairs"));

		}
		public override void BehandleCustomCommand( string in_kommando )
		{
			if (in_kommando == "take tool") {
				string antwort = ("\nThe tools look very old and dirty, but you can identify a broken broom,\na hose and a crowbar.\n");
				Console.WriteLine (antwort);
			} else if (in_kommando == "take broom") {
				string antwort = ("\nYou hold the broken broom in your hands when you realise,\nit's completely useless. You put it back.\n");
				Console.WriteLine (antwort);
			} else if (in_kommando == "take hose") {
				string antwort = ("\nThe hose is attached to the ground, you can't pick it up.\n");
				Console.WriteLine (antwort);
			} else if (in_kommando == "take board") {
				string antwort = ("\nYou examine the boards, but there is nothing behind them.\nYou try to pick one up but it's to heavy to lift.\n");
				Console.WriteLine (antwort);
			} else if (in_kommando == "take crowbar") {
				string antwort = ("\nYou take the crowbar, after you removed the cobwebs on it,\nof course.\n");
				//Ding crowbar in inventar
				Console.WriteLine (antwort);
			} else if (in_kommando == "take rope") {
				string antwort = ("\nThe rope is attached to the floor.\nYou pull harder and the rope snaps\nYou now have a torn piece of rope.\nYou examine the place where the rope was tied to.\nYou can see a trap door, hiding under the dust.\n");
				//Ding rope in inventar (braucht jemand ein rope??)
				Console.WriteLine (antwort);
			} else if (in_kommando == "open trap door") { //| (in_kommando == "open door") {
				// if Ding crowbar in inventar:
				string antwort = ("\nYou pry open the door with the crowbar. You can see stairs leading down");
				Console.WriteLine (antwort);
				trapDoorOpen = true;
				// else: “You try to open the trap door but it's blocked. You need a device to help you open it.
			} else if ((in_kommando == "go downstairs") && (trapDoorOpen == true)) {
				string antwort = ("\nYou go downstairs into the darkness.");
				Console.WriteLine (antwort);
				//SashasOrt.LetsGo ();
			} else {
				Console.WriteLine ("\nHmmm... that seems to be impossible around here.");
			}
			

		}

	}
}
