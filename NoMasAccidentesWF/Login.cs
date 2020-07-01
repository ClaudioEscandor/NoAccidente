using Capa_DAL.Controlador;
using Capa_DAL.Modelo;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoMasAccidentesWF
{
    

    public partial class Login : MetroForm
    {
        LoginControlador LCon = new LoginControlador();

        public Login()
        {
            InitializeComponent();
        }

        //Boton de iniciar sesion
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string email = txtUsu.Text;
            string password = txtPass.Text;

             int tipo_usuario = LCon.ObtenerUsuario(email, password);

            if (tipo_usuario == 1)
            {
                MenuPrincipal m = new MenuPrincipal();
                this.Hide();
                m.Show();
                MessageBox.Show(" Bienvenid@ || " + email, "Inicio Sesion ");

            } else if (txtUsu.Text.Trim() == "" && txtPass.Text.Trim() == "")
            {
                MessageBox.Show(" Ingrese Email y Contraseña", "Error");
            }
            else if(tipo_usuario == 2){
                MessageBox.Show(" Profesional no tiene privilegios ", "Error");
                limpiar();
            }
            else if (tipo_usuario == 3)
            {
                MessageBox.Show(" Cliente no tiene privilegios ", "Error");
                limpiar();
            }
            else 
            {
                MessageBox.Show(" EL USUARIO NO EXISTE ", "Error");
                limpiar();
            }

        }
        private void limpiar()
        {
            txtUsu.Text = "";
            txtPass.Text = "";
        }

        private void cbMostrarC_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMostrarC.Checked == true)
            {
                if(txtPass.PasswordChar == '*')
                {
                    txtPass.PasswordChar = '\0';
                }
            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }

        private void mlOlvidar_Click(object sender, EventArgs e)
        {

        }
    }
}
