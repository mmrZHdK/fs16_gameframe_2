using System;
using TextAdventure;

namespace TextAdventure
{
	public class NicolesOrt : Ort
	{
		public NicolesOrt ()
		{
			name = "dining room";
			beschrieb = "An old chandelier coveres the dining room in dull candlelight. ";
			beschrieb += "The huge table is laid for twelve people, but the plates are empty. ";
			beschrieb += "You can feel a cold draught coming from the end of the room, where claret ";
			beschrieb += "draperies hide a series of tinted windows. ";
			beschrieb += "On the right side of the room you see a long case clock. It's pendulum ";
			beschrieb += "is standing still. ";
			beschrieb += "West to you a small door leads to the kitchen. South to you lies the lobby. ";
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


