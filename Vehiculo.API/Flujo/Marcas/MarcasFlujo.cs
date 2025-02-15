using Abstracciones.Interfaces.DA.Marcas;
using Abstracciones.Interfaces.DA.Vehiculos;
using Abstracciones.Interfaces.Flujo.Marcas;
using Abstracciones.Modelos;

namespace Flujo.Marcas
{
    public class MarcasFlujo : IMarcasFlujo
    {
        private IMarcasDA _marcasDA;

        public MarcasFlujo(IMarcasDA marcasDA)
        {
            _marcasDA = marcasDA;
        }
        public Task<IEnumerable<MarcasBase>> Obtener()
        {
            return _marcasDA.Obtener();
        }
    }
}
