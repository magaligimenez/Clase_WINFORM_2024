namespace ProyectoUnoCursada2024
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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.chkHabilitado = new System.Windows.Forms.CheckBox();
            this.rdoMasculino = new System.Windows.Forms.RadioButton();
            this.rdoFemenino = new System.Windows.Forms.RadioButton();
            this.grpGenero = new System.Windows.Forms.GroupBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.txtLista = new System.Windows.Forms.RichTextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.grpGenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 67);
            this.button1.TabIndex = 0;
            this.button1.Text = "boton_division(ejercicio 1)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btn_Aceptar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Aceptar.Location = new System.Drawing.Point(12, 175);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(107, 51);
            this.btn_Aceptar.TabIndex = 1;
            this.btn_Aceptar.Text = "Agregar";
            this.btn_Aceptar.UseVisualStyleBackColor = false;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(67, 26);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(252, 20);
            this.txt_Nombre.TabIndex = 2;
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(67, 52);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(121, 21);
            this.cmbLocalidad.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 26);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // chkHabilitado
            // 
            this.chkHabilitado.AutoSize = true;
            this.chkHabilitado.Location = new System.Drawing.Point(15, 117);
            this.chkHabilitado.Name = "chkHabilitado";
            this.chkHabilitado.Size = new System.Drawing.Size(73, 17);
            this.chkHabilitado.TabIndex = 5;
            this.chkHabilitado.Text = "Habilitado";
            this.chkHabilitado.UseVisualStyleBackColor = true;
            // 
            // rdoMasculino
            // 
            this.rdoMasculino.AutoSize = true;
            this.rdoMasculino.Location = new System.Drawing.Point(13, 19);
            this.rdoMasculino.Name = "rdoMasculino";
            this.rdoMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdoMasculino.TabIndex = 6;
            this.rdoMasculino.TabStop = true;
            this.rdoMasculino.Text = "Masculino";
            this.rdoMasculino.UseVisualStyleBackColor = true;
            // 
            // rdoFemenino
            // 
            this.rdoFemenino.AutoSize = true;
            this.rdoFemenino.Location = new System.Drawing.Point(15, 42);
            this.rdoFemenino.Name = "rdoFemenino";
            this.rdoFemenino.Size = new System.Drawing.Size(71, 17);
            this.rdoFemenino.TabIndex = 8;
            this.rdoFemenino.TabStop = true;
            this.rdoFemenino.Text = "Femenino";
            this.rdoFemenino.UseVisualStyleBackColor = true;
            // 
            // grpGenero
            // 
            this.grpGenero.Controls.Add(this.rdoMasculino);
            this.grpGenero.Controls.Add(this.rdoFemenino);
            this.grpGenero.Location = new System.Drawing.Point(107, 105);
            this.grpGenero.Name = "grpGenero";
            this.grpGenero.Size = new System.Drawing.Size(130, 64);
            this.grpGenero.TabIndex = 11;
            this.grpGenero.TabStop = false;
            this.grpGenero.Text = "Genero";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(67, 79);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 12;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(12, 86);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(35, 13);
            this.lblEdad.TabIndex = 13;
            this.lblEdad.Text = "Edad:";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(12, 55);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(56, 13);
            this.lblLocalidad.TabIndex = 14;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnListar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnListar.Location = new System.Drawing.Point(154, 175);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(107, 51);
            this.btnListar.TabIndex = 16;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // txtLista
            // 
            this.txtLista.Location = new System.Drawing.Point(445, 26);
            this.txtLista.Name = "txtLista";
            this.txtLista.Size = new System.Drawing.Size(285, 235);
            this.txtLista.TabIndex = 17;
            this.txtLista.Text = "";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(107, 238);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 18;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(742, 285);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtLista);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.grpGenero);
            this.Controls.Add(this.chkHabilitado);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.cmbLocalidad);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.grpGenero.ResumeLayout(false);
            this.grpGenero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.ComboBox cmbLocalidad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.CheckBox chkHabilitado;
        private System.Windows.Forms.RadioButton rdoMasculino;
        private System.Windows.Forms.RadioButton rdoFemenino;
        private System.Windows.Forms.GroupBox grpGenero;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.RichTextBox txtLista;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

