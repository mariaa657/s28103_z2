using System;
using System.Collections.Generic;
using kontenery.Properties.interfaces;

namespace kontenery.Properties.classes
{
    public class Plyn : Kontener, IHazardNotifier
    {
        public string numer_seryjny;
        public List<string> niebezpieczne;
        //private IHazardNotifier _hazardNotifierImplementation;

        public Plyn(double deadweight, int height, double max_weight, int depth, string stuff) : base(deadweight, height, max_weight, depth, stuff)
        {
            numer_seryjny = kon + "-" + "P" + "-" + id_s;
            niebezpieczne = new List<string> { "paliwo", "ropa", "kwas" };
        }
        public void prirn_nrs()
        {
            System.Console.WriteLine(numer_seryjny);
        }

        public void danger()
        {
            //_hazardNotifierImplementation.danger();
            System.Console.WriteLine("DANGER");
        }

        public void load(double weight)
        {
            if (niebezpieczne.Contains(stuff))
            {
                if (weight_inside + weight < 0.5 * max_weight)
                {
                    weight_inside = weight_inside + weight;
                }
                else
                {
                    danger();
                }
            }
            else
            {
                if (weight_inside + weight < 0.9 * max_weight)
                {
                    weight_inside = weight_inside + weight;
                }
                else
                {
                    danger();
                }
            }
        }
    }
}