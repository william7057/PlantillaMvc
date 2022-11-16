using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace PlantillaMvc.Conexion
{
    class _Conexion
    {
       static string cadena = ConfigurationManager.ConnectionStrings["Admin"].ConnectionString;
        SqlConnection Conexion = new SqlConnection(cadena);

        public SqlConnection AbrirConexion() {
            if (Conexion.State == ConnectionState.Closed)
            {
                Conexion.Open();
            }
            return Conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
            {
                Conexion.Close();
            }
            return Conexion;
        }


    }
}
