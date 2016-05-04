using System;
using TextAdventure;

namespace TextAdventure
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// Start des Programms
			Console.WriteLine ("Start your journey!");
			Console.WriteLine ();

			// -- Orte initialisieren
			// hier werden Instanzen der von euch
			// programmierten Klassen 
			Ort start_ort = new StartOrt();
			Ort magnus_ort = new MagnusOrt ();

			Ort arnos_ort = new ArnosOrt();
			Ort domis_ort = new DomisOrt();
			Ort julians_ort = new JuliansOrt();
			Ort maliks_ort = new MaliksOrt();
			Ort marcellos_ort = new MarcellosOrt();
			Ort martinas_ort = new MartinasOrt();
			Ort michis_ort = new MichisOrt();
			Ort moritz_ort = new MoritzOrt();
			Ort myriams_ort = new MyriamsOrt();
			Ort nicoles_ort = new NicolesOrt();
			Ort sashas_ort = new SashasOrt();
			Ort sebis_ort = new SebisOrt();
			Ort selinas_ort = new SelinasOrt();
			Ort tobias_ort = new TobiasOrt();
			// ...

			// -- Orte zu Struktur verknüpfen
			// Zu jedem Ort definieren wir die ausgehenden
			// Verbindungen mit zwei Parametern
			// - das Schlüsselwort
			// - zu welchem Ort Objekt es geht

			// Beispiel:
			// Mit S für Süden, kommst du
			// zu einem neuen Ort
			// nämlich Moritz Ort
			start_ort.VerknuepfeOrt( "n", nicoles_ort );
			start_ort.VerknuepfeOrt( "e", magnus_ort );
			start_ort.VerknuepfeOrt( "east", magnus_ort );

			magnus_ort.VerknuepfeOrt( "w", start_ort );
			magnus_ort.VerknuepfeOrt( "s", sashas_ort );
			magnus_ort.VerknuepfeOrt( "n", marcellos_ort );
			magnus_ort.VerknuepfeOrt( "e", domis_ort );

			arnos_ort.VerknuepfeOrt( "w", marcellos_ort );

			domis_ort.VerknuepfeOrt( "?", magnus_ort );
			domis_ort.VerknuepfeOrt( "?", maliks_ort );
			// TODO

			julians_ort.VerknuepfeOrt( "?", moritz_ort );
			// TODO

			maliks_ort.VerknuepfeOrt( "w", sebis_ort );
			maliks_ort.VerknuepfeOrt( "e", martinas_ort );
			// TODO

			marcellos_ort.VerknuepfeOrt( "?", arnos_ort );
			marcellos_ort.VerknuepfeOrt( "?", selinas_ort );
			marcellos_ort.VerknuepfeOrt( "s", magnus_ort );
			// TODO

			martinas_ort.VerknuepfeOrt( "w", maliks_ort );
			martinas_ort.VerknuepfeOrt( "n", sashas_ort );
			martinas_ort.VerknuepfeOrt( "s", moritz_ort );
			// TODO

			michis_ort.VerknuepfeOrt( "?", moritz_ort );
			michis_ort.VerknuepfeOrt( "?", sebis_ort );
			// TODO

			moritz_ort.VerknuepfeOrt( "n", martinas_ort );
			// TODO

			myriams_ort.VerknuepfeOrt( "e", nicoles_ort );
			myriams_ort.VerknuepfeOrt( "n", selinas_ort );

			nicoles_ort.VerknuepfeOrt( "w", myriams_ort );
			nicoles_ort.VerknuepfeOrt( "s", start_ort );

			sashas_ort.VerknuepfeOrt( "s", martinas_ort );
			sashas_ort.VerknuepfeOrt( "e", julians_ort );
			sashas_ort.VerknuepfeOrt( "n", magnus_ort );
			// TODO

			sebis_ort.VerknuepfeOrt( "e", maliks_ort );
			sebis_ort.VerknuepfeOrt( "?", michis_ort );
			// TODO

			selinas_ort.VerknuepfeOrt( "s", myriams_ort );
			selinas_ort.VerknuepfeOrt( "?", marcellos_ort );

			tobias_ort.VerknuepfeOrt( "n", start_ort );
			tobias_ort.VerknuepfeOrt( "s", maliks_ort );

			// -- Start Ort aktivieren
			// Der Ort, an dem das Adventure beginnt,
			start_ort.LosGehts();
		}
	}
}
