using System;
using TextAdventure;

namespace TextAdventure
{

	// Ein spezial Ding
	public class SelinaDing: Ding
	{
		// Übernimmt die Parameter
		public SelinaDing (string in_name) : base(in_name)
		{
			
			beschrieb = "It's a cut little thing with sharp teeth. ";
			name = "rat";
			
		}
	}
}

