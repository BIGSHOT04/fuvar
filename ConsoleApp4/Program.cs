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
            Console.WriteLine($"3. feladat : {fuvaroks.Count} fuvar");
        }






        
    }


}
