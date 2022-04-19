using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<fuvarok> fuvaroks = new List<fuvarok>();
            foreach (var sor in File.ReadLines("fuvar.csv").Skip(1))
            {
                fuvaroks.Add(new fuvarok(sor));
            }
            Console.WriteLine($"{fuvaroks.Count} fuvar");

            double bevétel = 0;
                int db = 0;
            foreach (var f in fuvaroks)
            {
                if (f.Taxi_Id==6185)
                {
                    bevétel += f.VitelDij + f.Borravalo;
                    db++;
                }
                
            }
            Console.WriteLine($"{db} fuvar alatt: {bevétel}");

            int kártyás = 0;
            int cash = 0;
            foreach (var d in fuvaroks)
            {
                if (d.FizetesModja=="bankkártyás")
                {
                    kártyás++;
                }
                if (d.FizetesModja=="kézpénz")
                {
                    cash++;
                }
            }
            Console.WriteLine($"Bankkártya: {kártyás} fuvar");
            Console.WriteLine($"Kézőénz: {cash} fuvar");





            double Tmile = 0;

            foreach (var d in fuvaroks)
            {
                Tmile += d.tavolsag;
            }

            Console.WriteLine($"{Tmile * 1.6:0.00} km");

            Console.ReadKey();
        }






       
    }

    
}
