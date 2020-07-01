using Capa_DAL.Conexion;
using Capa_DAL.Controlador;
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
    public partial class GestionCliente : MetroUserControl
    {
        ClienteControlador cliControlador = new ClienteControlador();
        SucursalControlador suControlador = new SucursalControlador();
        UsuarioControlador usuControlador = new UsuarioControlador();
        ContratoControlador contControlador = new ContratoControlador();
        ServicioControlador servControlador = new ServicioControlador();
        ErrorProvider error = new ErrorProvider();

        CL_Operaciones operaciones = new CL_Operaciones();
        public GestionCliente()
        {
            InitializeComponent();
            grdLstClientes.DataSource = cliControlador.listarCliente();
            cargarGrdCliente();
            //DataGrid para eliminar cli
            cargarGrdEditCliente();
        }
        //Metodo para cargar la grilla y poder listar los datos
        private void cargarGrdEditCliente()
        {
            grdEditCli.DataSource = cliControlador.listarClienteEditar();
        }
        private void cargarGrdCliente()
        {
            grdLstClientes.DataSource = cliControlador.listarCliente();
        }

        //boton modificar al apretar el la grilla se llenan los campos uno los modifica
        //apreta el boton de modificar para cambiar los datos
        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            string nomTitu = txtNomTiEdit.Text;
            string rutEmpresa = txtRutEmpEdit.Text;
            string nomEmp = txtNomEmpEdit.Text;
            string giro = txtGiroEdit.Text;
            string direccion = txtDirCliEdit.Text;
            //int tel = int.Parse(txtTelCliEdit.Text);
            string paginaWeb = txtPaginaEdit.Text;
            //string profAsignado = txtProfAsigEdit.Text;
            string email = txtEmailCliEdit.Text;
            string pass = txtPass.Text;
            int tel;
            tel = 0;

            Regex rgLetras = new Regex(@"^[a-zA-Z]{3,10}$");
            Regex rgTelefono = new Regex(@"^\d{1,2}\.\d{3}\.\d{3}[-][0-9kK]{1}$");
            Regex rgRutEmpresa = new Regex(@"^\d{1,2}\.\d{3}\.\d{3}[-][0-9kK]{1}$");
            Regex rgEmail = new Regex(@"^[^@]+@[^@]+\.[a-zA-Z]{2,}$");
            Regex rgPass = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{6,}$");

            if (!rgLetras.IsMatch(nomTitu))
            {
                txtNomTiEdit.WithError = true;
                error.SetError(txtNomTiEdit, "Nombre titular debe contener solo letras");
                return;
            }
            else
            {
                txtNomTiEdit.WithError = false;
                error.SetError(txtNomTiEdit, "");
            }
            if (!rgLetras.IsMatch(nomEmp))
            {
                txtNomEmpEdit.WithError = true;
                error.SetError(txtNomEmpEdit, "Nombre empresa debe contener solo letras");
                return;
            }
            else
            {
                txtNomEmpEdit.WithError = false;
                error.SetError(txtNomEmpEdit, "");
            }
            if (!rgRutEmpresa.IsMatch(rutEmpresa))
            {
                txtRutEmpEdit.WithError = true;
                error.SetError(txtRutEmpEdit, "Rut debe contener puntos y guion");
                return;
            }
            else
            {
                txtRutEmpEdit.WithError = false;
                error.SetError(txtRutEmpEdit, "");
            }
            if (!rgLetras.IsMatch(giro))
            {
                txtGiroEdit.WithError = true;
                error.SetError(txtGiroEdit, "Giro debe contener solo letras");
                return;
            }
            else
            {
                txtGiroEdit.WithError = false;
                error.SetError(txtGiroEdit, "");
            }
            if (txtTelCliEdit.Text == "")
            {
                error.SetError(txtTelCliEdit, "Debe ingresar un Telefono en numeros");
                return;
            }
            else
            {
                int resultado;
                if (!int.TryParse(txtTelCliEdit.Text, out resultado))
                {
                    error.SetError(txtTelCliEdit, "Solo se debe ingresar numeros");
                    return;
                }
                else
                {
                    tel = Convert.ToInt32(txtTelCliEdit.Text);
                    txtTelCliEdit.WithError = false;
                    error.SetError(txtTelCliEdit, "");
                }


            }
            if (!rgEmail.IsMatch(email))
            {
                txtEmailCliEdit.WithError = true;
                error.SetError(txtEmailCliEdit, "Debe Ingresar un Email");
                return;
            }
            else
            {
                txtEmailCliEdit.WithError = false;
                error.SetError(txtEmailCliEdit, "");
            }

            if (!rgPass.IsMatch(pass))
            {
                txtPass.WithError = true;
                error.SetError(txtPass, "Mínimo 6 caracteres al menos 1 alfabeto y 1 número");
                return;
            }
            else
            {
                txtPass.WithError = false;
                error.SetError(txtPass, "");
            }



            cliControlador.actualizar_cliente(email, pass, nomTitu, rutEmpresa, nomEmp, giro, direccion, tel, paginaWeb);

            MessageBox.Show("Cliente Modificado", "Correcto");
            cargarGrdEditCliente();
        }

        //Boton eliminar por email se usa la grilla para que agrege los datos a los campos y los elimine
        private void btnEliminarCli_Click(object sender, EventArgs e)
        {
            string email = txtEmailCliEdit.Text;
            cliControlador.eliminar_cliente(email);
            MessageBox.Show("Se elimino Cliente", "Correcto");
            cargarGrdEditCliente();
            limpiarEditarEliminarCli();
        }

        private void limpiarEditarEliminarCli()
        {
            txtNomEmpEdit.Text = "";
            txtNomEmpEdit.Text = "";
            txtRutEmpEdit.Text = "";
            txtGiroEdit.Text = "";
            txtDirCliEdit.Text = "";
            txtTelCliEdit.Text = "";
            txtPaginaEdit.Text = "";
            txtEmailCliEdit.Text = "";
            txtPass.Text = "";
        }



        private void btnRecargarCliente_Click(object sender, EventArgs e)
        {
            cargarGrdCliente();
        }

        private void grdEditCli_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int idCliente = Convert.ToInt32(this.grdEditCli.Rows[e.RowIndex].Cells["id_cliente"].Value);
                txtNomTiEdit.Text = this.grdEditCli.Rows[e.RowIndex].Cells["nombre_titular"].Value.ToString();
                txtNomEmpEdit.Text = this.grdEditCli.Rows[e.RowIndex].Cells["nombre_empresa"].Value.ToString();
                txtRutEmpEdit.Text = this.grdEditCli.Rows[e.RowIndex].Cells["rut_empresa"].Value.ToString();
                txtGiroEdit.Text = this.grdEditCli.Rows[e.RowIndex].Cells["giro"].Value.ToString();
                txtDirCliEdit.Text = this.grdEditCli.Rows[e.RowIndex].Cells["direccion"].Value.ToString();
                txtTelCliEdit.Text = this.grdEditCli.Rows[e.RowIndex].Cells["telefono"].Value.ToString();
                txtPaginaEdit.Text = this.grdEditCli.Rows[e.RowIndex].Cells["pagina_web"].Value.ToString();
                string sql = "SELECT EMAIL,PASSWORD FROM USUARIO us INNER JOIN CLIENTE cli ON cli.USUARIO = us.ID_USUARIO WHERE cli.ID_CLIENTE =" + idCliente;
                using (OracleDataReader dr = operaciones.sqlOperacion(sql))
                {
                    while (dr.Read())
                    {
                        txtEmailCliEdit.Text = dr["email"].ToString();
                        txtPass.Text = dr["password"].ToString();
                    }
                    operaciones.cerrarConexion();
                }
            }
        }
    }
}
