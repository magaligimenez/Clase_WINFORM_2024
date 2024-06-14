using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoUnoCursada2024
{
    public partial class Form1 : Form
    {
        List<String> listaLocalidades; //creo una lista en memoria
        List<Alumno> listaAlumnos;
        //cada control expone una serie de eventos


        //groupbox es para agrupar y que se vea
        //panel es para agrupar y que NO se vea 
        
        
        public Form1()
        {
            InitializeComponent();
            listaLocalidades = new List<string>();
            listaAlumnos = new List<Alumno>();
            //MessageBox.Show("me estoy construyendo");

            //agrego a la lista
            listaLocalidades.Add("Avellaneda");
            listaLocalidades.Add("lomas");
            listaLocalidades.Add("wilde");
        }

        //ejemplo 1
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Buenas... division 221"); //message es la clase y show es el metodo estatico. Es como un alert pero mas pro
        }

        #region ciclos de vida del formulario

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("me estoy cargando");

            //agrego items al comboBox
            /*cmbLocalidad.Items.Add("Avellaneda");
            cmbLocalidad.Items.Add("Gerli");
            cmbLocalidad.Items.Add("Wilde");*/

            //es mas optimo hacer un foreach. De todas formas esto deberia estar en un metodo.
            /*foreach (string localidad in listaLocalidades)
            {
                cmbLocalidad.Items.Add(localidad);
            }
            */
            CargarComboLocalidades();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            //MessageBox.Show("me estoy activando");
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //MessageBox.Show("me estoy pintando");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Seguro?", "Cierre del formulario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) 
                == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MessageBox.Show("me cerre");
        }


        #endregion

        //metodo que mencione anteriormente en el ciclo load
        private void CargarComboLocalidades()
        {
            foreach (string localidad in listaLocalidades)
            {
                cmbLocalidad.Items.Add(localidad);
            }
        }

        //usar textbox con un boton para mostrar
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            /*bloqueo el textbox y con el mostrar solo muestro lo que yo quiero
            txt_Nombre.Enabled = false;
            txt_Nombre.Text = "german";
            */


            /*dejo que el textbox tome un texto y con el boton lo muestro con un alert
            //string nombre;
            //nombre = txt_Nombre.Text;

            MessageBox.Show(nombre);*/


            //Manera correcta integrando clase Alumno.
            string nombre;
            string localidad;
            int edad;
            string genero;
            bool habilitado;
            //string mensaje;

            genero = "Masculino";
            habilitado = false;

            localidad = cmbLocalidad.Text;
            nombre = txt_Nombre.Text;
            edad = int.Parse(txtEdad.Text);
            if (rdoFemenino.Checked)
            {
                genero = "Femenino";
            }
            if (chkHabilitado.Checked)
            {
                habilitado = true;
            }

            Alumno miAlumno = new Alumno(nombre, localidad, edad, genero, habilitado);
            
            listaAlumnos.Add(miAlumno);
            //MessageBox.Show(miAlumno.ToString());

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtLista.Clear();
            //cargar en el listbox el alumno
            foreach (Alumno miAlumno in listaAlumnos)
            {
                txtLista.Text += miAlumno.ToString();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtEdad.Clear();
            txt_Nombre.Clear();
            chkHabilitado.Checked = false;
            rdoFemenino.Checked = false;
            rdoMasculino.Checked = false;
        }
    }
}
