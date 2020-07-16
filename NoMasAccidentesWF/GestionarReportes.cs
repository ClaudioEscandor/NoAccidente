using Capa_DAL.Conexion;
using Capa_DAL.Controlador;
using MetroFramework.Controls;
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
    public partial class GestionarReportes : MetroUserControl
    { 
        CL_Operaciones operaciones = new CL_Operaciones();
        ErrorProvider error = new ErrorProvider();

        ReporteControlador rc = new ReporteControlador();
        DetallePagoControlador dt = new DetallePagoControlador();
        AccidenteControlador ac = new AccidenteControlador();

        PDFControlador pdfC = new PDFControlador();
    
        public GestionarReportes()
        {
            InitializeComponent();
            cargarCantAccidente();
            pdfC.crearPdf();
        }

        private void GestionarReportes_Load(object sender, EventArgs e)
        {
            //Prueba comentario
            //Prueba comentario 2
        }

        private void btnListarPago_Click(object sender, EventArgs e)
        {
            grListarDetaPago.DataSource = dt.ListarPago();
        }

        public void cargarCantAccidente(){
            grdAccidente.DataSource = ac.listarCantidadAccidente();
        }
    }
}
