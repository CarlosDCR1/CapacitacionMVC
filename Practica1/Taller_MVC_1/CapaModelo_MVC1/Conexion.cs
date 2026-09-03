using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_MVC1
{
     class Conexion
    {
        public OdbcConnection conexion()
        {
            OdbcConnection conn = new OdbcConnection("Dsn=sistema_reparto");
            try
            { 
            conn.Open();
            }
            catch (OdbcException) 
            {
                    Console.WriteLine("No conecto");
            }
                return conn;

        }
        public void desconexion(OdbcConnection conn)
        {
            try
            {
                conn.Close();
            }catch (OdbcException)
            {
                Console.WriteLine("No se Desconecto");
            }
        }
    }
}
