using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Visualizar : Form
    {
        public Visualizar(string primerPlato, string segundoPlato, string postre, string bebida, bool pan, double total)
        {
            InitializeComponent();
            labelPrimerPlato.Text = primerPlato;
            labelSegundoPlato.Text = segundoPlato;
            labelPostre.Text = postre;
            labelBebida.Text = bebida;
            labelTotal.Text = total + "€";

            if (pan)
            {
                labelPan.Text = "Pan +0.8€";
            }
            else
            {
                labelPan.Text = "Sin complemento";
            }
        }

        private void labelPan_Click(object sender, EventArgs e)
        {

        }
    }
}
