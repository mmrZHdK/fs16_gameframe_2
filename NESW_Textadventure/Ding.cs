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


		public void BehandleKommando( string in_kommando ) {
			Console.WriteLine ("-- Das Ding " + name + " behandelt das Kommando " + in_kommando);

			// allgemeine Ding Kommandos behandeln
			// Variante mit IF ELSE IF ELSE
//			if (in_kommando == "examine") {
//				Console.WriteLine (beschrieb);
//
//			} else if (in_kommando == "destroy") {
//				this.WechseleStatus ( "zerstoert" );
//				Console.WriteLine ("You destroyed " + name);
//				Console.WriteLine ("Don't you feel sorry for that?...");
//			}

			// Variante mit SWITCH
			switch (in_kommando) {

			//case "take":
				//Console.WriteLine ("Objekt aufgenommen");
				//break;


			case "examine":
				Console.WriteLine (beschrieb);
				break;

			case "destroy":
				this.WechseleStatus ("zerstoert");
				Console.WriteLine ("You destroyed " + name);
				Console.WriteLine ("Don't you feel sorry for that?...");
				break;

			default:
				this.BehandleSpeziellesKommando (in_kommando);
				break;
			}
		}

		public virtual void WechseleStatus( string in_status ) {
			if (in_status == "zerstoert") {
				name = "destroyed " + name;
			}
		}

		public virtual void BehandleSpeziellesKommando( string in_kommando ) {
			// Behandle spezielle Kommandos der Subklassen
		}
	

	}
}
