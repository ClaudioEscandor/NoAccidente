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
    public class DetallePagoControlador
    {
        private CL_Operaciones operaciones;

        public DetallePagoControlador()
        {
            operaciones = new CL_Operaciones();
        }

        public List<Pagos> ListarPago()
        {

            List<Pagos> listpago;
            OracleDataReader dr;
            try
            {
                operaciones.abrirConexion();
                listpago = new List<Pagos>();
                object[] parametro = new object[1];
                parametro[0] = "PAGO";
                OracleCommand cmd = operaciones.execSP("LISTAR_DETALLE_PAGO", parametro);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Pagos detapago = new Pagos();

                        detapago.id_pago = int.Parse(dr["ID_PAGO"].ToString());
                        detapago.estado_pago = dr["ESTADO_PAGO"].ToString();
                        detapago.nombre_titular = dr["NOMBRE_TITUTAL"].ToString();
                        detapago.rut_empresa = dr["RUT_EMPRESA"].ToString();

                        listpago.Add(detapago);
                    }
                }
                dr.Dispose();
                return listpago;
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
