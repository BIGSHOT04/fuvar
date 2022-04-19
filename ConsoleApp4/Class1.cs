using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class fuvarok
    {
        public int Taxi_Id { get; set; }
        public DateTime Indulas_Ido { get; set; }
        public int Utazas_Ido { get; set; }
        public double Megtett_Tav { get; set; }
        public double VitelDij { get; set; }
        public double Borravalo { get; set; }
        public string FizetesModja { get; set; }

        public fuvarok (string sor)
        {
            string[] f = sor.Split(';');
            Taxi_Id = int.Parse(f[0]);
            Indulas_Ido = int.Parse(f[1]);
            Utazas_Ido = int.Parse(f[2]);
            Megtett_Tav = int.Parse(f[3]);
            VitelDij = int.Parse(f[4]); 
            Borravalo=int.Parse(f[5]);
            FizetesModja = f[6];

        }
    }
}
