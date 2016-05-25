using System;

namespace TextAdventure
{
	public class SebisOrt : Ort
	{
		public SebisOrt ()
		{
			name = "Treehouse";
			beschrieb = "This Treehouse looks very old.I should be careful, rusty Nails everywhere";
			beschrieb += "oh shit! the ladder just fell on the ground, how the fuck do i get out of this treehouse?";
			beschrieb += "it's a very narrow room, my head touches the ceiling  ";
			beschrieb += "A strange Smell is in the air. A dead Honeybadger lies in the corner.  ";
			beschrieb += "There is a red cross on the ceiling. ";
			beschrieb += "An old Bonsai is standing on the floor. ";
			beschrieb += "The Wind is shaking the little Treehouse";
			beschrieb += "Is there something beneath the dead Honeybadger?";
			// Beschrieb meines Ortes
		}



		//Befehle, die nur in meinem Raum möglich sind
		public override bool IstCustomCommand(string in_kommando){

			return ((in_kommando == "look") || (in_kommando == "take honeybadger") || (in_kommando == "take bonsai") || (in_kommando == "use honeybadger") || (in_kommando == "cut leaves")) ;
			return ((in_kommando == "use key") || (in_kommando == "use zipline")) ;

			//	meine Commands sind look | take | use | cut

		}

		public override void BehandleCustomCommand(string in_kommando){
			if (in_kommando == "look") {
				string antwort = "You take a closer look at the walls and find a key hole in the center of the red cross! what a strange key hole. ";
				Console.WriteLine (antwort);
				// durch look gibt es eine zweiter Beschreibung, hinweis -> Schlüsselloch
			} else if (in_kommando == "take honeybadger") {
				string antwort = "You take a honeybadger with you. with alot of fantasy his tail looks like a key. hmm there is nothing beneath it ";
				Console.WriteLine (antwort);
				// durch Beschrieb darauf hingewiesen nimmt der User den honeybadger, und sieht dass darunter nichts ist ( fehlleiten des textes ) man denkt, honeybadger ist key
			} else if (in_kommando == "use honeybadger") {
				string antwort = "You sick bastard, how do you want to use a dead honeybadger!? whats wrong with you dude? noo you can't use his tail as a key. omg ";
				Console.WriteLine (antwort);
				// logische führung aufgrund punkt oben.
			} else if (in_kommando == "take bonsai") {
				string antwort = "bonsais don't like it when you take them with you, they need peace and harmony, and i guess the leaves should be cut to give him a nice new look. ";
				Console.WriteLine (antwort);
				// näcchste handlung da honeybadger nicht geht, hinweis zu cut
			} else if (in_kommando == "cut leaves") {
				string antwort = "oh my god, this bonsai looks faboulous now and an old wise voyce appears... 'Hello little friend, thank you that you cut my leaves, take this key and...dude...stop talking to plants.'  ";
				Console.WriteLine (antwort);
				// erhalt des keys
			} else if (in_kommando == "use key") {
				string antwort = "A small door openend and you are now standing on the roof of this creepy Treehouse. oh my god. there is a zipline right in front of you! how awesome is that??";
				Console.WriteLine (antwort);
				// benutzung des keys
			} else if (in_kommando == "use zipline") {
				string antwort = "woooooooooooooooooooooohooooooooooooooooooooooooooooooooo";
				Console.WriteLine (antwort);
				// Martina Raum aufrufen
				MartinasOrt.LosGehts ();
				// danach freies bewegen im raum ( n = michi, e = malik )
				//				


			}
		}

	}
}
