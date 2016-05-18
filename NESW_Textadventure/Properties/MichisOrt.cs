using System;
using TextAdventure;

namespace TextAdventure
{
	public class MichisOrt : Ort
	{
		public MichisOrt ()
		{
			name = "forgotten well";
			beschrieb = "Brittle stones frame a small, abandoned well amidst the trees";
			beschrieb += "An old kettle sways in the wind, hold by a rusty chain";
			beschrieb += "To your right you can see a leather that leads to a rotten treehouse";
			beschrieb += "On your left is an overgrown winder behind a few plant pots full of weed";
			beschrieb += "A strange voice comes out of the hole";
			//cut thorns (need sword or something else to cut) to use winder, to save helpful gnome who's trapped down the well
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
