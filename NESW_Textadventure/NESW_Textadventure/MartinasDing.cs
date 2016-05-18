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

			beschrieb = "It's old but it looks like it still serves its purpose. ";
			name = "crowbar";

		}
	}
}

