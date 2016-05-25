using System;
using TextAdventure;

namespace TextAdventure
{
	public class SebiDing : Ding
	{




		public SebiDing ( string in_name )
		{
			name = in_name;
		}
		/*
		public override void BehandleKommando( string in_kommando ) {
			Console.WriteLine ("-- Das Ding " + name + " behandelt das Kommando " + in_kommando);

			
			switch (in_kommando) {

		

			case "take":
				this.WechseleStatus ("nehmen");
				Console.WriteLine ("You took " + name + "in your Hand");
				Console.WriteLine ("Don't you feel sorry for that?...");
				break;

			default:
				this.BehandleSpeziellesKommando (in_kommando);
				break;
			}
		}

		public virtual void WechseleStatus( string in_status ) {
			if (in_status == "use") {
				name = "you used " + name;
			}
		}

		public virtual void BehandleSpeziellesKommando( string in_kommando ) {
			// Behandle spezielle Kommandos der Subklassen
		}*/
	
	}
}
