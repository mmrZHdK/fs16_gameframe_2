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

