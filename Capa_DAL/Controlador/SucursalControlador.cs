using Capa_DAL.Conexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DAL.Controlador
{
    public class SucursalControlador
    {
        CL_Operaciones operaciones;
        public SucursalControlador()
        {
            operaciones = new CL_Operaciones();
        }
        public int insertarSucursal(string nombre_sucursal, string direccion, string nombre_contacto,int id_comuna,int id_cliente)
        {
            try
            {
                object[] parameter = new object[5];
                parameter[0] = nombre_sucursal;
                parameter[1] = direccion;
                parameter[2] = nombre_contacto;
                parameter[3] = id_comuna;
                parameter[4] = id_cliente;
                operaciones.abrirConexion();
                operaciones.execSP("PKG_SUCURSAL.INSERTAR_SUCURSAL",parameter);
            }catch(Exception e)
            {
                return 0;
            }
            finally
            {
                operaciones.cerrarConexion();
            }
            return 1;
        }
    }
}
