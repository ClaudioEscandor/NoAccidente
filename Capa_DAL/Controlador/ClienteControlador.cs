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
    public class ClienteControlador
    {
        private CL_Operaciones operaciones;
        public ClienteControlador()
        {
            operaciones = new CL_Operaciones();
        }

        public List<Cliente> listarCliente()
        {

            List<Cliente> list;
            OracleDataReader dr;
            try
            {
                operaciones.abrirConexion();
                list = new List<Cliente>();
                object[] parametro = new object[1];
                parametro[0] = "CLIENTE";
                OracleCommand cmd = operaciones.execSP("PKG_CLIENTE.LISTAR_CLIENTES", parametro);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Cliente item = new Cliente();

                        item.id_cliente= int.Parse(dr["ID_CLIENTE"].ToString());
                        item.nombre_titular = dr["NOMBRE_TITUTAL"].ToString();
                        item.rut_empresa = dr["RUT_EMPRESA"].ToString();
                        item.nombre_empresa = dr["NOMBRE_EMPRESA"].ToString();
                        item.giro = dr["GIRO"].ToString();
                        item.direccion = dr["DIRECCION"].ToString();
                        item.telefono = Convert.ToInt32(dr["TELEFONO"]);
                        item.pagina_web = dr["PAGINA_WEB"].ToString();
                        item.id_usuario = Convert.ToInt32(dr["USUARIO"]);
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




        public int insertar_cliente(string nombreTitular, string rutEmpresa, string nombreEmpresa, string giro, string direccion, int telefono, string email, string pass,string pagina)
        {
            try
            {

                object[] parameter = new object[10];

                parameter[0] = email;
                parameter[1] = pass;
                parameter[2] = nombreTitular;
                parameter[3] = rutEmpresa;
                parameter[4] = nombreEmpresa;
                parameter[5] = giro;
                parameter[6] = direccion;
                parameter[7] = telefono;
                parameter[8] = pagina;
                //parameter[6] = idUsuario.ToString();
                operaciones.abrirConexion();
                OracleCommand cmd = operaciones.execSP("PKG_CLIENTE.INSERTAR_CLIENTE", parameter);
                int id_cliente = Convert.ToInt32(cmd.Parameters["P_ID_CLIENTE"].Value);
                return id_cliente;

            }
            catch (Exception e)
            {

                return 0;
            }
            finally
            {
                operaciones.cerrarConexion();
            }
        }



        public List<Cliente> buscar_cliente(string rut)
        {

            List<Cliente> list;
            OracleDataReader dr;
            try
            {
                operaciones.abrirConexion();
                list = new List<Cliente>();
                object[] parametro = new object[2];
                parametro[0] = rut;
                parametro[1] = "CLIENTE";
                OracleCommand cmd = operaciones.execSP("PKG_CLIENTE.BUSCAR_CLIENTE", parametro);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Cliente item = new Cliente();

                        item.id_cliente = int.Parse(dr["ID_CLIENTE"].ToString());
                        item.nombre_titular = dr["NOMBRE_TITULAR"].ToString();
                        item.rut_empresa = dr["RUT_EMPRESA"].ToString();
                        item.nombre_empresa = dr["NOMBRE_EMPRESA"].ToString();
                        item.giro = dr["GIRO"].ToString();
                        item.direccion = dr["DIRECCION"].ToString();
                        item.telefono = Convert.ToInt32(dr["TELEFONO"]);
                        item.pagina_web = dr["PAGINA"].ToString();
                        item.id_usuario = Convert.ToInt32(dr["USUARIO"]);

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

        public List<Cliente> listarClienteEditar()
        {

            List<Cliente> list;
            OracleDataReader dr;
            try
            {
                operaciones.abrirConexion();
                list = new List<Cliente>();
                object[] parametro = new object[1];
                parametro[0] = "CLIENTE";
                OracleCommand cmd = operaciones.execSP("PKG_CLIENTE.LISTAR_CLIENTES", parametro);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Cliente item = new Cliente();

                        item.id_cliente = int.Parse(dr["ID_CLIENTE"].ToString());
                        item.nombre_titular = dr["NOMBRE_TITUTAL"].ToString();
                        item.rut_empresa = dr["RUT_EMPRESA"].ToString();
                        item.nombre_empresa = dr["NOMBRE_EMPRESA"].ToString();
                        item.giro = dr["GIRO"].ToString();
                        item.direccion = dr["DIRECCION"].ToString();
                        item.telefono = Convert.ToInt32(dr["TELEFONO"]);
                        item.pagina_web = dr["PAGINA_WEB"].ToString();
                        item.id_usuario = Convert.ToInt32(dr["USUARIO"]);
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

        public int eliminar_cliente(string email)
        {
            try
            {
                object[] parameter = new object[1];

                parameter[0] = email;
                operaciones.abrirConexion();
                operaciones.execSP("PKG_CLIENTE.ELIMINAR_CLIENTE", parameter);
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


        public int actualizar_cliente(string email, string pass, string nombreTitular, string rutEmpresa, 
            string nombreEmpresa, string giro, string direccion,int telefono , string paginaWeb)
        {
            try
            {

                object[] parameter = new object[9];

                parameter[0] = email;
                parameter[1] = pass;
                parameter[2] = nombreTitular;
                parameter[3] = rutEmpresa;
                parameter[4] = nombreEmpresa;
                parameter[5] = giro;
                parameter[6] = direccion;
                parameter[7] = telefono;
                parameter[8] = paginaWeb;
                //parameter[6] = idUsuario.ToString();

                operaciones.abrirConexion();
                operaciones.execSP("PKG_CLIENTE.MODIFICAR_CLIENTE", parameter);
                return 1;


            }
            catch (Exception e)
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
