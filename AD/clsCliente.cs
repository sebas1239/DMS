using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Common;

namespace DMS.AD
{
    public class clsCliente:dstCliente
    {
        public void llenarCliente ()
        {
            using (SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings ["DefaultConnection"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "tbCliente_TrTc";
                cmd.Connection = Conn;
                Conn.Open();

                using (DbDataReader sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    tbCliente.Load(sdr);
                //SqlDataReader dr = cmd.ExecuteReader();

                //if (dr.HasRows)
                //{
                //    while (dr.Read())
                //    {
                //        tbCliente.Rows.Add(
                //            dr["Id"].ToString(),
                //            dr["Nombre"].ToString(),
                //            dr["Documento"].ToString(),
                //            dr["Tipo"].ToString(),
                //            dr["telefono"].ToString(),
                //            dr["Pais"].ToString(),
                //            dr["Linea"].ToString(),
                //            dr["Area"].ToString(),
                //            dr["CodigoPostal"].ToString(),
                //            dr["Direccion"].ToString(),
                //            dr["Encuesta"].ToString(),
                //            dr["Estado"].ToString()
                //            ); ;
                //    }
                //}
             
                Conn.Close();
            }
        }


        public void GuardarCliente(tbClienteRow dr)
        {
          
            using (SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[tbCliente_Insert]"; // sp que se encarga de guardar cliente

                cmd.Parameters.Add("@Tipo", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Nombre", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Documento", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Telefono", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Pais", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Linea", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Area", SqlDbType.NVarChar);
                cmd.Parameters.Add("@CodigoPostal", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Direccion", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Encuesta", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Firma", SqlDbType.NVarChar);
                cmd.Parameters.Add("@UsuarioName", SqlDbType.NVarChar);
                cmd.Parameters.Add("@EmailCliente", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Estado", SqlDbType.Int);

                cmd.Parameters["@Tipo"].Value = dr.Tipo;
                cmd.Parameters["@Nombre"].Value = dr.Nombre;
                cmd.Parameters["@Documento"].Value = dr.Documento;
                cmd.Parameters["@Telefono"].Value = dr.telefono;
                cmd.Parameters["@Pais"].Value = dr.Pais;
                cmd.Parameters["@Linea"].Value = dr.Linea;
                cmd.Parameters["@Area"].Value = dr.Area;
                cmd.Parameters["@CodigoPostal"].Value = dr.CodigoPostal;
                cmd.Parameters["@Direccion"].Value = dr.Direccion;
                cmd.Parameters["@Encuesta"].Value = dr.Encuesta;
                cmd.Parameters["@Firma"].Value = dr.Firma;
                cmd.Parameters["@UsuarioName"].Value = dr.UserName;
                cmd.Parameters["@EmailCliente"].Value = dr.EmailCliente;
                cmd.Parameters["@Estado"].Value = 1;

                cmd.Connection = Conn;
                Conn.Open();
                cmd.ExecuteNonQuery();
                Conn.Close();
            }
        }


        public void llenarArea()
        {
            using (SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "tbCliente_Area";
                cmd.Connection = Conn;
                Conn.Open();

                using (DbDataReader sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    tbAreaIndicador.Load(sdr);
                Conn.Close();
            }
        }

        public void llenarLinea()
        {
            using (SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "tbCliente_Linea";
                cmd.Connection = Conn;
                Conn.Open();

                using (DbDataReader sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    tbLineaIndicador.Load(sdr);
                Conn.Close();
            }
        }

        public void llenarPais()
        {
            using (SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "tbCliente_Pais";
                cmd.Connection = Conn;
                Conn.Open();

                using (DbDataReader sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    tbLineaIndicador.Load(sdr);
                Conn.Close();
            }
        }


    }
}