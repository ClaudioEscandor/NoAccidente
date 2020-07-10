using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using Capa_DAL.Controlador;

namespace NoMasAccidentesWF
{
    public partial class GestionarSolicitud : MetroUserControl
    {
        SolicitudControlador sc = new SolicitudControlador();
        ProfesionalControlador pc = new ProfesionalControlador();
        int idSolicitud = 0;
        int idProfesional = 0;
        public GestionarSolicitud()
        {
            InitializeComponent();
            cargarSolicitud();
            cargarProfesionales();
        }

        private void cargarProfesionales()
        {
            grdProfesional.DataSource = pc.listarProfecional();
        }

        private void cargarSolicitud()
        {
            grdSolicitud.DataSource = sc.listarSolicitud();
        }

        private void btnAñadirSolicitud_Click(object sender, EventArgs e)
        {
            sc.agregarSolicitud(idSolicitud, idProfesional);
            MessageBox.Show("Solicitud agregada correctamente", "Correcto");
        }

        private void grdSolicitud_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                idSolicitud = Convert.ToInt32(this.grdSolicitud.Rows[e.RowIndex].Cells["id_solicitud"].Value);  
            }
        }

        private void grdProfesional_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                idProfesional = Convert.ToInt32(this.grdProfesional.Rows[e.RowIndex].Cells["idProfesional"].Value);
            }
        }

        private void btnRecargarListado_Click(object sender, EventArgs e)
        {
            cargarSolicitud();
            cargarProfesionales();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
