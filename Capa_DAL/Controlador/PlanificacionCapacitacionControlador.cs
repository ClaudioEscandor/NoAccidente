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
    class PlanificacionCapacitacionControlador
    {
        private CL_Operaciones operaciones;
        public PlanificacionCapacitacionControlador()
        {
            operaciones = new CL_Operaciones();
        }
        public List<Planificacion_Capacitacion> listarPlanificacionCapacitacion()
        {
            List<Planificacion_Capacitacion> list;
            OracleDataReader dr;
            try
            {
                operaciones.abrirConexion();
                list = new List<Planificacion_Capacitacion>();
                object[] parametro = new object[1];
                parametro[0] = "";
                OracleCommand cmd = operaciones.execSP("PKG_CAPACITACION.LISTAR_PLANIFICACION_CAPACITACION", parametro);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Planificacion_Capacitacion item = new Planificacion_Capacitacion();

                        item.id_planificacion_capacitacion = int.Parse(dr["ID_CAPACITACION"].ToString());
                        item.fecha_registro = Convert.ToDateTime(dr["FECHA_REGISTRO"].ToString());
                        item.material = dr["MATERIAL"].ToString();
                        item.cantidad_asistentes = int.Parse(dr["CATIDAD_ASISTENTES"].ToString());
                        list.Add(item);
                    }
                }
                dr.Dispose();
                return list;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
            finally
            {
                operaciones.cerrarConexion();
            }
        }




        public int insertar_planificacion_capac(int id_planificacion_capacitacion, DateTime fecha_registro, string material,int cantidad_asistentes)
        {
            try
            {

                object[] parameter = new object[4];


                parameter[0] = id_planificacion_capacitacion;
                parameter[1] = fecha_registro;
                parameter[2] = material;
                parameter[3] = cantidad_asistentes;

                operaciones.execSP("PKG_CLIENTE.INSERTAR_PLANIFICACION_CAPACITACION", parameter);
                return 1;


            }
            catch (Exception e)
            {

                return 0;
            }
        }



        public List<Planificacion_Capacitacion> buscar_planificacion_capacitacion(int id_planificacion_capacitacion)
        {

            List<Planificacion_Capacitacion> list;
            OracleDataReader dr;
            try
            {
                operaciones.abrirConexion();
                list = new List<Planificacion_Capacitacion>();
                object[] parametro = new object[2];
                parametro[0] = id_planificacion_capacitacion;
                parametro[1] = "ID_CAPACITACION";
                OracleCommand cmd = operaciones.execSP("PKG_CAPACITACION.LISTAR_PLANIFICACION_CAPACITACION", parametro);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Planificacion_Capacitacion item = new Planificacion_Capacitacion();

                        item.id_planificacion_capacitacion = int.Parse(dr["ID_CAPACITACION"].ToString());
                        item.fecha_registro = Convert.ToDateTime(dr["FECHA_REGISTRO"].ToString());
                        item.material = dr["MATERIAL"].ToString();
                        item.cantidad_asistentes = int.Parse(dr["CATIDAD_ASISTENTES"].ToString());
                        list.Add(item);
                    }
                }
                dr.Dispose();
                return list;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
            finally
            {
                operaciones.cerrarConexion();
            }
        }




        public int actualizar_planificacion_capacitacion(int id_planificacion_capacitacion, DateTime fecha_registro, string material, int cantidad_asistentes)
        {
            try
            {

                object[] parameter = new object[4];

                parameter[0] = id_planificacion_capacitacion;
                parameter[1] = fecha_registro;
                parameter[2] = material;
                parameter[3] = cantidad_asistentes;

                operaciones.execSP("PKG_CLIENTE.ACTUALIZAR_PLANIFICACION_CAPACITACION", parameter);
                return 1;


            }
            catch (Exception e)
            {

                return 0;
            }
        }
    }
}
