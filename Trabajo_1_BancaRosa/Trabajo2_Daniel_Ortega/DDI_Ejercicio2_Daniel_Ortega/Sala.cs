using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDI_Ejercicio2_Daniel_Ortega
{
    internal class Sala
    {
        Boolean[] horas;
        String nombre;
        int aforo;

        public Sala(String nombre, int aforo)
        {
            this.nombre = nombre;
            this.aforo = aforo;
            horas = new Boolean[17];
        }
        public Sala(String nombre, int aforo,int[] horasExentas)
        {
            this.nombre = nombre;
            this.aforo = aforo;
            horas = new Boolean[17];
            foreach (int x in horasExentas)
            {
                horas[x] = true;
            }

        }

        public void Reservar(int hora)
        {
            horas[hora] = true;
        }
        public String GetNombre()
        {
            return nombre+ " (" + aforo+" personas)";
        }

        public Boolean[] getHoras()
        {
            return horas;
        }

        public int getAforo()
        {
            return aforo;
        }
        
    }
}
