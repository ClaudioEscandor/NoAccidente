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
    public class CapacitacionControlador
    {
        private CL_Operaciones operaciones;
        public CapacitacionControlador()
        {
            operaciones = new CL_Operaciones();
        }
        public List<Capacitacion> listarCapacitacion()
        {
            List<Capacitacion> list;
            OracleDataReader dr;
            try
            {
                operaciones.abrirConexion();
                list = new List<Capacitacion>();
                object[] parametro = new object[1];
                parametro[0] = "";
                OracleCommand cmd = operaciones.execSP("PKG_CAPACITACION.LISTAR_CAPACITACION", parametro);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Capacitacion item = new Capacitacion();

                        item.id_capacitacion = int.Parse(dr["ID_CAPACITACION"].ToString());
                        item.fecha_capacitacion = Convert.ToDateTime(dr["FECHA_CAPACITACION"].ToString());
                        item.id_planificacion = int.Parse(dr["ID_PLANIFICACION"].ToString());
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




        public int insertar_cliente(int id_capacitacion, DateTime fecha_capacitacion, int id_planificacion)
        {
            try
            {

                object[] parameter = new object[3];


                parameter[0] = id_capacitacion;
                parameter[1] = fecha_capacitacion;
                parameter[2] = id_planificacion;

                operaciones.execSP("PKG_CLIENTE.INSERTAR_CAPACITACION", parameter);
                return 1;


            }
            catch (Exception e)
            {

                return 0;
            }
        }



        public List<Capacitacion> buscar_capacitacion(int id_capacitacion)
        {

            List<Capacitacion> list;
            OracleDataReader dr;
            try
            {
                operaciones.abrirConexion();
                list = new List<Capacitacion>();
                object[] parametro = new object[2];
                parametro[0] = id_capacitacion;
                parametro[1] = "ID_CAPACITACION";
                OracleCommand cmd = operaciones.execSP("PKG_CLIENTE.BUSCAR_CAPACITACION", parametro);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Capacitacion item = new Capacitacion();

                        item.id_capacitacion = int.Parse(dr["ID_CAPACITACION"].ToString());
                        item.fecha_capacitacion = Convert.ToDateTime(dr["FECHA_CAPACITACION"].ToString());
                        item.id_planificacion = int.Parse(dr["ID_PLANIFICACION"].ToString());

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




        public int actualizar_capacitacion(int id_capacitacion, DateTime fecha_capacitacion, int id_planificacion)
        {
            try
            {

                object[] parameter = new object[11];

                parameter[0] = id_capacitacion;
                parameter[1] = fecha_capacitacion;
                parameter[2] = id_planificacion;

                operaciones.execSP("PKG_CLIENTE.ACTUALIZAR_CAPACITACION", parameter);
                return 1;


            }
            catch (Exception e)
            {

                return 0;
            }
        }
    }
}
