using Abstracciones.Modelos;

namespace Abstracciones.Interfaces.Flujo.Modelos
{
    public interface IModelosFlujo
    {
        Task<IEnumerable<ModeloResponse>> Obtener(Guid IdMarca);
    }
}
