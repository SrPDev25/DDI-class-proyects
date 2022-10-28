using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDI_Ejercicio2_Daniel_Ortega
{
    internal class Comida
    {
        String nombre;
        double precio;

        public Comida(string nombre, double precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        public String GetNombre()
        {
            return nombre+" "+precio+"€";
        }

        public double GetPrecio()
        {
            return precio;
        }
    }
}
