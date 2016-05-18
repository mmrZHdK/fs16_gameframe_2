using System;
using TextAdventure;

namespace TextAdventure
{
    public class TobiasOrt : Ort
    {
        public TobiasOrt ()
        {
            name = "veranda";
            beschrieb = "The air hammers in your eyes and ears as you set foot on a small porch  ";
            beschrieb += "First you can't hear anything but the howling wind." ;
            beschrieb += "Then you hear the doors to the mansion smash and then rumble in their frame" ;
            beschrieb += "You're squinting and trying to protect your face with one hand held up" ;
            beschrieb += "Further outside you can make out what seems to be a garden" ;
            beschrieb += "Between the rumbling and the howling your ears pick up a clacking sound..." ;
            beschrieb += "It's a small metal plummet, smashing ceaselessly against the wood." ;
        }
		//hier auch mit so switch züg arbeiten wie julian.


		//plummet-> it just hangs on this nail. I should take it with me
		//look-> it just hangs on this nail. I should take it with me

		//take
		//-> put plummet in inventory
		//with one strong pull you rip the plummet of the wall and let it slide into your pocket.

		public override bool IstCustomCommand( string in_kommando )
		{
			return false;
		}
		public override void BehandleCustomCommand( string in_kommando )
		{
		}
    }
}
