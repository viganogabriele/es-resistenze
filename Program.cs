using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_resistenze
{
    internal class Program
    {
        class Resistenza
        {
            public float R;
            public Resistenza (float r) 
            {
                R = r;
            }
            public Resistenza SumTwoRSeries (Resistenza r2)
            {
                return new Resistenza (R + r2.R);
            }
            public Resistenza SumRNSeries(float r2)
            {
                return new Resistenza(R + r2);
            }

            public Resistenza SumTwoRParallel(Resistenza r2)
            {
                return new Resistenza((R * r2.R) / (R + r2.R));
            }
            public Resistenza SumRNParallel(float r2)
            {
                return new Resistenza((R * r2) / (R + r2));
            }

            public float CalcolaDDP(float I)
            {
                return (R * I);
            }
            public float CalcolaCorrente(float DDP)
            {
                return (DDP / R);
            }
            public string ToString(Resistenza r2)
            {
                Resistenza r3 = SumTwoRSeries(r2);
                Resistenza r4 = SumTwoRParallel(r2);
                return (r3.R.ToString() + " " + r4.R.ToString());
            }
        }
        static void Main(string[] args)
        {
            Resistenza r1 = new Resistenza(50);
            Resistenza r2 = new Resistenza(10);
            Console.WriteLine(r1.ToString(r2));
            Console.ReadLine();
        }
    }
}
