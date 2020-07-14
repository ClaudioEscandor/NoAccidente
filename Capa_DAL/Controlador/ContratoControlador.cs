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
    public class ContratoControlador
    {
        CL_Operaciones operaciones;
        public ContratoControlador()
        {
            operaciones = new CL_Operaciones();
        }

        //public int insertarContrato(DateTime fecha_expiracion, string detalle_contrato, int idTipoContrato)
        //{
        //    try
        //    {
        //        object[] parameter = new object[4];

        //        parameter[0] = fecha_expiracion;
        //        parameter[1] = detalle_contrato;
        //        parameter[2] = idTipoContrato;
        //        operaciones.abrirConexion();
        //        OracleCommand cmd = operaciones.execSP("PKG_CONTRATO.INSERTAR_CONTRATO", parameter);

        //        int id_contrato = Convert.ToInt32(cmd.Parameters["P_ID_CONTRATO"].Value);

        //        return id_contrato;
        //    }
        //    catch (Exception ex)
        //    {
        //        return 0;
        //    }
        //    finally
        //    {
        //        operaciones.cerrarConexion();
        //    }

        //}

        public int aceptarContrato(int idContrato)
        {
            try
            {
                object[] parameter = new object[1];
                parameter[0] = idContrato;
                operaciones.abrirConexion();
                OracleCommand cmd = operaciones.execSP("PKG_CONTRATO.ACEPTAR_CONTRATO", parameter);
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

        public List<Contrato> listarContratos()
        {
            List<Contrato> list;
            OracleDataReader dr;
            try
            {
                operaciones.abrirConexion();
                list = new List<Contrato>();
                object[] parametro = new object[1];
                parametro[0] = "CONTRATO";
                OracleCommand cmd = operaciones.execSP("PKG_CONTRATO.LISTAR_CONTRATO", parametro);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Contrato item = new Contrato();

                        item.id_contrato = Convert.ToInt32(dr[0].ToString());
                        item.id_cliente = int.Parse(dr[1].ToString());
                        item.rut_empresa = dr[2].ToString();
                        item.nombre_titular = dr[3].ToString();
                        item.nombre_empresa = dr[4].ToString();
                        item.telefono = Convert.ToInt32(dr[5].ToString());
                        item.tipo_contrato = dr[6].ToString();
                        list.Add(item);
                    }
                }
                dr.Dispose();
                return list;
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
