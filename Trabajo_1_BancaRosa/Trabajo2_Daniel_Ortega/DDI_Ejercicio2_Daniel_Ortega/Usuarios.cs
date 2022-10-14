using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDI_Ejercicio2_Daniel_Ortega
{
    internal class Usuarios
    {
        String name;
        String pass;
        public Usuarios(String name, String pass)
        {
            this.name = name;
            this.pass = pass;   
        }

        public String GetName()
        {
            return name;
        }

        public String Pass()
        {
            return pass;
        }
    }
}
