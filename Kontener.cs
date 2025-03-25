using System;
using kontenery.Properties.exceptions;

namespace kontenery.Properties.classes
{
    public class Kontener
    {
        private static int next_id = 0;

        public int id { get; } = next_id++;

        public string id_s { get; }
        public String kon = "KON";
        public double deadweight { get; set; }
        public int height { get; set; }
        public double max_weight { get; set; }
        public int depth { get; set; }
        public String stuff { get; set; }

        public double weight_inside = 0;

        public Kontener(double deadweight, int height, double max_weight, int depth, String stuff)
        {
            id_s = id.ToString();
            this.deadweight = deadweight;
            this.height = height;
            this.max_weight = max_weight;
            this.depth = depth;
            this.stuff = stuff;
        }

        public void load(double weight)
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

        public void unload()
        {
            weight_inside = 0;
        }

        public override string ToString()
        {
            return "ciezar wlasny: " + deadweight + " wysokosc: " + height + " glebokosc: " + depth +
                   " maksymalna waga: " + max_weight + " masa wewnatrz: " + weight_inside + " towar: " + stuff;
        }
    }
}