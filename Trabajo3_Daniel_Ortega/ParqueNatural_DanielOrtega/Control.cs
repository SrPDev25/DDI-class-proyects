using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParqueNatural_DanielOrtega
{
    internal class Control
    {
        Dictionary<String, String> vehiculos;//Limite 500
        int aforo;//Limite 3000

        public Control()
        {
            vehiculos = new Dictionary<String, String>();
            vehiculos.Add("queso", "789456123");
            aforo = 450;
        }


        public String getTelefono(String matricula)
        {
            String telefono;
            if (!vehiculos.ContainsKey(matricula))
            {
                telefono = "";
            }
            else
            {
                telefono = vehiculos[matricula];
            }

            return telefono;//Controlar si no existe
        }

        public Boolean isAforoPersonasSuperado(String menores, String mayores)
        {
            int numMenores=  Int32.Parse("5");
            int numMayores= Int32.Parse("5");

            if ((aforo+numMenores+numMayores)>3000)
            
                return true;
            else
                return false;
        }

        public Boolean isAforoVehiculosSuperado()
        {
            if (!(vehiculos.Count<500))
                return true;
            else
                return false;
        }

        public void annadirPersonas(String menores, String mayores)
        {
            int numMayores = 0;
            int numMenores = 0;//Se peta
            if (!menores.Equals(""))
            {
                numMenores = 0;
            }
            aforo += numMenores + numMayores;
        }

        public void annadirVehiculo(String matricula, String telefono)
        {
            vehiculos.Add(matricula, telefono);
        }

        public int getAforoPersonas()
        {
            return aforo;
        }

        public int getAforoVehiculos()
        {
            return vehiculos.Count;
        }


    }
}
