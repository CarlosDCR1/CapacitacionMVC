using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo_prototipoumg2k26.Contratos;
using CapaModelo_prototipoumg2k26.Entidades;
using CapaModelo_prototipoumg2k26.Repositorios;
using System.ComponentModel.DataAnnotations;

namespace CapaControlador_prototipoumg2k26
{
    public class ModeloTipoVehiculo
    {
        private int _idPK;
        private string _nombre;
        private string _descripcion;
        private IRepositorioTipoVehiculo RepositorioTipoVehiculo;

        public EstadoEntidad Estado { private get; set; }
        private List<ModeloTipoVehiculo> ListaTipoVehiculos;

        public int IdPK { get => _idPK; set => _idPK = value; }

        [Required(ErrorMessage = "El campo nombre es requerido")]
        [StringLength(maximumLength: 50, MinimumLength = 2, ErrorMessage = "El nombre debe tener entre 2 y 50 caracteres")]
        public string Nombre { get => _nombre; set => _nombre = value; }

        [StringLength(maximumLength: 255, ErrorMessage = "La descripcion no puede superar los 255 caracteres")]
        public string Descripcion { get => _descripcion; set => _descripcion = value; }

        public ModeloTipoVehiculo()
        {
            RepositorioTipoVehiculo = new RepositorioTipoVehiculo();
        }

        public string GrabarCambios()
        {
            string mensaje = null;
            try
            {
                var modeloDatosTipoVehiculo = new TipoVehiculo();
                modeloDatosTipoVehiculo.IdPK = _idPK;
                modeloDatosTipoVehiculo.Nombre = _nombre;
                modeloDatosTipoVehiculo.Descripcion = _descripcion;
                switch (Estado)
                {
                    case EstadoEntidad.Added:
                        RepositorioTipoVehiculo.Agregar(modeloDatosTipoVehiculo);
                        mensaje = "Grabacion exitosa";
                        break;
                    case EstadoEntidad.Modified:
                        RepositorioTipoVehiculo.Editar(modeloDatosTipoVehiculo);
                        mensaje = "Actualizacion exitosa";
                        break;
                    case EstadoEntidad.Deleted:
                        RepositorioTipoVehiculo.Remover(modeloDatosTipoVehiculo);
                        mensaje = "Eliminacion exitosa";
                        break;
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.ToString();
            }
            return mensaje;
        }

        public List<ModeloTipoVehiculo> GetAll()
        {
            var modeloDatosTipoVehiculo = RepositorioTipoVehiculo.GetAll();
            ListaTipoVehiculos = new List<ModeloTipoVehiculo>();
            foreach (TipoVehiculo item in modeloDatosTipoVehiculo)
            {
                ListaTipoVehiculos.Add(new ModeloTipoVehiculo
                {
                    _idPK = item.IdPK,
                    _nombre = item.Nombre,
                    _descripcion = item.Descripcion
                });
            }
            return ListaTipoVehiculos;
        }

        public IEnumerable<ModeloTipoVehiculo> FindbyId(string filter)
        {
            return ListaTipoVehiculos.FindAll(t => t.Nombre.Contains(filter));
        }
    }
}