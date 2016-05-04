using System;
using TextAdventure;

namespace TextAdventure
{
	public class MoritzOrt : Ort
	{
		public MoritzOrt ()
		{
			name = "lootroom";
			beschrieb = "There is a chest in the middle of the room";
			beschrieb += "its shiny";
			beschrieb += "so shiny";
			beschrieb += "so very shiny shiny";
			beschrieb += "YA ALREADY SMELLIN DA MANEEY";
			beschrieb += "Its really that fucking shiny, that Chest";
			beschrieb += "Anyways";
			beschrieb += "Besides the sparkly Chest";
			beschrieb += "Oh sparkly is a good word";
			beschrieb += "so very sparkly";
			beschrieb += "Turned on by the feel of the GOLD in your close vicinity";
			beschrieb += "you begin to search for the key.";
			beschrieb += "Your Eyes fall onto a shoemat.";
			beschrieb += "Its super suspiciocous.";

			bool KeyPickup = false;
			bool Shoemat = false;

			String[] Shoematter = { "look below mat", "look below shoemat", "check below mat", "look below shoemat", "procrastinate" };
			String[] Keer = { "take", "gib key", "pick up", "grab", "procrastinate" };
			String[] Chestie = { "open chest", "take shiny", "open", "unlock chest", "procrastinate" };	

//			public override void Los_gehts()
//			{
//				// Textausgabe des Ortes / Beschrieb
//				Console.WriteLine( "You are " + bezug + " the " + name );
//				// Beschrieb ausgeben, haben wir noch nicht
//				Console.WriteLine( beschrieb );
//
//				string kommando;
//				do {
//					// Was will der Spieler tun?
//					Console.WriteLine( "What do you want to do?" );
//					kommando = Console.ReadLine ();
//
//					// Prüfe ob das kommando im Dictionary ist
//					if (base.verknuepfung.ContainsKey (kommando)) {
//						// Hole den Ort, zu dem dieses Kommando führt
//						Ort neuer_ort = base.verknuepfung [kommando];
//						// Ort neuer_ort = verknuepfung.VGet( kommando );
//
//						Console.WriteLine();
//						neuer_ort.Los_gehts ();
//					//prüfe ob einer der StringArrays das kommando enthält > wenn ja prüfe progress und gib entsprechenden string aus.NOCH NICHT GEMACHT.
//
//					} else {
//						Console.WriteLine ("Hmmm... that seems to be impossible around here.");
//						Console.WriteLine();
//					}
//				} while ( !base.verknuepfung.ContainsKey (kommando) ); //OR einer der stringarrays das kommando enthält > Variabel daraus machen
//			}
		}

		public override bool IstCustomCommand( string in_kommando )
		{
			return false;
		}
		public override void BehandleCustomCommand( string in_kommando )
		{
		}
	}
}
