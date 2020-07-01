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
        public int insertarContrato(DateTime fecha_expiracion, string detalle_contrato, int idTipoContrato)
        {
            try
            {
                object[] parameter = new object[4];

                parameter[0] = fecha_expiracion;
                parameter[1] = detalle_contrato;
                parameter[2] = idTipoContrato;
                operaciones.abrirConexion();
                OracleCommand cmd = operaciones.execSP("PKG_CONTRATO.INSERTAR_CONTRATO", parameter);

                int id_contrato = Convert.ToInt32(cmd.Parameters["P_ID_CONTRATO"].Value);

                return id_contrato;
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

        public int actualizarContrato(int idContrato,DateTime fecha_expiracion, string detalle_contrato, int idTipoContrato)
        {
            try
            {
                object[] parameter = new object[4];
                parameter[0] = idContrato;
                parameter[1] = fecha_expiracion;
                parameter[2] = detalle_contrato;
                parameter[3] = idTipoContrato;
                operaciones.abrirConexion();
                OracleCommand cmd = operaciones.execSP("PKG_CONTRATO.ACTUALIZAR_CONTRATO", parameter);

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

                        item.id_cliente = int.Parse(dr[0].ToString());
                        item.rut_empresa = dr[1].ToString();
                        item.nombre_titular = dr[2].ToString();
                        item.id_contrato = Convert.ToInt32(dr[3].ToString());
                        item.tipo_contrato = dr[4].ToString();
                        item.fecha_expiracion = Convert.ToDateTime(dr[5].ToString());
                        item.servicios = dr[6].ToString();
                        item.detalle_contrato = dr[7].ToString();
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
