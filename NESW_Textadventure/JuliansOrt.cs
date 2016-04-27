using System;
using TextAdventure;

namespace TextAdventure
{
	public class JuliansOrt : Ort
	{
		public JuliansOrt ()
		{
			name = "dammned catacombs";
			beschrieb = "You enter a murky and somber area. According the bright echo of your footsteps on the moisty stone floor, ";
			beschrieb += "it seems that you're standing in a great hall. From a far distance, you can hear a deep and frightening groaning. ";
			beschrieb += "The smell of death and fermented organs rising up to tickle your senses. ";
			beschrieb += "You recognize the flame of a torch about five meters to your left. In its shine you can make out the shape of a wooden door. ";
			beschrieb += "There is the noise of rushing water further to the right. The hall is shrouded in darkness and you can feel the oppressive atmosphere.";
			beschrieb += "Something flits around your feet.";
			
			// [catacombs]
			// l, left, door, torch:							Pool of blood disappears under the door
			//													- if [m-follow]: Monster kills player
			//  --> (take, grab) torch:							Take torch [if still there]
			//  --> (open) door:								Facing a huge cannibalistic and terrifying sepulchral monster, heading with wide open mouth in your direction
			//	  --> (use, fight, throw) torch [if taken]:		Burning monster kills player
			//    --> run, leave, back, b, return:				Monster follows player [m-follow] --> room start position
			//  --> b, back, return:							Room start position
			// r, right, water, stream:							Player cannot see anything, hears water louder
			//													- if [m-follow]: Player falls down in sewer --> sewer --> monster will not follow
			//  --> (use, light) torch [if taken]:				Player stumbles and looses torch --> torch burns out --> DO NOT LIGHT UP PLACE!
			//    --> (search, grab, take, find) torch:			Cannot find torch anymore
			//  --> (follow, go, walk, move) water, stream:		Player falls down in sewer --> sewer
			//  --> b, back, return:							Room start position
			//  --> any other direction:						"I cannot see anything!"
			// b, back, return:									Back to Sasha's dungeon
			// any other direction:								"This place doesn't seem safe..."
			// stamp, stomp, kick:								- if [rat not killed yet]: Player kills the rat to her/his feet.
			//
			// [sewer]											Tunnel with light at the end
			// (follow, go, move) tunnel, light, exit:			Player stands at the bottom of Michi's well
			//  --> climb, go up, exit:							Player climbs out of well --> Michi's room
			//  --> b, back, return:							Sewer start position
			// b, back, return:									Player cannot find back to catacombs
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


