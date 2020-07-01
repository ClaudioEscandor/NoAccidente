using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Capa_DAL.Conexion
{
    public class CL_Operaciones
    {
        private OracleConnection conn;

        public CL_Operaciones()
        {
            conn = new CL_Conexion().ObtenerConexion();
        }

        public void abrirConexion()
        {
            conn.Open();
        }

        public void cerrarConexion()
        {
            conn.Close();
        }

        public OracleDataReader sqlOperacion(string sql)
        {
            OracleCommand cmd = new OracleCommand(sql, conn);
            abrirConexion();
            OracleDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public OracleCommand execSP(string SP, params object[] parametros)
        {
            try
            {
                OracleCommand cmd = new OracleCommand(SP, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //abrirConexion();
                OracleCommandBuilder.DeriveParameters(cmd);
                int cuenta = 0;
                foreach (OracleParameter param in cmd.Parameters)
                {
                    if (param.ParameterName != "RETURN_VALUE")
                    {
                        param.Value = parametros[cuenta];
                        cuenta++;
                    }

                }
                cmd.ExecuteNonQuery();
                return cmd;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
