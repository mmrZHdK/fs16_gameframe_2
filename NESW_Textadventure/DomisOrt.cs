using System;
using TextAdventure;

namespace TextAdventure
{
	public class DomisOrt : Ort
	{
		public DomisOrt ()
		{
            Raven raven = new Raven();
            this.VerknuepfeDing(raven);
            name = "Villas Roof";
			beschrieb = "The roof is made out of Clay Tiles.";
			beschrieb += "There is a smoking chimney on the other side, but the footing on the tiles seems insecure.";
            beschrieb += "Theres a drop of about 20 meters on both sides, if you fall you will surely die.";
            beschrieb += "To the left you can see a light from down below, out of the garden.";
			beschrieb += "Some Ravens fly above, one of them lands on the chimney.";
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
