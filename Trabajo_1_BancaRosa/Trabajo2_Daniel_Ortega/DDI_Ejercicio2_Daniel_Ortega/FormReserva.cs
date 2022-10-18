using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DDI_Ejercicio2_Daniel_Ortega
{
    public partial class formReservas : System.Windows.Forms.Form
    {
        Dictionary<String, String> usuarios;
        String[] horas;
        List<Sala> salas;
        ErrorProvider errorUser;


        public formReservas()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] credenciales;
            String credencialProv = Properties.Resources.credenciales.ToString();
            credenciales = credencialProv.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
            usuarios = new Dictionary<String, String>();
            int i = 0;
            while (i < credenciales.Length)
            {
                usuarios.Add(credenciales[i], credenciales[i + 1]);
                i += 2;
            }

            horas = new String[] {"8:00-9:00", "9:00-10:00", "10:00-11:00", "11:00-12:00", "12:00-13:00",
            "13:00-14:00", "14:00-15:00", "15:00-16:00", "16:00-17:00" };
            cargarSalas();
            cargarDatosPanel();
            panelSala.Visible = false;
            this.Size = new Size(349, 250);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String user = textBoxUser.Text;
            String pass = textBoxPass.Text;
            String passCheck;
            if (usuarios.TryGetValue(user, out passCheck))
            {
                if (passCheck.Equals(pass))
                {



                    panelSesion.Visible = false;
                    panelSala.Visible = true;
                    labelHola.Text = "Hola, " + user;
                    this.Size = new Size(816, 366);


                }
            }
            else
            {
                errorUser = new ErrorProvider();
                errorUser.SetError(textBoxUser, "Usuario o contraseña incorrectos");
            }
        }
        private void cargarSalas()
        {
            salas = new List<Sala>();
            salas.Add(new Sala("Sala 1", 8));
            salas.Add(new Sala("Sala 2", 10));
            salas.Add(new Sala("Comedor", 20, new int[] { 5, 6, 7 }));//Ocupa las horas indicadas del comedor

        }

        private void cargarDatosPanel()
        { 
            foreach (Sala i in salas )
            {
                comboBoxSalas.Items.Add(i.getNombre());
            }
            
        }

        private void labelUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}

