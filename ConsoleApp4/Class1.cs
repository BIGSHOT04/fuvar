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
        public int idötartam { get; set; }
        public double tavolsag { get; set; }
        public double VitelDij { get; set; }
        public double Borravalo { get; set; }
        public string FizetesModja { get; set; }

        public fuvarok (string sor)
        {
            string[] f = sor.Split(';');

            Taxi_Id = int.Parse(f[0]);
            Indulas_Ido = DateTime.Parse(f[1]);
            idötartam = int.Parse(f[2]);
            tavolsag = double.Parse(f[3]);
            VitelDij = double.Parse(f[4]); 
            Borravalo=double.Parse(f[5]);
            FizetesModja = f[6];

        }
    }
}
