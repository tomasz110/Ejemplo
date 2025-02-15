using Abstracciones.Modelos;

namespace Abstracciones.Interfaces.DA.Modelos
{
    public interface IModelosDA
    {
        Task<IEnumerable<ModeloResponse>> Obtener(Guid IdMarca);
    }
}
