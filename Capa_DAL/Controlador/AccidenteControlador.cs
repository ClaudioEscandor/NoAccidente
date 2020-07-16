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
    public class AccidenteControlador
    {
        private CL_Operaciones operaciones;

        public AccidenteControlador()
        {
            operaciones = new CL_Operaciones();
        }
        
        public List<Accidente> listarCantidadAccidente()
        {
            List<Accidente> list;
            OracleDataReader dr;
            try
            {
                operaciones.abrirConexion();
                list = new List<Accidente>();
                object[] parametro = new object[1];
                parametro[0] = "";
                OracleCommand cmd = operaciones.execSP("ACCIDENTES_POR_CLIENTE", parametro);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Accidente item = new Accidente();

                        item.idCliente = int.Parse(dr[0].ToString());
                        item.nombreTitular = dr[1].ToString();
                        item.rutEmpresa = dr[2].ToString();
                        item.nombreEmpresa = dr[3].ToString();
                        item.cantAccidente = int.Parse(dr[4].ToString());
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
    }
}
