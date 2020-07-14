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
    
        public GestionarReportes()
        {
            InitializeComponent();
        }

        private void GestionarReportes_Load(object sender, EventArgs e)
        {

        }
    }
}
