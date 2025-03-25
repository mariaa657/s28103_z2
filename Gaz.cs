using System;
using System.Collections.Generic;
using kontenery.Properties.interfaces;

namespace kontenery.Properties.classes
{
    public class Gaz : Kontener, IHazardNotifier
    {
        public string numer_seryjny;
        
        public Gaz(double deadweight, int height, double max_weight, int depth, string stuff) : base(deadweight, height, max_weight, depth, stuff)
        {
            numer_seryjny = kon + "-" + "G" + "-" + id_s;
        }

        public void prirn_nrs()
        {
            System.Console.WriteLine(numer_seryjny);
        }

        public void unload()
        {
            weight_inside = weight_inside * 0.05;
        }

        public void danger()
        {
            System.Console.WriteLine("DANGER");
        }
    }
}