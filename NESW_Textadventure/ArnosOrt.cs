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
			beschrieb += "They don't seem to like strangers.";
			beschrieb += "What appears to be the one in charge, maybe their king, steps forth.";
			beschrieb += "He tells you that every citizen of the colony of the mouse-people ";
			beschrieb += "has suffered the same fate as you and allows you to stay.";
			beschrieb += "The citizens are distant, but soon you will be like them.";
			beschrieb += "There is no escape.";
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
