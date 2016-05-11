using System;
using TextAdventure;

namespace TextAdventure
{
	public class MyriamsOrt : Ort
	{
		public MyriamsOrt ()
		{
			// Beschreibung was der Spieler in meinem Ort bekommt
			name = "kitchen";
			bezug = "in";
			beschrieb = "It seems that this is the kitchen of the house.\n";
			beschrieb += "It still smells of the last dinner but there is no food left." ;
			beschrieb += "Only in the middle of the table stands a bowl with 4 red apples in it.";
			beschrieb += "Everything glares and seems clean.";
			beschrieb += "You see a dirty knife that is dangerously balancing over the kitchen table. ";
			beschrieb += "Ping!";
			beschrieb += "It fell on the floor and points to a woody old door.";

			// erzeugt ein neues Standart Ding
			//Ding apfel = new Ding ("apple");
			//this.VerknuepfeDing (apfel);

			Ding messer = new Ding ("knife");
			this.VerknuepfeDing (messer);


			MyriamsDing apfel = new MyriamsDing ("apple");
			this.VerknuepfeDing (apfel);


		//	beschrieb += "The woody old door leads you to the pantry.";//South. Speisekammer von Selina
		//	beschrieb += "The old door leads you to the dining room ";//West. Speisesaal von Nicole

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
