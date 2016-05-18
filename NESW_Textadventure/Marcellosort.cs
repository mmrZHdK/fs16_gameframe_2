using System;
using System.Collections.Generic;
using System.Linq;

using TextAdventure;

namespace TextAdventure
{
	public class MarcellosOrt : Ort
	{
		public MarcellosOrt ()
		{
			name = "hidden book chamber";
			bezug = "in";
			beschrieb = "You enter a small chamber that is filled up with books to the top. ";
			beschrieb += "The air is fusty and the dust trickels down as you tap a book.";
			beschrieb += "As you turn your head to the left, you see a small crack in the wall,";
			beschrieb += "but wide enough for a thin body to slip through.";
			beschrieb += "The only source of light originates from the spine of a book. Self-illuminating, it seems...";
			beschrieb += "It's quite far up the bookshelf, you can't reach it.";

			Ding magicbook = new Ding ("Magic Book");
			this.VerknuepfeDing( magicbook);

		}

		//Befehle, die nur in meinem Raum möglich sind
		public override bool IstCustomCommand(string in_kommando){

			return ((in_kommando == "climb") || (in_kommando == "place ladder") || (in_kommando == "open book") || (in_kommando == "take book") || (in_kommando == "squeeze")) ;

			//	

		}





		public override void BehandleCustomCommand(string in_kommando){
			if (in_kommando == "climb") {
				string antwort = "You climb up far enough to reach the glowing book. ";
				Console.WriteLine (antwort);
			} else if (in_kommando == "take book") {
				string antwort = "As you take the glowing book, a slight shiver runs down your spine...";

				Console.WriteLine (antwort);
			}  else if (in_kommando == "open book") {
				if(IstDingKommando("Magic Book")){
				string antwort = "you're holding the glowing book in your hands. As you open it, the glow increases infinitly. It's so bright that you have to close your eyes. The ground begins to shake...";
				Console.WriteLine (antwort);
				Ort neuer_ort = new ArnosOrt();
				neuer_ort.LosGehts();
				}else{
					string antwort = "You don't have that...";
					Console.WriteLine (antwort);
				}
			} else if (in_kommando == "squeeze") {
				string antwort = "You breathe out and move your left arm into the small crack. You managed to pull yourself trough the crack. You are reliefed as you left the crack on the other side.";
				Console.WriteLine (antwort);
				Ort neuer_ort = new SelinasOrt();


				Console.WriteLine();  // Leerzeile ausgeben
				neuer_ort.LosGehts ();	
			}else if (in_kommando == "place ladder") {
				string antwort = "You placed the ladder on the book shelf.";
				Console.WriteLine (antwort);

			}else if (in_kommando == "default") {
				string antwort = "better do something reasonable...";
				Console.WriteLine (antwort);

			}
		}

	}
}


