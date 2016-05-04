using System;
using TextAdventure;

namespace TextAdventure
{
	    class MartinasOrt : Ort
	    {
		        public MartinasOrt ()
		        {
			            name = "crooked shed";

			            beschrieb += "A dim light falls through the small window to your right.";
			            beschrieb += "\nUnder the window, you can see different garden tools, covered in cobwebs.";
			            beschrieb += "\nOn your left, there are a few wooden boards, leaned against the wall";
			            beschrieb += "\nA piece of rope lies on the dusty floor";
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

// Ort martina_ort = new Ort ( "crooked shed" );
// martina_ort.VerknuepfeOrt( "n", sasha_ort );
// sasha_ort.VerknuepfeOrt( "s", martina_ort );
// gartenperson_ort.VerknuepfeOrt( "w", martina_ort );
// martina_ort.VerknuepfeOrt( "e", gartenperson_ort ); 