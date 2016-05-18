using System;
using TextAdventure;

namespace TextAdventure
{
	public class MaliksOrt : Ort
	{
		public MaliksOrt ()
		{
			name = "Malik's Garden";
			beschrieb = "This is the Garden of the Villa. There are a lot of beautiful plants and flowers.";
			beschrieb += "You feel save here. There are a lot of tasty apples and a wonderfull spring.";
			beschrieb += "The sun is shining today bright and warm. You can even feel a fresh breeze.";
			beschrieb += "On the East side you see a big green tree. It's green and on the top you can see a wooden house.";
			beschrieb += "On the West side you see a small toolsheed. Obviusly for the garden";

			// Der Benutzer kann nach westen um in den Schuppen (von Martina) zu gelangen
			// oder nach osten um in einem Baumhaus (vom Sebi) zu kommen
			// der Benutzer kann hier Wasser trinken, Äpfel essen oder sich ausruhen




			//Meine Dinge

			Ding apple = new Ding ("apple");
			this.VerknuepfeDing (apple);

			Ding water = new Ding ("water");
			this.VerknuepfeDing (water);




		}


		//public override Geschichten

		public override bool IstCustomCommand( string in_kommando )
		{
			return (in_kommando == "drink water" || in_kommando == "eat apple" || 
					in_kommando == "rest" || in_kommando == "dance"|| in_kommando =="run");
		}




		public override void BehandleCustomCommand( string in_kommando )
		{
			if (in_kommando == "drink water") {
				string antwort = "Wow this water is really, really, REALLY HARD ULTRA HARDCORE FRESH!!";

				Console.WriteLine (antwort);
			} else if (in_kommando == "eat apple") {

				string antwort = "Mhmmmm... so delicious :)";

				Console.WriteLine (antwort);
			} else if (in_kommando == "rest") {

				string antwort = "You take a long nap. An after a while you wake up and you feel refreshed.";

				Console.WriteLine (antwort);
			}

			else if (in_kommando == "dance") {

				string antwort = "You are swinging with your hips and shaking your ass baby.";

				Console.WriteLine (antwort);
			}

			else if (in_kommando == "run") {

				string antwort = "You are runing in circles until you puke.";

				Console.WriteLine (antwort);
			}
				
		}
			
	}

}


