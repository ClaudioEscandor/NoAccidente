using Capa_DAL.Conexion;
using Capa_DAL.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace Capa_DAL.Controlador
{
    public class ProfesionalControlador
    {
        private CL_Operaciones operaciones;

        public ProfesionalControlador()
        {
            operaciones = new CL_Operaciones();
        }

        public List<Profesional> buscarProfesional(string param)
        {

            List<Profesional> listaPro;
            OracleDataReader dr;
            try
            {
                operaciones.abrirConexion();
                listaPro = new List<Profesional>();
                object[] parametro = new object[2];
                parametro[0] = param;
                parametro[1] = "PROFESIONAL";
                OracleCommand cmd = operaciones.execSP("BUSCAR_PROFESIONAL", parametro);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Profesional profecional = new Profesional();

                        profecional.idProfesional = int.Parse(dr["ID_PROFESIONAL"].ToString());
                        profecional.rutProfesional = dr["RUT"].ToString();
                        profecional.pnombre = dr["PNOMBRE"].ToString();// + " " + dr["SNOMBRE"].ToString() + " " + dr["APPATERNO"].ToString() + " " + dr["APMATERNO"].ToString();
                        profecional.snombre = dr["SNOMBRE"].ToString();
                        profecional.appaterno = dr["APPATERNO"].ToString();
                        profecional.apmaterno = dr["APMATERNO"].ToString();
                        profecional.direccion = dr["DIRECCION"].ToString();
                        profecional.telefono = dr["TELEFONO"].ToString();
                        listaPro.Add(profecional);
                    }
                }
                dr.Dispose();
                return listaPro;
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

        //listar profesional con todos sus campos
        public List<Profesional> listarProfecional()
        {

            List<Profesional> listaPro;
            OracleDataReader dr;
            try
            {
                operaciones.abrirConexion();
                listaPro = new List<Profesional>();
                object[] parametro = new object[1];
                parametro[0] = "PROFESIONAL";
                OracleCommand cmd = operaciones.execSP("LISTAR_PROFESIONAL", parametro);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Profesional profecional = new Profesional();

                        profecional.idProfesional = int.Parse(dr["ID_PROFESIONAL"].ToString());
                        profecional.rutProfesional = dr["RUT"].ToString();
                        profecional.pnombre = dr["PNOMBRE"].ToString();// + " " + dr["SNOMBRE"].ToString() + " " + dr["APPATERNO"].ToString() + " " + dr["APMATERNO"].ToString();
                        profecional.snombre = dr["SNOMBRE"].ToString();
                        profecional.appaterno = dr["APPATERNO"].ToString();
                        profecional.apmaterno = dr["APMATERNO"].ToString();
                        profecional.direccion = dr["DIRECCION"].ToString();
                        profecional.telefono = dr["TELEFONO"].ToString();
                        listaPro.Add(profecional);
                    }
                }
                dr.Dispose();
                return listaPro;
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
        public List<Profesional> listarProfesionalEditar()
        {

            List<Profesional> listaPro;
            OracleDataReader dr;
            try
            {
                operaciones.abrirConexion();
                listaPro = new List<Profesional>();
                object[] parametro = new object[1];
                parametro[0] = "PROFESIONAL";
                OracleCommand cmd = operaciones.execSP("LISTAR_PROFESIONAL_EDITAR", parametro);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Profesional profecional = new Profesional();

                        profecional.idProfesional = int.Parse(dr["ID_PROFESIONAL"].ToString());
                        profecional.rutProfesional = dr["RUT"].ToString();
                        profecional.pnombre = dr["PNOMBRE"].ToString();// + " " + dr["SNOMBRE"].ToString() + " " + dr["APPATERNO"].ToString() + " " + dr["APMATERNO"].ToString();
                        profecional.snombre = dr["SNOMBRE"].ToString();
                        profecional.appaterno = dr["APPATERNO"].ToString();
                        profecional.apmaterno = dr["APMATERNO"].ToString();
                        profecional.direccion = dr["DIRECCION"].ToString();
                        profecional.telefono = dr["TELEFONO"].ToString();
                        listaPro.Add(profecional);
                    }
                }
                dr.Dispose();
                return listaPro;
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
        public int InsertarProfesional( string email, string pass, string pnombre, string snombre, string apPaterno, string apMaterno, string direccion, string rutProfesional, int telefono)
        {
            try
            {

                operaciones.abrirConexion();
                object[] parameter = new object[9];

                parameter[0] = email.ToString();
                parameter[1] = pass.ToString();
                parameter[2] = pnombre.ToString();
                parameter[3] = snombre.ToString();
                parameter[4] = apPaterno.ToString();
                parameter[5] = apMaterno.ToString();
                parameter[6] = direccion;
                parameter[7] = rutProfesional.ToString();
                parameter[8] = telefono.ToString();

                //Oracle.DataAccess.Client.OracleCommand cmd = operaciones.execSP("PKG_PROFESIONAL.INSERTAR_PROFESIONAL", parameter);
                operaciones.execSP("P_AGREGAR_PROFESIONAL", parameter);
                return 1;
            }
            catch (Exception) 
            {
                return 0;
            }
            finally
            {
                operaciones.cerrarConexion();
            }
            
        }

        public int ModificarProfesional(string email, string pass, string pnombre, string snombre, string apPaterno, string apMaterno, string direccion, string rutProfesional, int telefono)
        {
            try
            {
                operaciones.abrirConexion();
                object[] parameter = new object[9];

                parameter[0] = email.ToString();
                parameter[1] = pass.ToString();
                parameter[2] = pnombre.ToString();
                parameter[3] = snombre.ToString();
                parameter[4] = apPaterno.ToString();
                parameter[5] = apMaterno.ToString();
                parameter[6] = direccion;
                parameter[7] = rutProfesional.ToString();
                parameter[8] = telefono.ToString();

                //Oracle.DataAccess.Client.OracleCommand cmd = operaciones.ExecSP("PKG_PROFESIONAL.INSERTAR_PROFESIONAL", parameter);
                operaciones.execSP("MODIFICAR_PROFESIONAL", parameter);
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
            finally
            {
                operaciones.cerrarConexion();
            }
        }

        public int Eliminar_profesional(string email)
        {
            try
            {
                object[] parameter = new object[1];

                operaciones.abrirConexion();
                parameter[0] = email;
                operaciones.execSP("ELIMINAR_PROFESIONAL", parameter);
                return 1;

            }
            catch (Exception)
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
