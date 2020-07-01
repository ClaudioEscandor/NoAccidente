using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DAL.Conexion
{
    public class CL_Conexion
    {
        private OracleConnection conn;
        private string cadena = "Data Source=localhost:1521/xe;USER ID = NoMasAccidentes; PASSWORD=asd";

        public CL_Conexion()
        {
            try
            {
                if(conn == null)
                {
                    conn = new OracleConnection(cadena);
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public OracleConnection ObtenerConexion()
        {
            return conn;
        }
    }
}
