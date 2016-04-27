using System;
using TextAdventure;

namespace TextAdventure
{
	public class MyriamsOrt : Ort
	{
		public MyriamsOrt ()
		{
			name = "kitchen";
			bezug = "in";
			beschrieb = "It seems that this is the kitchen of the house.\n";
			beschrieb += "It still smells of the last dinner but there is no food left." ;
			beschrieb += "Everything glares and seems clean.";
			beschrieb += "You see a dirty knife that is dangerously balancing over the kitchen table. ";
			beschrieb += "Ping!";
			beschrieb += "It fell on the floor and points to a woody old door.";

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
