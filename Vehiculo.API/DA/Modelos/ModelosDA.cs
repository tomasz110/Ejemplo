using Abstracciones.Interfaces.DA;
using Abstracciones.Interfaces.DA.Modelos;
using Abstracciones.Modelos;
using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DA.Modelos
{
    public class ModelosDA : IModelosDA
    {
        private IRepositorioDapper _repositorioDapper;
        private SqlConnection _sqlConnection;
        public ModelosDA(IRepositorioDapper repositorioDapper)
        {
            _repositorioDapper = repositorioDapper;
            _sqlConnection = _repositorioDapper.ObtenerRepositorio();
        }

        public async Task<IEnumerable<ModeloResponse>> Obtener(Guid IdMarca)
        {
            string query = @"ObtenerModelosPorMarca";
            var resultadoConsulta = await _sqlConnection.QueryAsync<ModeloResponse>(query, new
            {
                IdMarca
            });
            return resultadoConsulta;
        }

       

    }

    }

