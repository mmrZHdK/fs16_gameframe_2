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
			beschrieb += "You feel save here. There are a lot of tasty Apples and a wonderfull spring with fresh and clear water.";
			beschrieb += "The sun is shining today bright and warm. You can even feel a fresh breeze.";
			beschrieb += "On the East side you see a big green tree. It's green and on the top you can see a wooden house.";
			beschrieb += "On the West side you see a small toolsheed. Obviusly for the garden";
			beschrieb += "On the North side you see a big tower.";

				// Der Benutzer soll mit dem Wasser und den Äpfeln interagieren, ausserdem soll er eine orientierung erhalten

		}
		public override bool IstCustomCommand (string in_kommando)
		{
			return (in_kommando =="eat apple") ;
			return (in_kommando == " drink water"); 
			return (in_kommando == "take apple");
		}

		//in meinem Garten soll der Benutzer sich einfach nur wohl fühlen und Äpferl 

		public override void BehandleCustomCommand (string in_kommando)
		{
			if (in_kommando == "eat fruit") {
				Console.WriteLine ("Mhmmmm... so delicious :) ");


			}

			if (in_kommando == "drink water") {
				Console.WriteLine ("Wow this water is really, really, REALLY HARD ULTRA HARDCORE FRESH!!");
			}

			if (in_kommando == "take apple") {
				Console.WriteLine ("I should probably just eat them...");
			
		
			}
		}

	}}


