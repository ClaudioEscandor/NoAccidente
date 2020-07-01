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
    public partial class MenuPrincipal : MetroForm
    {
        GestionCliente GC = new GestionCliente();
        GestionarProfesional GP = new GestionarProfesional();
        GestionarUsuarios GU = new GestionarUsuarios();
        GestionarContratos GContra = new GestionarContratos();

        public MenuPrincipal()
        {
            
            InitializeComponent();
            Personalizar();
            
        }
        // Personalizacion de submenu desplegable
        private void Personalizar()
        {
            panelSubMenuProfesional.Visible = false;
            PanelSubMenuGestionarUsuario.Visible = false;
            PanelSubMenuGestionarClientes.Visible = false;
            PanelSubMenuGestionarContratos.Visible = false;
        }
        // Aca se hace visible los botones del menu
        private void OcultarMenu()
        {
            if (panelSubMenuProfesional.Visible == true)
                panelSubMenuProfesional.Visible = false;
            if (PanelSubMenuGestionarUsuario.Visible == true)
                PanelSubMenuGestionarUsuario.Visible = false;
            if (PanelSubMenuGestionarClientes.Visible == true)
                PanelSubMenuGestionarClientes.Visible = false;
            if (PanelSubMenuGestionarContratos.Visible == true)
                PanelSubMenuGestionarContratos.Visible = false;
        }

        private void MostrarSubmenu(Panel SubMenu)
        {
            if(SubMenu.Visible == false)
            {
                OcultarMenu();
                SubMenu.Visible = true;
            }else
            {
                SubMenu.Visible = false;
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
        private void btnGestionarProfesionales_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelSubMenuProfesional);
            

            GP.Dock = DockStyle.Fill;
            PanelDePestañas.Controls.Clear();
            PanelDePestañas.Controls.Add(GP);
            GP.Show();

        }

        private void btnAgregarProfesional_Click(object sender, EventArgs e)
        {
            //Codigo del boton
            GP.MetroTabGestionProfesional.SelectedTab = GP.tpEditarProf;
            OcultarMenu();
        }

        private void btnListarProfesionales_Click(object sender, EventArgs e)
        {
            //Codigo del boton
            GP.MetroTabGestionProfesional.SelectedTab = GP.tpListarProf;
            OcultarMenu();
        }

        private void btnBuscarProfesional_Click(object sender, EventArgs e)
        {
            //Codigo del boton
            GP.MetroTabGestionProfesional.SelectedTab = GP.tpActividadProf;
            OcultarMenu();
        }

        private void btnGestionarUsuarios_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(PanelSubMenuGestionarUsuario);
            

            GU.Dock = DockStyle.Fill;
            PanelDePestañas.Controls.Clear();
            PanelDePestañas.Controls.Add(GU);
            GU.Show();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            GU.tcUsuario.SelectedTab = GU.tpAñadirUsuario;
            //Codigo del boton
            OcultarMenu();
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            //Codigo del boton
            GU.tcUsuario.SelectedTab = GU.tpEditarUsuario;
            OcultarMenu();
        }

        private void btnGestionarClientes_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(PanelSubMenuGestionarClientes);
            //GestionCliente GC = new GestionCliente();

            GC.Dock = DockStyle.Fill;
            PanelDePestañas.Controls.Clear();
            PanelDePestañas.Controls.Add(GC);
            GC.Show();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            //Codigo del boton
            OcultarMenu();
        }

        private void btnListarCliente_Click(object sender, EventArgs e)
        {
            //Codigo del boton
            
            GC.tcGestionCli.SelectedTab = GC.tpLstCliente;
            OcultarMenu();
        }

        private void btnModificarCLiente_Click(object sender, EventArgs e)
        {
            //Codigo del boton
            GC.tcGestionCli.SelectedTab = GC.tpEditarCli;
            OcultarMenu();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            //Codigo del boton
            OcultarMenu();
        }

        private void btnGestionarContratos_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(PanelSubMenuGestionarContratos);

            GContra.Dock = DockStyle.Fill;
            PanelDePestañas.Controls.Clear();
            PanelDePestañas.Controls.Add(GContra);
            GContra.Show();
        }

        private void btnModificarContratos_Click(object sender, EventArgs e)
        {
            //Codigo del boton
            GContra.tcContratos.SelectedTab = GContra.tpEditarContrato;
            OcultarMenu();
        }

        private void btnListarContratos_Click(object sender, EventArgs e)
        {
            //Codigo del boton
            GContra.tcContratos.SelectedTab = GContra.tpLstContrato;
            OcultarMenu();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se a cerrado su sesion correctamente", "Termino");
            this.Close();
        }

        private void btnListarUsuarios_Click(object sender, EventArgs e)
        {
            //Codigo del boton
            GU.tcUsuario.SelectedTab = GU.tpListarUsuario;
            OcultarMenu();
        }

        private void btnDetPago_Click(object sender, EventArgs e)
        {
            GC.tcGestionCli.SelectedTab = GC.tpDetPago;
            OcultarMenu();
        }
    }
}
