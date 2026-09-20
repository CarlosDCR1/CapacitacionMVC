using CapaModelo_prototipoumg2k26.Contratos;
using CapaModelo_prototipoumg2k26.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_prototipoumg2k26.Repositorios
{
    public class RepositorioTipoVehiculo : RepositorioMaestro, IRepositorioTipoVehiculo
    {
        private string selectAll;
        private string insert;
        private string update;
        private string delete;
        public RepositorioTipoVehiculo()
        {
            selectAll = "SELECT * FROM tipo_vehiculo";
            insert = "INSERT INTO tipo_vehiculo value (NULL, ?, ?)";
            update = "UPDATE tipo_vehiculo SET nombre_tipo_vehiculo=?, descripcion_tipo_vehiculo=? WHERE id_tipo_vehiculo=?";
            delete = "DELETE FROM tipo_vehiculo WHERE id_tipo_vehiculo=?";
        }
        public int Agregar(TipoVehiculo entidad)
        {
            var _parametros = new List<OdbcParameter>();
            _parametros.Add(new OdbcParameter("p_Nombre", entidad.Nombre));
            _parametros.Add(new OdbcParameter("p_Descripcion", entidad.Descripcion));

            return EjecucionNonQuery(insert, _parametros, CommandType.Text);
        }
        public int Editar(TipoVehiculo entidad)
        {
            var _parametros = new List<OdbcParameter>();
            _parametros.Add(new OdbcParameter("p_Nombre", entidad.Nombre));
            _parametros.Add(new OdbcParameter("p_Descripcion", entidad.Descripcion));
            _parametros.Add(new OdbcParameter("p_IdPK", entidad.IdPK));
            return EjecucionNonQuery(update, _parametros, CommandType.Text);
        }
        public int Remover(TipoVehiculo entidad)
        {
            var _parametros = new List<OdbcParameter>();
            _parametros.Add(new OdbcParameter("p_IdPK", entidad.IdPK));
            return EjecucionNonQuery(delete, _parametros, CommandType.Text);
        }
        public IEnumerable<TipoVehiculo> GetAll()
        {
            var lstTipoVehiculo = new List<TipoVehiculo>();
            var tblTabla = EjecucionConsulta(selectAll, CommandType.Text);
            foreach (DataRow row in tblTabla.Rows)
            {
                var tipoVehiculo = new TipoVehiculo();
                tipoVehiculo.IdPK = Convert.ToInt32(row[0]);
                tipoVehiculo.Nombre = row[1].ToString();
                tipoVehiculo.Descripcion = row[2].ToString();
                lstTipoVehiculo.Add(tipoVehiculo);
            }
            tblTabla.Clear();
            tblTabla = null;
            return lstTipoVehiculo;
        }
    }
}