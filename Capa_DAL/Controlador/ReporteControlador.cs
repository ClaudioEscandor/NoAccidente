using Capa_DAL.Conexion;
using Capa_DAL.Modelo;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DAL.Controlador
{
    public class ReporteControlador
    {
        CL_Operaciones operaciones;
        
        public ReporteControlador()
        {
            operaciones = new CL_Operaciones();
        }

        public PDFpago ListarPagoPdf(int idPago)
        {
            
            OracleDataReader dr;
            try
            {
                operaciones.abrirConexion();
                object[] parametro = new object[2];
                parametro[0] = idPago;
                parametro[1] = "PAGO";
                OracleCommand cmd = operaciones.execSP("PDF_PAGO", parametro);
                dr = cmd.ExecuteReader();
                PDFpago pdfPago = new PDFpago();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        pdfPago.nombre_titutal = dr[0].ToString();
                        pdfPago.rut_empresa = dr[1].ToString();
                        pdfPago.giro = dr[2].ToString();
                        pdfPago.telefono = Convert.ToInt32(dr[3].ToString());
                        pdfPago.servicios = dr[4].ToString();
                        pdfPago.fecha_realizacion = Convert.ToDateTime(dr[5].ToString());
                        pdfPago.fecha_expiracion = Convert.ToDateTime(dr[6].ToString());
                        pdfPago.impuesto = Convert.ToInt32(dr[7].ToString());
                        pdfPago.monto = Convert.ToInt32(dr[8].ToString());
                        pdfPago.monto_total = Convert.ToInt32(dr[9].ToString());
                        pdfPago.estado_pago = dr[10].ToString();

                    }
                }
                dr.Dispose();
                return pdfPago;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                operaciones.cerrarConexion();
            }
        }
    }
}
