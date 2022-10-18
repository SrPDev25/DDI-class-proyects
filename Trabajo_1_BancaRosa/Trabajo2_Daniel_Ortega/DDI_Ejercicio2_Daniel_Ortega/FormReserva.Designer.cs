using System.Windows.Forms;

namespace DDI_Ejercicio2_Daniel_Ortega
{
    partial class formReservas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formReservas));
            this.panelSesion = new System.Windows.Forms.Panel();
            this.buttonSesion = new System.Windows.Forms.Button();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.panelSala = new System.Windows.Forms.Panel();
            this.labelCantidadPersonas = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxHoras = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelHola = new System.Windows.Forms.Label();
            this.comboBoxSalas = new System.Windows.Forms.ComboBox();
            this.panelSesion.SuspendLayout();
            this.panelSala.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSesion
            // 
            this.panelSesion.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelSesion.Controls.Add(this.buttonSesion);
            this.panelSesion.Controls.Add(this.textBoxPass);
            this.panelSesion.Controls.Add(this.textBoxUser);
            this.panelSesion.Controls.Add(this.label2);
            this.panelSesion.Controls.Add(this.labelUsuario);
            this.panelSesion.Location = new System.Drawing.Point(12, 12);
            this.panelSesion.Name = "panelSesion";
            this.panelSesion.Size = new System.Drawing.Size(776, 100);
            this.panelSesion.TabIndex = 0;
            // 
            // buttonSesion
            // 
            this.buttonSesion.BackColor = System.Drawing.Color.IndianRed;
            this.buttonSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSesion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSesion.Location = new System.Drawing.Point(612, 54);
            this.buttonSesion.Name = "buttonSesion";
            this.buttonSesion.Size = new System.Drawing.Size(118, 32);
            this.buttonSesion.TabIndex = 4;
            this.buttonSesion.Text = "Iniciar sesion";
            this.buttonSesion.UseVisualStyleBackColor = false;
            this.buttonSesion.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxPass
            // 
            this.textBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPass.Location = new System.Drawing.Point(487, 24);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(154, 24);
            this.textBoxPass.TabIndex = 3;
            // 
            // textBoxUser
            // 
            this.textBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUser.Location = new System.Drawing.Point(127, 24);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(154, 24);
            this.textBoxUser.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(334, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña: ";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(14, 24);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(107, 25);
            this.labelUsuario.TabIndex = 0;
            this.labelUsuario.Text = "Usuario: ";
            // 
            // panelSala
            // 
            this.panelSala.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelSala.Controls.Add(this.labelCantidadPersonas);
            this.panelSala.Controls.Add(this.textBox1);
            this.panelSala.Controls.Add(this.button1);
            this.panelSala.Controls.Add(this.label3);
            this.panelSala.Controls.Add(this.comboBoxHoras);
            this.panelSala.Controls.Add(this.label1);
            this.panelSala.Controls.Add(this.labelHola);
            this.panelSala.Controls.Add(this.comboBoxSalas);
            this.panelSala.Location = new System.Drawing.Point(12, 12);
            this.panelSala.Name = "panelSala";
            this.panelSala.Size = new System.Drawing.Size(776, 306);
            this.panelSala.TabIndex = 2;
            // 
            // labelCantidadPersonas
            // 
            this.labelCantidadPersonas.AutoSize = true;
            this.labelCantidadPersonas.Location = new System.Drawing.Point(348, 92);
            this.labelCantidadPersonas.Name = "labelCantidadPersonas";
            this.labelCantidadPersonas.Size = new System.Drawing.Size(51, 13);
            this.labelCantidadPersonas.TabIndex = 7;
            this.labelCantidadPersonas.Text = "Personas";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(351, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(32, 20);
            this.textBox1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(643, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 56);
            this.button1.TabIndex = 5;
            this.button1.Text = "Reservar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Horas";
            // 
            // comboBoxHoras
            // 
            this.comboBoxHoras.FormattingEnabled = true;
            this.comboBoxHoras.Location = new System.Drawing.Point(188, 108);
            this.comboBoxHoras.Name = "comboBoxHoras";
            this.comboBoxHoras.Size = new System.Drawing.Size(121, 21);
            this.comboBoxHoras.TabIndex = 3;
            this.comboBoxHoras.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sala";
            // 
            // labelHola
            // 
            this.labelHola.AutoSize = true;
            this.labelHola.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHola.Location = new System.Drawing.Point(27, 18);
            this.labelHola.Name = "labelHola";
            this.labelHola.Size = new System.Drawing.Size(74, 25);
            this.labelHola.TabIndex = 1;
            this.labelHola.Text = "Hola, ";
            // 
            // comboBoxSalas
            // 
            this.comboBoxSalas.FormattingEnabled = true;
            this.comboBoxSalas.DropDownStyle= ComboBoxStyle.DropDownList;
            this.comboBoxSalas.Location = new System.Drawing.Point(33, 108);
            this.comboBoxSalas.Name = "comboBoxSalas";
            this.comboBoxSalas.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSalas.TabIndex = 0;
            // 
            // formReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 325);
            this.Controls.Add(this.panelSala);
            this.Controls.Add(this.panelSesion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formReservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSesion.ResumeLayout(false);
            this.panelSesion.PerformLayout();
            this.panelSala.ResumeLayout(false);
            this.panelSala.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSesion;
        private System.Windows.Forms.Button buttonSesion;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Panel panelSala;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxHoras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelHola;
        private System.Windows.Forms.ComboBox comboBoxSalas;
        private System.Windows.Forms.Label labelCantidadPersonas;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxPass;
    }
}

