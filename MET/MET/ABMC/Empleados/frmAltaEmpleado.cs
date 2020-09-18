﻿using BibliotecaDB.Acceso;
using BibliotecaDB.Entidades;
using BibliotecaMET.Clases.Form;
using BibliotecaMET.Clases.MetodosGenerales.Forms;
using BibliotecaMET.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MET.ABMC.Empleados
{
    public partial class frmAltaEmpleado : AbstractForm
    {
        public frmAltaEmpleado()        {
            InitializeComponent();
            Actualizar(base.Tema);
        }
        private void CargarForm() 
        {
            CargarGeneros();
            Actualizar(base.Tema);
        }

        private void CargarGeneros() 
        {
            cmbGeneros.DataSource = AccesoDBGenero.ConsultarGeneros();
            cmbGeneros.DisplayMember = "nombre";
            cmbGeneros.ValueMember = "id";
            cmbGeneros.SelectedIndex = -1;
        }


        //TEMAS

        //Set colores 
        protected override void AjustarPaneles(Color[] Colors) //Ingresar colores
        {
            //barraTitulo.BackColor = Colors[0];
            //panelCentro.BackColor = Colors[1];
            this.BackColor = Colors[0];
        }
        //Ingresar colores - según tema
        protected override void AjustarFondos(string nombreTema)
        {
            Color[] Colors = new Color[1];
            if (nombreTema.Equals("Visual Studio 2013 Dark"))
            {
                //Colors[0] = Color.FromArgb(45, 45, 48);
                //Colors[1] = Color.FromArgb(28, 28, 28);
                Colors[0] = Color.FromArgb(37, 37, 38);
                
            }
            if (nombreTema.Equals("Visual Studio 2013 Light"))
            {
                //Colors[0] = Color.FromArgb(238, 238, 242);
                //Colors[1] = Color.FromArgb(204, 206, 219);
                Colors[0] = Color.FromArgb(255, 255, 255);
            }

            AjustarPaneles(Colors);

        }
        //Set colores 
        protected override void AjustarBotones(Color[] Colors)
        {
            //botones
            btnRegistrar.BackColor = Colors[0];
            btnCancelar.BackColor = Colors[0];
            btnLimpiarCampos.BackColor = Colors[0];
            //BotonesSobre
            btnLimpiarCampos.FlatAppearance.MouseOverBackColor = Colors[1];
            btnRegistrar.FlatAppearance.MouseOverBackColor = Colors[1];
            btnCancelar.FlatAppearance.MouseOverBackColor = Colors[1];
        }
        //Ingresar colores - según tema
        protected override void AjustarMenues(string nombreTema)
        {
            Color[] Colors = new Color[2];
            if (nombreTema.Equals("Visual Studio 2013 Dark"))
            {
                Colors[0] = Color.FromArgb(27, 27, 28);
                Colors[1] = Color.FromArgb(51, 51, 52);

            }
            if (nombreTema.Equals("Visual Studio 2013 Light"))
            {
                Colors[0] = Color.FromArgb(246, 246, 246);
                Colors[1] = Color.FromArgb(201, 222, 245);
            }
            AjustarBotones(Colors);

        }

        private bool Validar()
        {
            bool resultado = true;
            string mensaje = "";
            if (txtNombre.Text.Equals("")) { mensaje += "\n-Nombre: vacio"; }
            if (txtApellido.Text.Equals("")) { mensaje += "\n-Apellido: vacio"; }
            if (txtTelefono.Text.Equals("+")) { mensaje += "\n-Telefono: El telefono ingresado no es válido"; }
            if (dtpFechaNacimiento.Value.Date==DateTime.Today.Date) { mensaje += "\n-Fecha Nacimiento: Identíca al día actual"; }
            if (cmbGeneros.SelectedIndex.Equals(-1)) { mensaje += "\n-Genero: No se ha seleccionado un genero"; }

            if (!mensaje.Equals("")) { MessageBox.Show("Los siguientes campos están erroneos:" + mensaje, "Error"); resultado = false; }

            return resultado;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (Validar()) 
            {
                BibliotecaDB.Entidades.Empleado empleadoNuevo = new BibliotecaDB.Entidades.Empleado(Convert.ToInt32(txtNroDocumento.Text), txtNombre.Text, txtApellido.Text, Convert.ToInt32(cmbGeneros.SelectedValue), dtpFechaNacimiento.Value.Date, txtCorreo.Text, txtTelefono.Text, txtObservaciones.Text, txtInstagram.Text);

                if (ControladorEmpleados.RegistrarEmpleado(empleadoNuevo)) 
                {
                    MessageBox.Show("Empleado cargado con exito", "Operacion exitosa");
                }
                else
                {
                    MessageBox.Show("No se pudo cargar el Empleado", "Operacion fallida");
                }

            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
           OnlyPhoneNumbers(sender, e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetodosForms.OnlyIntergers(sender, e);
        }

        private void frmAltaEmpleado_Load(object sender, EventArgs e)
        {
            CargarForm();
        }

        public void OnlyPhoneNumbers(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine(e.KeyChar.ToString().ToCharArray());
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.Equals('+'))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.Equals('')) { e.Handled = false; }
            else if (e.KeyChar.Equals('-')) { e.Handled = false; }
            else
                {
                    e.Handled = true;
                }
            
        }

        public void LimpiarCampos() 
        {
            txtNroDocumento.Text = txtNombre.Text = txtApellido.Text = txtCorreo.Text = txtTelefono.Text = txtInstagram.Text = txtObservaciones.Text = "";
        }
        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
