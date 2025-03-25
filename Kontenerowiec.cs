using System;
using System.Collections.Generic;
using System.Text;
using kontenery.Properties.exceptions;

namespace kontenery.Properties.classes
{
    public class Kontenerowiec
    {
        public int speed { get; set; }
        public int max_weight { get; set; }
        
        public double weihgt_inside = 0;
        
        public List<Kontener> Konteners { get; set; } = new List<Kontener>();
 
        // Konstruktor
        public Kontenerowiec(int speed, int max_weight)
        {
            this.speed = speed;
            this.max_weight = max_weight;
        }

        public void dodaj_kontener(Kontener k)
        {
            if (weihgt_inside + k.deadweight*0.001 + k.weight_inside*0.001 < max_weight)
            {
                Konteners.Add(k);
                weihgt_inside = weihgt_inside + k.weight_inside*0.001 + k.deadweight*0.001;
            }
            else
            {
                throw new OverfillException("za duzo kontenerow");
            }
            
        }

        public void dodaj_liste_kontenerow(List<Kontener> kontenery)
        {
            double weihgt_to_add = 0;
            foreach (Kontener k in kontenery)
            {
                weihgt_to_add = weihgt_to_add + k.weight_inside*0.001 + k.deadweight*0.001;
            }

            if (weihgt_to_add + weihgt_inside< max_weight)
            {
                Konteners.AddRange(kontenery);
                weihgt_inside = weihgt_inside + weihgt_to_add;
                
            }
            else
            {
                throw new OverfillException("za malo miejsca na statku");
            }
        }

        public void zammien_kontenery(Kontener k1, Kontener k2)
        {
            if (Konteners.Contains(k1))
            {
                Konteners.Remove(k1);
                Konteners.Add(k2);
            }
            else
            {
                System.Console.WriteLine("nie mozna zamienic kontenerow");
            }
        }

        public void usun_kontener(Kontener k)
        {
            if (Konteners.Contains(k))
            {
                Konteners.Remove(k);
            }
            else
            {
                System.Console.WriteLine("tego kontenera nie ma na statku");
            }
        }
        
        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var kontener in Konteners)
            {
                sb.Append($" {kontener}");
                sb.AppendLine();
            }

            return $"speed {speed} : max_weight: {max_weight}, weight_inside: {weihgt_inside}, Kontenery: \n[\n{sb}]";
        }
    }
}