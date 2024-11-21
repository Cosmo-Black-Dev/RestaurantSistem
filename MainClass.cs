using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;

namespace RestaurantSistem
{
    internal class MainClass
    {
        // Instanciar DtBase_Conexion para acceder a la cadena de conexión
        public static DtBase_Conexion conexion = new DtBase_Conexion();

        // Usar la cadena de conexión desde la clase DtBase_Conexion
        public static SqlConnection con = new SqlConnection(conexion.con);

        // Método para validar usuario
        public static bool isValidUser(string user, string pass)
        {
            bool isValid = false;

            try
            {
                // Verificar si la conexión está cerrada, abrirla si es necesario
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string qry = @"SELECT * FROM users WHERE username = @username AND upass = @password";
                SqlCommand cmd = new SqlCommand(qry, con);

                // Agregar parámetros para evitar inyecciones SQL
                cmd.Parameters.AddWithValue("@username", user);
                cmd.Parameters.AddWithValue("@password", pass);

                // Crear un SqlDataAdapter y DataTable
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                // Llenar el DataTable con los resultados de la consulta
                da.Fill(dt);

                // Verificar si el usuario es válido
                if (dt.Rows.Count > 0)
                {
                    isValid = true;
                    USER = dt.Rows[0]["uName"].ToString();  // Suponiendo que "uName" es el nombre del usuario
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                // Asegurarse de cerrar la conexión después de usarla
                if (con.State == ConnectionState.Open)
                    con.Close();
            }

            return isValid;
        }

        public static string user;

        public static string USER
        {
            get { return user; }
            private set { user = value; }
        }
    }
}