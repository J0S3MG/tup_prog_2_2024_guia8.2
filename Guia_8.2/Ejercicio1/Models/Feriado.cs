using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Feriado
    {
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set;}

        public Feriado(DateTime f,string d)
        {
            Fecha = f;
            Descripcion = d;
        }
    }
}
