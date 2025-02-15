using System.Data.SqlClient;

namespace Abstracciones.Interfaces.DA
{
    public interface IRepositorioDapper
    {
        SqlConnection ObtenerRepositorio();

    }
}
