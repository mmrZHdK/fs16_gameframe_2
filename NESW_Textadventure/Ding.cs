using System;
using TextAdventure;

namespace TextAdventure
{
	public class Ding
	{
		// -- Properties, die alle Dinge haben sollen
		// Der Name eines Dings
		public string name = "untitled item";
		public string beschrieb;

		public Ding ()
		{
			// leerer Konstruktor, damit ein Ding auch
			// ohne zusätzlichen Namen erzeugt werden kann
			// nötig, damit erbende Klassen einen
			// parameterlosen Konstruktor haben können
			// -- Alternative base (...)
			// TODO
			// -- nachschlagen im Nakov Buch
		}
		public Ding ( string in_name )
		{
			name = in_name;
		}

		public virtual bool HatKommando( string in_kommando ) {
			return false;
		}
	}
}
