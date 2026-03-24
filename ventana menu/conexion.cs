using System;
using Microsoft.Data.SqlClient;

namespace ventana_menu
{
    internal class Conexion
    {
        private string cadena = "Server=.;Database=DB_TicketingEstadioPro;Trusted_Connection=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadena);
        }
    }
}