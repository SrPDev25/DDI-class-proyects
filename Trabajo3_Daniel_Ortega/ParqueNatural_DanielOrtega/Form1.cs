using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParqueNatural_DanielOrtega
{
    public partial class Form1 : Form
    {
        Control control;
        Double[] precios = new double[]{1d,5d, 5d,10d };//niños,adultos,mascotas,vehiculo
        public Form1()
        {
            InitializeComponent();
            panelMatricula.Enabled = false;
            panelTicket.Visible = false;
            this.Size = new Size(574, 467);
            control=new Control();
            labelAforoPersonas.Text=control.getAforoPersonas().ToString();
            labelAforoVehiculos.Text = control.getAforoVehiculos().ToString();

        }
        
        private bool isCalculable()
        {
            bool isFine =true;

            //Calcular matricula y telefono
            if (radioButtonSI.Checked)
            {
                if (textBoxMatricula.Text.Equals(""))
                {
                    error.SetError(textBoxMatricula, "Falta matricula");
                    isFine = false;
                }
                else
                {
                    error.SetError(textBoxMatricula, "");
                }
                if (!isTelefonoRight())
                {
                    labelAforoPersonas.Text = "queso";
                    
                    isFine = false;
                }
                else
                {
                    error.SetError(textBoxTelefono, "");
                }

                if (control.isAforoVehiculosSuperado())
                {
                    isFine = false;
                    error.SetError(textBoxMatricula, "Aforo superado");
                }else
                {
                    error.SetError(textBoxMatricula, "");
                }
            }

            if (textBoxAdultos.Text.Equals("") && !textBoxNinnos.Text.Equals(""))
            {
                error.SetError(textBoxNinnos, "Los niños no pueden ir solos");
                isFine = false;
            }
            else if(!textBoxAdultos.Text.Equals("") && !textBoxNinnos.Text.Equals("") && !IsAllDigits(textBoxNinnos.Text))
            {
                error.SetError(textBoxNinnos, "Introduzca un número");
                isFine = false;
            }
            else
            {
                error.SetError(textBoxNinnos, "");
            }

            if (textBoxAdultos.Text.Equals("") && !textBoxMascotas.Text.Equals(""))
            {
                error.SetError(textBoxMascotas, "Las mascotas no pueden ir solas");
                isFine = false;
            }
            else if (!textBoxAdultos.Text.Equals("") && !textBoxMascotas.Text.Equals("") && !IsAllDigits(textBoxMascotas.Text))
            {
                error.SetError(textBoxMascotas, "Introduzca un número");
                isFine = false;
            }
            else
            {
                error.SetError(textBoxMascotas, "");
            }

            if (textBoxAdultos.Text.Equals(""))
            {
                error.SetError(textBoxAdultos, "Falta adulto");
                isFine = false;
            }else if (!IsAllDigits(textBoxAdultos.Text))
            {
                error.SetError(textBoxAdultos, "Introduzca un número");
                isFine = false;
            }
            else
            {
                error.SetError(textBoxAdultos, "");
            }

            if (control.isAforoPersonasSuperado(textBoxAdultos.Text, textBoxNinnos.Text))
            {
                error.SetError(textBoxAdultos, "Superado aforo");
                isFine = false;
            }else
            {
                error.SetError(textBoxAdultos, "");
            }
                
            

            return isFine;
        }

        //Comprobar telefono
        private Boolean isTelefonoRight()
        {
            Boolean isFine =true;
            String telefono = textBoxTelefono.Text;
            if (telefono.Length!=0)
            {
                labelAforoPersonas.Text = telefono.ElementAt(0)+"";
                if (telefono.ElementAt(0).Equals("6") || telefono.ElementAt(0).Equals("7"))
                {
                    error.SetError(textBoxTelefono, "Tiene que empezar por 7 o 6");
                    isFine = false;
                }
                if (!IsAllDigits(telefono))
                {
                    error.SetError(textBoxTelefono, "Solo introduzca números");
                    isFine = false;
                }
                if (telefono.Length!=9)
                {
                    error.SetError(textBoxTelefono, "Los telefonos tienen 9 números");
                    isFine = false;
                }
            }
            else
            {
                isFine = false;
            }
            return isFine;

        }

        private void isRadioChecked()
        {
            if (radioButtonSI.Checked)
            {
                panelMatricula.Enabled = true;
            }else if (radioButtonNo.Checked)
            {
                panelMatricula.Enabled = false;
                
            }
        }

        bool IsAllDigits(string s)
        {
            foreach (char c in s)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }

        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            isRadioChecked();
        }

        private void radioButtonNo_CheckedChanged(object sender, EventArgs e)
        {
            isRadioChecked();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxAdultos_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            if (isCalculable())
            {
                this.Size = new Size(795, 467);
                panelTicket.Visible = true;
                if (radioButtonSI.Checked)
                {
                    control.annadirVehiculo(textBoxMatricula.Text, textBoxTelefono.Text);
                }
                control.annadirPersonas(textBoxAdultos.Text, textBoxNinnos.Text);
                labelAforoPersonas.Text = control.getAforoPersonas().ToString();
                labelAforoVehiculos.Text = control.getAforoVehiculos().ToString();


                //---Ticket
                double total = 0;//Int32.Parse(menores)
                double adulto = Int32.Parse(textBoxAdultos.Text) * precios[1];
                labelAdultos.Text = adulto + "€";
                total = total + adulto;
                if (textBoxNinnos.Text.Length != 0)
                {
                    double ninno = Int32.Parse(textBoxNinnos.Text) * precios[0];
                    labelNinnos.Text = ninno + "€";
                    total = total + ninno;
                }
                else
                {
                    labelNinnos.Text = 0 + "€";
                }
                if (textBoxMascotas.Text.Length != 0)
                {
                    double mascotas = Int32.Parse(textBoxMascotas.Text) * precios[2];
                    labelMascotas.Text = mascotas + "€";
                    total = total + mascotas;
                }
                else
                {
                    labelMascotas.Text = 0 + "€";
                }
                if (radioButtonSI.Checked)
                {
                    labelVehiculo.Text = precios[3]+"€";
                    total += precios[3];
                }
                else
                {
                    labelVehiculo.Text = "No";
                }

                labelTotal.Text = total + "€";
            }
        }

        private void textBoxBuscarTelf_TextChanged(object sender, EventArgs e)
        {
            String telefono = control.getTelefono(textBoxBuscarTelf.Text);
            if (!telefono.Equals(""))
            {
                labelTelefono.Text = telefono;
            }
            else
            {
                labelTelefono.Text = "";
            }
        }
    }
}
