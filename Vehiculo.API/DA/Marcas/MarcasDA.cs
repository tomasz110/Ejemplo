using Abstracciones.Interfaces.DA;
using Abstracciones.Interfaces.DA.Marcas;
using Abstracciones.Modelos;
using Dapper;
using System.Data.SqlClient;

namespace DA.Vehiculos
{
    public class MarcasDA : IMarcasDA
    {

        private IRepositorioDapper _repositorioDapper;
        private SqlConnection _sqlConnection;

        #region Constructor

        public MarcasDA(IRepositorioDapper repositorioDapper)
        {
            _repositorioDapper = repositorioDapper;
            _sqlConnection = _repositorioDapper.ObtenerRepositorio();
        }

        #endregion

        #region Operaciones
        public async Task<IEnumerable<MarcasBase>> Obtener()
        {
            string query = @"ObtenerMarcas";
            var resultadoConsulta = await _sqlConnection.QueryAsync<MarcasBase>(query);
            return resultadoConsulta;
        }

       

        #endregion
    }
}
