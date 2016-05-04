using System;
using TextAdventure;

namespace TextAdventure
{
	public class Ding
	{
		// -- Properties, die alle Dinge haben sollen
		// Der Name eines Dings
		public string name = "untitled item";

		public Ding()
		{
		}

		public Ding ( string in_name )
		{
			name = in_name;
		}
	}
}
