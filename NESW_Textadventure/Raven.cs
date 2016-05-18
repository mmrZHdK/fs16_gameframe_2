using System;
using TextAdventure;

namespace TextAdventure
{
    public class Raven : Ding
    {
        public bool ravenInInventory = false;

        public Raven()
        {
            name = "raven";
            beschrieb = "It croaks and flaps its wings. It seems to be unhappy.";

        }

        public override void WechseleStatus(string in_status)
        {
            if (in_status == "zerstoert")
            {
                name = "destroyed " + name;
                beschrieb = "Its wings are broken. Now it is even more unhappy than before.";
            }
        }

        public override void BehandleSpeziellesKommando(string in_kommando)
        {
            switch (in_kommando)
            {

                case "take":
                    ravenInInventory = true;
                    break;

                default:

                    break;
            }
        }
    }
}
