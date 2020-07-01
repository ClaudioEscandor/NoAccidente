
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
    public class UsuarioControlador
    {
        private CL_Operaciones operaciones;

        public UsuarioControlador()
        {
            operaciones = new CL_Operaciones();
        }

        public int InsertarUsuario(int id_tipo_usuario,string email, string password)
        {
            try
            {
                object[] parametros = new object[3];
                parametros[0] = id_tipo_usuario;
                parametros[1] = email;
                parametros[2] = password;

                operaciones.abrirConexion();
                OracleCommand cmd = operaciones.execSP("AGREGAR_USUARIO_P", parametros);
                
                return 1;
            }
            catch (Exception ex )
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                operaciones.cerrarConexion();
            }
        }

        public int ModificarUsuario(int id_tipo_usuario, string email, string password)
        {
            try
            {
                object[] parametros = new object[3];
                parametros[0] = id_tipo_usuario;
                parametros[1] = email;
                parametros[2] = password;

                operaciones.abrirConexion();
                OracleCommand cmd = operaciones.execSP("MODIFICAR_USUARIO_P", parametros);

                return 1;
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

        public List<Usuario> listarUsuario()
        {

            List<Usuario> list;
            OracleDataReader dr;
            try
            {
                operaciones.abrirConexion();
                list = new List<Usuario>();
                object[] parametro = new object[1];
                parametro[0] = "USUARIO";
                OracleCommand cmd = operaciones.execSP("LISTAR_USUARIO_P", parametro);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Usuario item = new Usuario();

                        item.idUsuario = int.Parse(dr["ID_USUARIO"].ToString());
                        item.email = dr["EMAIL"].ToString();
                        item.password = dr["PASSWORD"].ToString();
                        item.tipo_usuario = dr["TIPO_USUARIO"].ToString();
                        item.estado = dr["ESTADO"].ToString();
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

        public List<Usuario> buscarUsuario(string param)
        {

            List<Usuario> list;
            OracleDataReader dr;
            try
            {
                operaciones.abrirConexion();
                list = new List<Usuario>();
                object[] parametro = new object[2];
                parametro[0] = param;
                parametro[1] = "USUARIO";
                OracleCommand cmd = operaciones.execSP("BUSCAR_USUARIO", parametro);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Usuario item = new Usuario();

                        item.idUsuario = int.Parse(dr["ID_USUARIO"].ToString());
                        item.email = dr["EMAIL"].ToString();
                        item.password = dr["PASSWORD"].ToString();
                        item.tipo_usuario = dr["TIPO_USUARIO"].ToString();
                        item.estado = dr["ESTADO"].ToString();
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
