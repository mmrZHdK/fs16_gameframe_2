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
			beschrieb += "You feel save here. There are a lot of tasty fruits and a wonderfull spring.";
			beschrieb += "The sun is shining today bright and warm. You can even feel a fresh breeze.";
			beschrieb += "On the East side you see a big green tree. It's green and on the top you can see a wooden house.";
			beschrieb += "On the West side you see a small toolsheed. Obviusly for the garden";

		}
		public override bool IstCustomCommand( string in_kommando )
		{
			return false;
		}
		public override void BehandleCustomCommand( string in_kommando ) //elf
		{
		}
	}

}


