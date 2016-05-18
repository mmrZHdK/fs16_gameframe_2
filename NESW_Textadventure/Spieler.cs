using System;
using System.Collections.Generic;
using System.Linq;

using TextAdventure;

namespace TextAdventure
{
	public class Spieler
	{
		protected Dictionary<string, Ding> dinge =
			new Dictionary<string, Ding>();

		public Spieler ()
		{
			// was hier passieren soll, sehen wir noch
		}

		public void InventarAusgeben() {
			if (dinge.Count > 0) {
				// Gib Liste der Dinge aus
				Console.Write( "You've got the following things in your pocket: " );

				foreach (var ding_eintrag in dinge) {
					string name = ding_eintrag.Key;

					if ( !ding_eintrag.Equals( dinge.Last() ) ) {
						Console.Write( name + ", " );
					} else {
						Console.WriteLine( name + "." );
					}
				}

			} else {
				// Leider nichts im Inventar
				Console.WriteLine ("You've got nothing in your pocket, sorry.");
			}
		}

		public void ZuInventarDazu( Ding in_ding ) {
			// Ding in das Dictionary dazu
			dinge[ in_ding.name ] = in_ding;
		}

		public Ding AusInventarEntfernen( string in_name ) {
			// schaue, ob der Name im dinge Dictionary ist
			// wenn ja, entferne aus dem Dictionary und
			// gib zurück
			return null;
		}

	}
}
