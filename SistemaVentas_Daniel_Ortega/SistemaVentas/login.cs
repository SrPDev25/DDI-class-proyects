using System;
using System.Windows.Forms;

using CapaNegocio;
using CapaEntidad;
using CapaDatos;
using System.Linq;
using System.Collections.Generic;

namespace SistemaVentas
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            List<Usuario> TEST = new CD_Usuario().Listar()
           
            Usuario ousuario = new CN_Usuario().Listar().Where(u => u.Documento == txUser.Text && u.Clave == txContra.Text).FirstOrDefault();

            if (ousuario != null)
            {
                inicio form = new inicio(/*ousuario*/);
                form.Show();
                this.Hide();//DESPUES DE INICIAR CIERRAS ESTE PANEL
                form.FormClosing += frm_closing;//CUANDO CIERRES EL DE INICIO TE REABRE ESTE
                txUser.Text = "";
                txContra.Text = "";
            }
            else
            {
                MessageBox.Show("Usuario erroneo", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
              
            

        
        }

        private void frm_closing(object sender, FormClosingEventArgs e)//FORM CLOSSING  
        {
            this.Show();
        }
    }
}
