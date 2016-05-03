using System;
using TextAdventure;

namespace TextAdventure
{
	public class SashasOrt : Ort
	{
		public SashasOrt ()
		{
			name = "mysterious dungeon";
			beschrieb = "You are in a dungeon under the villa. It's dark and creepy.";
			beschrieb += "You feel something has happened here a long time ago.";
			beschrieb += "Now it is empty and the floor is covered with dust. You notice an old hammer on the floor.";
			beschrieb += "Someone left footprints near the south wall and there is a torch on that wall.";
			beschrieb += "It looks like no one has ever lighted it.";

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
