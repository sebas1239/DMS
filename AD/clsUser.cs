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
    public class clsUser:dstUsuarios
    {
        public void llenarUsuario()
        {
            AspNetUsers.Clear();
            using (SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[AspNetUsers_TrTc]";
               // cmd.Parameters["@IdTipoEtiqueta"].Value
                cmd.Connection = Conn;
                Conn.Open();
               // SqlDataReader dr = cmd.ExecuteReader();

                using (DbDataReader sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    tbUsuario.Load(sdr);
                //if (dr.HasRows)
                //{
                //    while (dr.Read())
                //    {
                //        AspNetUsers.Rows.Add(
                //            dr["Id"].ToString(),
                //            dr["Email"].ToString(),
                //            dr["EmailConfirmed"].ToString(), 
                //            dr["PasswordHash"].ToString(), 
                //            dr["SecurityStamp"].ToString(),
                //            dr["PhoneNumber"].ToString(), 
                //            dr["PhoneNumberConfirmed"].ToString(),
                //            dr["TwoFactorEnabled"].ToString(),
                //            dr["LockoutEndDateUtc"].ToString(),
                //            dr["LockoutEnabled"].ToString(),
                //            dr["AccessFailedCount"].ToString(),
                //            dr["UserName"].ToString()
                //            ); ;
                //    }
                //}

                Conn.Close();
            }
        }
        public void GuardarCliente(String Nombre, string UserName, string Cedula, string Direccion, string Telefono)

        {
            tbUsuario.Clear();
            using (SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[tbUsuario_Insert]";
                cmd.Parameters.Add("@UserName", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Nombre", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Cedula", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Direccion", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Telefono", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Fecha", SqlDbType.DateTime);
                cmd.Parameters["@UserName"].Value = UserName;
                cmd.Parameters["@Nombre"].Value = Nombre;
                cmd.Parameters["@Cedula"].Value = Cedula;
                cmd.Parameters["@Direccion"].Value = Direccion;
                cmd.Parameters["@Telefono"].Value = Telefono;
                cmd.Parameters["@Fecha"].Value = DateTime.Now;
                cmd.Connection = Conn;
                Conn.Open();
                cmd.ExecuteNonQuery();

                //using (DbDataReader sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                //    AspNetUsers.Load(sdr);
                //if (dr.HasRows)
                //{
                //    while (dr.Read())
                //    {
                //        AspNetUsers.Rows.Add(
                //            dr["Id"].ToString(),
                //            dr["Email"].ToString(),
                //            dr["EmailConfirmed"].ToString(), 
                //            dr["PasswordHash"].ToString(), 
                //            dr["SecurityStamp"].ToString(),
                //            dr["PhoneNumber"].ToString(), 
                //            dr["PhoneNumberConfirmed"].ToString(),
                //            dr["TwoFactorEnabled"].ToString(),
                //            dr["LockoutEndDateUtc"].ToString(),
                //            dr["LockoutEnabled"].ToString(),
                //            dr["AccessFailedCount"].ToString(),
                //            dr["UserName"].ToString()
                //            ); ;
                //    }
                //}

                Conn.Close();
            }



        }

       


        public void ContarUsuario()
        {
            tbUsuario.Clear();
            using (SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[tbUsuarios_Count]";
                // cmd.Parameters["@IdTipoEtiqueta"].Value
                cmd.Connection = Conn;
                Conn.Open();
                // SqlDataReader dr = cmd.ExecuteReader();

                using (DbDataReader sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    tbUsuario.Load(sdr);
                //if (dr.HasRows)
                //{
                //    while (dr.Read())
                //    {
                //        AspNetUsers.Rows.Add(
                //            dr["Id"].ToString(),
                //            dr["Email"].ToString(),
                //            dr["EmailConfirmed"].ToString(), 
                //            dr["PasswordHash"].ToString(), 
                //            dr["SecurityStamp"].ToString(),
                //            dr["PhoneNumber"].ToString(), 
                //            dr["PhoneNumberConfirmed"].ToString(),
                //            dr["TwoFactorEnabled"].ToString(),
                //            dr["LockoutEndDateUtc"].ToString(),
                //            dr["LockoutEnabled"].ToString(),
                //            dr["AccessFailedCount"].ToString(),
                //            dr["UserName"].ToString()
                //            ); ;
                //    }
                //}

                Conn.Close();
            }
        }

    }
    }