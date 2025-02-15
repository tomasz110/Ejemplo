using Abstracciones.Interfaces.DA;
using Abstracciones.Interfaces.DA.Persona;
using Abstracciones.Modelos;
using System.Data.SqlClient;

namespace DA.Persona
{
    public class PersonaDA : IPersonaDA
    {

        private IRepositorioDapper _repositorioDapper;
        private SqlConnection _sqlConnection;

        public PersonaDA(IRepositorioDapper repositorioDapper)
        {
            _repositorioDapper = repositorioDapper;
            _sqlConnection = _repositorioDapper.ObtenerRepositorio();
        }
        public Task<Guid> Agregar(PersonaBase persona)
        {
            throw new NotImplementedException();
        }

        public Task<Guid> Editar(Guid Id, PersonaBase persona)
        {
            throw new NotImplementedException();
        }

        public Task<Guid> Eliminar(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PersonaResponse>> Obtener()
        {
            throw new NotImplementedException();
        }

        public Task<PersonaResponse> Obtener(Guid Id)
        {
            throw new NotImplementedException();
        }
    }
}
