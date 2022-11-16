using PlantillaMvc.ConsultasAdo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace PlantillaMvc.Controlador
{
    class ProductosControler
    {
        Mantenimiento _Fucniones = new Mantenimiento();
        public DataTable MostrarProduc() {
            DataTable tabla = new DataTable();
            tabla = _Fucniones.Mostrar();
            return tabla;
        }
    }
}
