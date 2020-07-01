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

    public class LoginControlador
    {
        private CL_Operaciones operaciones;
        public LoginControlador()
        {
            operaciones = new CL_Operaciones();
        }
        public int  ObtenerUsuario(string email, string password)
        {
            try
            {
                
                OracleDataReader dr;
                object[] parametros = new object[3];
                parametros[0] = email;
                parametros[1] = password;
                operaciones.abrirConexion();
                OracleCommand cmd = operaciones.execSP("LOGINE",parametros);
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        //usuL.email = dr[1].ToString();
                        //usuL.password = dr[2].ToString();
                        //usuL.tipo_usuario = Convert.ToInt32(dr[3].ToString());
                        return Convert.ToInt32(dr[3].ToString());
                    }
                    dr.Dispose();
                }
                return 0;
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
