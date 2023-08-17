using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace Tienda_online.models
{
    public class DBCommon
    {
        private static string Conn = @"Data Source=LAPTOP-MFCJ5J1J\SQLEXPRESS03;Initial Catalog=UH_almacen;Integrated Security=True";

        public static IDbConnection conexion()
        {
            return new SqlConnection(Conn);
        }
    }
}