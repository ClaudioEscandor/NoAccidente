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
        int idPago = 0;
    
        public GestionarReportes()
        {
            InitializeComponent();
            cargarCantAccidente();
            
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

        private void btnPDF_Click(object sender, EventArgs e)
        {
            if (idPago > 0 )
            {
                pdfC.crearPdf(idPago);
                MessageBox.Show("Se creo el pdf en el escritorio", "Correcto");
            }else
            {
                MessageBox.Show("Debe seleccionar un pago", "Error");
            }
            
        }

        private void grListarDetaPago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                idPago = Convert.ToInt32(this.grListarDetaPago.Rows[e.RowIndex].Cells["id_pago"].Value);
            }
        }
    }
}
