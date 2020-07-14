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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoMasAccidentesWF
{
    public partial class GestionarContratos : MetroUserControl
    {

        ContratoControlador contratoControlador = new ContratoControlador();
        CL_Operaciones operaciones = new CL_Operaciones();

        private int idContrato=0;

        public GestionarContratos()
        {
            InitializeComponent();
            cargarGrdContrato();

        }

        private void cargarGrdContrato()
        {
            grdLstContratos.DataSource = contratoControlador.listarContratos();
        }

        private void btnAceptarContrato_Click(object sender, EventArgs e)
        {
            if (idContrato > 0)
            {
                int resp = contratoControlador.aceptarContrato(idContrato);
                if (resp>0)
                {
                    MessageBox.Show("Contrato Aceptado");
                }else
                {
                    MessageBox.Show("Fallo al Ingresar Contrato");
                }
            }

            cargarGrdContrato();
        }

        private void grdLstContratos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                idContrato = Convert.ToInt32(this.grdLstContratos.Rows[e.RowIndex].Cells["id_contrato"].Value);
            }
        }


        //private void btnEditContrato_Click(object sender, EventArgs e)
        //{
        //    //contratoControlador
        //    int tipoContrato = int.Parse(cboTipoContrEdit.SelectedValue.ToString());
        //    string detContrato = txtDetContrEdit.Text;
        //    DateTime fecExpiracion = dpFecExpiracion.Value;

        //   // contratoControlador.actualizarContrato(idContrato, fecExpiracion, detContrato, tipoContrato);
        //    List<int> lst_tipo_servicios = new List<int>();
        //    if (chkSeguridad.Checked)
        //    {
        //        lst_tipo_servicios.Add(1);
        //    }
        //    if (chkAsesoria.Checked)
        //    {
        //        lst_tipo_servicios.Add(2);
        //    }
        //    if (chkMantencion.Checked)
        //    {
        //        lst_tipo_servicios.Add(3);
        //    }
        //    servControlador.eliminar_servicio_contrato(idContrato);

        //    List<int> id_servicios = new List<int>();
        //    foreach (int serv in lst_tipo_servicios)
        //    {
        //        string tp_serv = "";
        //        switch (serv)
        //        {
        //            case 1:
        //                tp_serv = "Seguridad";
        //                break;
        //            case 2:
        //                tp_serv = "Asesoria";
        //                break;
        //            case 3:
        //                tp_serv = "Mantencion";
        //                break;
        //        }
        //        int idServicio = servControlador.insertarServicio(tp_serv, fecExpiracion, serv, idContrato);
        //        servControlador.insertar_detalle_servicio(idCliente, idServicio);
        //    }
        //    MessageBox.Show("Contrato Editado con Exito", "Correcto");
        //    cargarGrdContrato();
        //}

        //private void cargarCboTipoContrato()
        //{
        //    List<Object> listaContratos = new List<object>();
        //    using (OracleDataReader dr = operaciones.sqlOperacion("SELECT ID_TIPO_CONTRATO,NOMBRE_TIPO FROM TIPO_CONTRATO"))
        //    {
        //        while (dr.Read())
        //        {
        //            listaContratos.Add(new { id = dr["ID_TIPO_CONTRATO"].ToString(), desc = dr["NOMBRE_TIPO"].ToString() });

        //            //cboTipoContrEdit.Items.Add(new { id = dr["ID_TIPO_CONTRATO"].ToString(), desc = dr["NOMBRE_TIPO"].ToString() });             
        //        }
        //        operaciones.cerrarConexion();

        //        cboTipoContrEdit.DataSource = listaContratos;
        //        cboTipoContrEdit.DisplayMember = "desc";
        //        cboTipoContrEdit.ValueMember = "id";


        //    }
        //}

        //private void grdEditContrato_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
        //    {
        //        idCliente = Convert.ToInt32(this.grdEditContrato.Rows[e.RowIndex].Cells["id_cliente"].Value);
        //        idContrato = Convert.ToInt32(this.grdEditContrato.Rows[e.RowIndex].Cells["id_contrato"].Value);
        //        string[] servicios = this.grdEditContrato.Rows[e.RowIndex].Cells["servicios"].Value.ToString().Split(',');
        //        DateTime fecExpiracion = Convert.ToDateTime(this.grdEditContrato.Rows[e.RowIndex].Cells["fecha_expiracion"].Value);
        //        dpFecExpiracion.Value = fecExpiracion;
        //        string tipo_contrato = this.grdEditContrato.Rows[e.RowIndex].Cells["tipo_contrato"].Value.ToString();
        //        string detalle_contrato = this.grdEditContrato.Rows[e.RowIndex].Cells["detalle_contrato"].Value.ToString();
        //        txtDetContrEdit.Text = detalle_contrato;
        //        foreach (string servicio in servicios)
        //        {
        //            switch (servicio.Trim())
        //            {
        //                case "Asesoria":
        //                    chkAsesoria.Checked = true;
        //                    break;
        //                case "Seguridad":
        //                    chkSeguridad.Checked = true;
        //                    break;
        //                case "Mantencion":
        //                    chkMantencion.Checked = true;
        //                    break;
        //            }
        //        }

        //        for (int i = 0; i < cboTipoContrEdit.Items.Count; i++)
        //        {
        //            string cbo_tp = cboTipoContrEdit.GetItemText(cboTipoContrEdit.Items[i]);

        //            if (cbo_tp == tipo_contrato)
        //            {
        //                cboTipoContrEdit.SelectedIndex = i;
        //            }
        //        }

        //    }
        //}

        //private void cargarContratoEdit(int idContrato)
        //{
        //    return;
        //}
    }
}
