using System;

namespace TextAdventure
{
	// Klasse fuer Aufnehmbare Objekt
	public sealed class CatacombTorch : Ding
	{
		private int helligkeit;			// In Lumen
		private int leuchtdauer;		// In Sekunden
		
		// Constructor
		public CatacombTorch(string name, int lumen, int leuchtdauer) : base(name)
		{
			this.helligkeit = lumen;
			this.leuchtdauer = leuchtdauer;
		}
		
		// Properties
		public int Helligkeit
		{
			get { return helligkeit; }
		}
		
		public int Leuchtdauer
		{
			get { return leuchtdauer; }
		}
	}
	
	// Ortsklasse
	public class JuliansOrt : Ort
	{
		private string position = "catacombs";
		private bool rat = true;
		private bool torch = false;
		private bool lostTorch = false;
		private bool monster = false;

		// Aufnehmbare Objekte

		// Fakel: 500 Lumen, 2 Minuten Leuchtdauer
		CatacombTorch torchObject = new CatacombTorch("torch", 500, 120);

		public JuliansOrt ()
		{
			name = "dammned catacombs";
			beschrieb = "You enter a murky and somber area. According the bright echo of your footsteps on the moisty stone floor, ";
			beschrieb += "it seems that you're standing in a great hall. From a far distance, you can hear a deep and frightening groaning. ";
			beschrieb += "The smell of death and fermented organs rising up to tickle your senses. ";
			beschrieb += "You recognize the flame of a torch about five meters to your left. In its shine you can make out the shape of a wooden door. ";
			beschrieb += "There is the noise of rushing water further to the right. The hall is shrouded in darkness and you can feel the oppressive atmosphere. ";
			beschrieb += "Something flits around your feet. ";
			
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
			// (follow, go, move) tunnel, light, exit:			Player enters Moritz' fancy chest room
			// b, back, return:									Player cannot find back to catacombs
		}
		
		// Moegliche commands
		public override bool IstCustomCommand(string in_kommando)
		{
			bool vorhanden = false;
			
			switch(in_kommando)
			{
				// [catacombs]
				case "l":
				case "left":
				case "door":
				case "torch":
				
				case "r":
				case "right":
				case "water":
				case "stream":
					if(position == "catacombs")
						vorhanden = true;
					break;
					
				case "stamp":
				case "stomp":
				case "kick":
					if(position == "catacombs")
						vorhanden = true;
					break;
				
				// [door]
				case "take torch":
				case "grab torch":
					if((position == "door") && !torch)
						vorhanden = true;
					else if((position == "water") && lostTorch)
						vorhanden = true;
					break;
				
				case "open door":
					if(position == "door")
						vorhanden = true;
					break;
				
				case "use torch":
					if((position == "door") && torch && monster)
						vorhanden = true;
					else if((position == "water") && torch)
						vorhanden = true;
					break;

				case "fight torch":
				case "throw torch":
					if((position == "door") && torch && monster)
						vorhanden = true;
					break;
				
				case "run":
				case "leave":
					if((position == "door") && monster)
						vorhanden = true;
					break;
				
				// [water]
				case "light torch":
					if((position == "water") && torch)
						vorhanden = true;
					break;
				
				case "search torch":
				case "find torch":
					if((position == "water") && lostTorch)
						vorhanden = true;
					break;
				
				case "follow water":
				case "go water":
				case "walk water":
				case "move water":
				case "follow stream":
				case "go stream":
				case "walk stream":
				case "move stream":
					if(position == "water")
						vorhanden = true;
					break;
				
				// [sewer]
				case "follow tunnel":
				case "go tunnel":
				case "move tunnel":
				case "follow light":
				case "go light":
				case "move light":
				case "follow exit":
				case "go exit":
				case "move exit":
					if(position == "sewer")
						vorhanden = true;
					break;
				
				// going back
				case "b":
				case "back":
				case "return":
					vorhanden = true;
					break;
				
				default:
					break;
				
			}
			
			return vorhanden;
		}
		
		// Was zu tun?
		public override void BehandleCustomCommand(string in_kommando)
		{
			// Ausgabe
			string antwort;
			
			switch(in_kommando)
			{
				// [catacombs]
				case "l":
				case "left":
				case "door":
				case "torch":
					if(position == "catacombs")
					{
						if(!monster)
						{
							antwort = "Woah, you slip and almost tumble into a pool of blood which seems to disappear under the wooden door. ";
							antwort += "The door is slightly open and looks pretty creepy in the flickering light of the torch next to it.";
							Console.WriteLine(antwort);
							position = "door";
						}
						else
						{
							antwort = "Hmmmm, It seems that the monster's tearing you into pieces!\n";
							antwort += "YOU DIEDEDED!";
							Console.WriteLine(antwort);
							antwort = Console.ReadLine();
							System.Environment.Exit(0);
						}
					}
					break;
				
				case "r":
				case "right":
				case "water":
				case "stream":
					if(position == "catacombs")
					{
						if(!monster)
						{
							antwort = "It seems that you are now closer to a stream and can clearly hear the sound of rushing water. ";
							antwort += "Unfortunately, it is so dark in here that you can't see s**t! But... you should be able to follow the noise even without any sight.";
							Console.WriteLine(antwort);
							position = "water";
						}
						else
						{
							antwort = "Aaaaaayyyiiiiiii! You fall through a deep shaft into kneedeep dirty water! Luckily, the monster could not follow you. On the other side, ";
							antwort += "you're not able to make it back to the catacombs from here. But who would go there now anyway?\n";
							antwort += "It looks like you are standing in a sewer. There's light at the end of the tunnel....";
							Console.WriteLine(antwort);
							position = "sewer";
						}
					}
					break;
					
				case "stamp":
				case "stomp":
				case "kick":
					if(position == "catacombs")
					{
						if(rat)
						{
							antwort = "Squeeeze!\nCongratulations! You killed a cute, little, innocent rat and will probably end up in hell!";
							Console.WriteLine(antwort);
							rat = false;
						}
						else
						{
							antwort = "There's no rat left to kill, you brutal murderer!";
							Console.WriteLine(antwort);
						}
						
					}
					break;
				
				// [door]
				case "take torch":
				case "grab torch":
					if((position == "door") && !torch)
					{
						antwort = "Well... If anyone can find a good use for it... (You take the torch)";
						Console.WriteLine(antwort);
						torch = true;
					}
					else if((position == "water") && lostTorch)
					{
						antwort = "Are you kidding me? Forget the torch! It's unbelievable murky and f***ing dark. You can't see a damn thing. You're blind like a mole, like an unborn baby, ";
						antwort += "like an eyeless purple glossed snake ... you understand?!? ... like a freaking astronaut soaked into a black hole during a lovely space walk. You can't find it! The torch is gone!";
						Console.WriteLine(antwort);
					}
					break;
				
				case "open door":
					if(position == "door")
					{
						antwort = "You carefully open the heavy door and suddenly facing a huge cannibalistic and terrifying sepulchral monster, ";
						antwort += "with a wide open mouth, heading in your direction.";
						Console.WriteLine(antwort);
						monster = true;
					}
					break;
				
				case "use torch":
					if((position == "door") && torch && monster)
					{
						antwort = "You throw the torch directly into the monsters face! Certainly, it doesn't care and keeps tearing you into pieces!\n";
						antwort += "YOU DIEDEDED!";
						Console.WriteLine(antwort);
						Console.ReadLine();
						System.Environment.Exit(0);
					}
					else if((position == "water") && torch)
					{
						antwort = "Pffsch! The torch falls down on the wet floor an lost it's light. You really need to attend some psychomotility therapy... ";
						antwort += "I mean, come on! A torch isn't that hard to hold properly, am I right? However, due to your high amount of stupidity, you're now standing in the dark again... ";
						Console.WriteLine(antwort);
						lostTorch = true;
					}
					break;

				case "fight torch":
				case "throw torch":
					if((position == "door") && torch && monster)
					{
						antwort = "You throw the torch directly into the monsters face! Certainly, it doesn't care and keeps tearing you into pieces!\n";
						antwort += "YOU DIEDEDED!";
						Console.WriteLine(antwort);
						Console.ReadLine();
						System.Environment.Exit(0);
					}
					break;
				
				case "run":
				case "leave":
					if((position == "door") && monster)
					{
						antwort = "You turn around just to run back as fast as you can, while screaming like a three year old little girl. You're standing now at the initial position of the catacombs again! ";
						antwort += "Hurry, you can already hear the monster behind you!";
						Console.WriteLine(antwort);
						position = "catacombs";
					}
					break;
				
				// [water]
				case "light torch":
					if((position == "water") && torch)
					{
						antwort = "Pffsch! The torch falls down on the wet floor an lost it's light. You really need to attend some psychomotility therapy... ";
						antwort += "I mean, come on! A torch isn't that hard to hold properly, am I right? However, due to your high amount of stupidity, you're now standing in the dark again... ";
						Console.WriteLine(antwort);
						lostTorch = true;
					}
					break;
				
				case "search torch":
				case "find torch":
					if((position == "water") && lostTorch)
					{
						antwort = "Are you kidding me? Forget the torch! It's unbelievable murky and f***ing dark. You can't see a damn thing. You're blind like a mole, like an unborn baby, ";
						antwort += "like an eyeless purple glossed snake ... you understand?!? ... like a freaking astronaut soaked into a black hole during a lovely space walk. You can't find it! The torch is gone!";
						Console.WriteLine(antwort);
					}
					break;
				
				case "follow water":
				case "go water":
				case "walk water":
				case "move water":
				case "follow stream":
				case "go stream":
				case "walk stream":
				case "move stream":
					if(position == "water")
					{
						antwort = "As you walk closer to the sound of pouring water, you suddenly loose balance and plunge through a deep shaft into kneedeep dirty water! ";
						antwort += "You're not able to make it back to the catacombs from here. It looks like you are standing in a sewer and there's light at the end of the tunnel....";
						Console.WriteLine(antwort);
						position = "sewer";
					}
					break;
				
				// [sewer]
				case "follow tunnel":
				case "go tunnel":
				case "move tunnel":
				case "follow light":
				case "go light":
				case "move light":
				case "follow exit":
				case "go exit":
				case "move exit":
					if(position == "sewer")
					{
						antwort = "[Editors note:] This path leads to Moritz' chest room.........";
						Console.WriteLine(antwort);
					}
					break;
				
				// going back
				case "b":
				case "back":
				case "return":
					
					// Von wo aus zurueckkehren?
					switch(position)
					{
						case "door":
							if(monster)
							{
								antwort = "You turn around just to run back as fast as you can, while screaming like a three year old little girl. You're standing now at the initial position of the catacombs again! ";
								antwort += "Hurry, you can already hear the monster behind you!";
							}
							else
							{
								antwort = "Since you're a little sissy and scared from dusky adventures, you think that it would be safer going back to the initial position of the catacombs to where you came from.";
							}
							position = "catacombs";
							break;
							
						case "water":
							antwort = "Somehow you grope your way back to the initial position of the catacombs to where you came from.";
							position = "catacombs";
							break;
						
						case "sewer":
							antwort = "You're not able to climb back to the catacombs! Should have trained some more....";
							break;
							
						default:
							antwort = "[Editors note:] This path leads to Sashas Dungeon.........";
							break;
					}
					
					Console.WriteLine(antwort);
					
					break;
				
				default:
					break;
				
			}
		}
	}
}


