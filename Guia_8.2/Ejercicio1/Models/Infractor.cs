using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Infractor
    {
        public int DNI { get; set; }
        public string ApeyNom { get; set; }

        public Infractor(int dNI, string apeyNom)
        {
            DNI = dNI;
            ApeyNom = apeyNom;
        }
        public override string ToString()
        {
            string dat = $"{ApeyNom};{DNI}";
            return dat;
        }
    }
}
