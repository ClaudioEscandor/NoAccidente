using Capa_DAL.Conexion;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DAL.Controlador
{
    public class ServicioControlador
    {
        CL_Operaciones operaciones;

        public ServicioControlador()
        {
            operaciones = new CL_Operaciones();
        }

        public int insertarServicio(string nombre_servicio, DateTime fecha_termino, int id_tipo_servicio, int id_contrato)
        {
            try
            {
                object[] parameter = new object[5];
                parameter[0] = nombre_servicio;
                parameter[1] = fecha_termino;
                parameter[2] = id_tipo_servicio;
                parameter[3] = id_contrato;
                operaciones.abrirConexion();
                OracleCommand cmd = operaciones.execSP("PKG_SERVICIO.INSERTAR_SERVICIO", parameter);

                int id_servicio = Convert.ToInt32(cmd.Parameters["P_ID_SERVICIO"].Value);
                return id_servicio;
            }
            catch(Exception ex)
            {
                return 0;
            }
            finally
            {
                operaciones.cerrarConexion();
            }
        }

        public int insertar_detalle_servicio(int id_cliente, int id_servicio)
        {
            try
            {
                object[] parameter = new object[2];
                parameter[0] = id_cliente;
                parameter[1] = id_servicio;
                operaciones.abrirConexion();
                OracleCommand cmd = operaciones.execSP("PKG_SERVICIO.INSERTAR_DETALLE_SERVICIO", parameter);
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                operaciones.cerrarConexion();
            }
        }

        public int eliminar_servicio_contrato(int id_contrato)
        {
            try
            {
                object[] parameter = new object[1];
                parameter[0] = id_contrato;
                operaciones.abrirConexion();
                OracleCommand cmd = operaciones.execSP("PKG_SERVICIO.ELIMINAR_SERVICIO_POR_CONTRATO", parameter);
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                operaciones.cerrarConexion();
            }
        }
    }
}
