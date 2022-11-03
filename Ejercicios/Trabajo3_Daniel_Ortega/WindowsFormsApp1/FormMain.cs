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

namespace WindowsFormsApp1
{
    public partial class FormMain : Form
    {
        String[] callesList;
        public FormMain()
        {
            InitializeComponent();
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxCiudad.Items.Add("Burgos");
        }

        
        private void comboBoxCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCiudad.SelectedIndex!=-1)
            {
                fillComboBox();
            }
        }

        private Boolean CheckData()
        {
            Boolean isFine=true;



            return isFine;
        }

        

        private void fillComboBox()
        {
            
            String calles = Properties.Resources.calles.ToString();
            callesList = calles.Split(new[] {"/"}, StringSplitOptions.RemoveEmptyEntries);
            foreach (String calle in callesList)
            {
                comboBoxCalle.Items.Add(calle);
            }
        }

        
    }

}
