using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace Tienda_online.models
{
    public class ClsUsuario
    {
        private string usuario;

        public static string Usuario
        {
            get { return Usuario; }
            set { Usuario = value; }
        }


        private string clave;

        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }


        public static int ConsultarUsuario(string usuario, string clave)
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();

            try
            {

                using (Conn = models.DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("ValidarUsuario", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@USUARIO", usuario));
                    cmd.Parameters.Add(new SqlParameter("@CLAVE", clave));
                    retorno = cmd.ExecuteNonQuery();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            retorno = 1;
                        }

                    }
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                return 0;
            }
            finally
            {
                Conn.Close();
                Conn.Dispose();
            }

            return retorno;
        }

    }
}