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
        List<String> happyUsers;
        String currentUser;
        List<Sala> salas;
        ErrorProvider errorUser;
        Boolean[] horasSala;
        ErrorProvider errorSeleccion;



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
            happyUsers = new List<string>();
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
                if (!happyUsers.Contains(user))
                {
                    if (passCheck.Equals(pass))
                    {
                        panelSesion.Visible = false;
                        panelSala.Visible = true;
                        labelHola.Text = "Hola, " + user;
                        this.Size = new Size(816, 366);
                        currentUser = user;

                    }
                }
                else
                {
                    errorUser = new ErrorProvider();
                    errorUser.SetError(textBoxUser, "Este usuario ya ha reservado");
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
            comboBoxSalas.Items.Clear();
            comboBoxHoras.Items.Clear();
            errorSeleccion = new ErrorProvider();
            foreach (Sala i in salas)
            {
                comboBoxSalas.Items.Add(i.GetNombre());
            }

        }

        private void labelUsuario_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxSalas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pos = comboBoxSalas.SelectedIndex;

            comboBoxHoras.Items.Clear();
            horasSala = salas.ElementAt(pos).getHoras();
            for (int i = 0; i < horas.Length; i++)
            {
                if (!horasSala[i])
                {
                    comboBoxHoras.Items.Add(horas[i]);
                }
                else
                {
                    comboBoxHoras.Items.Add("Reservada");
                }

            }

        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            panelSala.Visible = false;
            panelSesion.Visible = true;
            this.Size = new Size(349, 250);
        }

        private void buttonReserva_Click(object sender, EventArgs e)
        {
            if (comboBoxHoras.SelectedIndex >= 0 && comboBoxSalas.SelectedIndex >= 0 && !horasSala[comboBoxHoras.SelectedIndex])
            {
                errorSeleccion.Clear();
                salas.ElementAt(comboBoxSalas.SelectedIndex).Reservar(comboBoxHoras.SelectedIndex);
                happyUsers.Add(currentUser);
                panelSala.Visible = false;
                panelSesion.Visible = true;
                this.Size = new Size(349, 250);
            }
            else
            {
                errorSeleccion.SetError(comboBoxHoras, "Seleccione una hora y una sala disponible");
            }
        }
    }
}

