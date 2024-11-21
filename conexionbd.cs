using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Sistema_de_Restaurantes
{
    internal class ConexionBd
    {
        //Cadena de Conexion
        string cadena = "data source = SistemaRestaurantes; initial catalog = BaseDatos; user id = Usuario; password = Contraseña";

        public SqlConnection Conectarbd = new SqlConnection();

        //Constructor
        public ConexionBd()
        {
            Conectarbd.ConnectionString = cadena;
        }

        //Metodo para abrir la conexion
        public void abrir()
        {
            try
            {
                Conectarbd.Open();
            }
            catch (Exception ex)
            {
                // Imprime un mensaje de error más detallado
                Console.WriteLine("Error al abrir la base de datos: " + ex.Message);
            }
        }

        //Metodo para cerrar la conexion
        public void cerrar()
        {
            Conectarbd.Close();
        }


        // Luego podremos usarla desde cualquier otro lugar
        ConexionBd conexion = new ConexionBd();
            
    }
        
}
