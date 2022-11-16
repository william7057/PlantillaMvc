using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace PlantillaMvc.ConsultasAdo
{
    class Mantenimiento
    {
        SqlCommand _micomando = new SqlCommand();
        Conexion._Conexion _Micon = new Conexion._Conexion();
        DataTable Tabla = new DataTable();
        DataSet Ntablas = new DataSet();
        SqlDataAdapter _Adap = new SqlDataAdapter();
        SqlDataReader Leer;

        public DataTable Mostrar() {
            _micomando.Connection = _Micon.AbrirConexion();
            _micomando.CommandText = "Select * from productos";
            _micomando.CommandType = CommandType.Text;
            Leer = _micomando.ExecuteReader();
            Tabla.Load(Leer);
            return Tabla;
        
        }

    }
}
