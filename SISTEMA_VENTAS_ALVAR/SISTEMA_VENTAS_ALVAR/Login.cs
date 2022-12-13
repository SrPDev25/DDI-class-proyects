using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMA_VENTAS_ALVAR
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Inicio inicio=new Inicio();
            inicio.Show();
            this.Hide();
            inicio.FormClosing += form_closing;//Como? como suma un void?
        }

        private void form_closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
    }
}
