using System;
using TextAdventure;

namespace TextAdventure
{
	public class MarcellosOrt : Ort
	{
		public MarcellosOrt ()
		{
			name = "hidden book chamber";
			beschrieb = "You enter a small chamber that is filled up with books to the top. ";
			beschrieb += "The air is fusty and the dust trickels down as you tap a book.";
			beschrieb += "As you turn your head to the left, you see a small crack in the wall,";
			beschrieb += "but wide enough for a thin body to slip through.";
			beschrieb += "The only source of light originates from the spine of a book. Self-illuminating, it seems...";
			beschrieb += "It's quite far up the bookshelf, you can't reach it.";
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


