using System;
using TextAdventure;

namespace TextAdventure
{

	// Ein spezial Ding
	public class MartinasDing: Ding
	{
		// Übernimmt die Parameter
		public MartinasDing (string in_name) : base(in_name)
		{

			beschrieb = "Although it's old, it still looks sturdy. ";
			name = "crowbar";

		}
	}
}

