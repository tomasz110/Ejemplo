using Abstracciones.Interfaces.DA.Modelos;
using Abstracciones.Interfaces.DA.Vehiculos;
using Abstracciones.Interfaces.Flujo.Modelos;
using Abstracciones.Modelos;

namespace Flujo.Modelos
{
    public class ModelosFlujo : IModelosFlujo
    {
        private IModelosDA _modelosDA;

        public ModelosFlujo(IModelosDA modelosDA)
        {
            _modelosDA = modelosDA;
        }

        //public Task<IEnumerable<ModeloResponse>> Obtener()
        //{
        //    return _modelosDA.Obtener();
        //}

        public Task<IEnumerable<ModeloResponse>> Obtener(Guid IdMarca)
        {
            return _modelosDA.Obtener(IdMarca);
        }
    }
}
