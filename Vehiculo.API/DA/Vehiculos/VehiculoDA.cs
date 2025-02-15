using Abstracciones.Interfaces.DA;
using Abstracciones.Interfaces.DA.Vehiculos;
using Abstracciones.Modelos;
using System.Data.SqlClient;
using Dapper;
using System.Drawing;
using System.Numerics;

namespace DA.Vehiculos
{
    public class VehiculoDA : IVehiculosDA
    {

        private IRepositorioDapper _repositorioDapper;
        private SqlConnection _sqlConnection;

        #region Constructor

        public VehiculoDA(IRepositorioDapper repositorioDapper)
        {
            _repositorioDapper = repositorioDapper;
            _sqlConnection = _repositorioDapper.ObtenerRepositorio();
        }

        #endregion

        #region Operaciones
        public async Task<Guid> Agregar(VehiculoRequest vehiculo)
        {
            string query = @"AgregarVehiculo";
            var resultadoConsulta = await _sqlConnection.ExecuteScalarAsync<Guid>(query, new
            {
                Id = Guid.NewGuid(),
                vehiculo.IdModelo,
                vehiculo.Placa,
                vehiculo.Color,
                vehiculo.Anio,
                vehiculo.Precio,
                vehiculo.CorreoPropietario,
                vehiculo.TelefonoPropietario
            });
            return resultadoConsulta;
        }

        public async Task<Guid> Editar(Guid Id, VehiculoRequest vehiculo)
        {
            await verificarVehiculoExiste(Id);
            string query = @"EditarVehiculo";
            var resultadoConsulta = await _sqlConnection.ExecuteScalarAsync<Guid>(query, new
            {
                Id,
                vehiculo.IdModelo,
                vehiculo.Placa,
                vehiculo.Color,
                vehiculo.Anio,
                vehiculo.Precio,
                vehiculo.CorreoPropietario,
                vehiculo.TelefonoPropietario
            });
            return resultadoConsulta;
        }


        public async Task<Guid> Eliminar(Guid Id)
        {
            await verificarVehiculoExiste(Id);
            string query = @"EliminarVehiculo";
            var resultadoConsulta = await _sqlConnection.ExecuteScalarAsync<Guid>(query, new
            {
                Id
            });
            return resultadoConsulta;
        }

        public async Task<IEnumerable<VehiculoResponse>> Obtener()
        {
            string query = @"ObtenerVehiculos";
            var resultadoConsulta = await _sqlConnection.QueryAsync<VehiculoResponse>(query);
            return resultadoConsulta;
        }

        public async Task<VehiculoResponse> Obtener(Guid Id)
        {
            string query = @"ObtenerVehiculo";
            var resultadoConsulta = await _sqlConnection.QueryAsync<VehiculoResponse>(query, new
            {
                Id
            });
            return resultadoConsulta.FirstOrDefault();
        }

        #endregion

        #region Helpers
        private async Task verificarVehiculoExiste(Guid Id)
        {
            VehiculoResponse? resultadoConsultaVehiculo = await Obtener(Id);
            if (resultadoConsultaVehiculo == null)
                throw new Exception("No se encontró el vehiculo");
        }
        #endregion
    }
}
