﻿namespace examen2eva_daniel_ortega
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.menufichar = new FontAwesome.Sharp.IconMenuItem();
            this.menuconsultar = new FontAwesome.Sharp.IconMenuItem();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menufichar,
            this.menuconsultar});
            this.Menu.Location = new System.Drawing.Point(0, 73);
            this.Menu.Name = "Menu";
            this.Menu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Menu.Size = new System.Drawing.Size(800, 73);
            this.Menu.TabIndex = 8;
            this.Menu.Text = "Menu";
            // 
            // menufichar
            // 
            this.menufichar.AutoSize = false;
            this.menufichar.IconChar = FontAwesome.Sharp.IconChar.SchoolCircleCheck;
            this.menufichar.IconColor = System.Drawing.Color.Black;
            this.menufichar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menufichar.IconSize = 50;
            this.menufichar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menufichar.Name = "menufichar";
            this.menufichar.Size = new System.Drawing.Size(122, 69);
            this.menufichar.Text = "Fichar";
            this.menufichar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuconsultar
            // 
            this.menuconsultar.AutoSize = false;
            this.menuconsultar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassMinus;
            this.menuconsultar.IconColor = System.Drawing.Color.Black;
            this.menuconsultar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuconsultar.IconSize = 50;
            this.menuconsultar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuconsultar.Name = "menuconsultar";
            this.menuconsultar.Size = new System.Drawing.Size(122, 69);
            this.menuconsultar.Text = "Consultar";
            this.menuconsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.Lime;
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.Size = new System.Drawing.Size(800, 73);
            this.menuTitulo.TabIndex = 7;
            this.menuTitulo.Text = "menuStrip2";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Lime;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.Azure;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnSalir.IconColor = System.Drawing.Color.Azure;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.Location = new System.Drawing.Point(12, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(62, 66);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(91, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(581, 42);
            this.label1.TabIndex = 10;
            this.label1.Text = "Registro de Asistencia a Cursos";
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 146);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(800, 304);
            this.contenedor.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.menuTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Asistencia";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private FontAwesome.Sharp.IconMenuItem menufichar;
        private FontAwesome.Sharp.IconMenuItem menuconsultar;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private FontAwesome.Sharp.IconButton btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel contenedor;
    }
}

