using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Cuota
    {
        double montB = 0;
        public int CantCuota { get; set; }
        public double PjVoluntario { get; set; }
        public double Pj1erVen { get; set; }
        public double Pj2doVen { get; set; }
        public DateTime Fecha1erVen {  get; set; }
        public DateTime Fecha2doVen { get; set; }   

        public double MontB 
        {
            get 
            {
                double mb = montB / CantCuota;
                return mb;
            }
            set { }
        }
        public double Mont1erVen
        {
            get
            {

            }
        }
        public double Mont2doVen
        {
            get
            {

            }
        }


    }
}
