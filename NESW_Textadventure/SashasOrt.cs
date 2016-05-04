using System;
using TextAdventure;

namespace TextAdventure
{
	public class SashasOrt : Ort
	{

		public SashasOrt ()
		{
			name = "mysterious dungeon";

			beschrieb = "You are in a dungeon under the villa. It's dark and creepy.";
			beschrieb += "You feel something has happened here a long time ago.";
			beschrieb += "Now it is empty and the floor is covered with dust. You notice an old hammer on the floor.";
			beschrieb += "Someone left footprints near the south wall and there is a torch on that wall.";
			beschrieb += "It looks like no one has ever lighted it.";  //take/use the torch and go to Martinas Ort
			beschrieb += "The stairs to the library are on the north side of the dungeon";//north to library
			beschrieb += "The light comes from the hole in the wall on the west side"; // west to Julians Ort

			Ding hammer = new Ding ("hammer");
			this.VerknuepfeDing(hammer);

		}

		public override bool IstCustomCommand (string in_kommando){
			return (in_kommando == "take torch" || in_kommando == "light torch" || in_kommando == "take dust" || in_kommando == "push torch"|| in_kommando ==  "take hammer");
		}
		public override void BehandleCustomCommand(string in_kommando){
			if (in_kommando == "take torch") {
				string antwort = "You tried to take a torch, but it is stuck in the wall.";
				antwort += "Hmm..It feels like you can push it...";

				Console.WriteLine (antwort);
			}
			else if (in_kommando == "push torch") {
				string antwort = "As you push the torch the stone wall slides with ";
				antwort += "a crushing sound. You enter the opening and into the long dark ";
				antwort += "corridor. You have no idea how long did it take you to reach ";
				antwort += "the end of it. Finally you see the ladder and climb it up.";

				Console.WriteLine (antwort);
				//	rooms["martinas_ort"].LosGehts ();
			}
			else if (in_kommando == "light torch") {    /// test kommentare
				string antwort = "No, you have nothing to light the torch with.";

				Console.WriteLine (antwort);
			}
			else if (in_kommando == "take dust") {
				string antwort = "You pick up some dust. ";
				antwort += "And throw it away, you don't want to have it in your pocket.";

				Console.WriteLine (antwort);
			}
			else if (in_kommando == "take hammer") {
				string antwort = "You pick up a hammer. ";
				antwort += "It's always good to have an old good hammer with you.";

				Console.WriteLine (antwort);
			}

			/*if (in_kommando == "s") {
				string antwort = "You could try to examine the torch, but you just go through the wall like a ghost.";

				Console.WriteLine (antwort);
			}*/

		}
	}
}