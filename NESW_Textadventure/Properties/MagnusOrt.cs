using System;
using TextAdventure;

namespace TextAdventure
{
	public class MagnusOrt : Ort
	{
		public MagnusOrt ()
		{
			// Noch was
			name = "small library";
			beschrieb = "This library is packed with books. From a high woodden ceiling ";
			beschrieb += "down to the ground there are shelfloads of books of all sizes. ";
			beschrieb += "In the corner you see a heavy old chair with dark leather covered pillows. ";
			beschrieb += "The athmosphere is inviting. Is that a cup of hot tea on the little table ";
			beschrieb += "beside the chair?";
		}

//		public new void LosGehts()
//		{
//			// Ich möchte eigene Kommandos ausführen können
//			Console.WriteLine( "Wie kann ich das machen" );
//		}

		public override bool IstCustomCommand( string in_kommando )
		{
			return ( in_kommando == "drink tea" );
		}
		public override void BehandleCustomCommand( string in_kommando )
		{
			if ( in_kommando == "drink tea" ) {
				string antwort = "Hmmmm... ";
				antwort += "what a tasteful cup of tea. ";
				antwort += "I'd long to have another one.";

				// Neuer Kommmentar zu Testzwecken
				Console.WriteLine( antwort );
			}
		}
	}
}
