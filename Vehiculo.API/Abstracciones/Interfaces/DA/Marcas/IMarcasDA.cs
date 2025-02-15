using Abstracciones.Modelos;

namespace Abstracciones.Interfaces.DA.Marcas
{
    public interface IMarcasDA
    {
        Task<IEnumerable<MarcasBase>> Obtener();
    }
}
