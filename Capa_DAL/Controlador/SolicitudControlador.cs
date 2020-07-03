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
    public class SolicitudControlador
    {
        CL_Operaciones operaciones;
        public SolicitudControlador()
        {
            operaciones = new CL_Operaciones();
        }

        public int agregarSolicitud(int id_solicitud, int id_profesional)
        {
            try
            {
                object[] parameter = new object[4];

                parameter[0] = id_solicitud;
                parameter[1] = id_profesional;
                operaciones.abrirConexion();
                OracleCommand cmd = operaciones.execSP("INGRESAR_PROFESIONAL_SOLICITUD", parameter);

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

        public List<Solicitud> listarSolicitud()
        {
            List<Solicitud> listaSolicitud;
            OracleDataReader dr;
            try
            {
                object[] parameter = new object[1];

                parameter[0] = "SOLICITUD";
                operaciones.abrirConexion();
                OracleCommand cmd = operaciones.execSP("LISTAR_SOLICITUD_PROFESIONAL", parameter);
                listaSolicitud = new List<Solicitud>();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Solicitud item = new Solicitud();

                        item.id_solicitud = int.Parse(dr[0].ToString());
                        item.nombre_titular = dr["NOMBRE_TITUTAL"].ToString();
                        item.rut_empresa = dr["RUT_EMPRESA"].ToString();
                        item.nombre_empresa = dr["NOMBRE_EMPRESA"].ToString();
                        listaSolicitud.Add(item);
                    }
                }
                dr.Dispose();
                return listaSolicitud;
            }
            catch (Exception ex)
            {
                return listaSolicitud = new List<Solicitud>();
            }
            finally
            {
                operaciones.cerrarConexion();
            }
        }
    }
}
