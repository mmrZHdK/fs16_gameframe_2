using System;
using TextAdventure;

namespace TextAdventure
{
	public class ArnosOrt : Ort
	{
		public ArnosOrt ()
		{
			name = "Colony of the Mouse-People";
			bezug = "in";
			beschrieb = "You don't know how you got here, or how much time has passed.";
			beschrieb += "Strange creatures stare at you, their faces a cruel amalgamation ";
			beschrieb += "of human and rodent features.";
			beschrieb += "They don't seem to like strangers. ";
			beschrieb += "What appears to be the one in charge, maybe their king, steps forth. ";
			beschrieb += "He tells you that every citizen of the colony of the mouse-people ";
			beschrieb += "has suffered the same fate as you and allows you to stay. ";
			beschrieb += "The citizens are distant, but soon you will be like them. ";
			beschrieb += "There is no escape. ";
			beschrieb += "... ";
			beschrieb += "But what is that? ";
			beschrieb += "A magic mind-erasing mindray that nobody else has even thought of using? ";
			beschrieb += "Maybe you can unread the book? ";
			beschrieb += "You can also spot a strange book on the other side of the room. ";
			beschrieb += "Maybe you can exit this world the same way you've entered it. ";
			
			//Eine Gedächtnis-löschende Waffe, "mindray", benutze mit "take", "use"
			//Ein weiteres Buch mit einer Maus, "mouse-book", benutze mit "take", "read"
			//Befehle, um nichts zu machen, "stay" und "sleep"

			Ding mindray = new Ding ("mindray");
			this.VerknuepfeDing( mindray );
			//DingMousebook mousebook = new DingMousebook ("mousebook");
			//this.VerknuepfeDing( mousebook );
		}

		public override bool IstCustomCommand( string in_kommando ){
			return (in_kommando == "take mindray" ) || (in_kommando == "use mindray") || (in_kommando == "take mousebook") || (in_kommando == "read mousebook") || (in_kommando == "stay") || (in_kommando == "sleep");
		}

		public override void BehandleCustomCommand( string in_kommando ){
			if (in_kommando == "take mindray") {
				string antwort = "Shiny, but ineffective Steampunk Design. There are unnecessary cogs and lightbulbs everywhere. ";
				Console.WriteLine (antwort);
			} else if (in_kommando == "use mindray") {
				string antwort = "You return to the hidden book chamber. ";
				antwort += "The book in your hands reminds you of something... ";
				antwort += "What a curious incident it was. Let us never speak of it again. ";
				Console.WriteLine (antwort);
			} else if (in_kommando == "take mousebook") {
				string antwort = "It is bound in what appears to be human skin. The inscription on its ridge reads ";
				antwort += "'Necronomicon ex mortis'. On its first page is written in blood 'Klaatu berada nikto'. ";
				Console.WriteLine (antwort);
			} else if (in_kommando == "read mousebook") {
				string antwort = "Suddenly, a bright light engulfs you, and everything turns white. ";
				antwort += "Strange creatures stare at you, their faces a cruel amalgamation ";
				antwort += "of rodent and rodent features.";
				antwort += "This is the colony of the mouse-mice. ";
				antwort += "There is no escape...";
				Console.WriteLine (antwort);
			} else if (in_kommando == "stay") {
				string antwort = "You decided not to risk it and integrate yourself into the Mouse-People society. ";
				antwort += "As time passes, you feel hair growing thicker everywhere on your body. Your teeth are now ";
				antwort += "bigger and sharper, and your back hunches. Slowly, your distinctly human features are receding, ";
				antwort += "as is your understanding of the humeep language and meep theeir cultmeep meep feep feep meep...";
				Console.WriteLine (antwort);
			} else if (in_kommando == "sleep") {
				string antwort = "Why would you want to sleep in a place like this? ";
				antwort += "Anyway, long story short, the mouse-people ate your intestines. Like, all of them. RIP. ";
				Console.WriteLine (antwort);
			}
		}
	}
}
