using CapaModelo_MVC1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;

namespace CapaControlador_MVC1
{
    public class Controlador
    {
       Sentencias sentencias = new Sentencias();
        public DataTable llenarDgv(string nombreTabla)
        {
            OdbcDataAdapter daControlador = sentencias.llenarTbl(nombreTabla);
            DataTable dtControlador = new DataTable();
            daControlador.Fill(dtControlador);
            return dtControlador;
        }
    }
}
