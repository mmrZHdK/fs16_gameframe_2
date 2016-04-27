﻿using System;
using TextAdventure;
// UTF8 bitte
namespace TextAdventure
{
	class MartinasOrt : Ort
	{
		public MartinasOrt ()
		{
			name = "crooked shed";
			beschrieb += "A dim light falls through the the small window to your right.";
			beschrieb += "To your left you can see different garden tools, covered in cobwebs";
			beschrieb += "On your right are a few wooden boards, leaned against the wall";
			beschrieb += "A piece of rope lies on the dusty floor";
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

// Ort martina_ort = new Ort ( "crooked shed" );
// martina_ort.VerknuepfeOrt( "n", sasha_ort );
// sasha_ort.VerknuepfeOrt( "s", martina_ort );
// gartenperson_ort.VerknuepfeOrt( "w", martina_ort );
// martina_ort.VerknuepfeOrt( "e", gartenperson_ort );