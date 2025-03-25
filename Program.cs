using System;
using System.Collections.Generic;
using kontenery.Properties.classes;

namespace kontenery
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Gaz gaz = new Gaz(5, 5, 6, 6, "tlen");
            gaz.prirn_nrs();
            
            Plyn plyn = new Plyn(6, 5, 2, 5, "sok pomaranczowy");
            plyn.prirn_nrs();

            Chladzacy chladzacy = new Chladzacy(8, 5, 3, 6, "owoce", 13.5);
            System.Console.WriteLine(gaz);
            System.Console.WriteLine(plyn);
            System.Console.WriteLine(chladzacy);
            System.Console.WriteLine(" ");
            
            gaz.load(5);
            plyn.load(1);
            chladzacy.load(2);
            
            System.Console.WriteLine(gaz);
            System.Console.WriteLine(plyn);
            System.Console.WriteLine(chladzacy);
            System.Console.WriteLine(" ");
            
            gaz.unload();
            plyn.unload();
            chladzacy.unload();
            
            System.Console.WriteLine(gaz);
            System.Console.WriteLine(plyn);
            System.Console.WriteLine(chladzacy);
            System.Console.WriteLine(" ");

            Kontenerowiec kontenerowiec = new Kontenerowiec(900, 900);
            kontenerowiec.dodaj_kontener(gaz);
            List<Kontener> k = new List<Kontener>();
            k.Add(plyn);
            k.Add(chladzacy);
            
            kontenerowiec.dodaj_liste_kontenerow(k);
            
            System.Console.WriteLine(kontenerowiec);
            

        }
    }
}