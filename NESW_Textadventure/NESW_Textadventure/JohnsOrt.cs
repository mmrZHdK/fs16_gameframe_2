using System;
using TextAdventure;

namespace TextAdventure
{
	public class JohnsOrt : Ort
	{

		public JohnsOrt ()
		{
			name = "John's Dark Tower";
			beschrieb = "This is the old Dark Tower. It looks very old and quite dangerous.";
			beschrieb += "You feel unsave here. The wooden stairs look rotten and they could collapse any time.";
			beschrieb += "The whole building seems to be creaking and groaning.";
			beschrieb += "On the West side you see a wooden chest on the floor infront of an window. Through the window you can see the rooftop of the villa.";
			beschrieb += "Down in the cellar there's closed door. You don't remember where it leads to";

		}
		public override bool IstCustomCommand (string in_kommando)
		{
			return (in_kommando =="open wooden chest") ;
			return (in_kommando == "open cellar door"); 
		}


		public override void BehandleCustomCommand (string in_kommando ) {
			if (in_kommando == "open wooden chest") {
				Console.WriteLine ("Inside the chest there’s a rope, it could be used get down from the top of the tower.");


			}

			if (in_kommando == "open door") {
				Console.WriteLine ("I wonder what a new and exciting place awaits me on the other side.");
			}
		}
	}}


