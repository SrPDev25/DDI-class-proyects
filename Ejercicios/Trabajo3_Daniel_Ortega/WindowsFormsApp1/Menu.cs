using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Menu
    {
        ArrayList primerPlato = new ArrayList();
        ArrayList segundoPlato = new ArrayList();
        ArrayList postre = new ArrayList();

        public Menu(ArrayList primerPlato, ArrayList segundoPlato, ArrayList postre)
        {
            this.primerPlato = primerPlato;
            this.segundoPlato = segundoPlato;
            this.postre = postre;
        }

        public ArrayList getPrimerPlato()
        {
            return primerPlato;
        }

        public ArrayList getSegundoPlato()
        {
            return segundoPlato;
        }

        public ArrayList getPostre()
        {
            return postre;
        }
    }
}
