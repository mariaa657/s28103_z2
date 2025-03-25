using System;
using System.Collections.Generic;
using kontenery.Properties.exceptions;

namespace kontenery.Properties.classes
{
    public class Chladzacy : Kontener
    {
        public string numer_seryjny;
        public double temperature { get; set; }
        Dictionary < string, double > lodowka = new Dictionary < string, double > ();

        public Chladzacy(double deadweight, int height, double max_weight, int depth, string stuff,double temperature) : base(deadweight, height, max_weight, depth, stuff)
        {
            this.temperature = temperature;
            numer_seryjny = kon + "-" + "C" + "-" + id_s;
            lodowka["owoce"] = 13.5;
            lodowka["lody"] = -9;
            lodowka["warzywa"] = 8;
            lodowka["mleko"] = 9.5;
            lodowka["orzechy"] = 18;
            lodowka["inne"] = 10;
        }
        public void prirn_nrs()
        {
            System.Console.WriteLine(numer_seryjny);
        }

        public void load(double weight)
        {
            if (lodowka.ContainsKey(stuff))
            {
                if (lodowka[stuff] == temperature)
                {
                    if (weight_inside + weight <= max_weight)
                    {
                        weight_inside = weight_inside + weight;
                    }
                    else
                    {
                        throw new OverfillException("too much stuff inside");
                    }
                }
                else
                {
                    System.Console.WriteLine("zla temperatura");
                }
            }else if (lodowka["inne"] == temperature)
            {
                if (weight_inside + weight <= max_weight)
                {
                    weight_inside = weight_inside + weight;
                }
                else
                {
                    throw new OverfillException("too much stuff inside");
                }
            }
            else
            {
                System.Console.WriteLine("zla temperatura");
            }
        }
        
        
    }
}