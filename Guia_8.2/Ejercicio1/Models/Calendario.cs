using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1.Models
{
    public class Calendario
    {
        List<Feriado> feriados = new List<Feriado>();
        public int CantF 
        { 
            get 
            {
                return feriados.Count;
            }
            set { }
        }
        public Feriado this[DateTime dia]
        {
            get
            {
                Feriado f = null;
                for (int i = 0; i < feriados.Count; i++)
                {
                    f = feriados[i];
                    if(f.Fecha.Year == dia.Year && f.Fecha.Month == dia.Month && f.Fecha.Day == dia.Day)
                    {
                        return f;
                    }
                }
                return f;
            }
        }
        public Feriado this[int idx]
        {
            get
            {
                Feriado f = null;
                if(idx > 0 && idx < CantF)
                    f = feriados[idx];
                return f;
            }
        }
        public Feriado AgregarF(DateTime dia, string des)
        {
            Feriado f = new Feriado(dia,des);
            feriados.Add(f);
            return f;
        }
    }
}
