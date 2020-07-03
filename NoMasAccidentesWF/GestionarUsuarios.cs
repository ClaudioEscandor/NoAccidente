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
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoMasAccidentesWF
{
    public partial class GestionarUsuarios : MetroUserControl
    {
        ErrorProvider error = new ErrorProvider();
        CL_Operaciones operaciones = new CL_Operaciones();

        UsuarioControlador UsuC = new UsuarioControlador();
        ProfesionalControlador proC = new ProfesionalControlador();

        ClienteControlador cliControlador = new ClienteControlador();
        ContratoControlador contControlador = new ContratoControlador();
        ServicioControlador servControlador = new ServicioControlador();
        SucursalControlador suControlador = new SucursalControlador();

        public GestionarUsuarios()
        {
            InitializeComponent();
            tcUsuario.SelectedTab = tpAñadirUsuario;
            cargarCBOusuario();
            CargarCBOeditarUsuario();

            //Cliente
            cargarCboPais();
            cargarCboTipoContrato();
        }

        private void cargarCboComuna(int idRegion)
        {
            using (OracleDataReader dr = operaciones.sqlOperacion("SELECT ID_COMUNA, NOMBRE_COMUNA FROM COMUNA WHERE REGION=" + idRegion))
            {
                while (dr.Read())
                {
                    cboComuna.Items.Add(new { id = dr["ID_COMUNA"].ToString(), nombre_comuna = dr["NOMBRE_COMUNA"].ToString() });
                    //cboTipoContrato.Items.Add(dr["NOMBRE_TIPO"].ToString());
                }

                cboComuna.DisplayMember = "nombre_comuna";
                cboComuna.ValueMember = "id";
                operaciones.cerrarConexion();
            }

        }

        private void cargarCboRegion(int idPais)
        {
            using (OracleDataReader dr = operaciones.sqlOperacion("SELECT ID_REGION, NOMBRE_REGION FROM REGION WHERE PAIS=" + idPais))
            {
                while (dr.Read())
                {
                    cboRegion.Items.Add(new { id = dr["ID_REGION"].ToString(), nombre_region = dr["NOMBRE_REGION"].ToString() });
                    //cboTipoContrato.Items.Add(dr["NOMBRE_TIPO"].ToString());
                }

                cboRegion.DisplayMember = "nombre_region";
                cboRegion.ValueMember = "id";
                operaciones.cerrarConexion();
            }
        }

        private void cargarCboPais()
        {
            using (OracleDataReader dr = operaciones.sqlOperacion("SELECT ID_PAIS, NOMBRE_PAIS FROM PAIS"))
            {
                while (dr.Read())
                {
                    cboPais.Items.Add(new { id = dr["ID_PAIS"].ToString(), nombre_pais = dr["NOMBRE_PAIS"].ToString() });
                    //cboTipoContrato.Items.Add(dr["NOMBRE_TIPO"].ToString());
                }

                cboPais.DisplayMember = "nombre_pais";
                cboPais.ValueMember = "id";
                operaciones.cerrarConexion();

            }
        }

        private void cargarCboTipoContrato()
        {
            using (OracleDataReader dr = operaciones.sqlOperacion("SELECT ID_TIPO_CONTRATO,NOMBRE_TIPO FROM TIPO_CONTRATO"))
            {
                while (dr.Read())
                {
                    cboTipoContrato.Items.Add(new { id = dr["ID_TIPO_CONTRATO"].ToString(), desc = dr["NOMBRE_TIPO"].ToString() });
                    //cboTipoContrato.Items.Add(dr["NOMBRE_TIPO"].ToString());
                }

                cboTipoContrato.DisplayMember = "desc";
                cboTipoContrato.ValueMember = "id";
                operaciones.cerrarConexion();
            }
        }

        private void cargarCBOusuario()
        {
            using (OracleDataReader dr = operaciones.sqlOperacion("SELECT ID_TIPO_USUARIO, DESCRIPCION FROM TIPO_USUARIO"))
            {
                while (dr.Read())
                {
                    cboTipoUsu.Items.Add(new { id = dr["ID_TIPO_USUARIO"].ToString(), desc = dr["DESCRIPCION"].ToString() });
                    //cboTipoContrato.Items.Add(dr["NOMBRE_TIPO"].ToString());
                }

                cboTipoUsu.DisplayMember = "desc";
                cboTipoUsu.ValueMember = "id";
                operaciones.cerrarConexion();
            }
           
        }
        private void limpiarAgregarUsu()
        {
            txtEmailUsu.Text = "";
            txtPassUsu.Text = "";
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                string email, password;
                password = txtPassUsu.Text;
                email = txtEmailUsu.Text;

                Regex rgEmail = new Regex(@"^[^@]+@[^@]+\.[a-zA-Z]{2,}$");
                Regex rgPass = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{6,}$");

                if (!rgEmail.IsMatch(email))
                {
                    txtEmailUsu.WithError = true;
                    error.SetError(txtEmailUsu, "Debe Ingresar un Correo");
                    return;
                }
                else
                {
                    txtEmailUsu.WithError = false;
                    error.SetError(txtEmailUsu, "");
                }

                if (!rgPass.IsMatch(password))
                {
                    txtPassUsu.WithError = true;
                    error.SetError(txtPassUsu, "Mínimo 6 caracteres al menos 1 alfabeto y 1 número");
                    return;
                }
                else
                {
                    txtPassUsu.WithError = false;
                    error.SetError(txtPassUsu, "");
                }

                var tipo_usuario = cboTipoUsu.SelectedItem as object;
                int id_tipo_usuario = int.Parse(tipo_usuario.GetType().GetProperty("id").GetValue(tipo_usuario, null).ToString());

                if (id_tipo_usuario == 1)
                {
                    agregarUsuario();
                }
                if (id_tipo_usuario==2)
                {
                    tcUsuario.SelectedTab = tpAddProf;
                }
                if (id_tipo_usuario==3)
                {
                    tcUsuario.SelectedTab = tpAddCli;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dejo de funcionar en usuario" + ex);
            }
        }

        private void agregarUsuario()
        {
            try
            {

                string email, password;


                email = txtEmailUsu.Text;
                password = txtPassUsu.Text;
                var tipo_usuario = cboTipoUsu.SelectedItem as object;
                int id_tipo_usuario = int.Parse(tipo_usuario.GetType().GetProperty("id").GetValue(tipo_usuario, null).ToString());
                Regex rgPass = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{6,}$");

                if (!rgPass.IsMatch(password))
                {
                    txtPassUsu.WithError = true;
                    error.SetError(txtPassUsu, "Mínimo 6 caracteres al menos 1 alfabeto y 1 número");
                    return;
                }
                else
                {
                    txtPassUsu.WithError = false;
                    error.SetError(txtPassUsu, "");
                }

                int resul = UsuC.InsertarUsuario(id_tipo_usuario, email, password);
                if (resul > 0)
                {
                    MessageBox.Show("Usuario guardado correctamente", "Correcto");
                    limpiarUsuario();
                }
                else
                {
                    MessageBox.Show("No se logro guardar el usuario", "Error");
                }


                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Al Agregar " + ex);
            }
        }

       private void limpiarUsuario()
        {
            txtEmailUsu.Text = "";
            txtPassUsu.Text = "";
        }

        private void btnBuscarEmailUsu_Click(object sender, EventArgs e)
        {
            var list = UsuC.buscarUsuario(txtBuscarEmail.Text.ToLower());
            List<Usuario> listaUsu = new List<Usuario>();

            foreach (var pro in list)
            {
                Usuario item = new Usuario();
                item.email = pro.email;
                item.password = pro.password;
                item.tipo_usuario = pro.tipo_usuario;
                item.estado = pro.estado;

                listaUsu.Add(item);
                limpiarBuscadorUsuario();
            }

            grdListarUsuario.DataSource = listaUsu;
            grdListarUsuario.Columns["idUsuario"].Visible = false;
            grdListarUsuario.Columns["email"].Width = 200;
            grdListarUsuario.Columns["password"].Width = 80;
        }
        private void limpiarBuscadorUsuario()
        {
            txtBuscarEmail.Text = "";
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void lblPass_Click(object sender, EventArgs e)
        {

        }

        private void lblEmailProf_Click(object sender, EventArgs e)
        {

        }

        private void btnRecargarProfesional_Click(object sender, EventArgs e)
        {

        }

        private void btnAñadirProfesional_Click(object sender, EventArgs e)
        {

        }

        private void btnAñadirProfesional_Click_1(object sender, EventArgs e)
        {
            try
            {
                string pass, pnombre, snombre, appaterno, apmaterno, direccion, rut, email;
                int telefono;


                email = txtEmailUsu.Text;
                pass = txtPassUsu.Text;
                pnombre = txtPnombreProf.Text;
                snombre = txtSnombreProf.Text;
                appaterno = txtApellidoPProf.Text;
                apmaterno = txtApellidoMProf.Text;
                direccion = txtDireccionProf.Text;
                rut = txtRutProfesional.Text;
                //email = txtEmailProf.Text;
                telefono = 0;

                Regex rgLetras = new Regex(@"^[a-zA-Z]{3,10}$");
                Regex rgPnombre = new Regex(@"^\d{1,2}\.\d{3}\.\d{3}[-][0-9kK]{1}$");
                Regex rgSnombre = new Regex(@"^\d{1,2}\.\d{3}\.\d{3}[-][0-9kK]{1}$");
                Regex rgAppaterno = new Regex(@"^\d{1,2}\.\d{3}\.\d{3}[-][0-9kK]{1}$");
                Regex rgApmaterno = new Regex(@"^\d{1,2}\.\d{3}\.\d{3}[-][0-9kK]{1}$");
                Regex rgDireccion = new Regex(@"^\d{1,2}\.\d{3}\.\d{3}[-][0-9kK]{1}$");
                Regex rgRut = new Regex(@"^\d{1,2}\.\d{3}\.\d{3}[-][0-9kK]{1}$");
                Regex rgPass = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{6,}$");
                Regex rgTelefono = new Regex(@"^\d{1,2}\.\d{3}\.\d{3}[-][0-9kK]{1}$");

                if (!rgLetras.IsMatch(pnombre))
                {
                    txtPnombreProf.WithError = true;
                    error.SetError(txtPnombreProf, "El primer nombre debe contener solo letras");
                    return;
                }
                else
                {
                    txtPnombreProf.WithError = false;
                    error.SetError(txtPnombreProf, "");
                }

                if (!rgLetras.IsMatch(snombre))
                {
                    txtSnombreProf.WithError = true;
                    error.SetError(txtSnombreProf, "El segundo nombre debe contener solo letras");
                    return;
                }
                else
                {
                    txtSnombreProf.WithError = false;
                    error.SetError(txtSnombreProf, "");
                }
                if (!rgLetras.IsMatch(appaterno))
                {
                    txtApellidoPProf.WithError = true;
                    error.SetError(txtApellidoPProf, "El apellido paterno debe contener solo letras");
                    return;
                }
                else
                {
                    txtApellidoPProf.WithError = false;
                    error.SetError(txtApellidoPProf, "");
                }
                if (!rgLetras.IsMatch(apmaterno))
                {
                    txtApellidoMProf.WithError = true;
                    error.SetError(txtApellidoMProf, "El apellido materno debe contener solo letras");
                    return;
                }
                else
                {
                    txtApellidoMProf.WithError = false;
                    error.SetError(txtApellidoMProf, "");
                }
                if (!rgRut.IsMatch(rut))
                {
                    txtRutProfesional.WithError = true;
                    error.SetError(txtRutProfesional, "Rut debe ser con punto y guion");
                    return;
                }
                else
                {
                    txtRutProfesional.WithError = false;
                    error.SetError(txtRutProfesional, "");
                }
                if (txtFono.Text == "")
                {
                    error.SetError(txtFono, "Debe ingresar un telefono");
                    return;
                }
                else
                {
                    int result;
                    if(!int.TryParse(txtFono.Text , out result))
                    {
                        error.SetError(txtFono, "Debe ingresar un Telefono en numeros");
                        return;
                    }
                    else
                    {
                        telefono = Convert.ToInt32(txtFono.Text);
                        txtFono.WithError = false;
                        error.SetError(txtFono, "");
                    }
                }
                int resul = proC.InsertarProfesional(email, pass, pnombre, snombre, appaterno, apmaterno, direccion, rut, telefono);
                if (resul > 0)
                {
                    MessageBox.Show(" Profesional agregado correctamente ", "Correcto");
                    limpiarProfesional();
                    limpiarAgregarUsu();
                }
                else
                {
                    MessageBox.Show(" Error Al Guardar ", "Error");
                }
                return;
            }
            catch (Exception ex)
            {

                MessageBox.Show(" Error Al Agregar " + ex);
            }
        }
        private void limpiarProfesional()
        {
            txtPnombreProf.Text = "";
            txtSnombreProf.Text = "";
            txtApellidoPProf.Text = "";
            txtApellidoMProf.Text = "";
            txtDireccionProf.Text = "";
            txtRutProfesional.Text = "";
            txtFono.Text = "";
        }

        private void btnAñadirCliente_Click(object sender, EventArgs e)
        {
            tcUsuario.SelectedTab = tpAddContrato;  
        }

        public void agregarCliente()
        {
            string nomTitu = txtNomTitu.Text;
            string rutEmpresa = txtRutEmp.Text;
            string nomEmp = txtNomEmp.Text;
            string giro = txtGiro.Text;
            string direccion = txtDireccion.Text;
            int tel = int.Parse(txtTelCli.Text);
            string email = txtEmailUsu.Text;
            string pass = txtPassUsu.Text;
            string paginaWeb = txtPaginaWeb.Text;
            
            if (txtTelCli.Text == "")
            {
                error.SetError(txtTelCli, "Debe ingresar un Telefono en numeros");

            }
            else
            {
                tel = Convert.ToInt32(txtTelCli.Text);
            }

            Regex rgLetras = new Regex(@"^[a-zA-Z]{3,10}$");
            //Regex rgTelefono = new Regex(@"^\d{1,2}\.\d{3}\.\d{3}[-][0-9kK]{1}$");
            Regex rgRut = new Regex(@"^\d{1,2}\.\d{3}\.\d{3}[-][0-9kK]{1}$");


            if (!rgLetras.IsMatch(nomTitu))
            {
                txtNomTitu.WithError = true;
                error.SetError(txtNomTitu, "Debe contener solo letras");

            }
            else
            {
                txtNomTitu.WithError = false;
                error.SetError(txtNomTitu, "");
            }
            if (!rgRut.IsMatch(rutEmpresa))
            {
                txtRutEmp.WithError = true;
                error.SetError(txtRutEmp, "Rut debe contener punto y guion");

            }
            else
            {
                txtRutEmp.WithError = false;
                error.SetError(txtRutEmp, "");
            }

            if (!rgLetras.IsMatch(nomEmp))
            {
                txtNomEmp.WithError = true;
                error.SetError(txtNomEmp, "Debe contener solo letras");

            }
            else
            {
                txtNomEmp.WithError = false;
                error.SetError(txtNomEmp, "");
            }

            if (!rgLetras.IsMatch(giro))
            {
                txtGiro.WithError = true;
                error.SetError(txtGiro, "Debe contener solo letras");

            }
            else
            {
                txtGiro.WithError = false;
                error.SetError(txtGiro, "");
            }
            
            cliControlador.insertar_cliente(nomTitu, rutEmpresa, nomEmp, giro, direccion, tel, email, pass, paginaWeb);

            MessageBox.Show("Cliente Agregado", "Correcto");
            limpiarAgregarUsu();
        }

        private void CargarCBOeditarUsuario()
        {
            using (OracleDataReader dr = operaciones.sqlOperacion("SELECT ID_TIPO_USUARIO, DESCRIPCION FROM TIPO_USUARIO"))
            {
                while (dr.Read())
                {
                    cboUsuarioEditar.Items.Add(new { id = dr["ID_TIPO_USUARIO"].ToString(), desc = dr["DESCRIPCION"].ToString() });
                    //cboTipoContrato.Items.Add(dr["NOMBRE_TIPO"].ToString());
                }

                cboUsuarioEditar.DisplayMember = "desc";
                cboUsuarioEditar.ValueMember = "id";
                operaciones.cerrarConexion();
            }

        }

        private void btnGuardarUsuEditado_Click(object sender, EventArgs e)
        {
            try
            {
                string email, password;
                email = txtEditarEmail.Text;
                password = txtContraseñaEditar.Text;
                var tipo_usuario = cboUsuarioEditar.SelectedItem as object;
                int id_tipo_usuario = int.Parse(tipo_usuario.GetType().GetProperty("id").GetValue(tipo_usuario, null).ToString());

                Regex rgContra = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{6,}$");
                Regex rgEmail = new Regex(@"^[^@]+@[^@]+\.[a-zA-Z]{2,}$");

                if (!rgEmail.IsMatch(email))
                {
                    txtEditarEmail.WithError = true;
                    error.SetError(txtEditarEmail, "Debe ingresar un correo");
                    return;
                }
                else
                {
                    txtEditarEmail.WithError = false;
                    error.SetError(txtEditarEmail, "");
                }
                if (!rgContra.IsMatch(password))
                {
                    txtContraseñaEditar.WithError = true;
                    error.SetError(txtContraseñaEditar, "Mínimo 6 caracteres al menos 1 alfabeto y 1 número");
                    return;
                }
                else
                {
                    txtContraseñaEditar.WithError = false;
                    error.SetError(txtContraseñaEditar, "");
                }
                

                int resul = UsuC.ModificarUsuario(id_tipo_usuario, email, password);
                if (resul > 0)
                {
                    MessageBox.Show("Usuario Modificado Correctamente", "Correcto");
                    limpiarEdiProf();
                }
                else
                {
                    MessageBox.Show("No se logro Modificar el usuario", "Error");
                }


                return;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error Al Modificar " + ex);
            }

        }
        private void limpiarEdiProf()
        {
            txtEditarEmail.Text = "";
            txtContraseñaEditar.Text = "";
        }
        private void btnListarUsuario_Click(object sender, EventArgs e)
        {
            grdListarUsuario.DataSource = UsuC.listarUsuario();
        }

        private void btnAñadirCliente_Click_1(object sender, EventArgs e)
        {
            Regex rgLetras = new Regex(@"^[a-zA-Z]{3,10}$");
            Regex rgTelefono = new Regex(@"^\d{1,2}\.\d{3}\.\d{3}[-][0-9kK]{1}$");
            Regex rgRut = new Regex(@"^\d{1,2}\.\d{3}\.\d{3}[-][0-9kK]{1}$");


            if (!rgLetras.IsMatch(txtNomTitu.Text))
            {
                txtNomTitu.WithError = true;
                error.SetError(txtNomTitu, "Debe contener solo letras");
                return;
            }
            else
            {
                txtNomTitu.WithError = false;
                error.SetError(txtNomTitu, "");
            }
            if (!rgLetras.IsMatch(txtNomEmp.Text))
            {
                txtNomEmp.WithError = true;
                error.SetError(txtNomEmp, "Debe contener solo letras");
                return;
            }
            else
            {
                txtNomEmp.WithError = false;
                error.SetError(txtNomEmp, "");
            }

            if (!rgRut.IsMatch(txtRutEmp.Text))
            {
                txtRutEmp.WithError = true;
                error.SetError(txtRutEmp, "Rut debe contener punto y guion");
                return;
            }
            else
            {
                txtRutEmp.WithError = false;
                error.SetError(txtRutEmp, "");
            }

            if (!rgLetras.IsMatch(txtGiro.Text))
            {
                txtGiro.WithError = true;
                error.SetError(txtGiro, "Debe contener solo letras");
                return;
            }
            else
            {
                txtGiro.WithError = false;
                error.SetError(txtGiro, "");
            }
            if (txtTelCli.Text == "")
            {
                error.SetError(txtTelCli, "Debe ingresar un telefono en numeros");
                return;
            }
            else
            {
                txtTelCli.WithError = false;
                error.SetError(txtTelCli, "");
            }

            if (!rgLetras.IsMatch(txtSucursal.Text))
            {
                txtSucursal.WithError = true;
                error.SetError(txtSucursal, "Debe contener solo letras");
                return;
            }
            else
            {
                txtSucursal.WithError = false;
                error.SetError(txtSucursal, "");
            }
            if (!rgLetras.IsMatch(txtNomContacto.Text))
            {
                txtNomContacto.WithError = true;
                error.SetError(txtNomContacto, "Contacto Debe contener solo letras");
                return;
            }
            else
            {
                txtNomContacto.WithError = false;
                error.SetError(txtNomContacto, "");
            }

            tcUsuario.SelectedTab = tpAddContrato;
        }

        //Formulario para guardar los datos del cliente
        private int guardarCliente()
        {
            string nomTitu = txtNomTitu.Text;
            string rutEmpresa = txtRutEmp.Text;
            string nomEmp = txtNomEmp.Text;
            string giro = txtGiro.Text;
            string direccion = txtDireccion.Text;
            int tel = int.Parse(txtTelCli.Text);
            string email = txtEmailUsu.Text;
            string pass = txtPassUsu.Text;
            string paginaWeb = txtPaginaWeb.Text;

            

            int id_cliente = cliControlador.insertar_cliente(nomTitu, rutEmpresa, nomEmp, giro, direccion, tel, email, pass, paginaWeb);
            string sucursal = txtSucursal.Text;
            string nombre_contacto = txtNomContacto.Text;

            var comuna = cboComuna.SelectedItem as object;
            int id_comuna = int.Parse(comuna.GetType().GetProperty("id").GetValue(comuna, null).ToString());
            suControlador.insertarSucursal(sucursal, direccion, nombre_contacto, id_comuna, id_cliente);

            //MessageBox.Show("Cliente Agregado");
            return id_cliente;
        }

        //formulario de contrato para guardar los datos del contrato
        private void btnAddContrato_Click(object sender, EventArgs e)
        {
            var tipo_contrato = cboTipoContrato.SelectedItem as object;
            int id_tipo_contrato = int.Parse(tipo_contrato.GetType().GetProperty("id").GetValue(tipo_contrato, null).ToString());
            //var tipo_servicio = cboTipoServicio.SelectedItem as object;
            //int id_tipo_servicio = int.Parse(tipo_servicio.GetType().GetProperty("id").GetValue(tipo_servicio, null).ToString());

            DateTime fecExpiracion = dtFecExpiracion.Value;

            string det_contrato = txtDetContrato.Text;

            Regex rgLetras = new Regex(@"^[a-zA-Z]{3,10}$");

            if (txtDetContrato.Text == "")
            {
                txtDetContrato.WithError = true;
                error.SetError(txtDetContrato, "Debe ingresar un detalle del contrato");
                return;
            }
            else
            {
                txtDetContrato.WithError = false;
                error.SetError(txtDetContrato, "");
            }
            int idCliente = guardarCliente();

            int idContrato = contControlador.insertarContrato(fecExpiracion, det_contrato, id_tipo_contrato);

           // MessageBox.Show("Contrato Creado");

            List<int> lst_tipo_servicios = new List<int>();
            if (chkSeguridad.Checked)
            {
                lst_tipo_servicios.Add(1);
            }
            if (chkAsesoria.Checked)
            {
                lst_tipo_servicios.Add(2);
            }
            if (chkMantencion.Checked)
            {
                lst_tipo_servicios.Add(3);
            }

            List<int> id_servicios = new List<int>();
            foreach (int serv in lst_tipo_servicios)
            {
                string tp_serv = "";
                switch (serv)
                {
                    case 1:
                        tp_serv = "Seguridad";
                        break;
                    case 2:
                        tp_serv = "Asesoria";
                        break;
                    case 3:
                        tp_serv = "Mantencion";
                        break;
                }
                int idServicio = servControlador.insertarServicio(tp_serv, fecExpiracion, serv, idContrato);
                servControlador.insertar_detalle_servicio(idCliente, idServicio);

            }


            MessageBox.Show("Se Completo el proceso Correctamente", "Finalizado");
        }

        //recoge de la bd un pais y se muestra mediante un combobox
        private void cboPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pais = cboPais.SelectedItem as object;
            int id_pais = int.Parse(pais.GetType().GetProperty("id").GetValue(pais, null).ToString());
            if (id_pais > 0)
            {
                cargarCboRegion(id_pais);
            }
        }

        //Trae de la bd una region y la muestra en el combobox
        private void cboRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            var region = cboRegion.SelectedItem as object;
            int id_region = int.Parse(region.GetType().GetProperty("id").GetValue(region, null).ToString());
            if (id_region > 0)
            {
                cargarCboComuna(id_region);
            }
        }

        private void grdProfesionales_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}