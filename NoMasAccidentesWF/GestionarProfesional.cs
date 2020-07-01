using Capa_DAL.Conexion;
using Capa_DAL.Controlador;
using Capa_DAL.Modelo;
using MetroFramework.Controls;
using MetroFramework.Forms;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoMasAccidentesWF
{
    public partial class GestionarProfesional : MetroUserControl
    {
        ErrorProvider error = new ErrorProvider();
        ProfesionalControlador proC = new ProfesionalControlador();

        CL_Operaciones operaciones = new CL_Operaciones();
        public GestionarProfesional()
        {
            InitializeComponent();
            // cargar grid
            cargarGrdEditProfesional();
        }
        //metodo para listar los datos en la grilla
        private void cargarGrdEditProfesional()
        {
            grdEditarProfe.DataSource = proC.listarProfesionalEditar();
        }
        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void txtContraseña_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

      

        private void limpiar()
        {
            txtEmailEditarP.Text = "";
            txtContraseñaEditarP.Text = "";
            txtPNombreEditarP.Text = "";
            txtSNombreEditarP.Text = "";
            txtAPaternoEditarP.Text = "";
            txtApMaternoEditarP.Text = "";
            txtDireccionEditarP.Text = "";
            txtRutEditarP.Text = "";
            txtTelefonoEditarP.Text = "";
        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void txtApellidoP_Click(object sender, EventArgs e)
        {

        }

        //Boton para recargar la lista del profesional
        private void btnRecargarProfesional_Click(object sender, EventArgs e)
        {
            grdListarProf.DataSource = proC.listarProfecional();

            List<Profesional> listaProf = new List<Profesional>();

           /* foreach (var pro in listaProf)
            {
                Profesional prof = new Profesional();
                //ListViewItem item = new ListViewItem(pro.idProfesional.ToString());
                prof.idProfesional = pro.idProfesional;
                prof.rutProfesional = pro.rutProfesional;
                prof.pnombre = pro.pnombre;
                prof.snombre = pro.snombre;
                prof.appaterno = pro.appaterno;
                prof.apmaterno = pro.appaterno;
                prof.telefono = pro.telefono;
                prof.direccion = pro.direccion;
                listaProf.Add(prof);
            }
            grdListarProf.DataSource = listaProf;*/
            grdListarProf.Columns["idProfesional"].Visible = false;
            //grdListarProf.Columns["rutProfesional"].Width = 80;
            grdListarProf.Columns["rutProfesional"].Width = 80;
            grdListarProf.Columns["pnombre"].Width = 80;
        }

        //boton de eliminar profesional con limpiar
        private void btnEliminarProfesional_Click(object sender, EventArgs e)
        {
            string email = txtEmailEditarP.Text;
            proC.Eliminar_profesional(email);
            MessageBox.Show(" Profesional Eliminado ", "Correcto");
            cargarGrdEditProfesional();
            limpiar();
        }

        /*private void btnguardarProfesional_Click(object sender, EventArgs e)
        {

        }

        private void btnDatosActividadProfesional_Click(object sender, EventArgs e)
        {

        }*/

        // boton de modificar profesional al ingresarcon una grilla que autocompleta los campos txt
        private void btnModificarProfesional_Click(object sender, EventArgs e)
        {
            try
            {
                string pass, pnombre, snombre, appaterno, apmaterno, direccion, rut, email;
                int telefono;

                email = txtEmailEditarP.Text;
                pass = txtContraseñaEditarP.Text;
                pnombre = txtPNombreEditarP.Text;
                snombre = txtSNombreEditarP.Text;
                appaterno = txtAPaternoEditarP.Text;
                apmaterno = txtApMaternoEditarP.Text;
                direccion = txtDireccionEditarP.Text;
                rut = txtRutEditarP.Text;
                telefono = 0;
                


                Regex rgLetras = new Regex(@"^[a-zA-Z]{3,10}$");
                Regex rgPnombre = new Regex(@"^\d{1,2}\.\d{3}\.\d{3}[-][0-9kK]{1}$");
                Regex rgSnombre = new Regex(@"^\d{1,2}\.\d{3}\.\d{3}[-][0-9kK]{1}$");
                Regex rgAppaterno = new Regex(@"^\d{1,2}\.\d{3}\.\d{3}[-][0-9kK]{1}$");
                Regex rgApmaterno = new Regex(@"^\d{1,2}\.\d{3}\.\d{3}[-][0-9kK]{1}$");
                Regex rgDireccion = new Regex(@"^\d{1,2}\.\d{3}\.\d{3}[-][0-9kK]{1}$");
                Regex rgRut = new Regex(@"^\d{1,2}\.\d{3}\.\d{3}[-][0-9kK]{1}$");
                Regex rgEmail = new Regex(@"^[^@]+@[^@]+\.[a-zA-Z]{2,}$");
                Regex rgTelefono = new Regex(@"^\d{1,2}\.\d{3}\.\d{3}[-][0-9kK]{1}$");
                Regex rgPass = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{6,}$");

                if (!rgLetras.IsMatch(pnombre))
                {
                    txtPNombreEditarP.WithError = true;
                    error.SetError(txtPNombreEditarP, "El primer nombre debe contener solo letras");
                    return;
                }
                else
                {
                    txtPNombreEditarP.WithError = false;
                    error.SetError(txtPNombreEditarP, "");
                }

                if (!rgLetras.IsMatch(snombre))
                {
                    txtSNombreEditarP.WithError = true;
                    error.SetError(txtSNombreEditarP, "El segundo nombre debe contener solo letras");
                    return;
                }
                else
                {
                    txtSNombreEditarP.WithError = false;
                    error.SetError(txtSNombreEditarP, "");
                }
                if (!rgLetras.IsMatch(appaterno))
                {
                    txtAPaternoEditarP.WithError = true;
                    error.SetError(txtAPaternoEditarP, "El apellido paterno debe contener solo letras");
                    return;
                }
                else
                {
                    txtAPaternoEditarP.WithError = false;
                    error.SetError(txtAPaternoEditarP, "");
                }
                if (!rgLetras.IsMatch(apmaterno))
                {
                    txtApMaternoEditarP.WithError = true;
                    error.SetError(txtApMaternoEditarP, "El apellido materno debe contener solo letras");
                    return;
                }
                else
                {
                    txtApMaternoEditarP.WithError = false;
                    error.SetError(txtApMaternoEditarP, "");
                }
                if (!rgRut.IsMatch(rut))
                {
                    txtRutEditarP.WithError = true;
                    error.SetError(txtRutEditarP, "Rut debe ser con punto y guion");
                    return;
                }
                else
                {
                    txtRutEditarP.WithError = false;
                    error.SetError(txtRutEditarP, "");
                }
                if (txtTelefonoEditarP.Text == "")
                {
                    error.SetError(txtTelefonoEditarP, "Debe ingresar un Telefono en numeros");
                    return;
                }
                else
                {
                    int resultado;
                    if (!int.TryParse(txtTelefonoEditarP.Text , out resultado))
                    {
                        error.SetError(txtTelefonoEditarP, "Solo se debe ingresar numeros");
                        return;
                    }else
                    {
                        telefono = Convert.ToInt32(txtTelefonoEditarP.Text);
                        txtTelefonoEditarP.WithError = false;
                        error.SetError(txtTelefonoEditarP, "");
                    }
                    
                }
                if (!rgEmail.IsMatch(email))
                {
                    txtEmailEditarP.WithError = true;
                    error.SetError(txtEmailEditarP, "Debe Ingresar un Email");
                    return;
                }
                else
                {
                    txtEmailEditarP.WithError = false;
                    error.SetError(txtEmailEditarP, "");
                }

                if (!rgPass.IsMatch(pass))
                {
                    txtContraseñaEditarP.WithError = true;
                    error.SetError(txtContraseñaEditarP, "Mínimo 6 caracteres al menos 1 alfabeto y 1 número");
                    return;
                }
                else
                {
                    txtContraseñaEditarP.WithError = false;
                    error.SetError(txtContraseñaEditarP, "");
                }
                int resul = proC.ModificarProfesional(email, pass, pnombre, snombre, appaterno, apmaterno, direccion, rut, telefono);
                if (resul > 0)
                {
                    MessageBox.Show(" Profesional modificado correctamente ", "Correcto");
                    cargarGrdEditProfesional(); // metodo para recargar la lista al modificar
                    limpiar();
                }
                else
                {
                    MessageBox.Show(" No se logro Modificar ", "Error");
                }
                return;

            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error al modificar " + ex);
            }
        }

        private void btnBuscarProfesionalEmail_Click(object sender, EventArgs e)
        {
            var list = proC.buscarProfesional(txtBuscador.Text.ToLower());
            List<Profesional> listaProf = new List<Profesional>();

            foreach (var pro in list)
            {
                Profesional prof = new Profesional();
                //ListViewItem item = new ListViewItem(pro.idProfesional.ToString());
                prof.idProfesional = pro.idProfesional;
                prof.rutProfesional = pro.rutProfesional;
                prof.pnombre = pro.pnombre;
                prof.snombre = pro.snombre;
                prof.appaterno = pro.appaterno;
                prof.apmaterno = pro.apmaterno;
                prof.direccion = pro.direccion;
                prof.telefono = pro.telefono;
                //prof.fechaNacimientoPro = pro.fechaNacimientoPro.ToString("dd/MM/yyyy");
                listaProf.Add(prof);
                limpiarBuscadorProfesional();
            }

            grdListarProf.DataSource = listaProf;
            grdListarProf.Columns["idProfesional"].Visible = false;
            grdListarProf.Columns["rutProfesional"].Width = 80;
            grdListarProf.Columns["pnombre"].Width = 80;
        }

        private void limpiarBuscadorProfesional()
        {
            txtBuscador.Text = "";
        }

        private void metroLabel25_Click(object sender, EventArgs e)
        {

        }
        //Metodo de grilla para autocompletar los campos 
        private void grdEditarProfe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int idProfesional = Convert.ToInt32(this.grdEditarProfe.Rows[e.RowIndex].Cells["idProfesional"].Value);
                txtPNombreEditarP.Text = this.grdEditarProfe.Rows[e.RowIndex].Cells["pnombre"].Value.ToString();
                txtSNombreEditarP.Text = this.grdEditarProfe.Rows[e.RowIndex].Cells["snombre"].Value.ToString();
                txtAPaternoEditarP.Text = this.grdEditarProfe.Rows[e.RowIndex].Cells["appaterno"].Value.ToString();
                txtApMaternoEditarP.Text = this.grdEditarProfe.Rows[e.RowIndex].Cells["apmaterno"].Value.ToString();
                txtRutEditarP.Text = this.grdEditarProfe.Rows[e.RowIndex].Cells["rutProfesional"].Value.ToString();
                txtTelefonoEditarP.Text = this.grdEditarProfe.Rows[e.RowIndex].Cells["telefono"].Value.ToString();
                txtDireccionEditarP.Text = this.grdEditarProfe.Rows[e.RowIndex].Cells["direccion"].Value.ToString();
                string sql = "SELECT EMAIL,PASSWORD FROM USUARIO us INNER JOIN PROFESIONAL PRO ON PRO.USUARIO = us.ID_USUARIO WHERE PRO.ID_PROFESIONAL =" + idProfesional;
                using (OracleDataReader dr = operaciones.sqlOperacion(sql))
                {
                    while (dr.Read())
                    {
                        txtEmailEditarP.Text = dr["email"].ToString();
                        txtContraseñaEditarP.Text = dr["password"].ToString();
                    }
                    operaciones.cerrarConexion();
                }
            }
        }

        private void cbMostrarContraProfesional_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMostrarContraProfesional.Checked == true)
            {
                if (txtContraseñaEditarP.PasswordChar == '*')
                {
                    txtContraseñaEditarP.PasswordChar = '\0';
                }
            }
            else
            {
                txtContraseñaEditarP.PasswordChar = '*';
            }
        }

        /*private void lblEmailProf_Click(object sender, EventArgs e)
        {

        }*/
    }

}
