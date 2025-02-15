using Abstracciones.Interfaces.DA.Vehiculos;
using Abstracciones.Interfaces.Flujo.Vehiculos;
using Abstracciones.Modelos;

namespace Flujo.Vehiculos
{
    public class VehiculoFlujo : IVehiculoFlujo
    {

        private IVehiculosDA _vehiculoDA;

        public VehiculoFlujo(IVehiculosDA vehiculoDA)
        {
            _vehiculoDA = vehiculoDA;
        }

        public Task<Guid> Agregar(VehiculoRequest vehiculo)
        {
            return _vehiculoDA.Agregar(vehiculo);
        }

        public Task<Guid> Editar(Guid Id, VehiculoRequest vehiculo)
        {
            return _vehiculoDA.Editar(Id, vehiculo);
        }

        public Task<Guid> Eliminar(Guid Id)
        {
          return _vehiculoDA.Eliminar(Id);
        }

        public Task<IEnumerable<VehiculoResponse>> Obtener()
        {
            return _vehiculoDA.Obtener();
        }

        public Task<VehiculoResponse> Obtener(Guid Id)
        {
            return _vehiculoDA.Obtener(Id);
        }
    }
}
