using System;
using TextAdventure;

namespace TextAdventure
{
	public class SebisOrt : Ort
	{
		public SebisOrt ()
		{
			name = "Treehouse";
			beschrieb = "This Treehouse looks very old.I should be careful, rusty Nails everywhere";
			beschrieb += "A strange Smell is in the air. A dead Honeybadger lies in the corner  ";
			beschrieb += "There is a red Cross written on the wall. ";
			beschrieb += "An old Bonsai is standing on the floor. ";
			beschrieb += "The Wind is shaking the little Treehouse";
			beschrieb += "Is there something under the dead Honeybadger?";
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