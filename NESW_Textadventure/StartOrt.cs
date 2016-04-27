using System;
using TextAdventure;

namespace TextAdventure
{
	public class StartOrt : Ort
	{
		public StartOrt ()
		{
			name = "entrance hall";
			bezug = "in";
			beschrieb = "Welcome to Nakov's Mansion.\n";
			beschrieb += "This is the entrance hall of a small but beautiful ";
			beschrieb += "old mansion with shimmering lanterns and a smooth dark red carpet ";
			beschrieb += "that muffles all noise from the outside. ";
			beschrieb += "Somewhere in the rooms there must be an open fire burning since you ";
			beschrieb += "can smell it's oak wood smoke. You hear several whispers from behind ";
			beschrieb += "but look to see nothing.";
			Ding apfel = new Ding ("apple");
		}

		// Implementiert die geforderte Methode
		// zur Indentifikation von speziellen Kommandos
		public override bool IstCustomCommand( string in_kommando )
		{
			// keine speziellen Kommandos vorhanden
			return false;
		}

		// Implementiert die geforderte Methode
		// zur Behandlung von speziellen Kommandos
		public override void BehandleCustomCommand( string in_kommando )
		{
			// keine speziellen Kommandos vorhanden
		}
	}
}

